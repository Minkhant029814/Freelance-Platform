namespace Freelance_Platform.view.components.clientComponent
{
    partial class RatingFreelancer
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.mainContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.ratingPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSave = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.rtxtReview = new System.Windows.Forms.RichTextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.ratingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.label2 = new System.Windows.Forms.Label();
            this.freelancerInfoPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProfessionalTitle = new System.Windows.Forms.Label();
            this.lblFreelacerName = new System.Windows.Forms.Label();
            this.profilePic = new Guna.UI2.WinForms.Guna2CirclePictureBox();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.ratingPanel.SuspendLayout();
            this.freelancerInfoPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).BeginInit();
            this.headContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Controls.Add(this.ratingPanel);
            this.mainContainer.Controls.Add(this.freelancerInfoPanel);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.Location = new System.Drawing.Point(12, 12);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(725, 612);
            this.mainContainer.TabIndex = 0;
            // 
            // ratingPanel
            // 
            this.ratingPanel.BackColor = System.Drawing.Color.White;
            this.ratingPanel.Controls.Add(this.btnSave);
            this.ratingPanel.Controls.Add(this.btnCancel);
            this.ratingPanel.Controls.Add(this.rtxtReview);
            this.ratingPanel.Controls.Add(this.label3);
            this.ratingPanel.Controls.Add(this.ratingStar);
            this.ratingPanel.Controls.Add(this.label2);
            this.ratingPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ratingPanel.Location = new System.Drawing.Point(0, 252);
            this.ratingPanel.Name = "ratingPanel";
            this.ratingPanel.Size = new System.Drawing.Size(725, 360);
            this.ratingPanel.TabIndex = 2;
            // 
            // btnSave
            // 
            this.btnSave.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSave.FillColor = System.Drawing.Color.Blue;
            this.btnSave.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSave.ForeColor = System.Drawing.Color.White;
            this.btnSave.Location = new System.Drawing.Point(498, 296);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(189, 45);
            this.btnSave.TabIndex = 8;
            this.btnSave.Text = "Submit Review";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnCancel.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnCancel.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnCancel.FillColor = System.Drawing.Color.Red;
            this.btnCancel.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnCancel.ForeColor = System.Drawing.Color.White;
            this.btnCancel.Location = new System.Drawing.Point(27, 296);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // rtxtReview
            // 
            this.rtxtReview.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.rtxtReview.Font = new System.Drawing.Font("Segoe UI Semibold", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rtxtReview.Location = new System.Drawing.Point(27, 179);
            this.rtxtReview.Name = "rtxtReview";
            this.rtxtReview.Size = new System.Drawing.Size(660, 96);
            this.rtxtReview.TabIndex = 6;
            this.rtxtReview.Text = "";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(21, 129);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(178, 31);
            this.label3.TabIndex = 5;
            this.label3.Text = "Written Review";
            // 
            // ratingStar
            // 
            this.ratingStar.BorderColor = System.Drawing.Color.Gold;
            this.ratingStar.Location = new System.Drawing.Point(27, 68);
            this.ratingStar.Name = "ratingStar";
            this.ratingStar.RatingColor = System.Drawing.Color.Gold;
            this.ratingStar.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.ratingStar.Size = new System.Drawing.Size(212, 39);
            this.ratingStar.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 21);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(140, 31);
            this.label2.TabIndex = 3;
            this.label2.Text = "Your Rating";
            // 
            // freelancerInfoPanel
            // 
            this.freelancerInfoPanel.BackColor = System.Drawing.Color.White;
            this.freelancerInfoPanel.Controls.Add(this.lblProfessionalTitle);
            this.freelancerInfoPanel.Controls.Add(this.lblFreelacerName);
            this.freelancerInfoPanel.Controls.Add(this.profilePic);
            this.freelancerInfoPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.freelancerInfoPanel.Location = new System.Drawing.Point(0, 112);
            this.freelancerInfoPanel.Name = "freelancerInfoPanel";
            this.freelancerInfoPanel.Size = new System.Drawing.Size(725, 140);
            this.freelancerInfoPanel.TabIndex = 1;
            // 
            // lblProfessionalTitle
            // 
            this.lblProfessionalTitle.AutoSize = true;
            this.lblProfessionalTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProfessionalTitle.Location = new System.Drawing.Point(134, 83);
            this.lblProfessionalTitle.Name = "lblProfessionalTitle";
            this.lblProfessionalTitle.Size = new System.Drawing.Size(65, 28);
            this.lblProfessionalTitle.TabIndex = 2;
            this.lblProfessionalTitle.Text = "label2";
            // 
            // lblFreelacerName
            // 
            this.lblFreelacerName.AutoSize = true;
            this.lblFreelacerName.Font = new System.Drawing.Font("Segoe UI", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFreelacerName.Location = new System.Drawing.Point(133, 30);
            this.lblFreelacerName.Name = "lblFreelacerName";
            this.lblFreelacerName.Size = new System.Drawing.Size(79, 31);
            this.lblFreelacerName.TabIndex = 1;
            this.lblFreelacerName.Text = "label2";
            // 
            // profilePic
            // 
            this.profilePic.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.profilePic.ImageRotate = 0F;
            this.profilePic.Location = new System.Drawing.Point(16, 15);
            this.profilePic.Name = "profilePic";
            this.profilePic.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.profilePic.Size = new System.Drawing.Size(95, 96);
            this.profilePic.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.profilePic.TabIndex = 0;
            this.profilePic.TabStop = false;
            // 
            // headContainer
            // 
            this.headContainer.BackColor = System.Drawing.Color.White;
            this.headContainer.Controls.Add(this.lblProjectTitle);
            this.headContainer.Controls.Add(this.label1);
            this.headContainer.Dock = System.Windows.Forms.DockStyle.Top;
            this.headContainer.Location = new System.Drawing.Point(0, 0);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(725, 112);
            this.headContainer.TabIndex = 0;
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(22, 67);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(65, 28);
            this.lblProjectTitle.TabIndex = 1;
            this.lblProjectTitle.Text = "label2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(286, 38);
            this.label1.TabIndex = 0;
            this.label1.Text = "Rate Your Freelancer";
            // 
            // RatingFreelancer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(749, 636);
            this.Controls.Add(this.mainContainer);
            this.Name = "RatingFreelancer";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "RatingFreelancer";
            this.Load += new System.EventHandler(this.RatingFreelancer_Load);
            this.mainContainer.ResumeLayout(false);
            this.ratingPanel.ResumeLayout(false);
            this.ratingPanel.PerformLayout();
            this.freelancerInfoPanel.ResumeLayout(false);
            this.freelancerInfoPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.profilePic)).EndInit();
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel freelancerInfoPanel;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel ratingPanel;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private System.Windows.Forms.RichTextBox rtxtReview;
        private System.Windows.Forms.Label label3;
        private Guna.UI2.WinForms.Guna2RatingStar ratingStar;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblProfessionalTitle;
        private System.Windows.Forms.Label lblFreelacerName;
        private Guna.UI2.WinForms.Guna2CirclePictureBox profilePic;
        private Guna.UI2.WinForms.Guna2Button btnSave;
    }
}