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

        private void btnPostProject_Click(object sender, EventArgs e)
        {
            Project p = new Project();
            p.ProjectTitle = txtProjectTitle.Text;
            p.Description = txtProejctDesc.Text;
            p.BaselineBudget = numBudget.Value;
            p.StartDate = dtimeStartDate.Value;
            p.EndDate = dtimeEndDate.Value;


            if (projectService.PostProject(p))
            {
                MessageBox.Show("Project is posted successfully");
            }
            else
            {
                MessageBox.Show("Failed to Post Proejct");
            }

        }
    }
}
