namespace Freelance_Platform.view.components.clientComponent
{
    partial class FreelancerPastReviewCard
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
            this.mainPanel = new Guna.UI2.WinForms.Guna2Panel();
            this.RatingStar = new Guna.UI2.WinForms.Guna2RatingStar();
            this.lblcomment = new System.Windows.Forms.Label();
            this.lblCommentDate = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.Controls.Add(this.RatingStar);
            this.mainPanel.Controls.Add(this.lblcomment);
            this.mainPanel.Controls.Add(this.lblCommentDate);
            this.mainPanel.Controls.Add(this.lblClientName);
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.mainPanel.Location = new System.Drawing.Point(17, 24);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(594, 316);
            this.mainPanel.TabIndex = 0;
            // 
            // RatingStar
            // 
            this.RatingStar.BackColor = System.Drawing.Color.Transparent;
            this.RatingStar.BorderColor = System.Drawing.Color.Gold;
            this.RatingStar.Location = new System.Drawing.Point(33, 64);
            this.RatingStar.Name = "RatingStar";
            this.RatingStar.RatingColor = System.Drawing.Color.Gold;
            this.RatingStar.Size = new System.Drawing.Size(268, 56);
            this.RatingStar.TabIndex = 3;
            // 
            // lblcomment
            // 
            this.lblcomment.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblcomment.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblcomment.Location = new System.Drawing.Point(28, 166);
            this.lblcomment.Name = "lblcomment";
            this.lblcomment.Size = new System.Drawing.Size(544, 130);
            this.lblcomment.TabIndex = 2;
            this.lblcomment.Text = "label3";
            // 
            // lblCommentDate
            // 
            this.lblCommentDate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblCommentDate.BackColor = System.Drawing.Color.Transparent;
            this.lblCommentDate.Font = new System.Drawing.Font("Segoe UI Semibold", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCommentDate.Location = new System.Drawing.Point(247, 23);
            this.lblCommentDate.Name = "lblCommentDate";
            this.lblCommentDate.Size = new System.Drawing.Size(308, 35);
            this.lblCommentDate.TabIndex = 1;
            this.lblCommentDate.Text = "label2";
            this.lblCommentDate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(29, 23);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(53, 23);
            this.lblClientName.TabIndex = 0;
            this.lblClientName.Text = "label1";
            // 
            // FreelancerPastReviewCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainPanel);
            this.Name = "FreelancerPastReviewCard";
            this.Size = new System.Drawing.Size(627, 358);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private Guna.UI2.WinForms.Guna2RatingStar RatingStar;
        private System.Windows.Forms.Label lblcomment;
        private System.Windows.Forms.Label lblCommentDate;
        private System.Windows.Forms.Label lblClientName;
    }
}
