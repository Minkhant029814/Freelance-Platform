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

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class PlanningCard : UserControl
    {
        private readonly Project project;
        public PlanningCard(Project p)
        {
            InitializeComponent();
            this.project = p;
            LoadData(project);

        }

        private void LoadData(Project p)
        {
            lblStatus.Text = p.CurrentStatus;
            lblProjectTitle.Text = p.ProjectTitle;
            lblDescription.Text = p.Description;
            lblBudget.Text = $"$ {p.BaselineBudget}";
            lblDate.Text = $"Created at {p.StartDate:dd MMMM yyyy}";

            if(p.BidCount == 0)
            {
                lblcheck.Text = "Opens for Bids";
            }else
            {
                lblcheck.Text = $"{p.BidCount} proposals received..";
            }
        }
    }
}
