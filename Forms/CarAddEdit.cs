using System;
using System.Linq;
using System.Text.RegularExpressions;
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
            if (!ValidateInput())
            {
                return;
            }

            car.manufacturer = tbCarManufacturer.Text.ToUpper();
            car.model = tbCarModel.Text.ToUpper();
            car.year = nudCarYear.Value;
            car.daily_rate = nudCarRate.Value;
            car.vin = tbVIN.Text;
            car.insurance = dtpCarInsurance.Value.Date;

            if (!editMode)
            {
                car.rented = false;
                RentalDatabase.DB.Cars.Add(car);
            }

            try
            {
                RentalDatabase.DB.SaveChanges();
                MessageBox.Show("Car added to database", "Success!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }

            this.Close();
        }
        private bool ValidateInput()
        {
            if (tbCarManufacturer.Text.Length == 0 || tbCarModel.Text.Length == 0)
            {
                MessageBox.Show("Fields cannot be empty.", "Alert!");
                return false;
            }

            if (nudCarYear.Value > DateTime.Now.Year)
            {
                MessageBox.Show("Production year cannot be from future.", "Alert!");
                return false;
            }
            
            if (nudCarRate.Value > 5000 || nudCarRate.Value <= 0)
            {
                MessageBox.Show("Incorrect daily rate.", "Alert!");
                return false;
            }

            Regex vinPattern = new Regex("[a-z0-9]{17}", RegexOptions.IgnoreCase);
            bool vinChecked = vinPattern.IsMatch(tbVIN.Text);

            if (!vinChecked)
            {
                MessageBox.Show("VIN number should have 17 characters.", "Alert!");
                return false;
            }

            if (dtpCarInsurance.Value < DateTime.Now || dtpCarInsurance.Value > DateTime.Now.AddYears(1))
            {
                MessageBox.Show("Incorrect insurance date.", "Alert!");
                return false;
            }

            return true;
        }
    }
}
