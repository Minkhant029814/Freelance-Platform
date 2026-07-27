namespace Freelance_Platform.view.components.projectsComponent
{
    partial class OngoingProjectCard
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
            this.btnSubmitReview = new Guna.UI2.WinForms.Guna2Button();
            this.mileStonePanel = new Guna.UI2.WinForms.Guna2Panel();
            this.mileStoneLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.progressBar = new Guna.UI2.WinForms.Guna2ProgressBar();
            this.btnEndate = new Guna.UI2.WinForms.Guna2Button();
            this.lblprogress = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.mileStonePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.btnSubmitReview);
            this.mainContainer.Controls.Add(this.mileStonePanel);
            this.mainContainer.Controls.Add(this.progressBar);
            this.mainContainer.Controls.Add(this.btnEndate);
            this.mainContainer.Controls.Add(this.lblprogress);
            this.mainContainer.Controls.Add(this.lblClientName);
            this.mainContainer.Controls.Add(this.lblProjectTitle);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(15, 18);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(947, 617);
            this.mainContainer.TabIndex = 0;
            // 
            // btnSubmitReview
            // 
            this.btnSubmitReview.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSubmitReview.BackColor = System.Drawing.Color.Transparent;
            this.btnSubmitReview.BorderRadius = 15;
            this.btnSubmitReview.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitReview.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSubmitReview.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSubmitReview.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSubmitReview.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSubmitReview.ForeColor = System.Drawing.Color.White;
            this.btnSubmitReview.Location = new System.Drawing.Point(637, 532);
            this.btnSubmitReview.Name = "btnSubmitReview";
            this.btnSubmitReview.Size = new System.Drawing.Size(239, 65);
            this.btnSubmitReview.TabIndex = 7;
            this.btnSubmitReview.Text = "Submit Review";
            this.btnSubmitReview.Visible = false;
            this.btnSubmitReview.Click += new System.EventHandler(this.btnSubmitReview_Click);
            // 
            // mileStonePanel
            // 
            this.mileStonePanel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mileStonePanel.BorderRadius = 15;
            this.mileStonePanel.Controls.Add(this.mileStoneLayout);
            this.mileStonePanel.Controls.Add(this.label1);
            this.mileStonePanel.FillColor = System.Drawing.Color.White;
            this.mileStonePanel.Location = new System.Drawing.Point(35, 277);
            this.mileStonePanel.Name = "mileStonePanel";
            this.mileStonePanel.Size = new System.Drawing.Size(883, 227);
            this.mileStonePanel.TabIndex = 6;
            // 
            // mileStoneLayout
            // 
            this.mileStoneLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mileStoneLayout.AutoScroll = true;
            this.mileStoneLayout.BackColor = System.Drawing.Color.Transparent;
            this.mileStoneLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.mileStoneLayout.Location = new System.Drawing.Point(20, 43);
            this.mileStoneLayout.Name = "mileStoneLayout";
            this.mileStoneLayout.Size = new System.Drawing.Size(846, 170);
            this.mileStoneLayout.TabIndex = 8;
            this.mileStoneLayout.WrapContents = false;
            this.mileStoneLayout.Resize += new System.EventHandler(this.mileStoneLayout_Resize);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(17, 15);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(156, 25);
            this.label1.TabIndex = 7;
            this.label1.Text = "Project Milestones";
            // 
            // progressBar
            // 
            this.progressBar.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.progressBar.Location = new System.Drawing.Point(33, 222);
            this.progressBar.Name = "progressBar";
            this.progressBar.Size = new System.Drawing.Size(804, 30);
            this.progressBar.TabIndex = 5;
            this.progressBar.Text = "guna2ProgressBar1";
            this.progressBar.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            // 
            // btnEndate
            // 
            this.btnEndate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnEndate.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEndate.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEndate.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEndate.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEndate.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnEndate.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnEndate.ForeColor = System.Drawing.Color.White;
            this.btnEndate.Location = new System.Drawing.Point(591, 27);
            this.btnEndate.Name = "btnEndate";
            this.btnEndate.Size = new System.Drawing.Size(295, 45);
            this.btnEndate.TabIndex = 4;
            this.btnEndate.Text = "guna2Button1";
            // 
            // lblprogress
            // 
            this.lblprogress.AutoSize = true;
            this.lblprogress.BackColor = System.Drawing.Color.Transparent;
            this.lblprogress.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblprogress.Location = new System.Drawing.Point(29, 173);
            this.lblprogress.Name = "lblprogress";
            this.lblprogress.Size = new System.Drawing.Size(133, 23);
            this.lblprogress.TabIndex = 3;
            this.lblprogress.Text = "Overall Progress";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(28, 89);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(59, 25);
            this.lblClientName.TabIndex = 2;
            this.lblClientName.Text = "label3";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI Semibold", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(27, 27);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(600, 62);
            this.lblProjectTitle.TabIndex = 0;
            this.lblProjectTitle.Text = "label1";
            // 
            // OngoingProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "OngoingProjectCard";
            this.Size = new System.Drawing.Size(979, 655);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.mileStonePanel.ResumeLayout(false);
            this.mileStonePanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private System.Windows.Forms.Label lblprogress;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblProjectTitle;
        private Guna.UI2.WinForms.Guna2Panel mileStonePanel;
        private Guna.UI2.WinForms.Guna2ProgressBar progressBar;
        private Guna.UI2.WinForms.Guna2Button btnEndate;
        private System.Windows.Forms.FlowLayoutPanel mileStoneLayout;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Button btnSubmitReview;
    }
}
