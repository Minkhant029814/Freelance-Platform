using Freelance_Platform.DTO;
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
    public partial class RatingFreelancer : Form
    {
        private readonly AssignedProjectDTO pf;
        public RatingFreelancer(AssignedProjectDTO p)
        {
            InitializeComponent();
            this.pf = p;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RatingFreelancer_Load(object sender, EventArgs e)
        {
            LoadData();
        }

        private void LoadData()
        {
            lblFreelacerName.Text = pf.Freelancer.Portfolio.OwnerName;
            lblProfessionalTitle.Text = pf.Freelancer.Portfolio.ProfessionalTitle;
            lblProjectTitle.Text = pf.Project.ProjectTitle;

            string imgPath = Path.Combine(Application.StartupPath, "Uploads", pf.Freelancer.Portfolio.Profile ?? "");
            profilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;



        }
    }
}
