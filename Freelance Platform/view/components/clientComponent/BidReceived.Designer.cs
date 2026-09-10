namespace Freelance_Platform.view.components.clientComponent
{
    partial class BidReceived
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.leftPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.topPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.BiddingFreelancersView = new Guna.UI2.WinForms.Guna2Panel();
            this.BiddingFreelancerView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.freelancerName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.reject = new System.Windows.Forms.DataGridViewButtonColumn();
            this.accept = new System.Windows.Forms.DataGridViewButtonColumn();
            this.title = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ProfilePic = new System.Windows.Forms.DataGridViewImageColumn();
            this.amount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Status = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.message = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.pnlTitle = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblTitle = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.topPanel.SuspendLayout();
            this.BiddingFreelancersView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.BiddingFreelancerView)).BeginInit();
            this.pnlTitle.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.AutoScroll = true;
            this.mainPanel.Controls.Add(this.leftPanel);
            this.mainPanel.Controls.Add(this.topPanel);
            this.mainPanel.Controls.Add(this.BiddingFreelancersView);
            this.mainPanel.Location = new System.Drawing.Point(57, 60);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(1041, 428);
            this.mainPanel.TabIndex = 0;
            // 
            // leftPanel
            // 
            this.leftPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.leftPanel.AutoScroll = true;
            this.leftPanel.BackColor = System.Drawing.Color.White;
            this.leftPanel.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.leftPanel.Location = new System.Drawing.Point(6, 88);
            this.leftPanel.Name = "leftPanel";
            this.leftPanel.Size = new System.Drawing.Size(867, 224);
            this.leftPanel.TabIndex = 2;
            this.leftPanel.WrapContents = false;
            this.leftPanel.Resize += new System.EventHandler(this.leftPanel_Resize);
            // 
            // topPanel
            // 
            this.topPanel.Controls.Add(this.label1);
            this.topPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.topPanel.Location = new System.Drawing.Point(0, 0);
            this.topPanel.Name = "topPanel";
            this.topPanel.Size = new System.Drawing.Size(1020, 82);
            this.topPanel.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(311, 11);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 41);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your Posted Projects";
            // 
            // BiddingFreelancersView
            // 
            this.BiddingFreelancersView.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.BiddingFreelancersView.BackColor = System.Drawing.Color.Lime;
            this.BiddingFreelancersView.Controls.Add(this.BiddingFreelancerView);
            this.BiddingFreelancersView.Controls.Add(this.pnlTitle);
            this.BiddingFreelancersView.Location = new System.Drawing.Point(6, 318);
            this.BiddingFreelancersView.Name = "BiddingFreelancersView";
            this.BiddingFreelancersView.Size = new System.Drawing.Size(813, 287);
            this.BiddingFreelancersView.TabIndex = 3;
            // 
            // BiddingFreelancerView
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.BiddingFreelancerView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.BiddingFreelancerView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.BiddingFreelancerView.ColumnHeadersHeight = 40;
            this.BiddingFreelancerView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.BiddingFreelancerView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.freelancerName,
            this.reject,
            this.accept,
            this.title,
            this.ProfilePic,
            this.amount,
            this.Status,
            this.message});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.BiddingFreelancerView.DefaultCellStyle = dataGridViewCellStyle3;
            this.BiddingFreelancerView.Dock = System.Windows.Forms.DockStyle.Fill;
            this.BiddingFreelancerView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.BiddingFreelancerView.Location = new System.Drawing.Point(0, 100);
            this.BiddingFreelancerView.Name = "BiddingFreelancerView";
            this.BiddingFreelancerView.ReadOnly = true;
            this.BiddingFreelancerView.RowHeadersVisible = false;
            this.BiddingFreelancerView.RowHeadersWidth = 60;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiddingFreelancerView.RowsDefaultCellStyle = dataGridViewCellStyle4;
            this.BiddingFreelancerView.RowTemplate.Height = 24;
            this.BiddingFreelancerView.Size = new System.Drawing.Size(813, 187);
            this.BiddingFreelancerView.TabIndex = 1;
            this.BiddingFreelancerView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.BiddingFreelancerView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiddingFreelancerView.ThemeStyle.HeaderStyle.Height = 40;
            this.BiddingFreelancerView.ThemeStyle.ReadOnly = true;
            this.BiddingFreelancerView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BiddingFreelancerView.ThemeStyle.RowsStyle.Height = 24;
            this.BiddingFreelancerView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.BiddingFreelancerView_CellContentClick);
            this.BiddingFreelancerView.CellPainting += new System.Windows.Forms.DataGridViewCellPaintingEventHandler(this.BiddingFreelancerView_CellPainting);
            // 
            // freelancerName
            // 
            this.freelancerName.DataPropertyName = "OwnerName";
            this.freelancerName.HeaderText = "Freelancer Name";
            this.freelancerName.MinimumWidth = 6;
            this.freelancerName.Name = "freelancerName";
            this.freelancerName.ReadOnly = true;
            // 
            // reject
            // 
            this.reject.HeaderText = "Reject";
            this.reject.MinimumWidth = 6;
            this.reject.Name = "reject";
            this.reject.ReadOnly = true;
            this.reject.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.reject.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.reject.Text = "Reject";
            this.reject.UseColumnTextForButtonValue = true;
            // 
            // accept
            // 
            this.accept.HeaderText = "Accept";
            this.accept.MinimumWidth = 6;
            this.accept.Name = "accept";
            this.accept.ReadOnly = true;
            this.accept.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.accept.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.accept.Text = "Accept";
            this.accept.UseColumnTextForButtonValue = true;
            // 
            // title
            // 
            this.title.DataPropertyName = "ProfessionalTitle";
            this.title.HeaderText = "Professional Title";
            this.title.MinimumWidth = 6;
            this.title.Name = "title";
            this.title.ReadOnly = true;
            // 
            // ProfilePic
            // 
            this.ProfilePic.DataPropertyName = "ProfileImage";
            this.ProfilePic.HeaderText = "Profile";
            this.ProfilePic.MinimumWidth = 6;
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.ReadOnly = true;
            this.ProfilePic.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.ProfilePic.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // amount
            // 
            this.amount.DataPropertyName = "BidAmount";
            this.amount.HeaderText = "Bid Amount";
            this.amount.MinimumWidth = 6;
            this.amount.Name = "amount";
            this.amount.ReadOnly = true;
            // 
            // Status
            // 
            this.Status.DataPropertyName = "Status";
            this.Status.HeaderText = "Status";
            this.Status.MinimumWidth = 6;
            this.Status.Name = "Status";
            this.Status.ReadOnly = true;
            // 
            // message
            // 
            this.message.DataPropertyName = "message";
            this.message.HeaderText = "Proposed Note";
            this.message.MinimumWidth = 6;
            this.message.Name = "message";
            this.message.ReadOnly = true;
            // 
            // pnlTitle
            // 
            this.pnlTitle.BackColor = System.Drawing.Color.Cyan;
            this.pnlTitle.Controls.Add(this.lblBudget);
            this.pnlTitle.Controls.Add(this.lblTitle);
            this.pnlTitle.Controls.Add(this.label2);
            this.pnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTitle.Location = new System.Drawing.Point(0, 0);
            this.pnlTitle.Name = "pnlTitle";
            this.pnlTitle.Size = new System.Drawing.Size(813, 100);
            this.pnlTitle.TabIndex = 0;
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(23, 60);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(65, 23);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "budget";
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTitle.Location = new System.Drawing.Point(139, 15);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(144, 28);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Dynamic Title";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(19, 15);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 28);
            this.label2.TabIndex = 0;
            this.label2.Text = "Bid For";
            // 
            // BidReceived
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.mainPanel);
            this.Name = "BidReceived";
            this.Size = new System.Drawing.Size(1165, 577);
            this.Load += new System.EventHandler(this.BidReceived_Load);
            this.mainPanel.ResumeLayout(false);
            this.topPanel.ResumeLayout(false);
            this.topPanel.PerformLayout();
            this.BiddingFreelancersView.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.BiddingFreelancerView)).EndInit();
            this.pnlTitle.ResumeLayout(false);
            this.pnlTitle.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2Panel topPanel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel leftPanel;
        private Guna.UI2.WinForms.Guna2Panel BiddingFreelancersView;
        private Guna.UI2.WinForms.Guna2DataGridView BiddingFreelancerView;
        private Guna.UI2.WinForms.Guna2Panel pnlTitle;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn freelancerName;
        private System.Windows.Forms.DataGridViewButtonColumn reject;
        private System.Windows.Forms.DataGridViewButtonColumn accept;
        private System.Windows.Forms.DataGridViewTextBoxColumn title;
        private System.Windows.Forms.DataGridViewImageColumn ProfilePic;
        private System.Windows.Forms.DataGridViewTextBoxColumn amount;
        private System.Windows.Forms.DataGridViewTextBoxColumn Status;
        private System.Windows.Forms.DataGridViewTextBoxColumn message;
    }
}
