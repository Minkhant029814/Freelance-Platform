namespace Freelance_Platform.view.components.projectsComponent
{
    partial class PendingProjectCard
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
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.lblSubmittedDate = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblClientName = new System.Windows.Forms.Label();
            this.bottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.bottomContainer);
            this.mainContainer.Controls.Add(this.lblClientName);
            this.mainContainer.Controls.Add(this.lblProjectTitle);
            this.mainContainer.Controls.Add(this.lblBudget);
            this.mainContainer.Controls.Add(this.lblSubmittedDate);
            this.mainContainer.Controls.Add(this.btnStatus);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(16, 16);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(839, 315);
            this.mainContainer.TabIndex = 0;
            // 
            // btnStatus
            // 
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(19, 16);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(180, 46);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "guna2Button1";
            // 
            // lblSubmittedDate
            // 
            this.lblSubmittedDate.AutoSize = true;
            this.lblSubmittedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblSubmittedDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSubmittedDate.Location = new System.Drawing.Point(247, 37);
            this.lblSubmittedDate.Name = "lblSubmittedDate";
            this.lblSubmittedDate.Size = new System.Drawing.Size(59, 25);
            this.lblSubmittedDate.TabIndex = 2;
            this.lblSubmittedDate.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(656, 23);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(140, 39);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "label1";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(14, 90);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(65, 28);
            this.lblProjectTitle.TabIndex = 4;
            this.lblProjectTitle.Text = "label1";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(24, 137);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(55, 23);
            this.lblClientName.TabIndex = 5;
            this.lblClientName.Text = "label1";
            // 
            // bottomContainer
            // 
            this.bottomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomContainer.BorderRadius = 15;
            this.bottomContainer.Controls.Add(this.label2);
            this.bottomContainer.Controls.Add(this.label1);
            this.bottomContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.bottomContainer.Location = new System.Drawing.Point(19, 191);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(797, 109);
            this.bottomContainer.TabIndex = 6;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(20, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(574, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "Your proposal is with the client. They are reviewing shortlisted candidates.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(21, 60);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(486, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next: No action needed — you will be notified when a decision is made.";
            // 
            // PendingStateProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "PendingStateProjectCard";
            this.Size = new System.Drawing.Size(873, 353);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Button btnStatus;
        private System.Windows.Forms.Label lblSubmittedDate;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblProjectTitle;
        private Guna.UI2.WinForms.Guna2Panel bottomContainer;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}
