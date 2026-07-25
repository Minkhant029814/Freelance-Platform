using Freelance_Platform.DTO;
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

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class AcceptedProjectCard : UserControl
    {
        private readonly ProjectStatusDTO project;
        private readonly FreelancerService fservice;
        
        public AcceptedProjectCard(ProjectStatusDTO p)
        {
            InitializeComponent();
            fservice = new FreelancerService();
            this.project = p;
            hasMilestonePanel.Visible = false;
            LoadData(project);
        }


        private void LoadData(ProjectStatusDTO p)
        {
            btnStatus.Text = p.BiddingStatus;
            lblAcceptDate.Text = $"Accepted at {p.BiddingDate.ToString("dd MMMM yyyy")}";
            lblBudget.Text = $"$ {p.ProjectBudget}";
            lblClientName.Text = p.ClientName;
            lblNote.Text = $"Congratulations — {p.ClientName} accepted your proposal. Your contract is now active.";
            lblProjectTitle.Text = p.ProjectTitle;
            if (fservice.HasMileStones(p.ProjectId))
            {
                MilestoneStatusCheck();
            }
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        
        private void headContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetMileStone_Click_1(object sender, EventArgs e)
        {
            SettingMileStone setMileStone = new SettingMileStone(project.ProjectId);
            setMileStone.SaveMileStone += () =>
            {
                MilestoneStatusCheck();
            };
            setMileStone.ShowDialog();

        }

        private void MilestoneStatusCheck()
        {
            btnSetMileStone.Visible = false;
            hasMilestonePanel.Visible = true;
        }
    }
}
