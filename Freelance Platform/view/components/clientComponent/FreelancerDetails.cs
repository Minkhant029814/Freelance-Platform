using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.FreelancerComponent;
using Guna.UI2.WinForms;
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
    public partial class FreelancerDetails : Form
    {
        private readonly FreelancerService fservice;

        private readonly int freelancerId;
        private  Freelancer freelancer;
        public FreelancerDetails(int fId)
        {
            this.freelancerId = fId;
            fservice = new FreelancerService();
            InitializeComponent();
        }

        private void FreelancerDetails_Load(object sender, EventArgs e)
        {
            freelancer = fservice.FreelancerDetails(freelancerId);
            lblNoProject.Visible = false;
            ShowData();

        }

        private void ShowData()
        {
            lblBio.Text = freelancer.Portfolio.Biography;
            lblName.Text = freelancer.Portfolio.OwnerName;
            lblProfessionalTitle.Text = freelancer.Portfolio.ProfessionalTitle;
            guna2RatingStar1.Value = freelancer.AverageRating;
            lblHourlyRate.Text = freelancer.HourlyRate.ToString() + " $ / hour";
            lblRating.Text = freelancer.AverageRating.ToString();
            lblReviewCount.Text = freelancer.TotalReviews.ToString();
            DisplayPastProjects(freelancer.Portfolio.Projects.ToList());
            lblProjectCount.Text = freelancer.Portfolio.Projects.Count.ToString() + " Past Projects";

            //display Profile
            //for Profile picutre
            string imgPath = Path.Combine(Application.StartupPath, "Uploads", freelancer.Portfolio.Profile ?? "");
            ProfilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;

            // Display Skill Panel
            if (freelancer.Skills != null)
            {
                SkillsPanel.Controls.Clear();
                foreach (string skill in freelancer.Skills)
                {
                    CreateSkillButton(skill);
                }
            }
        }


        //Skill Tag Display
        private void CreateSkillButton(string skill)
        {
            Guna2Button btnSkillTag = new Guna2Button
            {
                
                Text = skill,
                TextAlign = HorizontalAlignment.Left,
                TextOffset = new Point(5, 0),
                AutoSize = true,
                FillColor = Color.FromArgb(11, 115, 168),
                ForeColor = Color.White,
                BorderRadius = 15,
                Font = new Font("Segoe UI", 9F, FontStyle.Regular),
                Margin = new Padding(4),
                Padding = new Padding(10, 5, 10, 5),
            };

            SkillsPanel.Controls.Add(btnSkillTag);
        }

        //Past Projects Dispaly
        private void DisplayPastProjects(List<Project> projects)
        {

            PastWorkDisplay.Controls.Clear();

            if (projects == null || projects.Count == 0)
            {
                lblNoProject.Visible = true;
                return;
            }

            foreach (Project p in projects)
            {

                PastWorksCard card = new PastWorksCard();

                card.LoadData(p);

                //card.Dock = DockStyle.Fill;
                //card.Width = PastWorkDisplay.Width - 30;
                PastWorkDisplay.Controls.Add(card);
            }
        }

        private void FreelancerDetails_Resize(object sender, EventArgs e)
        {
           
        }

        private void PastWorkDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in PastWorkDisplay.Controls)
            {
                c.Width = PastWorkDisplay.Width - 50;
            }
        }
    }
}
