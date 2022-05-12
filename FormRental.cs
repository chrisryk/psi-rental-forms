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
    public partial class FormRental : Form
    {
        private IList<Button> controlButtons = new List<Button>();
        public FormRental()
        {
            InitializeComponent();
        }

        private void Rental_Load(object sender, EventArgs e)
        {
            FormLogin login = new FormLogin();
            login.StartPosition = FormStartPosition.CenterScreen;
            login.ShowDialog();

            controlButtons.Add(carButton);
            controlButtons.Add(customerButton);
            controlButtons.Add(rentButton);
            controlButtons.Add(invoiceButton);
        }

        private void ResetButtonsColor()
        {
            foreach (var button in controlButtons)
            {
                button.BackColor = Color.WhiteSmoke;
            }
        }
        private void SetButtonColor(string value)
        {
            var color = Color.DodgerBlue;

            switch (value)
            {
                case "Car":
                    carButton.BackColor = color;
                    break;
                case "Customer":
                    customerButton.BackColor = color;
                    break;
                case "Rent":
                    rentButton.BackColor = color;
                    break;
                case "Invoice":
                    invoiceButton.BackColor = color;
                    break;
                default:
                    break;
            }
        }

        private void AddWorkspace(string value)
        {
            workspacePanel.Controls.Clear();

            switch (value)
            {
                case "Car":
                    workspacePanel.Controls.Add(new UserControlCarManager());
                    break;
                case "Customer":
                    workspacePanel.Controls.Add(new UserControlCustomerManager());
                    break;
                case "Rent":
                    workspacePanel.Controls.Add(new UserControlRentManager());
                    break;
                case "Invoice":
                    workspacePanel.Controls.Add(new UserControlInvoiceManager());
                    break;
                default:
                    break;
            }
        }

        private void controlButton_Click(object sender, EventArgs e)
        {
            var value = (sender as Button).Tag.ToString();

            ResetButtonsColor();
            SetButtonColor(value);
            AddWorkspace(value);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
