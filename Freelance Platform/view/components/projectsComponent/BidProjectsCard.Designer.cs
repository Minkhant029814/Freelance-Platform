namespace Freelance_Platform.view.components.clientComponent
{
    partial class BidProjectsCard
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
            this.lblNewBid = new System.Windows.Forms.Label();
            this.lblOldBid = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.Color.White;
            this.mainPanel.BorderRadius = 15;
            this.mainPanel.Controls.Add(this.lblNewBid);
            this.mainPanel.Controls.Add(this.lblOldBid);
            this.mainPanel.Controls.Add(this.lblBudget);
            this.mainPanel.Controls.Add(this.lblProjectTitle);
            this.mainPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainPanel.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.mainPanel.Location = new System.Drawing.Point(0, 0);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(758, 205);
            this.mainPanel.TabIndex = 0;
            this.mainPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.mainPanel_Paint);
            // 
            // lblNewBid
            // 
            this.lblNewBid.AutoSize = true;
            this.lblNewBid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.lblNewBid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNewBid.ForeColor = System.Drawing.Color.Red;
            this.lblNewBid.Location = new System.Drawing.Point(155, 121);
            this.lblNewBid.Name = "lblNewBid";
            this.lblNewBid.Size = new System.Drawing.Size(73, 23);
            this.lblNewBid.TabIndex = 5;
            this.lblNewBid.Text = "New Bid";
            // 
            // lblOldBid
            // 
            this.lblOldBid.AutoSize = true;
            this.lblOldBid.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.lblOldBid.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOldBid.ForeColor = System.Drawing.Color.Gray;
            this.lblOldBid.Location = new System.Drawing.Point(24, 121);
            this.lblOldBid.Name = "lblOldBid";
            this.lblOldBid.Size = new System.Drawing.Size(66, 23);
            this.lblOldBid.TabIndex = 4;
            this.lblOldBid.Text = "Old Bid";
            // 
            // lblBudget
            // 
            this.lblBudget.AutoSize = true;
            this.lblBudget.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(23, 66);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(75, 28);
            this.lblBudget.TabIndex = 3;
            this.lblBudget.Text = "Budget";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(21, 17);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(128, 28);
            this.lblProjectTitle.TabIndex = 2;
            this.lblProjectTitle.Text = "Project Title";
            // 
            // BidProjectsCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.Controls.Add(this.mainPanel);
            this.Margin = new System.Windows.Forms.Padding(10);
            this.Name = "BidProjectsCard";
            this.Size = new System.Drawing.Size(758, 205);
            this.Click += new System.EventHandler(this.BidProjectsCard_Click);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainPanel;
        private System.Windows.Forms.Label lblNewBid;
        private System.Windows.Forms.Label lblOldBid;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblProjectTitle;
    }
}
