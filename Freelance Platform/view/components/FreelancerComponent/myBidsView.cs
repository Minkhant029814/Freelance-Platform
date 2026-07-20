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
            List<AcceptedProjectDTO> projects = fservice.GetAcceptedProjects();
            foreach(AcceptedProjectDTO p in projects)
            {
                AcceptedProjectCard card = new AcceptedProjectCard(p);
                acceptedLayout.Controls.Add(card);
            }

        }

        private void PendingPage()
        {

        }

        private void RejectedPage()
        {

        }
        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2TabControl1.SelectedIndex)
            {
                case 0:
                    AcceptedPage();
                    break;

                case 1:
                    PendingPage();
                    break;

                case 2:
                    RejectedPage();
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
    }
}
