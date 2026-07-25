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
    public partial class RejectedProjectCard : UserControl
    {
        
        public RejectedProjectCard(ProjectStatusDTO p)
        {
            InitializeComponent();
            LoadData(p);
        }

        private void LoadData(ProjectStatusDTO p)
        {
            lblBudget.Text = $"$ {p.ProjectBudget}";
            lblProjectTitle.Text = p.ProjectTitle;
            lblClientName.Text = p.ClientName;
            btnStatus.Text = p.BiddingStatus;
            lblRejectedDate.Text = $"Declined {p.BiddingDate:dd MMMM yyyy}";
        }
    }
}
