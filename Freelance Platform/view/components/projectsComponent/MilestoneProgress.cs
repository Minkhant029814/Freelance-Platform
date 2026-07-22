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
    public partial class MilestoneProgress : UserControl
    {
        public MilestoneProgress(Milestone m)
        {
            InitializeComponent();
            LoadData(m);
        }

        private void guna2NumericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void LoadData(Milestone m)
        {
            lblMileStonetile.Text = m.Title;
            lblProgressValue.Text = $"{m.Progress} %";
        }
    }
}
