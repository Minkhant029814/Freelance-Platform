using Freelance_Platform.Forms.Dashboard;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Forms
{
    public partial class ClientProflle : Form
    {
        private readonly int userId;
        private readonly string type;
        private readonly string name;
        private readonly ClientService clientService;
        public ClientProflle(int userId, string type, string name)
        {
            InitializeComponent();
            this.userId = userId;
            this.type = type;
            this.name = name;
            clientService = new ClientService();


        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void ClientProflle_Load(object sender, EventArgs e)
        {
            lblClientName.Text = name;
            lblUserType.Text = type + " Account";

        }

        string selectedFilePath = "";
        private void btnUploadImage_Click(object sender, EventArgs e)

        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    pictProfileBox.Image = Image.FromFile(selectedFilePath);

                }
            }
        }

        private void SetText(Control ctrl)
        {
          
            if (ctrl.Tag == null)
            {
                ctrl.Tag = new Tuple<Color, Font>(ctrl.ForeColor, ctrl.Font);
            }

            ctrl.Text = "All fields are required";
            ctrl.ForeColor = Color.Red;

            
            ctrl.Font = new Font(ctrl.Font.FontFamily, 14, ctrl.Font.Style);
        
        }

       


        private void btnSave_Click(object sender, EventArgs e)
        {

            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = rtxtCompanyAddress.Text;
           
            bool hasError = false;

            
            if (string.IsNullOrEmpty(email) || email == "All fields are required")
            {
                SetText(txtEmail);
                hasError = true;
            }

           
            if (string.IsNullOrEmpty(phone) || phone == "All fields are required")
            {
                SetText(txtPhone);
                hasError = true;
            }

            
            if (string.IsNullOrEmpty(address) || address == "All fields are required")
            {
                SetText(rtxtCompanyAddress);
                hasError = true;
            }

         
            if (hasError)
            {
                return;
            }

            string profileFileName = HandleImageUpload(userId, selectedFilePath);

           
            if (profileFileName == "ERROR")
            {
                return;
            }

           
            bool flag = clientService.CreateProfile(userId, email, phone, address, profileFileName);

            if (flag)
            {
                MessageBox.Show("Profile successfully saved!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                selectedFilePath = "";
                this.Hide();
                new Form1().Show();
            }
            else
            {
                MessageBox.Show("Failed to save profile.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

       
        private string HandleImageUpload(int userId, string sourceFilePath)
        {
            
            if (string.IsNullOrEmpty(sourceFilePath))
            {
                return null;
            }

            try
            {
                
                string targetFolder = Path.Combine(Application.StartupPath, "Uploads");
                if (!Directory.Exists(targetFolder))
                {
                    Directory.CreateDirectory(targetFolder);
                }

                
                string uniqueFileName = "client_" + userId + Path.GetExtension(sourceFilePath);
                string destinationPath = Path.Combine(targetFolder, uniqueFileName);

              
                File.Copy(sourceFilePath, destinationPath, true);

                
                return uniqueFileName;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Image upload လုပ်ရာတွင် အမှားအယွင်းဖြစ်ပါသည်: " + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "ERROR"; 
            }
        }

        private void txtEmail_TextChanged(object sender, EventArgs e)
        {
            

        }

        private void txtPhone_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void rtxtCompanyAddress_TextChanged(object sender, EventArgs e)
        {
        }

        private void txtPhone_Enter(object sender, EventArgs e)
        {
            if (txtPhone.Text == "All fields are required")
            {
                txtPhone.Text = "";

                if (txtPhone.Tag is Tuple<Color, Font> originalStyle)
                {
                    txtPhone.ForeColor = originalStyle.Item1;
                    txtPhone.Font = originalStyle.Item2;
                }
            }
        }

        

        private void rtxtCompanyAddress_Enter(object sender, EventArgs e)
        {
            if (rtxtCompanyAddress.Text == "All fields are required")
            {
                rtxtCompanyAddress.Text = "";

                
                if (rtxtCompanyAddress.Tag is Tuple<Color, Font> originalStyle)
                {
                    rtxtCompanyAddress.ForeColor = originalStyle.Item1;
                    rtxtCompanyAddress.Font = originalStyle.Item2;
                }
            }
        }

        private void txtEmail_Enter(object sender, EventArgs e)
        {
            if (txtEmail.Text == "All fields are required")
            {
                txtEmail.Text = "";

                
                if (txtEmail.Tag is Tuple<Color, Font> originalStyle)
                {
                    txtEmail.ForeColor = originalStyle.Item1;
                    txtEmail.Font = originalStyle.Item2;
                }
            }
        }
    }
        
}
