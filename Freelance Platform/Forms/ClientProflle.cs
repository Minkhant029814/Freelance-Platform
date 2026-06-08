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
            lblUserType.Text = type + "Account";

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

        private void btnSave_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text;
            string phone = txtPhone.Text;
            string address = rtxtCompanyAddress.Text;
            
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
    }
        
}
