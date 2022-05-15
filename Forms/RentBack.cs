using System;
using System.Linq;
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
            selectedRent.date_back = dtpReturnDate.Value;
            var returnedCar = selectedRent.car_id;
            FormLogin.DB.Cars.Where(c => c.id == returnedCar).FirstOrDefault().rented = false;
            FormLogin.DB.SaveChanges();
            MessageBox.Show("Rent updated.", "Info!");
            this.Close();
        }
    }
}
