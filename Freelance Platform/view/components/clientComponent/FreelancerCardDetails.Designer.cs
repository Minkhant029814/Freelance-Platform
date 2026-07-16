namespace Freelance_Platform.view.components.clientComponent
{
    partial class FreelancerCardDetails
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
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.bodyContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2Panel3 = new Guna.UI2.WinForms.Guna2Panel();
            this.PastWorkDisplay = new System.Windows.Forms.FlowLayoutPanel();
            this.label3 = new System.Windows.Forms.Label();
            this.guna2Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.SkillsPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.label2 = new System.Windows.Forms.Label();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.lblBio = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblReviewCount = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.guna2RatingStar1 = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblHourlyRate = new System.Windows.Forms.Label();
            this.lblProfessionalTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.ProfilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.btnClose = new FontAwesome.Sharp.IconButton();
            this.mainContainer.SuspendLayout();
            this.bodyContainer.SuspendLayout();
            this.guna2Panel3.SuspendLayout();
            this.guna2Panel2.SuspendLayout();
            this.guna2Panel1.SuspendLayout();
            this.headContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BackColor = System.Drawing.Color.White;
            this.mainContainer.Controls.Add(this.bodyContainer);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.Location = new System.Drawing.Point(9, 15);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(996, 633);
            this.mainContainer.TabIndex = 0;
            // 
            // bodyContainer
            // 
            this.bodyContainer.AutoScroll = true;
            this.bodyContainer.BackColor = System.Drawing.Color.Cyan;
            this.bodyContainer.Controls.Add(this.guna2Panel3);
            this.bodyContainer.Controls.Add(this.guna2Panel2);
            this.bodyContainer.Controls.Add(this.guna2Panel1);
            this.bodyContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyContainer.Location = new System.Drawing.Point(0, 193);
            this.bodyContainer.Name = "bodyContainer";
            this.bodyContainer.Size = new System.Drawing.Size(996, 440);
            this.bodyContainer.TabIndex = 1;
            this.bodyContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyContainer_Paint);
            // 
            // guna2Panel3
            // 
            this.guna2Panel3.Controls.Add(this.PastWorkDisplay);
            this.guna2Panel3.Controls.Add(this.label3);
            this.guna2Panel3.Location = new System.Drawing.Point(18, 629);
            this.guna2Panel3.Name = "guna2Panel3";
            this.guna2Panel3.Size = new System.Drawing.Size(452, 367);
            this.guna2Panel3.TabIndex = 2;
            // 
            // PastWorkDisplay
            // 
            this.PastWorkDisplay.AutoScroll = true;
            this.PastWorkDisplay.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PastWorkDisplay.Location = new System.Drawing.Point(15, 51);
            this.PastWorkDisplay.Name = "PastWorkDisplay";
            this.PastWorkDisplay.Size = new System.Drawing.Size(420, 299);
            this.PastWorkDisplay.TabIndex = 3;
            this.PastWorkDisplay.WrapContents = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(9, 17);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(116, 31);
            this.label3.TabIndex = 2;
            this.label3.Text = "PastWork";
            // 
            // guna2Panel2
            // 
            this.guna2Panel2.Controls.Add(this.SkillsPanel);
            this.guna2Panel2.Controls.Add(this.label2);
            this.guna2Panel2.Location = new System.Drawing.Point(18, 333);
            this.guna2Panel2.Name = "guna2Panel2";
            this.guna2Panel2.Size = new System.Drawing.Size(452, 269);
            this.guna2Panel2.TabIndex = 1;
            // 
            // SkillsPanel
            // 
            this.SkillsPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SkillsPanel.AutoScroll = true;
            this.SkillsPanel.Location = new System.Drawing.Point(20, 51);
            this.SkillsPanel.Name = "SkillsPanel";
            this.SkillsPanel.Size = new System.Drawing.Size(415, 201);
            this.SkillsPanel.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(9, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(71, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Skills";
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.lblBio);
            this.guna2Panel1.Controls.Add(this.label1);
            this.guna2Panel1.Location = new System.Drawing.Point(18, 37);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(452, 273);
            this.guna2Panel1.TabIndex = 0;
            // 
            // lblBio
            // 
            this.lblBio.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBio.BackColor = System.Drawing.Color.SpringGreen;
            this.lblBio.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBio.Location = new System.Drawing.Point(10, 78);
            this.lblBio.Name = "lblBio";
            this.lblBio.Size = new System.Drawing.Size(429, 181);
            this.lblBio.TabIndex = 1;
            this.lblBio.Text = "Bio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(9, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(81, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "About";
            // 
            // headContainer
            // 
            this.headContainer.Controls.Add(this.btnClose);
            this.headContainer.Controls.Add(this.lblReviewCount);
            this.headContainer.Controls.Add(this.lblRating);
            this.headContainer.Controls.Add(this.guna2RatingStar1);
            this.headContainer.Controls.Add(this.lblHourlyRate);
            this.headContainer.Controls.Add(this.lblProfessionalTitle);
            this.headContainer.Controls.Add(this.lblName);
            this.headContainer.Controls.Add(this.ProfilePic);
            this.headContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headContainer.Location = new System.Drawing.Point(0, 0);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(996, 193);
            this.headContainer.TabIndex = 0;
            // 
            // lblReviewCount
            // 
            this.lblReviewCount.AutoSize = true;
            this.lblReviewCount.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewCount.Location = new System.Drawing.Point(258, 140);
            this.lblReviewCount.Name = "lblReviewCount";
            this.lblReviewCount.Size = new System.Drawing.Size(119, 25);
            this.lblReviewCount.TabIndex = 6;
            this.lblReviewCount.Text = "Review Count";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(169, 140);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(63, 25);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
            // 
            // guna2RatingStar1
            // 
            this.guna2RatingStar1.Location = new System.Drawing.Point(33, 137);
            this.guna2RatingStar1.Name = "guna2RatingStar1";
            this.guna2RatingStar1.Size = new System.Drawing.Size(120, 28);
            this.guna2RatingStar1.TabIndex = 4;
            // 
            // lblHourlyRate
            // 
            this.lblHourlyRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblHourlyRate.AutoSize = true;
            this.lblHourlyRate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblHourlyRate.Location = new System.Drawing.Point(826, 73);
            this.lblHourlyRate.Name = "lblHourlyRate";
            this.lblHourlyRate.Size = new System.Drawing.Size(105, 25);
            this.lblHourlyRate.TabIndex = 3;
            this.lblHourlyRate.Text = "Hourly Rate";
            // 
            // lblProfessionalTitle
            // 
            this.lblProfessionalTitle.AutoSize = true;
            this.lblProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionalTitle.Location = new System.Drawing.Point(106, 73);
            this.lblProfessionalTitle.Name = "lblProfessionalTitle";
            this.lblProfessionalTitle.Size = new System.Drawing.Size(140, 25);
            this.lblProfessionalTitle.TabIndex = 2;
            this.lblProfessionalTitle.Text = "ProfessionalTitle";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(116, 35);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(68, 28);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // ProfilePic
            // 
            this.ProfilePic.FillColor = System.Drawing.Color.Lime;
            this.ProfilePic.ImageRotate = 0F;
            this.ProfilePic.Location = new System.Drawing.Point(18, 25);
            this.ProfilePic.Name = "ProfilePic";
            this.ProfilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.ProfilePic.Size = new System.Drawing.Size(82, 83);
            this.ProfilePic.TabIndex = 0;
            this.ProfilePic.TabStop = false;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.IconChar = FontAwesome.Sharp.IconChar.X;
            this.btnClose.IconColor = System.Drawing.Color.IndianRed;
            this.btnClose.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnClose.Location = new System.Drawing.Point(892, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(39, 38);
            this.btnClose.TabIndex = 7;
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // FreelancerCardDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "FreelancerCardDetails";
            this.Size = new System.Drawing.Size(1019, 667);
            this.mainContainer.ResumeLayout(false);
            this.bodyContainer.ResumeLayout(false);
            this.guna2Panel3.ResumeLayout(false);
            this.guna2Panel3.PerformLayout();
            this.guna2Panel2.ResumeLayout(false);
            this.guna2Panel2.PerformLayout();
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ProfilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private System.Windows.Forms.Label lblProfessionalTitle;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox ProfilePic;
        private Guna.UI2.WinForms.Guna2RatingStar guna2RatingStar1;
        private System.Windows.Forms.Label lblHourlyRate;
        private System.Windows.Forms.Label lblReviewCount;
        private System.Windows.Forms.Label lblRating;
        private Guna.UI2.WinForms.Guna2Panel bodyContainer;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.FlowLayoutPanel SkillsPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBio;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel3;
        private System.Windows.Forms.FlowLayoutPanel PastWorkDisplay;
        private System.Windows.Forms.Label label3;
        private FontAwesome.Sharp.IconButton btnClose;
    }
}
