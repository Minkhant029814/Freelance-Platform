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
    public partial class FreelancerCardDetails : UserControl
    {
        private readonly int freelancerId;
        public event Action closedClick;
        public FreelancerCardDetails(int id)
        {
            InitializeComponent();
            this.freelancerId = id;
        }

        private void bodyContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            closedClick?.Invoke();
        }
    }
}
