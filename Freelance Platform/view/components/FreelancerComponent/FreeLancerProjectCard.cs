using FontAwesome.Sharp;
using Freelance_Platform.model;
using Freelance_Platform.Service;
using Freelance_Platform.Session;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class FreeLancerProjectCard : UserControl
    {
        private  int projectId;
        private readonly ProjectService pService;
        private string projectStatus;
        private readonly decimal Budget;
        private readonly BidService bidService;

      

        public event EventHandler OnBidChanged;

        public FreeLancerProjectCard(Project p)
        {
            InitializeComponent();
            pService = new ProjectService();
            bidService = new BidService();
            Budget = p.BaselineBudget;
            LoadData(p);

         
        }

        

        private void LoadData(Project p)
        {
            this.projectId = p.ProjectId;
            this.projectStatus = p.CurrentStatus;
            lblProjectTitle.Text = p.ProjectTitle;
            lblProjectDesc.Text = p.Description;
            lblProjectBudget.Text = $"${p.BaselineBudget}";
            lblProjectDate.Text = $" Due {p.EndDate.ToString("d/M/yyyy")}";
            UpdateUIBasedOnStatus();
            OnBidChanged?.Invoke(this, EventArgs.Empty);

        }

    //  
        private void btnBidProject_Click(object sender, EventArgs e)
        {

            bool alreadyBidded = bidService.HasUserBidded(projectId, Convert.ToInt32(UserSession.FreelancerId));

            if (!alreadyBidded)
            {
                
                BidProjectForm bidForm = new BidProjectForm(Budget, projectId);
                bidForm.ShowDialog();

                if (bidForm.IsSubmitted)
                {
                    UpdateUIBasedOnStatus(); 
                    MessageBox.Show("Bid submitted successfully!");
                }
            }
            else
            {
                
                var confirm = MessageBox.Show("Do you want to cancel your bid?", "Confirm", MessageBoxButtons.YesNo);

                if (confirm == DialogResult.Yes)
                {
                    bidService.CancelSubmit(projectId, Convert.ToInt32(UserSession.FreelancerId));
                    UpdateUIBasedOnStatus(); 
                    MessageBox.Show("Bid cancelled.");
                }
            }
        }

        private void UpdateUIBasedOnStatus()
        {
            bool alreadyBidded = bidService.HasUserBidded(projectId, Convert.ToInt32(UserSession.FreelancerId));

            
           
            if (alreadyBidded)
            {
                btnBidProject.Text = "Bid Submitted";
                btnBidProject.Width = 130;
                btnBidProject.FillColor = Color.FromArgb(88, 227, 109);
                btnBidProject.Tag = "Submitted";
                btnBidProject.Image = IconChar.Check.ToBitmap(Color.Green, 20);
            }
            else
            {
                btnBidProject.Text = "Bid/ View";
                btnBidProject.Width = 118;
                btnBidProject.ForeColor = Color.White;
                btnBidProject.FillColor = Color.FromArgb(11, 115, 168);
                btnBidProject.Tag = "Bid";
                btnBidProject.Image = null;
            }
        }






       

    }
}
