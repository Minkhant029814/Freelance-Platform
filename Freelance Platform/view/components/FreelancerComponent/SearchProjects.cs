using Freelance_Platform.Forms.Dashboard;
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

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class SearchProjects : UserControl
    {

       
        private readonly FreelancerService fservice;
        private FreeLancerProjectCard card;
        
        public SearchProjects()
        {
           
            InitializeComponent();
            fservice = new FreelancerService();

            
            CreatingCard(txtSearch.Text);
           
        }

        private void SearchProjects_Load(object sender, EventArgs e)
        {

        }

        private void CreatingCard(string keyword)
        {
            ProjectDisplay.Controls.Clear();
            var projects = fservice.BrowseProjects(keyword);
            if (projects.Count == 0)
            {
                Label lblMessage = new Label();
                lblMessage.Text = "No  projects ....";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblMessage.AutoSize = true;


                

                ProjectDisplay.Controls.Add(lblMessage);

                foreach (Project p in projects)
                {
                    FreeLancerProjectCard card = new FreeLancerProjectCard(p);

                    card.Width = ProjectDisplay.ClientSize.Width - 30;
                    ProjectDisplay.Controls.Add(card);
                }
            }
        }



      

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectDisplay_Paint(object sender, PaintEventArgs e)
        {

        }

        private void ProjectDisplay_Resize(object sender, EventArgs e)
        {
            foreach(Control c in ProjectDisplay.Controls)
            {
                c.Width = ProjectDisplay.ClientSize.Width - 30;
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            
            CreatingCard(txtSearch.Text);
        }
    }
}
