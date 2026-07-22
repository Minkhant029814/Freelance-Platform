using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.projectsComponent;
using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class ProjectsReview : UserControl
    {
        private readonly ProjectService pservice;

        public ProjectsReview()
        {
            InitializeComponent();

            pservice = new ProjectService();

            // Default Tab
            PlanningPage();
        }

        #region Planning

        private void PlanningPage(bool refresh = false)
        {
            if (planningCardDisplay.Controls.Count > 0 && !refresh)
                return;

            planningCardDisplay.SuspendLayout();
            planningCardDisplay.Controls.Clear();

            List<Project> projects = pservice.GetProjectByStatus("PLANNING");

            foreach (Project project in projects)
            {
                PlanningCard card = new PlanningCard(project);
                card.Width = planningCardDisplay.ClientSize.Width - 25;

                planningCardDisplay.Controls.Add(card);
            }

            guna2TabControl1.TabPages[0].Text =
                $"Planning ({projects.Count})";

            planningCardDisplay.ResumeLayout();
        }

        #endregion

        #region In Progress

        private void InProgressPage(bool refresh = false)
        {
            if (InProgressDisplay.Controls.Count > 0 && !refresh)
                return;

            InProgressDisplay.SuspendLayout();
            InProgressDisplay.Controls.Clear();

            List<AssignedProjectDTO> projects =
                pservice.GetProjectsAssigned();

            foreach (AssignedProjectDTO project in projects)
            {
                InProgressCard card = new InProgressCard(project);

                card.Width = InProgressDisplay.ClientSize.Width - 25;

                InProgressDisplay.Controls.Add(card);
            }

            guna2TabControl1.TabPages[1].Text =
                $"In Progress ({projects.Count})";

            InProgressDisplay.ResumeLayout();
        }

        #endregion

        #region Completed

        private void CompletedPage(bool refresh = false)
        {
            if (CompletedDisplay.Controls.Count > 0 && !refresh)
                return;

            CompletedDisplay.SuspendLayout();
            CompletedDisplay.Controls.Clear();

            
            List<AssignedProjectDTO> projects =
                pservice.GetCompletedProjects();

            foreach (AssignedProjectDTO project in projects)
            {
                CompletedCard card = new CompletedCard(project);

                card.Width = CompletedDisplay.ClientSize.Width - 25;

                CompletedDisplay.Controls.Add(card);
            }

            guna2TabControl1.TabPages[2].Text =
                $"Completed ({projects.Count})";

            CompletedDisplay.ResumeLayout();
        }

        #endregion

        private void guna2TabControl1_SelectedIndexChanged(object sender, EventArgs e)
        {
            switch (guna2TabControl1.SelectedIndex)
            {
                case 0:
                    PlanningPage();
                    break;

                case 1:
                    InProgressPage();
                    break;

                case 2:
                    CompletedPage();
                    break;
            }
        }

        private void planningCardDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in planningCardDisplay.Controls)
            {
                c.Width = planningCardDisplay.ClientSize.Width - 25;
            }
        }

        private void InProgressDisplay_Resize(object sender, EventArgs e)
        {
            foreach (Control c in InProgressDisplay.Controls)
            {
                c.Width = InProgressDisplay.ClientSize.Width - 25;
            }
        }

       

        /// <summary>
        /// Status ပြောင်းပြီး Refresh လုပ်ချင်ရင် ဒီ Method ကိုခေါ်
        /// </summary>
        public void RefreshAllTabs()
        {
            PlanningPage(true);
            InProgressPage(true);
            CompletedPage(true);
        }

        private void CompletedDisplay_Resize(object sender, EventArgs e)
        {
            foreach(Control c in CompletedDisplay.Controls)
            {
                c.Width = CompletedDisplay.ClientSize.Width - 25;
            }
        }
    }
}