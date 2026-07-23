using Freelance_Platform.DTO;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class OngoingProjectCard : UserControl
    {

        public event Action ProjectDataChanged;
        private readonly int projectId;
        private readonly FreelancerService freelancerService;
        public OngoingProjectCard(ProjectWithMilestonesDTO p)
        {
            this.projectId = p.ProjectId;
            freelancerService = new FreelancerService();
            InitializeComponent();
            LoadData(p);
        }

        private void LoadData(ProjectWithMilestonesDTO p)
        {
            lblClientName.Text = p.ClientName;
            lblProjectTitle.Text = p.ProjectTitle;
            btnEndate.Text = p.ProjectEndDate.ToString();
            progressBar.Value = p.OverAllProgress;
            lblprogress.Text += $" {p.OverAllProgress} %";

            if(p.OverAllProgress == 100)
            {
                btnSubmitReview.Visible = true;
            }

            mileStoneLayout.Controls.Clear();
            foreach(Milestone m in p.Milestones)
            {
                MilestoneProgress mileStone = new MilestoneProgress(m,projectId);
                mileStone.UpdatedProgress += () => {
                    ProjectDataChanged?.Invoke();
                };
                mileStone.Width = mileStoneLayout.ClientSize.Width - 25;
                mileStoneLayout.Controls.Add(mileStone);

            }
        }

        private void mileStoneLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in mileStoneLayout.Controls)
            {
                c.Width = mileStoneLayout.ClientSize.Width - 25;
            }
        }

        private void btnSubmitReview_Click(object sender, EventArgs e)
        {
            if (freelancerService.SubmitCompletedProjects(projectId))
            {
                MessageBox.Show("Submit your Completed ProjectSuccessfully");
            }
            else
            {
                MessageBox.Show("Failed to submit your completed project");
            }
        }
    }
}
