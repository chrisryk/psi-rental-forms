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
        }
        public UserControlInvoiceManager(int rentId)
        {
            InitializeComponent();
            MessageBox.Show(rentId.ToString());
        }

        private void btnSearchInvoice_Click(object sender, EventArgs e)
        {
            var dataInvoices = from i in RentalDatabase.DB.Invoices
                               join r in RentalDatabase.DB.Rents
                               on i.rent_id equals r.id
                               join c in RentalDatabase.DB.Cars
                               on r.car_id equals c.id
                               join cu in RentalDatabase.DB.Customers
                               on r.customer_id equals cu.id
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
