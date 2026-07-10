using Freelance_Platform.model;
using Freelance_Platform.Service;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class BidReceived : UserControl
    {
        private List<BidProjectModel> bidProjects;
        private readonly BidService bidService;
        public BidReceived()
        {
            InitializeComponent();
            bidService = new BidService();
            bidProjects = bidService.GetBidProjects();
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BidReceived_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Total Projects Found: " + bidProjects.Count.ToString());
            if (bidProjects.Count == 0)
            {
                
                Panel containerPanel = new Panel();
                containerPanel.Size = new Size(leftPanel.Width - 20, leftPanel.Height);

                
                Label lblMessage = new Label();
                lblMessage.Text = "No bids Projects here...";
                lblMessage.ForeColor = Color.Green;
                lblMessage.Font = new Font("Segoe UI", 14, FontStyle.Bold);
                lblMessage.AutoSize = true;

                
                lblMessage.Location = new Point(
                    (containerPanel.Width - lblMessage.Width) / 2,
                    (containerPanel.Height - lblMessage.Height) / 2
                );

              
                containerPanel.Controls.Add(lblMessage);
                leftPanel.Controls.Add(containerPanel);

                return;
            }
            leftPanel.Controls.Clear();
            foreach (var p in bidProjects)
            {
                BidProjectsCard card = new BidProjectsCard(p);
                card.CardClick += (s, args) =>
                {
                    // ဒီနေရာမှာ Click လုပ်လိုက်တဲ့ Project ရဲ့ ID ကို သုံးပြီး ညာဘက် Panel ကို load ပါ
                    //LoadFreelancersForProject(p.ProjectId);
                    lblTitle.Text = $"\"{p.Title}\"";
                    lblBudget.Text = p.Budget.ToString();
                };
                card.Width = leftPanel.Width - 30;
                leftPanel.Controls.Add(card);
            }
        }

        private void leftPanel_Resize(object sender, EventArgs e)
        {
            foreach (Control c in leftPanel.Controls)
            {
                c.Width = leftPanel.Width - 30;
            }
        }

        private void leftPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
