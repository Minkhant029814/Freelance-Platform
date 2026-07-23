using Freelance_Platform.DTO;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.projectsComponent;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class myBidsView : UserControl
    {
        private readonly FreelancerService fservice;
        public myBidsView()
        {
            InitializeComponent();
            fservice = new FreelancerService();
            AcceptedPage();
            
        }

        private void AcceptedPage()
        {
            acceptedLayout.Controls.Clear();
            List<ProjectStatusDTO> projects = fservice.GetAcceptedProjects();
            foreach(ProjectStatusDTO p in projects)
            {
                AcceptedProjectCard card = new AcceptedProjectCard(p);
                card.Width = acceptedLayout.ClientSize.Width - 25;
                acceptedLayout.Controls.Add(card);
            }
            guna2TabControl1.TabPages[0].Text = $"Accepted ({projects.Count})";
           

        }

        private void PendingPage(string status)
        {
            PendingLayout.Controls.Clear();
            List<ProjectStatusDTO> pendingProjects = fservice.GetBiddingProjectsByStatus(status);
            foreach(ProjectStatusDTO p in pendingProjects)
            {
                PendingProjectCard card = new PendingProjectCard(p);
                card.Width = PendingLayout.ClientSize.Width - 25;
                PendingLayout.Controls.Add(card);
            }

            guna2TabControl1.TabPages[1].Text = $"Pending ({pendingProjects.Count})";

        }

        private void RejectedPage(string status)
        {
            RejectedLayout.Controls.Clear();
            List<ProjectStatusDTO> RejectedProjects = fservice.GetBiddingProjectsByStatus(status);
            foreach(ProjectStatusDTO p in RejectedProjects)
            {
                RejectedProjectCard card = new RejectedProjectCard(p);
                card.Width = RejectedLayout.ClientSize.Width - 25;
                RejectedLayout.Controls.Add(card);
            }
            guna2TabControl1.TabPages[2].Text = $"Not Selected ({RejectedProjects.Count})";


        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
              switch (guna2TabControl1.SelectedIndex)
                {
                    case 0:
                        AcceptedPage();
                        break;

                    case 1:
                        PendingPage("Pending");
                        break;

                    case 2:
                        RejectedPage("Rejected");
                        break;
                }
           
        }

        private void acceptedLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in acceptedLayout.Controls)
            {
                c.Width = acceptedLayout.ClientSize.Width - 25;
            }
        }

        private void PendingLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in PendingLayout.Controls)
            {
                c.Width = PendingLayout.ClientSize.Width - 25;
            }

        }

        private void RejectedLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in RejectedLayout.Controls)
            {
                c.Width = RejectedLayout.ClientSize.Width - 25;
            }
        }
    }
}
