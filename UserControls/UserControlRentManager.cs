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
            if (!AddEditIsOpen)
            {
                RentBack rentBack = new RentBack();
                rentBack.StartPosition = FormStartPosition.CenterScreen;
                rentBack.Show();
                AddEditIsOpen = true;
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

            var rentData = from r in FormLogin.DB.Rents
                           join cr in FormLogin.DB.Cars
                           on r.car_id equals cr.id
                           join cu in FormLogin.DB.Customers
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
