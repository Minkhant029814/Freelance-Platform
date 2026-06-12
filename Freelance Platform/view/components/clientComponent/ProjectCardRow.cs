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
            if (status == "In Progress")
            {
                lblProjectStatus.BackColor = Color.FromArgb(219, 234, 254); 
                lblProjectStatus.ForeColor = Color.FromArgb(29, 78, 216);    

               
            }
            else // Open
            {
                lblProjectStatus.BackColor = Color.FromArgb(243, 244, 246); 
                lblProjectStatus.ForeColor = Color.FromArgb(55, 65, 81);     
            }
        }
        private void ProjectCardRow_Load(object sender, EventArgs e)
        {

        }
    }
}
