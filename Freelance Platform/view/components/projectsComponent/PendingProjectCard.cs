using Freelance_Platform.DTO;
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
    public partial class PendingProjectCard : UserControl
    {
        private readonly ProjectStatusDTO pendingProject;
        public PendingProjectCard(ProjectStatusDTO p)
        {
            InitializeComponent();
            this.pendingProject = p;
            LoadData(pendingProject);
        }

        private void LoadData(ProjectStatusDTO p)
        {
            lblBudget.Text = p.ProjectBudget.ToString();
            lblProjectTitle.Text = p.ProjectTitle;
            lblClientName.Text = p.ClientName;
            lblSubmittedDate.Text = $"Submitted {p.BiddingDate:dd MMMM yyyy}";
            btnStatus.Text = p.BiddingStatus;
        }
    }
}
