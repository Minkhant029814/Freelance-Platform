namespace Freelance_Platform.view.components.projectsComponent
{
    partial class CompletedCardByClient
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
            this.ReviewPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblComments = new System.Windows.Forms.Label();
            this.btnRating = new FontAwesome.Sharp.IconButton();
            this.lblFinalPayment = new System.Windows.Forms.Label();
            this.FreelancerPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblPayrate = new System.Windows.Forms.Label();
            this.lblProfessionalTitle = new System.Windows.Forms.Label();
            this.lblFreelancerName = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.lblDescription = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblDate = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.guna2Panel1.SuspendLayout();
            this.ReviewPanel.SuspendLayout();
            this.FreelancerPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2Panel1.BackColor = System.Drawing.SystemColors.Control;
            this.guna2Panel1.BorderRadius = 20;
            this.guna2Panel1.Controls.Add(this.ReviewPanel);
            this.guna2Panel1.Controls.Add(this.btnRating);
            this.guna2Panel1.Controls.Add(this.lblFinalPayment);
            this.guna2Panel1.Controls.Add(this.FreelancerPanel);
            this.guna2Panel1.Controls.Add(this.lblDescription);
            this.guna2Panel1.Controls.Add(this.lblProjectTitle);
            this.guna2Panel1.Controls.Add(this.lblDate);
            this.guna2Panel1.Controls.Add(this.lblStatus);
            this.guna2Panel1.FillColor = System.Drawing.Color.White;
            this.guna2Panel1.Location = new System.Drawing.Point(45, 44);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(942, 567);
            this.guna2Panel1.TabIndex = 2;
            // 
            // ReviewPanel
            // 
            this.ReviewPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ReviewPanel.BackColor = System.Drawing.Color.Transparent;
            this.ReviewPanel.BorderRadius = 15;
            this.ReviewPanel.Controls.Add(this.RatingStar);
            this.ReviewPanel.Controls.Add(this.lblComments);
            this.ReviewPanel.FillColor = System.Drawing.SystemColors.Control;
            this.ReviewPanel.Location = new System.Drawing.Point(35, 424);
            this.ReviewPanel.Name = "ReviewPanel";
            this.ReviewPanel.Size = new System.Drawing.Size(865, 118);
            this.ReviewPanel.TabIndex = 8;
            this.ReviewPanel.Visible = false;
            // 
            // RatingStar
            // 
            this.RatingStar.BackColor = System.Drawing.Color.Transparent;
            this.RatingStar.BorderColor = System.Drawing.Color.Gold;
            this.RatingStar.Location = new System.Drawing.Point(27, 3);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.Gold;
            this.RatingStar.Size = new System.Drawing.Size(220, 43);
            this.RatingStar.TabIndex = 1;
            // 
            // lblComments
            // 
            this.lblComments.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblComments.BackColor = System.Drawing.Color.Transparent;
            this.lblComments.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblComments.Location = new System.Drawing.Point(29, 56);
            this.lblComments.Name = "lblComments";
            this.lblComments.Size = new System.Drawing.Size(815, 49);
            this.lblComments.TabIndex = 0;
            this.lblComments.Text = "label2";
            // 
            // btnRating
            // 
            this.btnRating.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnRating.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.btnRating.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnRating.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnRating.ForeColor = System.Drawing.Color.White;
            this.btnRating.IconChar = FontAwesome.Sharp.IconChar.Star;
            this.btnRating.IconColor = System.Drawing.Color.White;
            this.btnRating.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnRating.IconSize = 35;
            this.btnRating.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnRating.Location = new System.Drawing.Point(614, 333);
            this.btnRating.Name = "btnRating";
            this.btnRating.Size = new System.Drawing.Size(293, 52);
            this.btnRating.TabIndex = 7;
            this.btnRating.Text = "Rate Freelaner";
            this.btnRating.UseVisualStyleBackColor = false;
            this.btnRating.Click += new System.EventHandler(this.btnRating_Click);
            // 
            // lblFinalPayment
            // 
            this.lblFinalPayment.AutoSize = true;
            this.lblFinalPayment.BackColor = System.Drawing.Color.Transparent;
            this.lblFinalPayment.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFinalPayment.Location = new System.Drawing.Point(30, 333);
            this.lblFinalPayment.Name = "lblFinalPayment";
            this.lblFinalPayment.Size = new System.Drawing.Size(59, 25);
            this.lblFinalPayment.TabIndex = 6;
            this.lblFinalPayment.Text = "label2";
            // 
            // FreelancerPanel
            // 
            this.FreelancerPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.FreelancerPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.FreelancerPanel.Controls.Add(this.lblPayrate);
            this.FreelancerPanel.Controls.Add(this.lblProfessionalTitle);
            this.FreelancerPanel.Controls.Add(this.lblFreelancerName);
            this.FreelancerPanel.Controls.Add(this.label1);
            this.FreelancerPanel.Controls.Add(this.profilePic);
            this.FreelancerPanel.Location = new System.Drawing.Point(531, 92);
            this.FreelancerPanel.Name = "FreelancerPanel";
            this.FreelancerPanel.Size = new System.Drawing.Size(379, 198);
            this.FreelancerPanel.TabIndex = 5;
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
            // lblDescription
            // 
            this.lblDescription.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblDescription.BackColor = System.Drawing.Color.Transparent;
            this.lblDescription.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDescription.Location = new System.Drawing.Point(30, 92);
            this.lblDescription.Name = "lblDescription";
            this.lblDescription.Size = new System.Drawing.Size(484, 200);
            this.lblDescription.TabIndex = 3;
            this.lblDescription.Text = "label1";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectTitle.BackColor = System.Drawing.Color.White;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(29, 47);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(749, 45);
            this.lblProjectTitle.TabIndex = 2;
            this.lblProjectTitle.Text = "label1";
            // 
            // lblDate
            // 
            this.lblDate.AutoSize = true;
            this.lblDate.BackColor = System.Drawing.Color.Transparent;
            this.lblDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDate.Location = new System.Drawing.Point(389, 20);
            this.lblDate.Name = "lblDate";
            this.lblDate.Size = new System.Drawing.Size(58, 22);
            this.lblDate.TabIndex = 1;
            this.lblDate.Text = "label1";
            // 
            // lblStatus
            // 
            this.lblStatus.BackColor = System.Drawing.Color.Transparent;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Green;
            this.lblStatus.Location = new System.Drawing.Point(13, 15);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(287, 32);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "label1";
            this.lblStatus.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CompletedCardByClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.guna2Panel1);
            this.Name = "CompletedCardByClient";
            this.Size = new System.Drawing.Size(1017, 644);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ReviewPanel.ResumeLayout(false);
            this.FreelancerPanel.ResumeLayout(false);
            this.FreelancerPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Panel FreelancerPanel;
        private System.Windows.Forms.Label lblPayrate;
        private System.Windows.Forms.Label lblProfessionalTitle;
        private System.Windows.Forms.Label lblFreelancerName;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private System.Windows.Forms.Label lblDescription;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblDate;
        private System.Windows.Forms.Label lblStatus;
        private FontAwesome.Sharp.IconButton btnRating;
        private System.Windows.Forms.Label lblFinalPayment;
        private Guna.UI2.WinForms.Guna2Panel ReviewPanel;
        private System.Windows.Forms.Label lblComments;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
    }
}
