using CarRental.Database;
using CarRental.Forms;
using System;
using System.Data.Entity.Core;
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
                var selectedRentId = Convert.ToInt32(dgvRent.SelectedRows[0].Cells["RentId"].Value);
                try
                {
                    var selectedRent = RentalDatabase.GetRent(selectedRentId);

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
                catch (EntityException ex)
                {
                    MessageBox.Show("Database connection failed", "Alert!");
                    MessageBox.Show(ex.StackTrace, "Info!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured.", "Alert!");
                    MessageBox.Show(ex.StackTrace, "Info!");
                    throw;
                }
            }
            else
            {
                MessageBox.Show("Select one rent.", "Info!");
            }
        }
        private void rentSearchButton_Click(object sender, EventArgs e)
        {
            var rentId = (int)nudRentId.Value;
            var surname = tbRentSurname.Text.ToUpper();
            var email = tbEmail.Text.ToLower();
            var phone = tbPhone.Text;
            var licence = tbLicence.Text;
            var dateFrom = dtpFrom.Value;
            var dateTo = dtpTo.Value;

            try
            {
                var rentData = RentalDatabase.SearchRents(rentId, surname, email, phone, licence, dateFrom, dateTo);
                dgvRent.DataSource = rentData;
            }
            catch (EntityException ex)
            {
                MessageBox.Show("Connection to database failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
            catch (Exception ex)
            {
                MessageBox.Show("An error occured.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
                throw;
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

            var rentId = Convert.ToInt32(selectedRows[0].Cells["RentId"].Value);

            var userAnswer = MessageBox.Show("Invoice for selected rent will be created, proceed?", "Info!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.Yes
                && !RentalDatabase.InvoiceForRentExists(rentId)
                && RentalDatabase.ReturnDateNotNull(rentId))
            {
                try
                {
                    Invoices invoices = new Invoices();
                    var carDailyRate = RentalDatabase.GetCarRate(rentId);
                    var daysInRent = RentalDatabase.GetDaysInRent(rentId);
                    invoices.date = DateTime.Now;
                    invoices.rent_id = rentId;
                    var totalPrice = (daysInRent == 0 ? 1 : daysInRent) * carDailyRate;
                    invoices.price = Convert.ToDecimal(totalPrice);
                    RentalDatabase.DB.Invoices.Add(invoices);
                    RentalDatabase.DB.SaveChanges();
                    MessageBox.Show("Invoice created!", "Info!");
                }
                catch (EntityException ex)
                {
                    MessageBox.Show("Database connection failed", "Alert!");
                    MessageBox.Show(ex.StackTrace, "Info!");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("An error occured.", "Alert!");
                    MessageBox.Show(ex.StackTrace, "Info!");
                    throw;
                }
            }
            else if (RentalDatabase.InvoiceForRentExists(rentId))
            {
                MessageBox.Show("Invoice already exists for this rent.", "Info!");
            }
            else if (!RentalDatabase.ReturnDateNotNull(rentId))
            {
                MessageBox.Show("Cannot create invoice if return date is null.", "Info!");
            }
        }
    }
}
