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
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.FreelancerComponent
{
    public partial class BidProjectForm : Form
    {
        public Bidding BidData { get; private set; }

        public readonly BidService bidService;
        public bool IsSubmitted { get; private set; } = false;
        private readonly decimal Budget;
        private readonly int ProjectId;
        public BidProjectForm(Project p)
        {
            InitializeComponent();

            bidService = new BidService();
            this.ProjectId = p.ProjectId;
            this.Budget = p.BaselineBudget;
            lblBudget.Text = $"${Budget}";
            lblTitle.Text += $" {p.ProjectTitle}";
            numDown.Maximum = p.BaselineBudget;
            numDown.Value = p.BaselineBudget;
        }

        private void txtBidAmount_TextChanged(object sender, EventArgs e)
        {

        }

        private void BidProjectForm_Load(object sender, EventArgs e)
        {
            btnSubmit.Image = IconChar.ArrowsAlt.ToBitmap(Color.White, 30);
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(rtxtMessage.Text))
            {
                MessageBox.Show("Plese enter the message for this biddings");
                return;
            }
            
            
            
                BidData = new Bidding
                {
                    ProjectId =this.ProjectId, 
                    FreelancerId = Convert.ToInt32(UserSession.FreelancerId),
                    BidAmount = Convert.ToDecimal(numDown.Value),
                    Message = rtxtMessage.Text, 
                    Status = "Pending",         
                    SubmissionDate = DateTime.Now
                };
            if ( BidData != null & bidService.BidSubmit(BidData))
            {
               
                IsSubmitted = true;
                this.Close();
            }
            else
            {
                MessageBox.Show("Failed to submit Proposal");
            }
           
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
