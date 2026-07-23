namespace Freelance_Platform.view.components.projectsComponent
{
    partial class RejectedProjectCard
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
            this.lblRejectedDate = new System.Windows.Forms.Label();
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
            this.mainContainer.AutoSize = true;
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.bottomContainer);
            this.mainContainer.Controls.Add(this.lblClientName);
            this.mainContainer.Controls.Add(this.lblProjectTitle);
            this.mainContainer.Controls.Add(this.lblBudget);
            this.mainContainer.Controls.Add(this.lblRejectedDate);
            this.mainContainer.Controls.Add(this.btnStatus);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(13, 14);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(774, 287);
            this.mainContainer.TabIndex = 0;
            // 
            // btnStatus
            // 
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.FillColor = System.Drawing.Color.Silver;
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(16, 12);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(180, 46);
            this.btnStatus.TabIndex = 1;
            this.btnStatus.Text = "guna2Button1";
            // 
            // lblRejectedDate
            // 
            this.lblRejectedDate.AutoSize = true;
            this.lblRejectedDate.BackColor = System.Drawing.Color.Transparent;
            this.lblRejectedDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblRejectedDate.Location = new System.Drawing.Point(248, 33);
            this.lblRejectedDate.Name = "lblRejectedDate";
            this.lblRejectedDate.Size = new System.Drawing.Size(59, 25);
            this.lblRejectedDate.TabIndex = 3;
            this.lblRejectedDate.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(611, 19);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(140, 39);
            this.lblBudget.TabIndex = 4;
            this.lblBudget.Text = "label1";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(11, 79);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(65, 28);
            this.lblProjectTitle.TabIndex = 5;
            this.lblProjectTitle.Text = "label1";
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(12, 122);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(55, 23);
            this.lblClientName.TabIndex = 6;
            this.lblClientName.Text = "label1";
            // 
            // bottomContainer
            // 
            this.bottomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomContainer.BorderRadius = 15;
            this.bottomContainer.Controls.Add(this.label2);
            this.bottomContainer.Controls.Add(this.label1);
            this.bottomContainer.FillColor = System.Drawing.Color.Silver;
            this.bottomContainer.Location = new System.Drawing.Point(16, 177);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(735, 95);
            this.bottomContainer.TabIndex = 7;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI Semibold", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(18, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(418, 23);
            this.label1.TabIndex = 0;
            this.label1.Text = "The client selected another freelancer for this project.";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(18, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(460, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Next: This opportunity is closed. Keep bidding on matching projects.";
            // 
            // RejectedProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "RejectedProjectCard";
            this.Size = new System.Drawing.Size(802, 317);
            this.mainContainer.ResumeLayout(false);
            this.mainContainer.PerformLayout();
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Button btnStatus;
        private System.Windows.Forms.Label lblRejectedDate;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblProjectTitle;
        private Guna.UI2.WinForms.Guna2Panel bottomContainer;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblClientName;
    }
}
