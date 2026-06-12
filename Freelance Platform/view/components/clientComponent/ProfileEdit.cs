using FontAwesome.Sharp;
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
        public ProfileEdit()
        {
            InitializeComponent();
        }

        private void txtAddress_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {

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
    }
}
