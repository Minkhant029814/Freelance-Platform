using Freelance_Platform.DTO;
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
    public partial class OngoingProjectCard : UserControl
    {
        public OngoingProjectCard(ProjectWithMilestonesDTO p)
        {
            InitializeComponent();
            LoadData(p);
        }

        private void LoadData(ProjectWithMilestonesDTO p)
        {
            lblClientName.Text = p.ClientName;
            lblProjectTitle.Text = p.ProjectTitle;
            btnEndate.Text = p.ProjectEndDate.ToString();

            foreach(Milestone m in p.Milestones)
            {
                MilestoneProgress mileStone = new MilestoneProgress(m);
                mileStone.Width = mileStoneLayout.ClientSize.Width - 25;
                mileStoneLayout.Controls.Add(mileStone);

            }
        }

        private void mileStoneLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in mileStoneLayout.Controls)
            {
                c.Width = mileStoneLayout.ClientSize.Width - 25;
            }
        }
    }
}
