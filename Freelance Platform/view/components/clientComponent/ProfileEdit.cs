using FontAwesome.Sharp;
using Freelance_Platform.Repositories;
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
        private readonly ClientRepository clientRepo;
        public ProfileEdit()
        {
            InitializeComponent();
            clientRepo = new ClientRepository();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

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
                
                profileName = UserSession.Imagepath; 
            }

            bool flag = clientRepo.UpdateProfile(txtName.Text, txtEmail.Text, txtPhone.Text, txtAddress.Text,profileName);

            if (flag)
            {
                MessageBox.Show("Update successfully");

            }
            else
            {
                MessageBox.Show("failed to update data");
            }
        }


        public void UpdateProfile(string name,string email,string phone,string location,string image)
        {
            txtName.Text = name;
            txtEmail.Text = email;
            txtPhone.Text = phone;
            txtAddress.Text = location;

           

           
            if (!string.IsNullOrEmpty(image))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", image);

              
                if (File.Exists(imgPath))
                {
                    
                    ProfilePict.Image = Image.FromFile(imgPath);
                    return; 
                }
            }

            
            ProfilePict.Image = Properties.Resources.register;
        }

        private void ProfileEdit_Load(object sender, EventArgs e)
        {
            btnSaveChanges.Image = IconChar.Save.ToBitmap(color: Color.White, 30);
        }

        private void ProfilePict_Click(object sender, EventArgs e)
        {

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
        string selectedFilePath = "";
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
