using Freelance_Platform.DTO;
using Freelance_Platform.Service;
using Freelance_Platform.view.components.projectsComponent;
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
    public partial class CompletedProjectComponent : UserControl
    {
        private readonly List<CompletedProjectReviewDTO> projects;
        private readonly FreelancerService fservice;
        public CompletedProjectComponent()
        {
            fservice = new FreelancerService();
            projects = fservice.ViewCompletedProject();
            InitializeComponent();
            LoadData(projects);
        }
        private void LoadData(List<CompletedProjectReviewDTO> ps)
        {
            CompletedProjectLayout.Controls.Clear();
            if(ps.Count == 0)
            {
                Label lblMessage = new Label();
                lblMessage.Text = "No Completed projects here";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblMessage.AutoSize = true;


                lblMessage.Location = new Point(
                    (CompletedProjectLayout.Width - lblMessage.Width) / 2,
                    (CompletedProjectLayout.Height - lblMessage.Height) / 2
                );


                CompletedProjectLayout.Controls.Add(lblMessage);
            }
            foreach (CompletedProjectReviewDTO p in ps)
            {
               
                CompletedCardByFreelancer card = new CompletedCardByFreelancer(p);
                
                card.Width = CompletedProjectLayout.ClientSize.Width - 25;
                CompletedProjectLayout.Controls.Add(card);
            }
        }

        private void CompletedProjectLayout_Resize(object sender, EventArgs e)
        {
            foreach(Control c in CompletedProjectLayout.Controls)
            {
                c.Width = CompletedProjectLayout.ClientSize.Width - 25;
            }
        }
    }
}
