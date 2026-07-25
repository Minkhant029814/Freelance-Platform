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
    public partial class mileStoneAddComponent : UserControl
    {

     
       

        public event EventHandler MileStoneDeleted;
        public event EventHandler WeightChange;

        public mileStoneAddComponent()
        {
            InitializeComponent();
            
          
            
          
        }


        public string MilestoneTitle
        {
            get { return txtMileStoneTitle.Text; }
        }

        public string MilestoneDescription
        {
            get { return rtxtDescription.Text; }
        }

        public int MilestoneWeight
        {
            get { return Convert.ToInt32(numericMileStoneWeight.Value); }
        }

        private void mainContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnDeleteMileStone_Click(object sender, EventArgs e)
        {
            MileStoneDeleted?.Invoke(this, EventArgs.Empty);
           
        }

        private void mileStoneAddComponent_Load(object sender, EventArgs e)
        {

        }

        private void numericMileStoneWeight_ValueChanged(object sender, EventArgs e)
        {
            WeightChange?.Invoke(this,EventArgs.Empty);
        }
    }
}
