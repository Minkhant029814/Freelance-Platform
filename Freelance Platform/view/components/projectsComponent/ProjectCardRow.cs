using Freelance_Platform.model;
using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.components
{
    public partial class ProjectCardRow : UserControl
    {
        public ProjectCardRow()
        {
            InitializeComponent();
        }

        
        public void PopulateData(Project p)
        {
            lblProjectTitle.Text = p.ProjectTitle;
          
            lblProjectDesc.Text = p.Description;
            lblProjectBudget.Text = $"${p.BaselineBudget}";
          
         
            lblProjectDate.Text = $"Due{p.EndDate:dd MMMM yyyy}";

           
            lblProjectStatus.Text = p.CurrentStatus;
            if (p.CurrentStatus == "PLANNING")
            {

                lblProjectStatus.ForeColor = Color.Orange;   

               
            }
            else if(p.CurrentStatus == "IN_PROGRESS")
            {
                lblProjectStatus.ForeColor = Color.Blue;
            }
            else
            {
                lblProjectStatus.ForeColor = Color.Green;
            }
        }
        private void ProjectCardRow_Load(object sender, EventArgs e)
        {
            // FreeLancerProjectCard.Designer.cs
            lblProjectDesc.AutoSize = false;
            lblProjectDesc.Width = 600;
            lblProjectDesc.Height = 50;

        }
    }
}
