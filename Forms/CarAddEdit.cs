using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class CarAddEdit : Form
    {
        private Cars carToEdit;
        private bool editMode;
        public CarAddEdit()
        {
            InitializeComponent();
            this.Text = "Add";
            editMode = false;
        }

        public CarAddEdit(Cars carToEdit)
        {
            InitializeComponent();
            this.Text = "Edit";
            editMode = true;
            this.carToEdit = carToEdit;
            tbCarManufacturer.Text = carToEdit.manufacturer;
            tbCarModel.Text = carToEdit.model;
            tbVIN.Text = carToEdit.vin;
            nudCarYear.Value = carToEdit.year;
            nudCarRate.Value = (int)carToEdit.daily_rate;
        }

        private void CarAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlCarManager.AddEditIsOpen = false;
        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCarSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                SaveCar(carToEdit);
            }
            else
            {
                SaveCar(new Cars());
            }
        }
        private void SaveCar(Cars car)
        {
            car.manufacturer = tbCarManufacturer.Text.ToUpper();
            car.model = tbCarModel.Text.ToUpper();
            car.year = nudCarYear.Value;
            car.daily_rate = nudCarRate.Value;
            car.vin = tbVIN.Text;
            car.insurance = dtpCarInsurance.Value.Date;

            if (!editMode)
            {
                FormLogin.DB.Cars.Add(car);
            }
            FormLogin.DB.SaveChanges();
            MessageBox.Show("Car added to database", "Success!");

            if (!editMode)
            {
                Rents rent = new Rents();
                rent.car_id = FormLogin.DB.Cars.Where(c => c.vin == tbVIN.Text).Select(c => c.id).FirstOrDefault();
                rent.customer_id = FormLogin.DB.Customers.Where(c => c.id == 1).Select(c => c.id).FirstOrDefault();
                rent.date_start = DateTimeOffset.UtcNow.Date;
                rent.date_back = DateTimeOffset.UtcNow.Date;

                FormLogin.DB.Rents.Add(rent);
                FormLogin.DB.SaveChanges();
            }
            this.Close();
        }
    }
}
