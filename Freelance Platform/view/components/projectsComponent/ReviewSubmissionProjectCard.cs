using Freelance_Platform.DTO;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.projectsComponent
{
    public partial class ReviewSubmissionProjectCard : UserControl
    {
        private readonly int projectId;
        private readonly ClientService clientService;

        public event Action ProjectApproved;
        public ReviewSubmissionProjectCard(AssignedProjectDTO p)
        {
            InitializeComponent();
            this.projectId = p.Project.ProjectId;
            clientService = new ClientService();
            LoadData(p);
        }

        private void LoadData(AssignedProjectDTO p)
        {
            lblFreelancerName.Text = p.Freelancer.Portfolio.OwnerName;
            lblPayrate.Text = p.Freelancer.HourlyRate.ToString();
            lblProfessionalTitle.Text = p.Freelancer.Portfolio.ProfessionalTitle;
            lblProjectTitle.Text = p.Project.ProjectTitle;

            MessageBox.Show("Project Id is ..." + p.Project.ProjectId);


            //for profile image
            //for Profile picutre
            string imgPath = Path.Combine(Application.StartupPath, "Uploads", p.Freelancer.Portfolio.Profile ?? "");
            profilePic.Image = (File.Exists(imgPath)) ? Image.FromFile(imgPath) : Properties.Resources.register;

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            if (clientService.ApproveAndCompleteProject(projectId))
            {
                MessageBox.Show("You have approved this project");
                ProjectApproved?.Invoke();
            }else
            {
                MessageBox.Show("Some errors occurs in duing approval project...");
            }
        }
    }
}
