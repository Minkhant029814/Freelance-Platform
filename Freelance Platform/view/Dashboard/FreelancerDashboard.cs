using FontAwesome.Sharp;
using Freelance_Platform.components;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using Freelance_Platform.view.components.FreelancerComponent;
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

namespace Freelance_Platform.Forms.Dashboard
{
    public partial class FreelancerDashboard : Form
    {

        private readonly ProjectService projectService = new ProjectService();
        private readonly FreelancerService freelanerService = new FreelancerService();
        
        private readonly FreelancerEdit profile;
        private readonly SearchProjects searchProjects;

        public FreelancerDashboard()
        {
            InitializeComponent();
            profile = new FreelancerEdit(this);
            searchProjects = new SearchProjects(projectService.GetAllProjects());
            flowCardDisplay.Resize += flowCardDisplay_Resize;
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            profile.Dock = DockStyle.Fill;
            profile.Visible = false;
            mainPanel.Controls.Add(profile);

            //flowCardDisplay.Dock = DockStyle.Fill;
            flowCardDisplay.AutoScroll = true;
            flowCardDisplay.WrapContents = false;
            flowCardDisplay.FlowDirection = FlowDirection.TopDown;
            DisplayDashboard();
            DisplayProjectCards();
        }


        public void DisplayDashboard()
        {
            Freelancer f = freelanerService.DashboardInfo();
            lblGreeting.Text = f.Portfolio.OwnerName;
            string image = f.Portfolio.Profile;
            lblName.Text = f.Portfolio.OwnerName;
            //MessageBox.Show("The image name is.......... " + image);
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


        private void DisplayProjectCards()
        {
            flowCardDisplay.SuspendLayout();
            flowCardDisplay.Controls.Clear();

            List<Project> activeProjects = projectService.GetAllProjects();

            foreach (Project proj in activeProjects)
            {
                FreeLancerProjectCard card = new FreeLancerProjectCard();

                card.PopulateData(
                    proj.ProjectTitle,
                    proj.Description,
                    proj.BaselineBudget.ToString("N0"),
                    proj.EndDate.ToString("d/M/yyyy")
                );

                card.Width = flowCardDisplay.ClientSize.Width - 25;
                card.Height = 173;

                flowCardDisplay.Controls.Add(card);
            }

            flowCardDisplay.ResumeLayout();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblRecommend.Visible = true;
            CardLayout.Visible = true;
            flowCardDisplay.Visible = true;
            DisplayDashboard();
            profile.Visible = false;
            mainPanel.Controls.Remove(searchProjects);
            
        }


        //Display Freelancer Profile

           
        private void DisplayProfile()
        {
            
            profile.LoadData(freelanerService.DashboardInfo());
            
            mainPanel.Controls.Add(profile);
            
        }

        private void flowCardDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void FreelancerDashboard_Shown(object sender, EventArgs e)
        {
            //DisplayProjectCards();
        }

        private void flowCardDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowCardDisplay.Controls)
            {
                c.Width = flowCardDisplay.ClientSize.Width - 25;
            }
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Profile Setup";
            lblDesc.Text = "Complete your profile to win more projects";
            lblRecommend.Visible = false;
            CardLayout.Visible = false;
            flowCardDisplay.Visible = false;

            DisplayProfile();
            profile.Visible = true;
            profile.BringToFront();
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            
            DialogResult result = MessageBox.Show("Are you sure to log out?",
                                                  "Sign Out",
                                                  MessageBoxButtons.YesNo,
                                                  MessageBoxIcon.Question);

            if (result == DialogResult.Yes)
            {
                
                UserSession.Logout();

               
                frmLogin loginForm = new frmLogin();
                loginForm.Show();

             
                this.Hide();
                
            }
        }

        private void btnBrowseProject_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Browse Projects";
            lblDesc.Text = "Find work that matches your skills";
            lblRecommend.Visible = false;
            CardLayout.Visible = false;
            flowCardDisplay.Visible = false;
            DisplayProjectsViews();
            

        }

        
        private void DisplayProjectsViews()
        {
            //mainPanel.Controls.Clear();
            searchProjects.Dock = DockStyle.Fill; // အရေးကြီးဆုံးအချက် - mainPanel အပြည့်ဆန့်စေရန်
            if (!mainPanel.Controls.Contains(searchProjects))
            {
                mainPanel.Controls.Add(searchProjects);
            }
            searchProjects.Visible = true;
            searchProjects.BringToFront();
        }
    }
}
