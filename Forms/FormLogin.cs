using System;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormLogin : Form
    {
        public FormLogin()
        {
            InitializeComponent();
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
                passwordTextBox.PasswordChar = '✱';
                label.Text = "show password";
            }
        }

        private void submitLoginButton_Click(object sender, EventArgs e)
        {
            string userPassword = passwordTextBox.Text;
            string userName = usernameTextBox.Text;
            try
            {

                var userData = RentalDatabase.DB.Users.Where(u => u.name == userName && u.password == userPassword).Count();

                if (userData > 0)
                {
                    MessageBox.Show("Logged in!", "Info!");
                    this.Hide();
                }
                else
                {
                    MessageBox.Show("Login failed!", "Info!");
                    this.Close();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Database connection failed", "Alert!");
                MessageBox.Show(ex.StackTrace, "Info!");
            }
        }

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormLogin_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                submitLoginButton.PerformClick();
            }
        }
    }
}
