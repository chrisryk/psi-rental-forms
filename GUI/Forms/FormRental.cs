using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormRental : Form
    {
        private event Action<string> ControlButtonClicked = (x) => { };
        private IList<Button> controlButtons = new List<Button>();
        public FormRental()
        {
            InitializeComponent();

            ControlButtonClicked += (x) => ResetButtonsColor();
            ControlButtonClicked += SetButtonColor;
            ControlButtonClicked += AddWorkspace;
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

            ControlButtonClicked.Invoke(value);
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void FormRental_FormClosing(object sender, FormClosingEventArgs e)
        {
            System.Diagnostics.Process.GetCurrentProcess().Kill();
            Application.Exit();
        }
    }
}
