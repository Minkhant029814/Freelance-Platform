using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
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
    public partial class SettingMileStone : Form
    {
        private readonly int projectId;
        private readonly FreelancerService fservice;
       
        private int mileStoneCounts;
        private int mileStoneWeight;
      

        public SettingMileStone(int pid)
        {
            InitializeComponent();
            this.projectId = pid;
            fservice = new FreelancerService();
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void mileStoneCard_Paint(object sender, PaintEventArgs e)
        {
        }

        private void MileStoneLayout_Resize(object sender, EventArgs e)
        {
            foreach (Control c in MileStoneLayout.Controls)
            {
                c.Width = MileStoneLayout.ClientSize.Width - 40;
            }
        }

        private void btnAddMileStones_Click(object sender, EventArgs e)
        {
            mileStoneCounts++;
            mileStoneAddComponent newComponent = new mileStoneAddComponent(mileStoneCounts);

            newComponent.MileStoneDeleted += (s, args) =>
            {
                mileStoneCounts--;
                if (mileStoneCounts < 0) mileStoneCounts = 0;

                lblMildeStoneCount.Text = $"{mileStoneCounts} milestones";

               
                this.BeginInvoke((Action)(() =>
                {
                    DisplayMileStoneWeight();
                }));
            };

            MileStoneLayout.Controls.Add(newComponent);
            lblMildeStoneCount.Text = $"{mileStoneCounts} milestones";

            DisplayMileStoneWeight();
            MileStoneLayout.ScrollControlIntoView(newComponent);
        }

        private void DisplayMileStoneWeight()
        {
            mileStoneWeight = 0; 

            foreach (Control c in MileStoneLayout.Controls)
            {
                if (c is mileStoneAddComponent comp)
                {
                   
                    int weight = comp.MilestoneWeight;
                    mileStoneWeight += weight;
                    if(mileStoneWeight == 100)
                    {
                        btnAddMileStones.Enabled = false;
                        lblMileStonePercentage.Text = $"Your milestone weights are ready to share.";
                        lblMileStonePercentage.ForeColor = Color.Green;
                    }else if(mileStoneWeight > 100)
                    {
                        lblMileStonePercentage.Text = $"{mileStoneWeight - 100} Over to Reach 100 %";
                        lblMileStonePercentage.ForeColor = Color.Orange;
                        btnAddMileStones.Enabled = false;
                    }
                    else
                    {
                        btnAddMileStones.Enabled = true;
                        lblMileStonePercentage.Text = $"{100 - mileStoneWeight} remaings to Reach 100 %";
                        lblMileStonePercentage.ForeColor = Color.Red;
                    }
                    
                }
            }

            
            if (mileStoneWeight < 0) mileStoneWeight = 0;

            lblTotalWeight.Text = $"Total Weight \n {mileStoneWeight} % ";
        }
           
        private void SaveMilestones()
        {

            List<Milestone> milestones = new List<Milestone>();
            int totalWeight = 0;
            foreach (Control c in MileStoneLayout.Controls)
            {
                if (c is mileStoneAddComponent comp)
                {
                   
                    if (string.IsNullOrEmpty(comp.MilestoneTitle.Trim()))
                    {
                        MessageBox.Show("Milestone title cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                  
                    if (string.IsNullOrEmpty(comp.MilestoneDescription))
                    {
                        MessageBox.Show("Milestone description cannot be empty!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    
                    if (comp.MilestoneWeight <= 0)
                    {
                        MessageBox.Show("Milestone weight must be greater than zero!", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                        return;
                    }

                    Milestone m = new Milestone
                    {
                        ProjectId = this.projectId,
                        FreelancerId = Convert.ToInt32(UserSession.FreelancerId),
                        Title = comp.MilestoneTitle.Trim(),
                        Description = comp.MilestoneDescription.Trim(),
                        Weight = comp.MilestoneWeight,
                        Status = "PENDING",
                        Progress = 0
                    };

                    milestones.Add(m);
                    totalWeight += comp.MilestoneWeight;
                }
            }

           
            if (milestones.Count == 0)
            {
                MessageBox.Show("Please add at least one milestone.", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (totalWeight != 100)
            {
                MessageBox.Show($"Total weight must be exactly 100%. Current total: {totalWeight}%", "Weight Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

           
            if (SaveToDatabase(projectId, Convert.ToInt32(UserSession.FreelancerId), milestones))
            {
                MessageBox.Show("Set Milestones successfully...", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close(); 
            }
            else
            {
                MessageBox.Show("Fail to set Milestone...", "Database Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool SaveToDatabase(int projectId, int freelancerId, List<Milestone> ms)
        {
            return fservice.SetMileStones(projectId, freelancerId, ms);
        }

        private void btnSaveMileStone_Click(object sender, EventArgs e)
        {
            SaveMilestones();
        }

        private void SettingMileStone_Load(object sender, EventArgs e)
        {

        }
    }
}