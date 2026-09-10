using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using Freelance_Platform.view.components.FreelancerComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;



namespace Freelance_Platform.Forms.Dashboard
{
    public partial class FreelancerDashboard : Form
    {
        private readonly ProjectService projectService = new ProjectService();
        private readonly FreelancerService freelancerService = new FreelancerService();

        // Components
        private readonly FreelancerEdit profile;
        private readonly SearchProjects searchProjects;
        private readonly myBidsView mybids;
        private OngoingProjectComponent ongoingPage;
        private CompletedProjectComponent completedPage;

        public FreelancerDashboard()
        {
            InitializeComponent();
            searchProjects = new SearchProjects();
            mybids = new myBidsView();

            profile = new FreelancerEdit(this) { Visible = false, Dock = DockStyle.Fill };

            mainPanel.Controls.Add(profile);
            searchProjects.Dock = DockStyle.Fill;
            mybids.Dock = DockStyle.Fill;

            mainPanel.Controls.Add(searchProjects);
            mainPanel.Controls.Add(mybids);
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            ShowDashboardView();
            DisplayDashboard();
            DisplayProjectCards(); // initial load
        }

        //  UI Switching Logic
        private void ShowDashboardView()
        {
            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;
            bottomContainer.Visible = true;
            CardLayout.Visible = true;
        }

        private void ShowProfileView()
        {
            bottomContainer.Visible = false;
            CardLayout.Visible = false;

            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;

            profile.LoadData(freelancerService.DashboardInfo());
            profile.Visible = true;
            profile.BringToFront();
        }

        
        /// Refresh views and re-render active project cards.
        /// If updatedProjectId is provided, that project will be moved to top of the list (if present).
      
        public void RefreshAllViews(int? updatedProjectId = null)
        {
            var projects = SafeGetActiveProjects();

            if (projects == null) projects = new List<Project>();

            // If caller provided an updated project id, put it to the top so it's visible immediately
            if (updatedProjectId.HasValue)
            {
                int idx = projects.FindIndex(p => p.ProjectId == updatedProjectId.Value);
                if (idx > 0)
                {
                    var updated = projects[idx];
                    projects.RemoveAt(idx);
                    projects.Insert(0, updated);
                }
            }

            DisplayProjectCards(projects);

            // Optionally refresh other panels that rely on project data
            // If those controls expose public refresh methods, call them here.
            // e.g. if (ongoingPage != null) ongoingPage.RefreshData();
        }

        private void ShowBrowseView()
        {
            CardLayout.Visible = false;
            bottomContainer.Visible = false;

            foreach (Control ctrl in mainPanel.Controls) ctrl.Visible = false;

            searchProjects.Visible = true;
            searchProjects.BringToFront();
        }

        private void ShowBidsView()
        {
            CardLayout.Visible = false;
            bottomContainer.Visible = false;
            foreach (Control c in mainPanel.Controls) c.Visible = false;
            mybids.Visible = true;
            mybids.BringToFront();
        }

        private void ShowOngoingPage()
        {
            ongoingPage = new OngoingProjectComponent();
            CardLayout.Visible = false;
            bottomContainer.Visible = false;
            foreach (Control c in mainPanel.Controls) c.Visible = false;
            ongoingPage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(ongoingPage);

            ongoingPage.Visible = true;
            ongoingPage.BringToFront();
        }

        private void ShowCompletedPage()
        {
            completedPage = new CompletedProjectComponent();
            CardLayout.Visible = false;
            bottomContainer.Visible = false;
            foreach (Control c in mainPanel.Controls) c.Visible = false;
            completedPage.Dock = DockStyle.Fill;
            mainPanel.Controls.Add(completedPage);

            completedPage.Visible = true;
            completedPage.BringToFront();
        }

        // Navigation Buttons
        private void btnDashboard_Click(object sender, EventArgs e)
        {
            var info = freelancerService.DashboardInfo();
            lblGreeting.Text = info?.Portfolio?.OwnerName ?? "";
            lblDesc.Text = "Here is your freelance overview";
            ShowDashboardView();
            DisplayDashboard();
            RefreshAllViews();
        }

        private void btnProfile_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Profile Setup";
            lblDesc.Text = "Complete your profile to win more projects";
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
            lblGreeting.Text = f?.Portfolio?.OwnerName ?? string.Empty;
            lblName.Text = f?.Portfolio?.OwnerName ?? string.Empty;

            // Load image safely without locking file
            ProfilePict.Image?.Dispose();
            if (!string.IsNullOrEmpty(f?.Portfolio?.Profile))
            {
                string imgPath = Path.Combine(Application.StartupPath, "Uploads", f.Portfolio.Profile);
                if (File.Exists(imgPath))
                {
                    try
                    {
                        using (var fs = new FileStream(imgPath, FileMode.Open, FileAccess.Read))
                        using (var img = Image.FromStream(fs))
                        {
                            ProfilePict.Image = new Bitmap(img);
                        }
                        return;
                    }
                    catch
                    {
                        // fall through to default image
                    }
                }
            }

            ProfilePict.Image = Properties.Resources.register;
        }

  
        /// Displays project cards using provided list or fetches from service if null.
        /// Uses SuspendLayout/ResumeLayout to reduce flicker and avoids duplicate DB calls.
      
        private void DisplayProjectCards(List<Project> projects = null)
        {
            flowCardDisplay.SuspendLayout();
            try
            {
                flowCardDisplay.Controls.Clear();

                var activeProjects = projects ?? SafeGetActiveProjects();
                if (activeProjects == null) activeProjects = new List<Project>();

                if (activeProjects.Count == 0)
                {
                    var lblMessage = new Label
                    {
                        Text = "No active projects here",
                        ForeColor = Color.Green,
                        Font = new Font("Segoe UI", 14, FontStyle.Bold),
                        AutoSize = true
                    };

                    // Center label in the flow panel area
                    var wrapper = new Panel
                    {
                        Dock = DockStyle.Fill
                    };
                    lblMessage.Location = new Point(
                        Math.Max(0, (wrapper.ClientSize.Width - lblMessage.PreferredWidth) / 2),
                        Math.Max(0, (wrapper.ClientSize.Height - lblMessage.PreferredHeight) / 2)
                    );
                    lblMessage.Anchor = AnchorStyles.None;
                    wrapper.Controls.Add(lblMessage);
                    flowCardDisplay.Controls.Add(wrapper);
                }
                else
                {
                    foreach (Project proj in activeProjects)
                    {
                        var card = new FreeLancerProjectCard(proj)
                        {
                            Width = Math.Max(0, flowCardDisplay.ClientSize.Width - 25)
                        };

                        flowCardDisplay.Controls.Add(card);
                    }
                }
            }
            finally
            {
                flowCardDisplay.ResumeLayout();
            }
        }

        private List<Project> SafeGetActiveProjects()
        {
            try
            {
                var list = projectService.GetAllProjects() ?? new List<Project>();
                // defensive: ensure no null entries
                return list.Where(p => p != null).ToList();
            }
            catch
            {
                // Don't throw from UI refresh — return empty list on failure
                return new List<Project>();
            }
        }

        private void flowCardDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in flowCardDisplay.Controls)
            {
                // wrapper panels may exist for the "no items" message
                if (c is Panel) continue;
                c.Width = Math.Max(0, flowCardDisplay.ClientSize.Width - 25);
            }
        }

        private void btnSignOut_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to log out?", "Sign Out", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                UserSession.Logout();
                new frmLogin().Show();
                Hide();
            }
        }

        private void FreelancerDashboard_Shown(object sender, EventArgs e)
        {
            DisplayProjectCards();
        }

        private void btnMyBids_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "My Bids";
            lblDesc.Text = "Track client decisions and your next steps";
            ShowBidsView();
        }

        private void btnOngoingProjects_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Ongoing Projects";
            lblDesc.Text = "Track your active contracts and milestones";
            ShowOngoingPage();
        }

        private void btnCompletedProject_Click(object sender, EventArgs e)
        {
            lblGreeting.Text = "Completed Projects";
            lblDesc.Text = "Your finished work and client Feedback";
            ShowCompletedPage();
        }
    }
}