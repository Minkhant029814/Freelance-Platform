
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
    public partial class AddPastWorksForm : Form
    {


       
        private readonly Freelancer freelancer;
        public AddPastWorksForm(Freelancer freelancer)
        {
            InitializeComponent();
            this.freelancer = freelancer;
            if (freelancer.Portfolio.Projects == null)
            {
                freelancer.Portfolio.Projects = new List<Project>();
            }

        }

        private void AddPastWorksForm_Load(object sender, EventArgs e)
        {

        }

       

        private void btnAddPastWorks_Click(object sender, EventArgs e)
        {
            if(string.IsNullOrEmpty(txtprojectName.Text) || string.IsNullOrEmpty(txtProjectDes.Text))
            {

                MessageBox.Show("All fields are required....");
                return;
            }

            Project p = new Project
            {
                ProjectTitle = txtprojectName.Text,
                Description = txtProjectDes.Text
            };



           
            
            freelancer.Portfolio.Projects.Add(p);

          
            txtprojectName.Clear();
            txtProjectDes.Clear();
            MessageBox.Show("Project added to list successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

           
        }
    }
}
