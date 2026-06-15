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
            this.Anchor = AnchorStyles.Left;
            this.Anchor = AnchorStyles.Right;

            // FreeLancerProjectCard.Designer.cs
            lblProjectDesc.AutoSize = false;
            lblProjectDesc.Width = 600;
            lblProjectDesc.Height = 50;

            this.Margin = new Padding(5);
            this.Name = "FreeLancerProjectCard";
            this.Size = new System.Drawing.Size(750, 173);

            this.btnBidProject.Anchor =
    ((System.Windows.Forms.AnchorStyles)
    ((System.Windows.Forms.AnchorStyles.Top |
      System.Windows.Forms.AnchorStyles.Right)));
        }
    }
}
