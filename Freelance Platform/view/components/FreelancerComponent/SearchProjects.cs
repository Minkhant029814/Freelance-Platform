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

        private readonly List<Project> projects;
        private readonly FreelancerService fservice;
        private FreeLancerProjectCard card;
        
        public SearchProjects()
        {
           
            InitializeComponent();
            fservice = new FreelancerService();

            this.projects = fservice.BrowseProjects(txtSearch.Text);
            CreatingCard();
           
        }

        private void SearchProjects_Load(object sender, EventArgs e)
        {

        }

        private void CreatingCard()
        {
            foreach(Project p in projects)
            {
                card = new FreeLancerProjectCard(p);
                ProjectDisplay.Controls.Add(card);
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
                c.Width = ProjectDisplay.ClientSize.Width - 25;
            }
        }
    }
}
