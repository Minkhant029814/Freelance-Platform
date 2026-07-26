using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Repositories;
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

namespace Freelance_Platform.Forms
{
    public partial class PostProjectForm : Form
    {

        private readonly ProjectService projectService;
        public PostProjectForm()
        {
            InitializeComponent();
            projectService = new ProjectService();
            dtimeStartDate.Value = DateTime.Now;
            dtimeStartDate.MinDate = dtimeStartDate.Value;
            dtimeEndDate.Value = DateTime.Now.AddDays(7);
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void PostProjectForm_Load(object sender, EventArgs e)
        {
            btnPostProject.Image = IconChar.PlusCircle.ToBitmap(Color.White, 30);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private bool PostProjectValidation()
        {
            
            if (string.IsNullOrEmpty(txtProjectTitle.Text.Trim()))
            {
                MessageBox.Show("Please enter the project title.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProjectTitle.Focus(); 
                return false;
            }

           
            if (string.IsNullOrEmpty(txtProejctDesc.Text.Trim()))
            {
                MessageBox.Show("Please provide a detailed description for your project.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtProejctDesc.Focus();
                return false;
            }

            if ((double)numBudget.Value <= 0.00)
            {
                MessageBox.Show("Please enter a valid project budget greater than $0.00.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                numBudget.Focus();
                return false;
            }

           
            if (dtimeStartDate.Value.Date < DateTime.Now.Date)
            {
                MessageBox.Show("The project start date cannot be in the past.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeStartDate.Focus();
                return false;
            }

          
            if (dtimeStartDate.Value.Date > dtimeEndDate.Value.Date)
            {
                MessageBox.Show("The project end date must be after the start date.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                dtimeEndDate.Focus();
                return false;
            }

            
            return true;
        }
        private void btnPostProject_Click(object sender, EventArgs e)
        {

            Project p = new Project();
            p.ProjectTitle = txtProjectTitle.Text;
            p.Description = txtProejctDesc.Text;
            p.BaselineBudget = numBudget.Value;
            p.StartDate = dtimeStartDate.Value;
            p.EndDate = dtimeEndDate.Value;

            if (!PostProjectValidation())
            {
                
                return;
            }


            if (projectService.PostProject(p))
            {
                DialogResult result = MessageBox.Show(
                    "Project is posted successfully!\nDo you want to post another project?",
                    "Success",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Question
                );

                if (result == DialogResult.Yes)
                {
                    txtProjectTitle.Clear();
                    txtProejctDesc.Clear();
                    numBudget.Value = 0;
                    
                }
                else
                {
                    // No ကို နှိပ်လျှင် Form ကို ပိတ်မည်
                    this.Close();
                }
            }
            else
            {
                MessageBox.Show("Failed to Post Project", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void dtimeStartDate_ValueChanged(object sender, EventArgs e)
        {
            dtimeEndDate.MinDate = dtimeStartDate.Value;

            if (dtimeEndDate.Value < dtimeStartDate.Value)
            {
                dtimeEndDate.Value = dtimeStartDate.Value;
            }
        }

        
    }
}
