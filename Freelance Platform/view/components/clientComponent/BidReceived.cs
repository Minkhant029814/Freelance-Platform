using Freelance_Platform.DTO;
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
        private readonly ClientService clientService;
        public BidReceived()
        {
            InitializeComponent();
            bidService = new BidService();
            clientService = new ClientService();
            bidProjects = bidService.GetBidProjects();



            BiddingFreelancerView.RowTemplate.Height = 60;
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

                    List<FreelancerBidDTO> bidList = bidService.GetFreelancerBids(p.ProjectId);

                    BiddingFreelancerView.DataSource = bidList;
                    BiddingFreelancerView.AutoGenerateColumns = false;
                    if (BiddingFreelancerView.Columns["accept"] != null)
                    {
                        BiddingFreelancerView.Columns["accept"].DisplayIndex = BiddingFreelancerView.ColumnCount - 1;
                    }
                    if (BiddingFreelancerView.Columns["reject"] != null)
                    {
                        BiddingFreelancerView.Columns["reject"].DisplayIndex = BiddingFreelancerView.ColumnCount - 2;
                    }
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



        private void BiddingFreelancerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
           
            if (e.RowIndex < 0) return;

            var columnName = BiddingFreelancerView.Columns[e.ColumnIndex].Name;

            
            var selectedBid = (FreelancerBidDTO)BiddingFreelancerView.Rows[e.RowIndex].DataBoundItem;

            if (columnName == "accept")
            {
                //Accept Logic
                if (clientService.AcceptFreelancers(bidId,projectId))
                {
                MessageBox.Show(selectedBid.OwnerName + " has been accepted..");

                }
            }
            else if (columnName == "reject")
            {
                // Reject Logic
                MessageBox.Show(selectedBid.OwnerName + " has been rejected..");
            }
        }

        private void BiddingFreelancerView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            
            if ((e.ColumnIndex == BiddingFreelancerView.Columns["reject"].Index ||
                 e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index) && e.RowIndex >= 0)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);

                var rect = e.CellBounds;
                rect.Inflate(-4, -4); 


                Color btnColor = (e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index) ? Color.LightGreen : Color.LightSalmon;

                using (Brush brush = new SolidBrush(btnColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                    e.Graphics.DrawRectangle(Pens.Gray, rect);

                    
                    TextRenderer.DrawText(e.Graphics, e.FormattedValue.ToString(), e.CellStyle.Font, rect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                e.Handled = true;
            }
        }
    }
}
