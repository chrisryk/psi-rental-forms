using CarRental.Database;
using System;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class RentBack : Form
    {
        private Rents selectedRent;
        public RentBack(Rents rent)
        {
            InitializeComponent();

            selectedRent = rent;
        }

        private void btnCarCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RentBack_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlRentManager.AddEditIsOpen = false;
        }

        private void btnCarSave_Click(object sender, EventArgs e)
        {
            var dateBack = dtpReturnDate.Value;

            if (!ValidateDate(dateBack))
            {
                return;
            }

            selectedRent.date_back = dateBack;
            var returnedCar = selectedRent.car_id;

            try
            {
                RentalDatabase.SaveRentBack((int)returnedCar, dateBack);
                MessageBox.Show("Rent updated.", "Info!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }

            this.Close();
        }
        private bool ValidateDate(DateTime dateBack)
        {
            if (InputValidation.RentDateBackFromFuture(dateBack))
            {
                MessageBox.Show("Date cannot be from future.", "Warning!");
                return false;
            }
            if (InputValidation.RentDateBackEarlierThanStart(dateBack, selectedRent.date_start))
            {
                MessageBox.Show("Date cannot be earlier than rent start date.", "Warning!");
                return false;
            }

            return true;
        }
    }
}
