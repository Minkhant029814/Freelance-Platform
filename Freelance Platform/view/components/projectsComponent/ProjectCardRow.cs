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

        
        public void PopulateData(string title, string desc, string budget, string dueDate, string status)
        {
            lblProjectTitle.Text= title;
          
            lblProjectDesc.Text = desc;
            lblProjectBudget.Text = $"${budget}";
          
         
            lblProjectDate.Text = $"Due{dueDate}";

           
            lblProjectStatus.Text = status;
            if (status == "PLANNING")
            {

                lblProjectStatus.ForeColor = Color.Orange;   

               
            }
            else if(status == "IN_PROGRESS")
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
