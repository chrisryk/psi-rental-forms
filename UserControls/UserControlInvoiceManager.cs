using System;
using System.Data.Entity.Core;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlInvoiceManager : UserControl
    {
        public UserControlInvoiceManager()
        {
            InitializeComponent();

            dtpDateFrom.MaxDate = DateTime.Now;
            dtpDateTo.MaxDate = DateTime.Now;

            try
            {
                nudInvoiceId.Maximum = RentalDatabase.GetLatestInvoiceId();
                nudRentId.Maximum = RentalDatabase.GetLatestRentId();
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
        public UserControlInvoiceManager(int rentId)
        {
            InitializeComponent();
            MessageBox.Show(rentId.ToString());
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            int invoiceId = (int)nudInvoiceId.Value;
            string customerSurname = tbSurname.Text.ToUpper();
            string carManufacturer = tbManufacturer.Text.ToUpper();
            string carModel = tbModel.Text.ToUpper();
            int rentId = Convert.ToInt32(nudRentId.Value);
            DateTime invoiceDateFrom = dtpDateFrom.Value;
            DateTime invoiceDateTo = dtpDateTo.Value;

            try
            {
                dgvInvoices.DataSource = RentalDatabase.SearchInvoices(invoiceId, customerSurname, carManufacturer,
                        carModel, rentId, invoiceDateFrom, invoiceDateTo);
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
    }
}
