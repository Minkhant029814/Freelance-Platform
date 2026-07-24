namespace Freelance_Platform.view.components.clientComponent
{
    partial class FreelancerCards
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnViewProfile = new Guna.UI2.WinForms.Guna2Button();
            this.lblDescription = new System.Windows.Forms.Label();
            this.skillDisplayPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.lblReviewCount = new System.Windows.Forms.Label();
            this.lblRating = new System.Windows.Forms.Label();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblPayRate = new System.Windows.Forms.Label();
            this.lblProfessionalTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.guna2Panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.btnViewProfile);
            this.guna2Panel1.Controls.Add(this.lblDescription);
            this.guna2Panel1.Controls.Add(this.skillDisplayPanel);
            this.guna2Panel1.Controls.Add(this.lblReviewCount);
            this.guna2Panel1.Controls.Add(this.lblRating);
            this.guna2Panel1.Controls.Add(this.RatingStar);
            this.guna2Panel1.Controls.Add(this.lblPayRate);
            this.guna2Panel1.Controls.Add(this.lblProfessionalTitle);
            this.guna2Panel1.Controls.Add(this.lblName);
            this.guna2Panel1.Controls.Add(this.profilePic);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(37, 38);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(551, 465);
            this.guna2Panel1.TabIndex = 0;
            // 
            // btnViewProfile
            // 
            this.btnViewProfile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnViewProfile.BorderColor = System.Drawing.Color.Blue;
            this.btnViewProfile.BorderRadius = 15;
            this.btnViewProfile.BorderThickness = 2;
            this.btnViewProfile.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProfile.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnViewProfile.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnViewProfile.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnViewProfile.FillColor = System.Drawing.Color.White;
            this.btnViewProfile.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnViewProfile.ForeColor = System.Drawing.Color.Black;
            this.btnViewProfile.Location = new System.Drawing.Point(21, 361);
            this.btnViewProfile.Name = "btnViewProfile";
            this.btnViewProfile.Size = new System.Drawing.Size(511, 64);
            this.btnViewProfile.TabIndex = 9;
            this.btnViewProfile.Text = "View Profile\r\n";
            this.btnViewProfile.Click += new System.EventHandler(this.btnViewProfile_Click);
            // 
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.AutoEllipsis = true;
            this.lblDescription.BackColor = System.Drawing.Color.White;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(26, 302);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(506, 42);
            this.lblDescription.TabIndex = 8;
            this.lblDescription.Text = "description";
            // 
            // skillDisplayPanel
            // 
            this.skillDisplayPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.skillDisplayPanel.AutoScroll = true;
            this.skillDisplayPanel.Location = new System.Drawing.Point(27, 190);
            this.skillDisplayPanel.Name = "skillDisplayPanel";
            this.skillDisplayPanel.Size = new System.Drawing.Size(505, 83);
            this.skillDisplayPanel.TabIndex = 7;
            // 
            // lblReviewCount
            // 
            this.lblReviewCount.AutoSize = true;
            this.lblReviewCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblReviewCount.Location = new System.Drawing.Point(307, 143);
            this.lblReviewCount.Name = "lblReviewCount";
            this.lblReviewCount.Size = new System.Drawing.Size(114, 23);
            this.lblReviewCount.TabIndex = 6;
            this.lblReviewCount.Text = "Review Count";
            // 
            // lblRating
            // 
            this.lblRating.AutoSize = true;
            this.lblRating.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRating.Location = new System.Drawing.Point(191, 143);
            this.lblRating.Name = "lblRating";
            this.lblRating.Size = new System.Drawing.Size(59, 23);
            this.lblRating.TabIndex = 5;
            this.lblRating.Text = "Rating";
            // 
            // RatingStar
            // 
            this.RatingStar.BorderColor = System.Drawing.Color.Gold;
            this.RatingStar.Location = new System.Drawing.Point(29, 138);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.Gold;
            this.RatingStar.Size = new System.Drawing.Size(133, 28);
            this.RatingStar.TabIndex = 4;
            // 
            // lblPayRate
            // 
            this.lblPayRate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblPayRate.AutoSize = true;
            this.lblPayRate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayRate.Location = new System.Drawing.Point(457, 24);
            this.lblPayRate.Name = "lblPayRate";
            this.lblPayRate.Size = new System.Drawing.Size(75, 23);
            this.lblPayRate.TabIndex = 3;
            this.lblPayRate.Text = "Pay Rate";
            // 
            // lblProfessionalTitle
            // 
            this.lblProfessionalTitle.AutoSize = true;
            this.lblProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionalTitle.Location = new System.Drawing.Point(109, 62);
            this.lblProfessionalTitle.Name = "lblProfessionalTitle";
            this.lblProfessionalTitle.Size = new System.Drawing.Size(101, 23);
            this.lblProfessionalTitle.TabIndex = 2;
            this.lblProfessionalTitle.Text = "Professional";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblName.Location = new System.Drawing.Point(118, 19);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(62, 25);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Name";
            // 
            // profilePic
            // 
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(21, 19);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(82, 80);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // FreelancerCards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "FreelancerCards";
            this.Size = new System.Drawing.Size(610, 528);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private System.Windows.Forms.Label lblProfessionalTitle;
        private System.Windows.Forms.Label lblName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label lblPayRate;
        private System.Windows.Forms.Label lblReviewCount;
        private System.Windows.Forms.Label lblRating;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
        private System.Windows.Forms.FlowLayoutPanel skillDisplayPanel;
        private Guna.UI2.WinForms.Guna2Button btnViewProfile;
        private System.Windows.Forms.Label lblDescription;
    }
}
