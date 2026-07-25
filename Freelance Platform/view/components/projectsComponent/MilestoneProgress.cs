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
    public partial class MilestoneProgress : UserControl
    {
        private string newStatus;
        private readonly FreelancerService fservice;
        private readonly ProjectService pservice;
        private readonly int milestoneId;
        private readonly int projectId;

        public event Action UpdatedProgress;
        public MilestoneProgress(Milestone m,int pid)
        {
            InitializeComponent();
            fservice = new FreelancerService();
            pservice = new ProjectService();
            this.milestoneId = m.MilestoneId;
            this.projectId = pid;
            LoadData(m);
          
        }


        private void LoadData(Milestone m)
        {
            lblMileStonetile.Text = m.Title;
            //lblProgressValue.Text = $"{m.Progress} %";
            numProgressValue.Value = m.Progress;

            if (m.Progress == 100)
            {
                lblProgressValue.Text = "100% ✓ Completed";
                lblProgressValue.BackColor = Color.LightGreen;
                iconBtn.IconChar = FontAwesome.Sharp.IconChar.Check;
              
                
                lblProgressValue.Font = new Font(lblProgressValue.Font, FontStyle.Strikeout);
            }
            else if (m.Progress > 0 && m.Progress < 100)
            {
                lblProgressValue.Text = $"{m.Progress}% In Progress";
                lblProgressValue.BackColor = Color.LightBlue;
                iconBtn.IconChar = FontAwesome.Sharp.IconChar.Tasks;

            }
            else
            {
                lblProgressValue.Text = "0% Pending";
                lblProgressValue.BackColor = Color.LightGray;
                iconBtn.IconChar = FontAwesome.Sharp.IconChar.Clock;

            }
        }

        private void btnSaveProgress_Click(object sender, EventArgs e)
        {
            int currentVal = Convert.ToInt32(numProgressValue.Value);

            if (fservice.UpdateMileStoneProgress(milestoneId, currentVal, newStatus) && pservice.CalculateProjectProgressRate(projectId))
            {
                MessageBox.Show("Successfully updated!");

                
                UpdatedProgress?.Invoke();
            }
            else
            {
                MessageBox.Show("Failed to update...");
            }
        }

        private void numProgressValue_ValueChanged(object sender, EventArgs e)
        {
            int val = Convert.ToInt32(numProgressValue.Value);
            if (val == 100)
            {
                lblProgressValue.Text = "100% ✓ Completed";
                lblProgressValue.BackColor = Color.LightGreen;
                lblProgressValue.Font = new Font(lblProgressValue.Font, FontStyle.Strikeout);
                newStatus = "COMPLETED";
            }
            else if (val > 0 && val < 100)
            {
                lblProgressValue.Text = $"{val}% In Progress";
                lblProgressValue.BackColor = Color.LightBlue;
                lblProgressValue.Font = new Font(lblProgressValue.Font,FontStyle.Regular);
                newStatus = "IN_PROGRESS";

            }
            else
            {
                lblProgressValue.Text = "0% Pending";
                lblProgressValue.BackColor = Color.LightGray;
                lblProgressValue.Font = new Font(lblProgressValue.Font, FontStyle.Regular);
                newStatus = "PENDING";

            }
        }
    }
}
