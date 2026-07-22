using Freelance_Platform.DTO;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
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
    public partial class OngoingProjectComponent : UserControl
    {
        private readonly FreelancerService fservice;
        private readonly List<ProjectWithMilestonesDTO> projectsWithMilestones;
        public OngoingProjectComponent()
        {
            InitializeComponent();
            fservice = new FreelancerService();
            projectsWithMilestones = fservice.GetProjectsWithMilestones(Convert.ToInt32(UserSession.FreelancerId));
            MessageBox.Show("Freelancer Id is ..." + UserSession.FreelancerId + "\n" + "Project counts is " + projectsWithMilestones.Count) ;
            LoadData(projectsWithMilestones);
            
            

        }

        private void LoadData(List<ProjectWithMilestonesDTO> ps)
        {
            foreach(ProjectWithMilestonesDTO p in ps)
            {
                OngoingProjectCard card = new OngoingProjectCard(p);

                card.Width = ongoingProjectLayout.ClientSize.Width - 25;
                ongoingProjectLayout.Controls.Add(card);
            }
        }

        private void ongoingProjectLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in ongoingProjectLayout.Controls)
            {
                c.Width = ongoingProjectLayout.ClientSize.Width - 25;
            }
        }
    }
}
