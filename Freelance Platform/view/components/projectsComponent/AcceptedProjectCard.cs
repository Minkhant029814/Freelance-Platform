using Freelance_Platform.DTO;
using Freelance_Platform.view.components.FreelancerComponent;
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
    public partial class AcceptedProjectCard : UserControl
    {
        private readonly AcceptedProjectDTO project;
       
        public AcceptedProjectCard(AcceptedProjectDTO p)
        {
            InitializeComponent();
            this.project = p;
            
            LoadData(project);
        }


        private void LoadData(AcceptedProjectDTO p)
        {
            btnStatus.Text = p.BiddingStatus;
            lblAcceptDate.Text = p.BiddingDate.ToString();
            lblClientName.Text = p.ClientName;
            lblProjectTitle.Text = p.ProjectTitle;
            
        }

        private void btnStatus_Click(object sender, EventArgs e)
        {

        }

        
        private void headContainer_Paint(object sender, PaintEventArgs e)
        {

        }

        private void btnSetMileStone_Click_1(object sender, EventArgs e)
        {
            Form setMileStone = new SettingMileStone(project.ProjectId);
            setMileStone.ShowDialog();

        }
    }
}
