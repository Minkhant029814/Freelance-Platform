using FontAwesome.Sharp;
using Freelance_Platform.components;
using Freelance_Platform.model;
using Freelance_Platform.Service;
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
       
        public FreelancerDashboard()
        {
            InitializeComponent();
            flowCardDisplay.Resize += flowCardDisplay_Resize;
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            
            //flowCardDisplay.Dock = DockStyle.Fill;
            flowCardDisplay.AutoScroll = true;
            flowCardDisplay.WrapContents = false;
            flowCardDisplay.FlowDirection = FlowDirection.TopDown;
            DisplayDashboard();
            DisplayProjectCards();
        }


        private void DisplayDashboard()
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
    }
}
