using System;
using System.Linq;
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

        private void submitLoginButton_Click(object sender, EventArgs e)
        {
            string userPassword = passwordTextBox.Text;
            string userName = usernameTextBox.Text;

            var userData = DB.Users.Where(u => u.name == userName && u.password == userPassword).Count();
            
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

        private void FormLogin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
