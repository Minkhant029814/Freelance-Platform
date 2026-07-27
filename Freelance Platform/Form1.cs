using Freelance_Platform.Forms;
using Freelance_Platform.Forms.Dashboard;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using System;
using System.Drawing;
using System.Windows.Forms;



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

        private void Form1_Load(object sender, EventArgs e) { }

        private void splitContainer1_Panel2_Paint(object sender, PaintEventArgs e) { }

        private void panel3_Paint(object sender, PaintEventArgs e) { }

        private void chkShowPassword_CheckedChanged(object sender, EventArgs e)
        {
            txtPassword.PasswordChar = chkShowPassword.Checked ? '\0' : '*';
        }

        private void linkLabel1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            new Register().Show();
            Hide();
        }

        private void SetText(Control ctrl, string message = "All fields are required")
        {
            if (ctrl.Tag == null)
            {
                ctrl.Tag = new Tuple<Color, Font>(ctrl.ForeColor, ctrl.Font);
            }

            ctrl.Text = message;
            ctrl.ForeColor = Color.Red;
            ctrl.Font = new Font(ctrl.Font.FontFamily, 12, ctrl.Font.Style);
        }

        private bool ValidateInputs(out string username, out string password)
        {
            username = txtUserName.Text?.Trim();
            password = txtPassword.Text;

            bool hasError = false;

            if (string.IsNullOrWhiteSpace(username) || username == "All fields are required")
            {
                SetText(txtUserName);
                hasError = true;
            }

            if (string.IsNullOrWhiteSpace(password) || password == "All fields are required")
            {
                // ensure placeholder is visible for password when used as message
                txtPassword.PasswordChar = '\0';
                SetText(txtPassword);
                hasError = true;
            }

            return !hasError;
        }

        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!ValidateInputs(out string name, out string password))
            {
                return;
            }

            // call login once and branch on result + session type
            bool loginResult = userService.Login(name, password);

            if (!loginResult)
            {
                MessageBox.Show("Login Failed", "Authentication", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            string type = UserSession.UserType ?? string.Empty;

            if (string.Equals(type, "Freelancer", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new FreelancerDashboard().Show();
            }
            else if (string.Equals(type, "Client", StringComparison.OrdinalIgnoreCase))
            {
                MessageBox.Show("Login successful", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                Hide();
                new ClientDashboard().Show();
            }
            else
            {
                // Unknown user type — safe fallback
                MessageBox.Show("Login successful, but user role is unrecognized.", "Notice", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

                txtPassword.PasswordChar = '*';
            }
        }
    }
}