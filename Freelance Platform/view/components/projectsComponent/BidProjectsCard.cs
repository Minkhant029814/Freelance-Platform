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

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class BidProjectsCard : UserControl
    {
        private readonly BidProjectModelDTO project;

        public event EventHandler CardClick;

        public BidProjectsCard(BidProjectModelDTO p)
        {
            InitializeComponent();
           
            project = p;
            DisplayData(p);

            
            SetupHoverEffects(this);
        }

       
        private void SetupHoverEffects(Control parentControl)
        {
            parentControl.Cursor = Cursors.Hand;
            parentControl.Click += BidProjectsCard_Click;
            
            foreach (Control child in parentControl.Controls)
            {
                SetupHoverEffects(child); 
            }
        }

        

        private void DisplayData(BidProjectModelDTO project)
        {
            lblProjectTitle.Text = project.Title.ToString();
            lblBudget.Text = project.Budget.ToString();
            lblOldBid.Text = project.TotalBids.ToString() + " Bids";
            lblNewBid.Text = project.NewBids.ToString() + " new";
        }

        private void mainPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void BidProjectsCard_Click(object sender, EventArgs e)
        {
            CardClick?.Invoke(this, EventArgs.Empty);
        }
    }
}