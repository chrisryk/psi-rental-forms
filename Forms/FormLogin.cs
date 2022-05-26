﻿using System;
using System.Data.Entity.Core;
using System.Linq;
using System.Windows.Forms;

namespace CarRental
{
    public partial class FormLogin : Form
    {
        private event Action UserDataSubmitted = () => { };
        private string userPassword;
        private string userName;
        public static Role UserRole { get; private set; } = Role.None;
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
            var role = from r in RentalDatabase.DB.Roles
                       join u in RentalDatabase.DB.Users
                       on r.id equals u.role_id
                       where u.name == userName
                       where u.password == userPassword
                       select r.role;

            switch (role.FirstOrDefault())
            {
                case "admin":
                    UserRole = Role.Admin;
                    break;
                case "manager":
                    UserRole = Role.Manager;
                    break;
                case "customer advisor":
                    UserRole = Role.Advisor;
                    break;
                default:
                    break;
            }

            MessageBox.Show("Role: " + UserRole.ToString(), "Info!");
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
