using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Windows.Forms;
using Freelance_Platform.components;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using Freelance_Platform.view.components.FreelancerComponent;

namespace Freelance_Platform.Forms.Dashboard
{
    public partial class FreelancerDashboard : Form
    {
        private readonly ProjectService projectService = new ProjectService();
        private readonly FreelancerService freelancerService = new FreelancerService();

        // Components
        private readonly FreelancerEdit profile;
        private readonly SearchProjects searchProjects;

        public FreelancerDashboard()
        {
            InitializeComponent();

           
            profile = new FreelancerEdit(this) { Visible = false, Dock = DockStyle.Fill };
            searchProjects = new SearchProjects(projectService.GetAllProjects()) { Visible = false, Dock = DockStyle.Fill };

            
            mainPanel.Controls.Add(profile);
            mainPanel.Controls.Add(searchProjects);

          
            flowCardDisplay.AutoScroll = true;
            flowCardDisplay.WrapContents = false;
            flowCardDisplay.FlowDirection = FlowDirection.TopDown;
            flowCardDisplay.Resize += flowCardDisplay_Resize;
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            DisplayDashboard();
            DisplayProjectCards();
        }

        // အဓိက UI Switching Logic
        private void ShowDashboardView()
        {
            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;
            flowCardDisplay.Visible = true;
            CardLayout.Visible = true;
            lblRecommend.Visible = true;
        }

        private void ShowProfileView()
        {
            flowCardDisplay.Visible = false;
            CardLayout.Visible = false;
            lblRecommend.Visible = false;

            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;

            profile.LoadData(freelancerService.DashboardInfo());
            profile.Visible = true;
            profile.BringToFront();
        }

        public void RefreshAllViews()
        {
            // Database ကနေ Data အသစ်ပြန်ယူ
            List<Project> updatedList = projectService.GetAllProjects();

            // Dashboard ကို ပြန်ဆောက်
            DisplayProjectCards();

            // SearchProjects ကို Data အသစ်နဲ့ Update လုပ်
            searchProjects.ShowProjects(updatedList);
        }
        private void ShowBrowseView()
        {
            flowCardDisplay.Visible = false;
            CardLayout.Visible = false;
            lblRecommend.Visible = false;

            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;

            searchProjects.Visible = true;
            searchProjects.BringToFront();
        }

        // Navigation Buttons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = freelancerService.DashboardInfo().Portfolio.OwnerName;
            ShowDashboardView();
            DisplayDashboard();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Profile Setup";
            lblDesc.Text = "Complete your profile to win more projects";
            RefreshAllViews();
            ShowProfileView();
        }

        private void btnBrowseProject_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Browse Projects";
            lblDesc.Text = "Find work that matches your skills";
            RefreshAllViews();
            ShowBrowseView();
        }

        // Data Display Methods
        public void DisplayDashboard()
        {
            Freelancer f = freelancerService.DashboardInfo();
            lblGreeting.Text = f.Portfolio.OwnerName;
            lblName.Text = f.Portfolio.OwnerName;

            string imgPath = Path.Combine(Application.StartupPath, "Uploads", f.Portfolio.Profile ?? "");
            ProfilePict.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;
        }

        private void DisplayProjectCards()
        {
            flowCardDisplay.SuspendLayout();
            flowCardDisplay.Controls.Clear();
            List<Project> activeProjects = projectService.GetAllProjects();

            foreach (Project proj in activeProjects)
            {
                FreeLancerProjectCard card = new FreeLancerProjectCard();
                card.PopulateData(proj.ProjectId, proj.ProjectTitle, proj.Description,
                                  proj.BaselineBudget.ToString("N0"), proj.EndDate.ToString("d/M/yyyy"),proj.Status);

                card.OnBidChanged += (s, ev) =>
                {
                    // တစ်ဖက်ဖက်မှာ နှိပ်လိုက်တာနဲ့ နှစ်နေရာလုံးကို Update လုပ်မယ်
                    DisplayProjectCards();
                    searchProjects.ShowProjects(projectService.GetAllProjects());
                };
                card.Width = flowCardDisplay.ClientSize.Width - 25;
                flowCardDisplay.Controls.Add(card);
            }
            flowCardDisplay.ResumeLayout();
        }

        private void flowCardDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowCardDisplay.Controls) c.Width = flowCardDisplay.ClientSize.Width - 25;
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Sign Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserSession.Logout();
                new frmLogin().Show();
                this.Hide();
            }
        }
    }
}