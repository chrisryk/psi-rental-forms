using CarRental.Database;
using System;
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
            dtpCarInsurance.Value = carToEdit.insurance;
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
            if (!InputValidation.CarManufacturer(tbCarManufacturer.Text))
            {
                MessageBox.Show("Manufacturer cannot be empty.", "Alert!");
                return;
            }
            if (!InputValidation.CarModel(tbCarModel.Text))
            {
                MessageBox.Show("Model cannot be empty.", "Alert!");
                return;
            }           
            if (!InputValidation.CarYear((int)nudCarYear.Value))
            {
                MessageBox.Show("Production year cannot be from future.", "Alert!");
                return;
            }
            if (!InputValidation.CarRate((int)nudCarRate.Value))
            {
                MessageBox.Show("Incorrect daily rate.", "Alert!");
                return;
            }
            if (!InputValidation.CarVin(tbVIN.Text))
            {
                MessageBox.Show("VIN number should have 17 characters.", "Alert!");
                return;
            }
            if (!InputValidation.CarInsurance(dtpCarInsurance.Value))
            {
                MessageBox.Show("Incorrect insurance date.", "Alert!");
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
    }
}
