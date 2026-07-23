namespace Freelance_Platform.view.components.projectsComponent
{
    partial class ReviewSubmissionProjectCard
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
            this.btnStat = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubmittedDate = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.FreelancerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.lblProfessionalTitle = new System.Windows.Forms.Label();
            this.lblFreelancerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.btnApprove = new Guna.UI2.WinForms.Guna2Button();
            this.mainContainer.SuspendLayout();
            this.FreelancerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.btnApprove);
            this.mainContainer.Controls.Add(this.FreelancerPanel);
            this.mainContainer.Controls.Add(this.lblProjectTitle);
            this.mainContainer.Controls.Add(this.lblSubmittedDate);
            this.mainContainer.Controls.Add(this.btnStat);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(19, 19);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1029, 311);
            this.mainContainer.TabIndex = 0;
            // 
            // btnStat
            // 
            this.btnStat.BorderRadius = 15;
            this.btnStat.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStat.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStat.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStat.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStat.FillColor = System.Drawing.Color.CornflowerBlue;
            this.btnStat.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStat.ForeColor = System.Drawing.Color.Blue;
            this.btnStat.Location = new System.Drawing.Point(24, 18);
            this.btnStat.Name = "btnStat";
            this.btnStat.Size = new System.Drawing.Size(180, 55);
            this.btnStat.TabIndex = 0;
            this.btnStat.Text = "Submitted Review";
            // 
            // lblSubmittedDate
            // 
            this.lblSubmittedDate.AutoSize = true;
            this.lblSubmittedDate.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittedDate.Location = new System.Drawing.Point(256, 30);
            this.lblSubmittedDate.Name = "lblSubmittedDate";
            this.lblSubmittedDate.Size = new System.Drawing.Size(65, 28);
            this.lblSubmittedDate.TabIndex = 1;
            this.lblSubmittedDate.Text = "label1";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(19, 95);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(579, 79);
            this.lblProjectTitle.TabIndex = 2;
            this.lblProjectTitle.Text = "label1";
            // 
            // FreelancerPanel
            // 
            this.FreelancerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FreelancerPanel.Controls.Add(this.label2);
            this.FreelancerPanel.Controls.Add(this.lblPayrate);
            this.FreelancerPanel.Controls.Add(this.lblProfessionalTitle);
            this.FreelancerPanel.Controls.Add(this.lblFreelancerName);
            this.FreelancerPanel.Controls.Add(this.label1);
            this.FreelancerPanel.Controls.Add(this.profilePic);
            this.FreelancerPanel.Location = new System.Drawing.Point(634, 30);
            this.FreelancerPanel.Name = "FreelancerPanel";
            this.FreelancerPanel.Size = new System.Drawing.Size(379, 198);
            this.FreelancerPanel.TabIndex = 6;
            // 
            // lblPayrate
            // 
            this.lblPayrate.AutoSize = true;
            this.lblPayrate.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblPayrate.Location = new System.Drawing.Point(107, 122);
            this.lblPayrate.Name = "lblPayrate";
            this.lblPayrate.Size = new System.Drawing.Size(55, 23);
            this.lblPayrate.TabIndex = 4;
            this.lblPayrate.Text = "label2";
            // 
            // lblProfessionalTitle
            // 
            this.lblProfessionalTitle.AutoSize = true;
            this.lblProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionalTitle.Location = new System.Drawing.Point(107, 87);
            this.lblProfessionalTitle.Name = "lblProfessionalTitle";
            this.lblProfessionalTitle.Size = new System.Drawing.Size(55, 23);
            this.lblProfessionalTitle.TabIndex = 3;
            this.lblProfessionalTitle.Text = "label2";
            // 
            // lblFreelancerName
            // 
            this.lblFreelancerName.AutoSize = true;
            this.lblFreelancerName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreelancerName.Location = new System.Drawing.Point(107, 53);
            this.lblFreelancerName.Name = "lblFreelancerName";
            this.lblFreelancerName.Size = new System.Drawing.Size(55, 23);
            this.lblFreelancerName.TabIndex = 2;
            this.lblFreelancerName.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(105, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(179, 25);
            this.label1.TabIndex = 1;
            this.label1.Text = "Assigned Freelancer\r\n";
            // 
            // profilePic
            // 
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(16, 17);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(64, 64);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label2.Location = new System.Drawing.Point(56, 158);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 23);
            this.label2.TabIndex = 5;
            this.label2.Text = "Waiting for your review";
            // 
            // btnApprove
            // 
            this.btnApprove.BorderRadius = 15;
            this.btnApprove.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnApprove.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnApprove.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnApprove.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.btnApprove.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnApprove.ForeColor = System.Drawing.Color.White;
            this.btnApprove.Location = new System.Drawing.Point(24, 253);
            this.btnApprove.Name = "btnApprove";
            this.btnApprove.Size = new System.Drawing.Size(223, 45);
            this.btnApprove.TabIndex = 7;
            this.btnApprove.Text = "Approve &&&Complete";
            this.btnApprove.Click += new System.EventHandler(this.btnApprove_Click);
            // 
            // ReviewSubmissionProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "ReviewSubmissionProjectCard";
            this.Size = new System.Drawing.Size(1067, 347);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.FreelancerPanel.ResumeLayout(false);
            this.FreelancerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Button btnStat;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblSubmittedDate;
        private Guna.UI2.WinForms.Guna2Panel FreelancerPanel;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblPayrate;
        private System.Windows.Forms.Label lblProfessionalTitle;
        private System.Windows.Forms.Label lblFreelancerName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private Guna.UI2.WinForms.Guna2Button btnApprove;
    }
}
