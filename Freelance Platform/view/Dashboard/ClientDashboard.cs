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

namespace Freelance_Platform.Forms.Dashboard
{
    public partial class ClientDashboard : Form
    {
        public ClientDashboard()
        {
            InitializeComponent();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
           
        }

        private void lblProject_Click(object sender, EventArgs e)
        {

        }

        private void btnPostProject_Click(object sender, EventArgs e)
        {
            new PostProjectForm().ShowDialog();
        }

        private void ClientDashboard_Load(object sender, EventArgs e)
        {
            
            btnPostProject.Image = IconChar.PlusCircle.ToBitmap(Color.White, 30);
        }
    }
}
