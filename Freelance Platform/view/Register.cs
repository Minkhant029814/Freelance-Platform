using Freelance_Platform.model;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Forms
{
    public partial class Register : Form
    {

        private readonly UserService userService = new UserService();
        public Register()
        {
            InitializeComponent();
        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {
                txtPassword.PasswordChar = '\0';
                txtConfirm.PasswordChar = '\0';
            }
            else
            {
                txtPassword.PasswordChar = '*' ;
                txtConfirm.PasswordChar = '*';
            }
        }

        public bool ValidatePassword(string password)
        {
            if (password == null) return false;
            if (password.Length < 8 || password.Length > 12)
            {
                return false;
            }
            bool hasUpper = Regex.IsMatch(password, "[A-Z]");
            bool hasLower = Regex.IsMatch(password, "[a-z]");

            return hasUpper && hasLower;
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string name = txtUserName.Text?.Trim();
            string password = txtPassword.Text;
            string confirmPass = txtConfirm.Text;
            string type = comboRole.Text?.Trim();

            // Validation
            if (string.IsNullOrWhiteSpace(name) ||
                string.IsNullOrWhiteSpace(password) ||
                string.IsNullOrWhiteSpace(type))
            {
                MessageBox.Show(
                    "All fields are required.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }
            //Ensure a valid is selected 
            if(!string.Equals(type,"Freelancer",StringComparison.OrdinalIgnoreCase) &&
                !string.Equals(type, "Client", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Please select a valid role.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // Confirm Password
            if (password != confirmPass)
            {
                MessageBox.Show(
                    "Passwords do not match.",
                    "Validation",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            if (!ValidatePassword(password))
            {
                MessageBox.Show(
                     "Password must be between 8 and 12 \n at least UpperCase and lowerCase",
                     "Validation",
                     MessageBoxButtons.OK,
                     MessageBoxIcon.Warning);

                return;
            }


            User user = new User(name,password,type);

            btnRegister.Enabled = false;
            try
            {
                // Register
                int userId = userService.Register(user);

                // Register Failed
                if (userId <= 0)
                {
                    MessageBox.Show(
                        "Username already exists or registration failed.",
                        "Register",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    return;
                }

                MessageBox.Show(
                    "Account created successfully.",
                    "Register",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                // Open Profile Form
                if (type == "Freelancer")
                {
                    new FreelancerProfile(userId, name).Show();


                }
                else
                {
                    ClientProfile frm =
                        new ClientProfile(userId, type, name);


                    frm.Show();
                }

                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Registration failed: " + ex.Message, "Register", MessageBoxButtons.OK, MessageBoxIcon.Error);
                throw;
            }
            finally
            {
                btnRegister.Enabled = true;
            }

        }

        private void Register_Load(object sender, EventArgs e)
        {

        }

        private void lbLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new frmLogin().Show();
            this.Hide();
        }
    }
}
