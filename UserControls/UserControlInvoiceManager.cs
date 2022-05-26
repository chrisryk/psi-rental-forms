using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
            nudInvoiceId.Maximum = RentalDatabase.DB.Invoices.Select(i => i.id).Max();
            nudRentId.Maximum = RentalDatabase.DB.Rents.Select(r => r.id).Max();
        }
        public UserControlInvoiceManager(int rentId)
        {
            InitializeComponent();
            MessageBox.Show(rentId.ToString());
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            var invoiceId = nudInvoiceId.Value;
            string customerSurname = tbSurname.Text.ToUpper();
            string carManufacturer = tbManufacturer.Text.ToUpper();
            string carModel = tbModel.Text.ToUpper();
            int rentId = Convert.ToInt32(nudRentId.Value);
            DateTime invoiceDateFrom = dtpDateFrom.Value;
            DateTime invoiceDateTo = dtpDateTo.Value;

            var dataInvoices = from i in RentalDatabase.DB.Invoices
                               join r in RentalDatabase.DB.Rents
                               on i.rent_id equals r.id
                               join c in RentalDatabase.DB.Cars
                               on r.car_id equals c.id
                               join cu in RentalDatabase.DB.Customers
                               on r.customer_id equals cu.id
                               where (invoiceId == 0) ? i.id >= 0 : i.id == invoiceId
                               where cu.surname.Contains(customerSurname)
                               where c.manufacturer.Contains(carManufacturer)
                               where c.model.Contains(carModel)
                               where (rentId == 0) ? i.rent_id >= 0 : i.rent_id == rentId
                               where i.date >= invoiceDateFrom
                               where i.date <= invoiceDateTo
                               select new
                               {
                                   DATE = i.date,
                                   CUSTOMER = cu.surname + " " + cu.name,
                                   CAR = c.manufacturer + " " + c.model,
                                   DATE_START = r.date_start,
                                   DATE_END = r.date_back,
                                   PRICE = i.price
                               };

            dgvInvoices.DataSource = dataInvoices.ToList();
        }
    }
}
