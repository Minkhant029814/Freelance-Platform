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
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.Forms.Dashboard
{
    public partial class FreelancerDashboard : Form
    {

        //private readonly FreelancerService freelancerService = new FreelancerService();
        private readonly ProjectService projectService = new ProjectService();
        public FreelancerDashboard()
        {
            InitializeComponent();
        }

        private void FreelancerDashboard_Load(object sender, EventArgs e)
        {
            DisplayProjectCards();

            //mainPanel_Resize(null, null);
        }

       

        private void DisplayProjectCards()
        {

            flowCardDisplay.SuspendLayout();
            flowCardDisplay.Controls.Clear();



            List<Project> activeProjects = projectService.GetAllProjects();

            if(activeProjects.Count == 0)
            {
                Label lblEmpty = new Label() { Text = "No active projects found.", AutoSize = true };
                flowCardDisplay.Controls.Add(lblEmpty);
                return;
            }


            foreach (Project proj in activeProjects)
            {

               

                FreeLancerProjectCard card = new FreeLancerProjectCard();


                card.PopulateData(

                    proj.ProjectTitle,
                    proj.Description,
                    proj.BaselineBudget.ToString("N0"),
                    proj.EndDate.ToString("d/M/yyyy")
                    //proj.CurrentStatus.ToString()
                );


                card.Width = flowCardDisplay.ClientSize.Width - 30;


                flowCardDisplay.Controls.Add(card);
            }
           flowCardDisplay.ResumeLayout();
        }

        private void btnDashboard_Click(object sender, EventArgs e)
        {
            
        }

        //private void mainPanel_Resize(object sender, EventArgs e)
        //{
        //    ProjectsLayout.Width = mainPanel.ClientSize.Width - 30;


        //    foreach (Control ctrl in ProjectsLayout.Controls)
        //    {
        //        if (ctrl is ProjectCardRow)
        //        {
        //            ctrl.Width = ProjectsLayout.ClientSize.Width - 30;
        //        }
        //    }
        //}
    }
}
