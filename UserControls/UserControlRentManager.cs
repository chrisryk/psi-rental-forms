using CarRental.Forms;
using System;
using System.Data;
using System.Data.Entity;
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
            else
            {
                MessageBox.Show("Select one rent.", "Info!");
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
                           where r.date_start >= dateFrom
                           where r.date_start <= dateTo
                           select new
                           {
                               RENT_ID = r.id,
                               CUSTOMER = cu.surname + " " + cu.name,
                               CAR = cr.manufacturer + " " + cr.model,
                               START = r.date_start,
                               END = r.date_back
                           };

            try
            {
                dgvRent.DataSource = rentData.ToList();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
        }

        private void btnInvoice_Click(object sender, EventArgs e)
        {
            var selectedRows = dgvRent.SelectedRows;

            if (selectedRows.Count != 1)
            {
                MessageBox.Show("Select one rent to add new invoce.", "Warning!");
                return;
            }

            var rentId = Convert.ToInt32(selectedRows[0].Cells["RENT_ID"].Value);

            var userAnswer = MessageBox.Show("Invoice for selected rent will be created, proceed?", "Info!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.Yes
                && !IsInvoiceExisting(rentId)
                && ReturnDateIsNotNull(rentId))
            {
                Invoices invoices = new Invoices();

                var carPrice = from c in RentalDatabase.DB.Cars
                               join r in RentalDatabase.DB.Rents
                               on c.id equals r.car_id
                               where r.id == rentId
                               select c.daily_rate;

                var daysInRent = RentalDatabase.DB.Rents.Where(r => r.id == rentId)
                                                        .Select(r => DbFunctions.DiffDays(r.date_start, r.date_back))
                                                        .FirstOrDefault();

                invoices.date = DateTime.Now;
                invoices.rent_id = rentId;
                var totalPrice = (daysInRent == 0 ? 1 : daysInRent) * carPrice.FirstOrDefault();
                invoices.price = Convert.ToDecimal(totalPrice);

                try
                {
                    RentalDatabase.DB.Invoices.Add(invoices);
                    RentalDatabase.DB.SaveChanges();
                    MessageBox.Show("Invoice created!", "Info!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Database connection failed", "Alert!");
                    MessageBox.Show(ex.StackTrace, "Info!");
                }
            }
            else if (IsInvoiceExisting(rentId))
            {
                MessageBox.Show("Invoice already exists for this rent.", "Info!");
            }
            else if (!ReturnDateIsNotNull(rentId))
            {
                MessageBox.Show("Cannot create invoice if return date is null.", "Info!");
            }
        }

        private bool ReturnDateIsNotNull(int rentId)
        {
            var rent = RentalDatabase.DB.Rents.Where(r => r.date_back != null && r.id == rentId).Count();

            if (rent > 0)
            {
                return true;
            }
            return false;
        }

        private bool IsInvoiceExisting(int rentId)
        {
            var invoices = from i in RentalDatabase.DB.Invoices
                           join r in RentalDatabase.DB.Rents
                           on i.rent_id equals r.id
                           where i.rent_id == rentId
                           select i;

            if (invoices.Count() > 0)
            {
                return true;
            }

            return false;
        }
    }
}
