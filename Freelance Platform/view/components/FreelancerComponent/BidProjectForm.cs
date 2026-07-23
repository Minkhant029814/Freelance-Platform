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
        public BidProjectForm(decimal budget,int projectId)
        {
            InitializeComponent();

            bidService = new BidService();
            this.ProjectId = projectId;
            this.Budget = budget;
            lblBudget.Text = "$" + $"{budget}";
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
            
            if (string.IsNullOrWhiteSpace(txtBidAmount.Text) || string.IsNullOrWhiteSpace(rtxtMessage.Text))
            {
                MessageBox.Show("Please fill in all fields.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            
            if (!decimal.TryParse(txtBidAmount.Text, out decimal bidAmount))
            {
                MessageBox.Show("Please enter a valid numeric amount.", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
           
                BidData = new Bidding
                {
                    ProjectId =this.ProjectId, 
                    FreelancerId = Convert.ToInt32(UserSession.FreelancerId),
                    BidAmount = Convert.ToDecimal(txtBidAmount.Text),
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
    }
}
