using Freelance_Platform.DTO;
using Freelance_Platform.model;
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
    public partial class RatingFreelancer : Form
    {
        private readonly ClientService clientService;
        private readonly AssignedProjectDTO pf;
        private  Review review;
        public RatingFreelancer(AssignedProjectDTO p)
        {
            InitializeComponent();
            this.clientService = new ClientService();
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

        private void btnSave_Click(object sender, EventArgs e)
        {
            //MessageBox.Show($"Rating is {ratingStar.Value}");

            review = new Review
            {
                ProjectId = pf.Project.ProjectId,
                ClientId = Convert.ToInt32(UserSession.ClientId),
                FreelancerId = pf.Freelancer.FreelancerId,
                Rating = ratingStar.Value,
                Comment = rtxtReview.Text
            };

            if (clientService.RatingFreelancer(review))
            {
                MessageBox.Show("Rating Freelancer task is completed..");
                this.Close();
            } else
            {
                MessageBox.Show("Some issues occur in rating freelancer");
            }
        }
    }
}
