using CarRental.Forms;
using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlRentManager : UserControl
    {
        public static bool AddEditIsOpen { get; set; }
        public UserControlRentManager()
        {
            InitializeComponent();
            AddEditIsOpen = false;

            dtpTo.MaxDate = DateTime.Now;
            dtpFrom.MaxDate = DateTime.Now;
        }

        private void btnNewRent_Click(object sender, EventArgs e)
        {
            if (!AddEditIsOpen)
            {
                RentAdd rentAdd = new RentAdd();
                rentAdd.StartPosition = FormStartPosition.CenterScreen;
                rentAdd.Show();
                AddEditIsOpen = true;
            }
        }
        private void btnGiveBack_Click(object sender, EventArgs e)
        {
            if (!AddEditIsOpen && dgvRent.SelectedRows.Count == 1)
            {
                var selectedRentId = Convert.ToInt32(dgvRent.SelectedRows[0].Cells["RENT_ID"].Value);
                var selectedRent = RentalDatabase.DB.Rents.Where(r => r.id == selectedRentId).FirstOrDefault();

                if (selectedRent.date_back != null)
                {
                    MessageBox.Show("Car is back already.", "Info!");
                    return;
                }

                RentBack rentBack = new RentBack(selectedRent);
                rentBack.StartPosition = FormStartPosition.CenterScreen;
                rentBack.Show();
                AddEditIsOpen = true;
            }
            else if (!AddEditIsOpen && dgvRent.SelectedRows.Count > 1)
            {
                MessageBox.Show("Select only one rent.", "Info!");
            }
        }
        private void rentSearchButton_Click(object sender, EventArgs e)
        {
            var rentId = tbRentId.Text;
            var surname = tbRentSurname.Text.ToUpper();
            var email = tbEmail.Text.ToLower();
            var phone = tbPhone.Text;
            var licence = tbLicence.Text;
            var dateFrom = dtpFrom.Value;
            var dateTo = dtpTo.Value;

            var rentData = from r in RentalDatabase.DB.Rents
                           join cr in RentalDatabase.DB.Cars
                           on r.car_id equals cr.id
                           join cu in RentalDatabase.DB.Customers
                           on r.customer_id equals cu.id
                           where cu.surname.Contains(surname)
                           where cu.email.Contains(email)
                           where cu.phone.Contains(phone)
                           where cu.licence.Contains(licence)
                           //where r.date_start >= dateFrom
                           //where r.date_back <= dateTo
                           select new
                           {
                               RENT_ID = r.id,
                               CUSTOMER = cu.surname + " " + cu.name,
                               CAR = cr.manufacturer + " " + cr.model,
                               START = r.date_start,
                               END = r.date_back
                           };

            dgvRent.DataSource = rentData.ToList(); 
        }
    }
}
