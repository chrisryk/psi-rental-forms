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

            customer.name = tbCustName.Text.ToUpper();
            customer.surname = tbCustSurname.Text.ToUpper();

            Regex patternEmail = new Regex("@{1}");
            var emailValidate = patternEmail.IsMatch(tbCustEmail.Text);

            if (emailValidate)
            {
                customer.email = tbCustEmail.Text.ToLower();
            }
            else
            {
                MessageBox.Show("Incorrect email format.", "Alert!");
                return;
            }

            Regex phonePattern = new Regex("[0-9]{9,}");
            var phoneValidate = phonePattern.IsMatch(tbCustPhone.Text);

            if (phoneValidate)
            {
                customer.phone = tbCustPhone.Text;
            }
            else
            {
                MessageBox.Show("Phone number must be minimum 9 digits only.", "Alert!");
                return;
            }
            
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
