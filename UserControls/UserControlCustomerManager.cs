using CarRental.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class UserControlCustomerManager : UserControl
    {
        private event Action<IEnumerable> DeleteCustomerClicked = (c) => { };
        public static bool AddEditIsOpen { get; set; }
        public UserControlCustomerManager()
        {
            InitializeComponent();

            DeleteCustomerClicked += DeleteData;
            AddEditIsOpen = false;
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text.ToUpper();
            var userSurname = tbUserSurname.Text.ToUpper();
            var userEmail = tbUserEmail.Text.ToLower();
            var userPhone = tbUserPhone.Text;
            var userLicence = tbUserLicence.Text.ToUpper();

            var customersData = from c in RentalDatabase.DB.Customers
                                where c.name.Contains(userName)
                                where c.surname.Contains(userSurname)
                                where c.email.Contains(userEmail)
                                where c.phone.Contains(userPhone)
                                where c.licence.Contains(userLicence)
                                select new { ID = c.id, CUSTOMER = c.name + " " + c.surname, EMAIL = c.email, PHONE = c.phone, LICENCE = c.licence };

            try
            {
                dgvCustomers.DataSource = customersData.ToList();
                dgvCustomers.Columns[0].Visible = false;
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
                        var selectedCustomer = RentalDatabase.DB.Customers.Where(c => c.id == selectedId).FirstOrDefault();
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

            DeleteCustomerClicked.Invoke(data);
        }
        private void DeleteData(IEnumerable data)
        {
            foreach (int id in data)
            {
                var invoicesToDelete = from i in RentalDatabase.DB.Invoices
                                       join r in RentalDatabase.DB.Rents
                                       on i.rent_id equals r.id
                                       join c in RentalDatabase.DB.Customers
                                       on r.customer_id equals c.id
                                       where c.id == id
                                       select i;

                foreach (var invoice in invoicesToDelete)
                {
                    RentalDatabase.DB.Invoices.Remove(invoice);
                }

                var rentsToDelete = RentalDatabase.DB.Rents.Where(r => r.customer_id == id);

                foreach (var rent in rentsToDelete)
                {
                    RentalDatabase.DB.Rents.Remove(rent);
                }

                var customerToDelete = RentalDatabase.DB.Customers.Where(c => c.id == id).FirstOrDefault();
                RentalDatabase.DB.Customers.Remove(customerToDelete);
            }

            RentalDatabase.DB.SaveChanges();
            MessageBox.Show("Data deleted.", "Info!");
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
