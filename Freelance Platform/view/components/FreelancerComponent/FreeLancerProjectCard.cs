using FontAwesome.Sharp;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
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

        public event EventHandler OnBidChanged;

        public FreeLancerProjectCard()
        {
            InitializeComponent();
            pService = new ProjectService();
        }

        public void PopulateData(int pid,string title, string desc, string budget, string dueDate,string status)
        {
            lblProjectTitle.Text = title;
            this.projectId = pid;
            this.projectStatus = status;
            lblProjectDesc.Text = desc;
            lblProjectBudget.Text = $"${budget}";
            UpdateUIBasedOnStatus();
            OnBidChanged?.Invoke(this, EventArgs.Empty);





            lblProjectDate.Text = $"Due{dueDate}";

          



        }

        private void FreeLancerProjectCard_Load(object sender, EventArgs e)
        {
            this.Anchor = AnchorStyles.Left;
            this.Anchor = AnchorStyles.Right;

            // FreeLancerProjectCard.Designer.cs
            lblProjectDesc.AutoSize = false;
            lblProjectDesc.Width = 600;
            lblProjectDesc.Height = 50;

            this.Margin = new Padding(5);
            this.Name = "FreeLancerProjectCard";
            this.Size = new System.Drawing.Size(750, 173);

            this.btnBidProject.Anchor =
    ((System.Windows.Forms.AnchorStyles)
    ((System.Windows.Forms.AnchorStyles.Top |
      System.Windows.Forms.AnchorStyles.Right)));
        }

        private void btnBidProject_Click(object sender, EventArgs e)
        {
            projectStatus = (projectStatus == "PLANNING") ? "ON_HOLD" : "PLANNING";

            if (FreelancerBids())
            {
                
                UpdateUIBasedOnStatus();


                if (projectStatus == "ON_HOLD")
                {
                    MessageBox.Show("Bid submitted successfully!");
                }
                else
                {
                    MessageBox.Show("Bid cancelled successfully.");
                }
            }
            else
            {
                MessageBox.Show("Operation failed. Please try again.");
            }


        }

        private void UpdateUIBasedOnStatus()
        {
            
            

            if (projectStatus.Equals("ON_HOLD")) 
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



       

       
        private bool FreelancerBids()
        {
          return  pService.FreelancerBids(projectId);
        }

    }
}
