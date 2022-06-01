using CarRental.Forms;
using System;
using System.Collections;
using System.Collections.Generic;
using System.Data.Entity.Core;
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

            if (FormLogin.UserRole == Role.Advisor)
            {
                btnDeleteCustomer.Enabled = false;
            }
        }

        private void btnSearchCustomer_Click(object sender, EventArgs e)
        {
            var userName = tbUserName.Text.ToUpper();
            var userSurname = tbUserSurname.Text.ToUpper();
            var userEmail = tbUserEmail.Text.ToLower();
            var userPhone = tbUserPhone.Text;
            var userLicence = tbUserLicence.Text.ToUpper();

            try
            {
                var customerData = RentalDatabase.SearchCustomers(userName, userSurname, userEmail, userPhone, userLicence);
                dgvCustomers.DataSource = customerData;
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
                    if (dgvCustomers.SelectedRows.Count != 1)
                    {
                        MessageBox.Show("Select one row to edit.");
                        return;
                    }
                    
                    try
                    {
                        int selectedId = Convert.ToInt32(dgvCustomers.SelectedRows[0].Cells["ID"].Value);
                        var selectedCustomer = RentalDatabase.GetCustomer(selectedId);
                        customerAddEdit = new CustomerAddEdit(selectedCustomer);
                        customerAddEdit.StartPosition = FormStartPosition.CenterScreen;
                        customerAddEdit.Show();
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
            }
        }

        private void btnDeleteCustomer_Click(object sender, EventArgs e)
        {
            var selectedCustomers = GetIndexes(dgvCustomers.SelectedRows);

            if (selectedCustomers.Count() == 0)
            {
                MessageBox.Show("Select row(s) to delete.", "Info");
                return;
            }

            DeleteData(selectedCustomers);
        }
        private void DeleteData(IEnumerable selectedCustomers)
        {
            var userAnswer = MessageBox.Show("Data will be removed, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswer == DialogResult.No)
            {
                return;
            }

            var userAnswerConfirm = MessageBox.Show("Removing this item will result rents and invoices removal, proceed?", "Warning!", MessageBoxButtons.YesNo);

            if (userAnswerConfirm == DialogResult.No)
            {
                return;
            }

            try
            {
                RentalDatabase.DeleteCustomers(selectedCustomers);
                MessageBox.Show("Data deleted.", "Info!");
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
