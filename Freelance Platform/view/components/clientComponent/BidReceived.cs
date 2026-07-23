using Freelance_Platform.DTO;
using Freelance_Platform.model;
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

namespace Freelance_Platform.view.components.clientComponent
{
    public partial class BidReceived : UserControl
    {
        private readonly  List<BidProjectModelDTO> bidProjects;
        private readonly BidService bidService;
        private readonly ClientService clientService;
        public BidReceived()
        {
            InitializeComponent();
            bidService = new BidService();
            clientService = new ClientService();
            bidProjects = bidService.GetBidProjects();
            BiddingFreelancersView.Visible = false;



            BiddingFreelancerView.RowTemplate.Height = 60;
        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void BidReceived_Load(object sender, EventArgs e)
        {
            MessageBox.Show("Total Projects Found: " + bidProjects.Count.ToString());
            //when there is no bidding projects
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
                BiddingFreelancersView.Visible = false;

                return;
            }
            //**************************************//

            leftPanel.Controls.Clear();
            foreach (var p in bidProjects)
            {
                BidProjectsCard card = new BidProjectsCard(p);
                card.CardClick += (s, args) =>
                {

                    List<FreelancerBidDTO> bidList = bidService.GetFreelancerBids(p.ProjectId);

                    



                    BiddingFreelancersView.Visible = true;
                    BiddingFreelancerView.AutoGenerateColumns = false;
                    BiddingFreelancerView.DataSource = bidList;
                    // Load ဖြစ်တဲ့နေရာ (သို့) Data ချိတ်ပြီးတဲ့နေရာမှာ ဒီ Code ကို ထည့်ပါ
                    if (BiddingFreelancerView.Columns["ProfilePic"] != null)
                    {
                        // 0 ဆိုရင် အရှေ့ဆုံး၊ 1 ဆိုရင် Freelancer Name ရဲ့ နောက်မှာပေါ့
                        BiddingFreelancerView.Columns["ProfilePic"].DisplayIndex = 0;
                    }

                    if (BiddingFreelancerView.Columns["OwnerName"] != null)
                    {
                        BiddingFreelancerView.Columns["OwnerName"].DisplayIndex = 1;
                    }

                    if (BiddingFreelancerView.Columns["BidId"] != null)
                        BiddingFreelancerView.Columns["BidId"].Visible = false;

                    if (BiddingFreelancerView.Columns["ProjectId"] != null)
                        BiddingFreelancerView.Columns["ProjectId"].Visible = false;

                    if (BiddingFreelancerView.Columns["accept"] != null)
                    {
                        BiddingFreelancerView.Columns["accept"].DisplayIndex = BiddingFreelancerView.ColumnCount - 1;
                    }
                    if (BiddingFreelancerView.Columns["reject"] != null)
                    {
                        BiddingFreelancerView.Columns["reject"].DisplayIndex = BiddingFreelancerView.ColumnCount - 2;
                    }
                    if (BiddingFreelancerView.Columns["Status"] != null)
                    {
                        BiddingFreelancerView.Columns["Status"].DisplayIndex = BiddingFreelancerView.ColumnCount - 3;
                    }
                    lblTitle.Text = $"\"{p.Title}\"";
                    lblBudget.Text = p.Budget.ToString();
                };
                card.Width = leftPanel.Width - 30;
                leftPanel.Controls.Add(card);
            }
        }


        private void RefreshProjectCards()
        {
            leftPanel.Controls.Clear();
            var updatedProjects = bidService.GetBidProjects();
            foreach (var p in updatedProjects)
            {
                BidProjectsCard card = new BidProjectsCard(p);
                card.CardClick += (s, args) =>
                {

                    List<FreelancerBidDTO> bidList = bidService.GetFreelancerBids(p.ProjectId);





                    BiddingFreelancersView.Visible = true;
                    BiddingFreelancerView.AutoGenerateColumns = false;
                    BiddingFreelancerView.DataSource = bidList;
                    // Load ဖြစ်တဲ့နေရာ (သို့) Data ချိတ်ပြီးတဲ့နေရာမှာ ဒီ Code ကို ထည့်ပါ
                    if (BiddingFreelancerView.Columns["ProfilePic"] != null)
                    {
                        // 0 ဆိုရင် အရှေ့ဆုံး၊ 1 ဆိုရင် Freelancer Name ရဲ့ နောက်မှာပေါ့
                        BiddingFreelancerView.Columns["ProfilePic"].DisplayIndex = 0;
                    }

                    if (BiddingFreelancerView.Columns["OwnerName"] != null)
                    {
                        BiddingFreelancerView.Columns["OwnerName"].DisplayIndex = 1;
                    }

                    if (BiddingFreelancerView.Columns["BidId"] != null)
                        BiddingFreelancerView.Columns["BidId"].Visible = false;

                    if (BiddingFreelancerView.Columns["ProjectId"] != null)
                        BiddingFreelancerView.Columns["ProjectId"].Visible = false;

                    if (BiddingFreelancerView.Columns["accept"] != null)
                    {
                        BiddingFreelancerView.Columns["accept"].DisplayIndex = BiddingFreelancerView.ColumnCount - 1;
                    }
                    if (BiddingFreelancerView.Columns["reject"] != null)
                    {
                        BiddingFreelancerView.Columns["reject"].DisplayIndex = BiddingFreelancerView.ColumnCount - 2;
                    }
                    if (BiddingFreelancerView.Columns["Status"] != null)
                    {
                        BiddingFreelancerView.Columns["Status"].DisplayIndex = BiddingFreelancerView.ColumnCount - 3;
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

       


        private void BiddingFreelancerView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            if (e.RowIndex < 0) return;

            // Status ကို အရင်စစ်ပါ (ပြီးသားဆိုရင် ထပ်နှိပ်လို့မရအောင်)
            var selectedBid = (FreelancerBidDTO)BiddingFreelancerView.Rows[e.RowIndex].DataBoundItem;
            if (selectedBid.Status != "Pending") return;

            var columnName = BiddingFreelancerView.Columns[e.ColumnIndex].Name;

            if (columnName == "accept")
            {
                if (clientService.AcceptFreelancers(selectedBid.BidId, selectedBid.ProjectId))
                {
                    MessageBox.Show(selectedBid.OwnerName + " has been accepted.");

                    
                    BiddingFreelancerView.DataSource = bidService.GetFreelancerBids(selectedBid.ProjectId);
                    RefreshProjectCards();
                }
            }
            else if (columnName == "reject")
            {
                if (clientService.RejectFreelancer(selectedBid.BidId))
                {
                    MessageBox.Show(selectedBid.OwnerName + " has been rejected.");
                    BiddingFreelancerView.DataSource = bidService.GetFreelancerBids(selectedBid.ProjectId);
                    RefreshProjectCards();
                }
            }
        }

        private void BiddingFreelancerView_CellPainting(object sender, DataGridViewCellPaintingEventArgs e)
        {
            if (e.RowIndex < 0) return;

            // ၁။ Button Column များအတွက် Painting
            if (e.ColumnIndex == BiddingFreelancerView.Columns["reject"].Index ||
                e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index)
            {
                e.Paint(e.CellBounds, DataGridViewPaintParts.All);
                var rowData = (FreelancerBidDTO)BiddingFreelancerView.Rows[e.RowIndex].DataBoundItem;
                var rect = e.CellBounds;
                rect.Inflate(-4, -4);

                Color btnColor;
                string btnText = (e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index) ? "Accept" : "Reject";

                if (rowData.Status == "Accepted")
                    btnColor = (e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index) ? Color.LightGray : Color.WhiteSmoke;
                else if (rowData.Status == "Rejected")
                    btnColor = (e.ColumnIndex == BiddingFreelancerView.Columns["reject"].Index) ? Color.LightGray : Color.WhiteSmoke;
                else
                    btnColor = (e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index) ? Color.LightGreen : Color.LightSalmon;

                using (Brush brush = new SolidBrush(btnColor))
                {
                    e.Graphics.FillRectangle(brush, rect);
                    e.Graphics.DrawRectangle(Pens.Gray, rect);
                    TextRenderer.DrawText(e.Graphics, rowData.Status == "Accepted" && e.ColumnIndex == BiddingFreelancerView.Columns["accept"].Index ? "Accepted" :
                                                     rowData.Status == "Rejected" && e.ColumnIndex == BiddingFreelancerView.Columns["reject"].Index ? "Rejected" : btnText,
                                                     e.CellStyle.Font, rect, Color.Black, TextFormatFlags.HorizontalCenter | TextFormatFlags.VerticalCenter);
                }
                e.Handled = true;
            }

            if (BiddingFreelancerView.Columns[e.ColumnIndex].Name == "ProfilePic")
            {
                e.PaintBackground(e.CellBounds, true);

                Image img = e.Value as Image;

                if (img != null)
                {
                    int size = 40;

                    Rectangle rect = new Rectangle(
                        e.CellBounds.X + (e.CellBounds.Width - size) / 2,
                        e.CellBounds.Y + (e.CellBounds.Height - size) / 2,
                        size,
                        size);

                    e.Graphics.SmoothingMode =
                        System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

                    using (var gp = new System.Drawing.Drawing2D.GraphicsPath())
                    {
                        gp.AddEllipse(rect);

                        e.Graphics.SetClip(gp);

                        e.Graphics.DrawImage(
                            img,
                            rect,
                            new Rectangle(0, 0, img.Width, img.Height),
                            GraphicsUnit.Pixel);

                        e.Graphics.ResetClip();
                    }
                }

                e.Handled = true;
            }
        }

       
    }
}
