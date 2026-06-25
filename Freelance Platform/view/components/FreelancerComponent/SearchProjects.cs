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
    public partial class SearchProjects : UserControl
    {
        private readonly List<Project> projects;
        public SearchProjects(List<Project> ps)
        {
            this.projects = ps;
            InitializeComponent();
            ShowProjects(projects);
        }

        private void SearchProjects_Load(object sender, EventArgs e)
        {

        }



        private void ShowProjects(List<Project> projects)
        {
            DisplayContainer.SuspendLayout();
            DisplayContainer.Controls.Clear();

           
           

            foreach (Project p in projects)
            {
                FreeLancerProjectCard card = new FreeLancerProjectCard();

                card.PopulateData(
                    p.ProjectTitle,
                    p.Description,
                    p.BaselineBudget.ToString("N0"),
                    p.EndDate.ToString("d/M/yyyy")
                );


                card.Width = DisplayContainer.Width - 32;
                

                DisplayContainer.Controls.Add(card);
            }
            DisplayContainer.ResumeLayout();
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel2_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
