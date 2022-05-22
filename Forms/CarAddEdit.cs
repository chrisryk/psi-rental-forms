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
                car.rented = false;
                RentalDatabase.DB.Cars.Add(car);
            }
            RentalDatabase.DB.SaveChanges();
            MessageBox.Show("Car added to database", "Success!");

            this.Close();
        }
    }
}
