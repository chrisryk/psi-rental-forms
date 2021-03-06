using System;
using System.Data.Entity.Core;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormLogin : Form
    {
        private event Action UserDataSubmitted = () => { };
        private string userPassword;
        private string userName;
        public static Role UserRole { get; private set; }
        public FormLogin()
        {
            InitializeComponent();

            UserDataSubmitted += ValidateInputData;
            UserDataSubmitted += SetRole;
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
            userPassword = passwordTextBox.Text;
            userName = usernameTextBox.Text;

            UserDataSubmitted.Invoke();

        }
        private void ValidateInputData()
        {
            try
            {
                var userInputValid = InputValidation.Login(userName, userPassword);

                if (userInputValid)
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
        private void SetRole()
        {
            try
            {
                var role = RentalDatabase.GetRole(userName, userPassword);
                UserRole = RoleSetter.SetRole(role);
                MessageBox.Show("Role: " + UserRole.ToString(), "Info!");
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
