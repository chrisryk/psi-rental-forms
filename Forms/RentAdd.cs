using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class RentAdd : Form
    {
        private string selectedManufacturer;
        private string selectedModel;
        private string selectedSurname;
        private string selectedName;
        private string selectedLicence;
        public RentAdd()
        {
            InitializeComponent();
        }
        private void btnRentCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void RentAddEdit_Load(object sender, EventArgs e)
        {
            cbCustomerSurname.DataSource = FormLogin.DB.Customers.Select(c => c.surname)
                                                                 .Distinct()
                                                                 .ToList();

            cbCarManufacturer.DataSource = FormLogin.DB.Cars.Select(c => c.manufacturer)
                                                            .Distinct()
                                                            .ToList();
        }

        private void cbCarManufacturer_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedManufacturer = cbCarManufacturer.SelectedValue.ToString();

            var carData = from c in FormLogin.DB.Cars
                          where c.rented == false
                          where c.manufacturer == selectedManufacturer
                          select c.model;

            if (carData.Count() == 0)
            {
                cbCarModel.DataSource = null;
            }
            else
            {
                cbCarModel.DataSource = carData.Distinct().ToList();
            }
        }

        private void cbCustomerSurname_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedSurname = cbCustomerSurname.SelectedValue.ToString();
            cbCustomerName.DataSource = FormLogin.DB.Customers.Where(c => c.surname == selectedSurname)
                                                              .Select(c => c.name)
                                                              .Distinct()
                                                              .ToList();
        }

        private void cbCustomerName_SelectedValueChanged(object sender, EventArgs e)
        {
            selectedName = cbCustomerName.SelectedValue.ToString();
            cbCustomerLicence.DataSource = FormLogin.DB.Customers.Where(c => c.surname == selectedSurname && c.name == selectedName)
                                                                .Select(c => c.licence)
                                                                .ToList();
        }

        private void btnRentSave_Click(object sender, EventArgs e)
        {
            selectedModel = cbCarModel.SelectedValue.ToString();
            selectedLicence = cbCustomerLicence.SelectedValue.ToString();

            Rents rent = new Rents();

            var carId = (int)FormLogin.DB.Cars.Where(c => c.manufacturer == selectedManufacturer && c.model == selectedModel)
                                                .Select(c => c.id)
                                                .FirstOrDefault();
            rent.car_id = carId;
            rent.customer_id = (int)FormLogin.DB.Customers.Where(c => c.licence == selectedLicence)
                                                     .Select(c => c.id)
                                                     .FirstOrDefault();
            
            if (dtpRentStartDate.Value <= DateTimeOffset.UtcNow)
            {
                rent.date_start = dtpRentStartDate.Value.Date;
            }
            else
            {
                MessageBox.Show("Date cannot be from future.", "Alert!");
                return;
            }

            FormLogin.DB.Rents.Add(rent);

            FormLogin.DB.Cars.Where(c => c.id == carId).FirstOrDefault().rented = true;

            FormLogin.DB.SaveChanges();
            MessageBox.Show("Rent added.", "Info!");
            this.Close();
        }

        private void RentAdd_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlRentManager.AddEditIsOpen = false;
        }
    }
}
