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
    public partial class CompletedCardByClient : UserControl
    {
        private readonly AssignedProjectDTO project;
        public CompletedCardByClient(AssignedProjectDTO p)
        {
            InitializeComponent();
            this.project= p;
            LoadData(project);
        }

        private void LoadData(AssignedProjectDTO pf)
        {
            lblProjectTitle.Text = pf.Project.ProjectTitle;
            lblDescription.Text = pf.Project.Description;
            lblDate.Text = $"Completed {pf.Project.CompletedDate:dd MMMM yyyy}";
            lblStatus.Text = pf.Project.CurrentStatus;
            lblFinalPayment.Text = $"Final payment: ${pf.Project.BaselineBudget} paid";

            //Freelancers info
            lblFreelancerName.Text = pf.Freelancer.Portfolio.OwnerName;
            lblPayrate.Text = $"${pf.Freelancer.HourlyRate}/hr";
            lblProfessionalTitle.Text = pf.Freelancer.Portfolio.ProfessionalTitle;

            if (pf.Review.ReviewId > 0)
            {
                btnRating.Visible = false;

                ReviewPanel.Visible = true;
                RatingStar.Value = pf.Review.Rating;
                lblComments.Text = pf.Review.Comment;


            }
            else
            {
                btnRating.Visible = true; 
            }

            //for profile image
            //for Profile picutre
            string imgPath = Path.Combine(Application.StartupPath, "Uploads", pf.Freelancer.Portfolio.Profile ?? "");
            profilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;


        }

        private void btnRating_Click(object sender, EventArgs e)
        {
            RatingFreelancer ratingForm = new RatingFreelancer(project);

            ratingForm.OnRatedCompleted += (savedReview) =>
            {
                
                project.Review = savedReview;

                
                btnRating.Visible = false;
                ReviewPanel.Visible = true;
                RatingStar.Value = savedReview.Rating;
                lblComments.Text = savedReview.Comment;
            };

            ratingForm.ShowDialog();
        }
    }
}
