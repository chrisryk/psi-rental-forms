using System;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace CarRental.Forms
{
    public partial class CustomerAddEdit : Form
    {
        private Customers customerToEdit;
        private bool editMode;
        public CustomerAddEdit()
        {
            InitializeComponent();
            this.Text = "ADD CUSTOMER";
            editMode = false;
        }
        public CustomerAddEdit(Customers customerToEdit)
        {
            InitializeComponent();
            this.Text = "EDIT CUSTOMER";
            editMode = true;
            this.customerToEdit = customerToEdit;
            tbCustName.Text = customerToEdit.name;
            tbCustSurname.Text = customerToEdit.surname;
            tbCustEmail.Text = customerToEdit.email;
            tbCustPhone.Text = customerToEdit.phone;
            tbCustLicence.Text = customerToEdit.licence;
        }
        private void CustomerAddEdit_FormClosed(object sender, FormClosedEventArgs e)
        {
            UserControlCustomerManager.AddEditIsOpen = false;
        }

        private void btnCustCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnCustSave_Click(object sender, EventArgs e)
        {
            if (editMode)
            {
                SaveCustomer(customerToEdit);
            }
            else
            {
                SaveCustomer(new Customers());
            }
        }

        private void SaveCustomer(Customers customer)
        {
            if (!InputValidation.CustomerName(tbCustName.Text))
            {
                MessageBox.Show("Incorrect name.", "Alert!");
                return;
            }
            if (!InputValidation.CustomerName(tbCustSurname.Text))
            {
                MessageBox.Show("Incorrect surname.", "Alert!");
                return;
            }
            if (!InputValidation.Email(tbCustEmail.Text))
            {
                MessageBox.Show("Incorrect email format.", "Alert!");
                return;
            }
            if (!InputValidation.Phone(tbCustPhone.Text))
            {
                MessageBox.Show("Phone number should have 9 digits.", "Alert!");
                return;
            }
            if (!InputValidation.CustomerLicence(tbCustLicence.Text))
            {
                MessageBox.Show("Licence pattern should be 12345/12/1234", "Alert!");
                return;
            }

            customer.name = tbCustName.Text.ToUpper();
            customer.surname = tbCustSurname.Text.ToUpper();
            customer.email = tbCustEmail.Text.ToLower();
            customer.phone = tbCustPhone.Text;
            customer.licence = tbCustLicence.Text;

            try
            {
                if (!editMode)
                {
                    RentalDatabase.DB.Customers.Add(customer);
                }
                RentalDatabase.DB.SaveChanges();
                MessageBox.Show($"Customer {(editMode ? "edited in" : "added to")} database", "Success!");
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed.", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
        }
    }
}
