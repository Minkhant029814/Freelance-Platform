using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
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

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class ProfileEdit : UserControl
    {
        private readonly ClientService clientService;
        private string selectedFilePath = "";
        private readonly Client client;

        public ProfileEdit()
        {
            InitializeComponent();
            clientService = new ClientService();
            client = clientService.GetClientDetails(Convert.ToInt32(UserSession.ClientId));
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            btnSaveChanges.Image = IconChar.Save.ToBitmap(color: Color.White, 30);
            UpdateProfile(client);

            
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            string profileName = "";

            if (!string.IsNullOrEmpty(selectedFilePath))
            {
                profileName = HandleImageUpload(UserSession.UserId, selectedFilePath);

                if (profileName == "ERROR")
                {
                    return;
                }
            }
            else
            {
                profileName = client.ProfilePic;
            }

            Client c = new Client(username: txtName.Text, "", "")
            {
                Email = txtEmail.Text,
                Phone = txtPhone.Text,
                Address = txtAddress.Text,
                ProfilePic = profileName
            };

            bool flag = clientService.UpdateProfile(c);

            if (flag)
            {

                UpdateProfile(clientService.GetClientDetails(Convert.ToInt32(UserSession.ClientId)));

                MessageBox.Show("Update successfully");
            }
            else
            {
                MessageBox.Show("failed to update data");
            }
        }
        
        private void UpdateProfile(Client c)
        {
            txtName.Text = c.Username;
            txtEmail.Text = c.Email;
            txtPhone.Text = c.Phone;
            txtAddress.Text = c.Address;

            if (!string.IsNullOrEmpty(c.ProfilePic))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", c.ProfilePic);

                if (File.Exists(imgPath))
                {
                    
                    using (var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                    {
                        ProfilePict.Image = Image.FromStream(fs);
                    }
                    return;
                }
            }

            ProfilePict.Image = Properties.Resources.register;
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
                MessageBox.Show("Image upload Failed.... " + ex.Message, "Upload Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return "ERROR";
            }
        }

        private void btnEditProfile_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog ofd = new OpenFileDialog())
            {
                ofd.Filter = "Image Files|*.jpg;*.jpeg;*.png;";
                if (ofd.ShowDialog() == DialogResult.OK)
                {
                    selectedFilePath = ofd.FileName;
                    ProfilePict.Image = Image.FromFile(selectedFilePath);
                }
            }
        }

       
    }
}