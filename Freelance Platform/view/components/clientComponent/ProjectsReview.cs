using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.projectsComponent;
using System;
using System.Collections.Generic;
using System.Drawing;
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

            List<Project> projects = pservice.GetPlanningProjects();
            IfNull(projects, planningCardDisplay, "No Planning projects here");

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

        

        private void InProgressPage(bool refresh = false)
        {
            if (InProgressDisplay.Controls.Count > 0 && !refresh)
                return;

            InProgressDisplay.SuspendLayout();
            InProgressDisplay.Controls.Clear();

            List<AssignedProjectDTO> projects =
                pservice.GetProjectsAssigned();
            IfNull(projects, InProgressDisplay, "No In_progress projects here...");

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

        private void Reviewpage(bool refresh = false)
        {
            if (ReviewLayout.Controls.Count > 0 && !refresh) return;
            
                ReviewLayout.SuspendLayout();
                ReviewLayout.Controls.Clear();

                List<AssignedProjectDTO> projects =
                    pservice.GetForSubmittedReview();
            IfNull(projects, ReviewLayout, "No submitted projects to check and approve here...");

                foreach (AssignedProjectDTO project in projects)
                {
                    ReviewSubmissionProjectCard card = new ReviewSubmissionProjectCard(project);
                card.ProjectApproved += () => {
                    RefreshAllTabs();
                };
                card.Width = ReviewLayout.ClientSize.Width - 25;
                    ReviewLayout.Controls.Add(card);
                }
                guna2TabControl1.TabPages[2].Text =
                    $"Submissions ({projects.Count}) ";
                ReviewLayout.ResumeLayout();
            

        }

        

        private void CompletedPage(bool refresh = false)
        {
            if (CompletedDisplay.Controls.Count > 0 && !refresh)
                return;

            CompletedDisplay.SuspendLayout();
            CompletedDisplay.Controls.Clear();


            List<AssignedProjectDTO> projects =
                pservice.GetCompletedProjects();
            IfNull(projects,CompletedDisplay,"No Completed project here...");

            foreach (AssignedProjectDTO project in projects)
            {
                CompletedCardByClient card = new CompletedCardByClient(project);

                card.Width = CompletedDisplay.ClientSize.Width - 25;

                CompletedDisplay.Controls.Add(card);
            }

            guna2TabControl1.TabPages[3].Text =
                $"Completed ({projects.Count})";

            CompletedDisplay.ResumeLayout();
        }

        #endregion
        //Messages if there is no projects for each category
        private void IfNull<T>(List<T> p,Control c,string message)
        {
            if (p.Count == 0)
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
                    Reviewpage();
                    break;

                case 3:
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
            Reviewpage(true);
        }

        private void CompletedDisplay_Resize(object sender, EventArgs e)
        {
            foreach(Control c in CompletedDisplay.Controls)
            {
                c.Width = CompletedDisplay.ClientSize.Width - 25;
            }
        }

        private void ReviewLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in ReviewLayout.Controls)
            {
                c.Width = ReviewLayout.ClientSize.Width - 25;
            }
        }
    }
}