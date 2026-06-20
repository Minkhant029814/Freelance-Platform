using FontAwesome.Sharp;
using Freelance_Platform.model;
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
    public partial class AddProjectForm : Form
    {
        private readonly Freelancer freelancer;
        public AddProjectForm(Freelancer f)
        {
            InitializeComponent();
            this.freelancer = f;
            if (freelancer.Portfolio.Projects == null)
            {
                freelancer.Portfolio.Projects = new List<Project>();
            }
        }

        private void AddProjectForm_Load(object sender, EventArgs e)
        {
            btnAddProject.Image = IconChar.Add.ToBitmap(Color.White, 10);
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnAddProject_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtProjectTitle.Text) || string.IsNullOrEmpty(txtShortDesc.Text))
            {
                MessageBox.Show("All fields are required...");
                return;
            }

            Project p = new Project
            {
                ProjectTitle = txtProjectTitle.Text,
                Description = txtShortDesc.Text
            };





            freelancer.Portfolio.Projects.Add(p);


            txtProjectTitle.Clear();
            txtShortDesc.Clear();
            MessageBox.Show("Project added to list successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);


        }
    }
}
