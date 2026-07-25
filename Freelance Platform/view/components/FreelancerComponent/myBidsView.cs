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

            //Default Tab
            AcceptedPage();
            
        }

        private void AcceptedPage(bool refresh = false)
        {
            if (acceptedLayout.Controls.Count > 0 && !refresh) return;

            acceptedLayout.Controls.Clear();
            List<ProjectStatusDTO> projects = fservice.GetAcceptedProjects();
            IfNull(projects, acceptedLayout, "No Accepted Projects here...");
            foreach(ProjectStatusDTO p in projects)
            {
                AcceptedProjectCard card = new AcceptedProjectCard(p);
                card.Width = acceptedLayout.ClientSize.Width - 25;
                acceptedLayout.Controls.Add(card);
            }
            guna2TabControl1.TabPages[0].Text = $"Accepted ({projects.Count})";
           

        }

        private void IfNull<T>(List<T> p,Control c, string message)
        {
            if(p.Count == 0)
            {
                Label lblMessage = new Label();
                lblMessage.Text = message;
                lblMessage.ForeColor = Color.Green;
                lblMessage.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblMessage.AutoSize = true;


                lblMessage.Location = new Point(
                    (c.Width - lblMessage.Width) / 2,
                    (c.Height - lblMessage.Height) / 2
                );


                c.Controls.Add(lblMessage);
            }
        }

        private void PendingPage(string status,bool refresh = false)
        {
            if (PendingLayout.Controls.Count > 0 && !refresh) return;
            PendingLayout.Controls.Clear();
            List<ProjectStatusDTO> pendingProjects = fservice.GetBiddingProjectsByStatus(status);
            IfNull(pendingProjects, PendingLayout, "No your bidding projects..");
            foreach(ProjectStatusDTO p in pendingProjects)
            {
                PendingProjectCard card = new PendingProjectCard(p);
                card.Width = PendingLayout.ClientSize.Width - 25;
                PendingLayout.Controls.Add(card);
            }

            guna2TabControl1.TabPages[1].Text = $"Pending ({pendingProjects.Count})";

        }

        private void RejectedPage(string status, bool refresh = false)
        {
            if (RejectedLayout.Controls.Count > 0 && !refresh) return;
            RejectedLayout.Controls.Clear();
            List<ProjectStatusDTO> RejectedProjects = fservice.GetBiddingProjectsByStatus(status);
            IfNull(RejectedProjects, RejectedLayout, "No Rejected Project here...");
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

        public void RefreshAllTabs()
        {
            AcceptedPage(true);
            PendingPage("Pending", true);
            RejectedPage("Rejected", true);
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
