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
            if (!ValidateInput())
            {
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

        private bool ValidateInput()
        {
            Regex namePattern = new Regex("^[a-z]{2,}$", RegexOptions.IgnoreCase);
            var nameValidate = namePattern.IsMatch(tbCustName.Text);
            var surnameValidate = namePattern.IsMatch(tbCustSurname.Text);

            if (!nameValidate)
            {
                MessageBox.Show("Incorrect name.", "Alert!");
                return false;
            }
            if (!surnameValidate)
            {
                MessageBox.Show("Incorrect surname.", "Alert!");
                return false;
            }

            Regex patternEmail = new Regex(@"^[0-9a-z.]*@[0-9a-z]+\.[0-9a-z]{2,4}$", RegexOptions.IgnoreCase);
            var emailValidate = patternEmail.IsMatch(tbCustEmail.Text);

            if (!emailValidate)
            {
                MessageBox.Show("Incorrect email format.", "Alert!");
                return false;
            }

            Regex phonePattern = new Regex("^[0-9]{9}$");
            var phoneValidate = phonePattern.IsMatch(tbCustPhone.Text);

            if (!phoneValidate)
            {
                MessageBox.Show("Phone number should have 9 digits.", "Alert!");
                return false;
            }

            Regex licencePattern = new Regex("^[0-9]{5}/[0-9]{2}/[0-9]{4}$");
            var licenceValidate = licencePattern.IsMatch(tbCustLicence.Text);

            if (!licenceValidate)
            {
                MessageBox.Show("Licence pattern should be 12345/12/1234", "Alert!");
                return false;
            }

            return true;
        }
    }
}
