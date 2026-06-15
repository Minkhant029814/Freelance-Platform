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
    public partial class FreeLancerProjectCard : UserControl
    {
        public FreeLancerProjectCard()
        {
            InitializeComponent();
        }

        public void PopulateData(string title, string desc, string budget, string dueDate)
        {
            lblProjectTitle.Text = title;

            lblProjectDesc.Text = desc;
            lblProjectBudget.Text = $"${budget}";


            lblProjectDate.Text = $"Due{dueDate}";


            
        }

        private void FreeLancerProjectCard_Load(object sender, EventArgs e)
        {

        }
    }
}
