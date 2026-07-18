using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.projectsComponent;
using Org.BouncyCastle.Asn1.Crmf;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class ProjectsReview : UserControl
    {
        private readonly ProjectService pservice;
        private PlanningCard planningCard;
        private List<Project> projects;

        public ProjectsReview()
        {
            InitializeComponent();
            pservice = new ProjectService();
            PlanningPage();
            
        }

        private void planning_Click(object sender, EventArgs e)
        {
            MessageBox.Show("this is planning...");
        }

        private void inProgress_Click(object sender, EventArgs e)
        {
            MessageBox.Show("This is in Progress...");
        }

        private void PlanningPage()
        {
            if(planningCard == null)
            {
                projects = pservice.GetAllProjectsListById();
                foreach(Project p in projects)
                {
                    planningCard = new PlanningCard(p);
                    planningCardDisplay.Controls.Add(planningCard);
                }
                
            }
        }

        private void planningCardDisplay_Resize(object sender, EventArgs e)
        {
            foreach(Control c in planningCardDisplay.Controls)
            {
                c.Width = planningCardDisplay.Width - 50;
            }
        }
    }
}
