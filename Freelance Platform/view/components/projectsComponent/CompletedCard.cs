using Freelance_Platform.DTO;
using Freelance_Platform.view.components.clientComponent;
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

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class CompletedCard : UserControl
    {
        private readonly AssignedProjectDTO project;
        public CompletedCard(AssignedProjectDTO p)
        {
            InitializeComponent();
            this.project= p;
            LoadData(project);
        }

        private void LoadData(AssignedProjectDTO pf)
        {
            lblProjectTitle.Text = pf.Project.ProjectTitle;
            lblDescription.Text = pf.Project.Description;
            lblDate.Text = pf.Project.EndDate.ToString("dd MMMM yyyy");
            lblStatus.Text = pf.Project.CurrentStatus;


            //Freelancers info
            lblFreelancerName.Text = pf.Freelancer.Portfolio.OwnerName;
            lblPayrate.Text = pf.Freelancer.HourlyRate.ToString();
            lblProfessionalTitle.Text = pf.Freelancer.Portfolio.ProfessionalTitle;

            //for profile image
            //for Profile picutre
            string imgPath = Path.Combine(Application.StartupPath, "Uploads", pf.Freelancer.Portfolio.Profile ?? "");
            profilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;


        }

        private void btnRating_Click(object sender, EventArgs e)
        {
          Form review =  new RatingFreelancer(project);
            review.Show();
        }
    }
}
