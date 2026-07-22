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
        private  List<ProjectWithMilestonesDTO> projectsWithMilestones;
        public OngoingProjectComponent()
        {
            InitializeComponent();
            fservice = new FreelancerService();
            LoadAllProjects();
        }

        private void LoadAllProjects()
        {
            projectsWithMilestones = fservice.GetProjectsWithMilestones(Convert.ToInt32(UserSession.FreelancerId));

            LoadData(projectsWithMilestones);

        }

        private void LoadData(List<ProjectWithMilestonesDTO> ps)
        {
            ongoingProjectLayout.Controls.Clear();
            foreach(ProjectWithMilestonesDTO p in ps)
            {
                OngoingProjectCard card = new OngoingProjectCard(p);
                card.ProjectDataChanged += () =>
                {
                    LoadAllProjects();
                };
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
