using FontAwesome.Sharp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Forms
{
    public partial class FreelancerProfile : Form
    {
        public FreelancerProfile(int userId,string type,string name)
        {
            InitializeComponent();
            txtName.Text = name;
        }

        private void FreelancerProfile_Load(object sender, EventArgs e)
        {
            btnUploadPhoto.Image = IconChar.Upload.ToBitmap( Color.White, 30);
            txtEmail.IconLeft = IconChar.MailBulk.ToBitmap(Color.Gray, 20); 

            
            //txtEmail.IconLeftSize = new Size(20, 20);

            txtExternalLink.IconLeft = IconChar.Link.ToBitmap(Color.Gray, 20);
        }

        private void guna2TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void guna2TextBox1_TextChanged_1(object sender, EventArgs e)
        {

        }
    }
}
