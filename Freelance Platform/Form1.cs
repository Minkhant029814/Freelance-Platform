using Freelance_Platform.Forms;
using Freelance_Platform.Forms.Dashboard;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace Freelance_Platform
{
    public partial class frmLogin : Form
    {

        private readonly UserService userService;
        public frmLogin()
        {
            InitializeComponent();
            userService = new UserService();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            MessageBox.Show("hello world");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void panel3_Paint(object sender, PaintEventArgs e)
        {

        }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            if (chkShowPassword.Checked)
            {// show password
                txtPassword.PasswordChar = '\0';
               

            }
            else
            {
                // hide password
                txtPassword.PasswordChar = '*';
               
            }
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            this.Hide();
        }

        private void SetText(Control ctrl)
        {

            if (ctrl.Tag == null)
            {
                ctrl.Tag = new Tuple<Color, Font>(ctrl.ForeColor, ctrl.Font);
            }

         
            ctrl.Text = "All fields are required";
            ctrl.ForeColor = Color.Red;
            


            ctrl.Font = new Font(ctrl.Font.FontFamily, 12, ctrl.Font.Style);

        }


        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            string name = txtUserName.Text;
            string password = txtPassword.Text;

           

            bool hasError = false;


            if (string.IsNullOrEmpty(name) || name == "All fields are required")
            {
                SetText(txtUserName);
                hasError = true;
            }


            if (string.IsNullOrEmpty(password) || password == "All fields are required")
            {
                if (txtPassword.PasswordChar.Equals('*'))
                {
                    txtPassword.PasswordChar = '\0';
                    SetText(txtPassword);
                }
                
                hasError = true;
            }


            

            if (hasError)
            {
                return;
            }

            if (userService.Login(name,password))
            {
                MessageBox.Show("login successful");
                this.Hide();
                new ClientDashboard().Show();
            }
            else
            {
                MessageBox.Show("Login Failed");
               
            }
        }

        private void txtUserName_Enter(object sender, EventArgs e)
        {
            if (txtUserName.Text == "All fields are required")
            {
                txtUserName.Text = "";


                if (txtUserName.Tag is Tuple<Color, Font> originalStyle)
                {
                   txtUserName.ForeColor = originalStyle.Item1;
                    txtUserName.Font = originalStyle.Item2;
                }
            }

        }

        private void txtPassword_Enter(object sender, EventArgs e)
        {
            if (txtPassword.Text == "All fields are required")
            {
                txtPassword.Text = "";


                if (txtPassword.Tag is Tuple<Color, Font> originalStyle)
                {
                    txtPassword.ForeColor = originalStyle.Item1;
                    txtPassword.Font = originalStyle.Item2;
                }
            }


        }
    }
}
