using System;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormLogin : Form
    {
        public static RentalEntities DB;
        public FormLogin()
        {
            InitializeComponent();
            DB = new RentalEntities();
        }

        private void showPasswordLabel_Click(object sender, EventArgs e)
        {
            var label = sender as Label;
            if (label.Text == "show password")
            {
                passwordTextBox.PasswordChar = default;
                label.Text = "hide password";
            }
            else
            {
                passwordTextBox.PasswordChar = '*';
                label.Text = "show password";
            }
        }
    }
}
