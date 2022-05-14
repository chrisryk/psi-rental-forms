using CarRental.Forms;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCustomerManager : UserControl
    {
        public static bool AddEditIsOpen { get; set; }
        public UserControlCustomerManager()
        {
            InitializeComponent();
            AddEditIsOpen = false;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text.ToUpper();
            var userSurname = tbUserSurname.Text.ToUpper();
            var userEmail = tbUserEmail.Text.ToLower();
            var userPhone = tbUserPhone.Text;
            var userLicence = tbUserLicence.Text.ToUpper();

            var customersData = from c in FormLogin.DB.Customers
                                where c.name.Contains(userName)
                                where c.surname.Contains(userSurname)
                                where c.email.Contains(userEmail)
                                where c.phone.Contains(userPhone)
                                where c.licence.Contains(userLicence)
                                select new { ID = c.id, CUSTOMER = c.name + " " + c.surname, EMAIL = c.email, PHONE = c.phone, LICENCE = c.licence };

            dgvCustomers.DataSource = customersData.ToList();
            dgvCustomers.Columns[0].Visible = false;
        }

        private void btnAddCustomer_Click(object sender, EventArgs e)
        {
            var value = (sender as Button).Text;

            if (!AddEditIsOpen)
            {
                CustomerAddEdit customerAddEdit;

                if (value == "ADD")
                {
                    customerAddEdit = new CustomerAddEdit();
                    customerAddEdit.StartPosition = FormStartPosition.CenterScreen;
                    customerAddEdit.Show();
                    AddEditIsOpen = true;
                }
                else if (value == "EDIT")
                {
                    int selectedId;
                    try
                    {
                        selectedId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["ID"].Value);
                        var selectedCustomer = FormLogin.DB.Customers.Where(c => c.id == selectedId).FirstOrDefault();
                        customerAddEdit = new CustomerAddEdit(selectedCustomer);
                        customerAddEdit.StartPosition = FormStartPosition.CenterScreen;
                        customerAddEdit.Show();
                        AddEditIsOpen = true;
                    }
                    catch
                    {
                        MessageBox.Show("Select item to edit.");
                    }
                }
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var data = GetIndexes(dgvCustomers.SelectedRows);

            if (data.Count() == 0)
            {
                MessageBox.Show("Select customer to delete.", "Info");
                return;
            }

            var userAnswer = MessageBox.Show("Data will be removed, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.No)
            {
                return;
            }

            foreach (var item in data)
            {
                var customerToDelete = FormLogin.DB.Customers.Where(c => c.id == item).FirstOrDefault();
                FormLogin.DB.Customers.Remove(customerToDelete);
            }

            FormLogin.DB.SaveChanges();
            btnSearchCustomer.PerformClick();
        }
        private IEnumerable<int> GetIndexes(DataGridViewSelectedRowCollection data)
        {
            for (int i = 0; i < data.Count; i++)
            {
                yield return Convert.ToInt32(data[i].Cells["ID"].Value);
            }
        }
    }
}
