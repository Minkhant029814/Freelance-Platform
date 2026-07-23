namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class SettingMileStone
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
            this.middleContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.MileStoneLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.btnAddMileStones = new Guna.UI2.WinForms.Guna2Button();
            this.bottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.btnSaveMileStone = new Guna.UI2.WinForms.Guna2Button();
            this.btnCancel = new Guna.UI2.WinForms.Guna2Button();
            this.lblMileStonePercentage = new System.Windows.Forms.Label();
            this.heaadContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblTotalWeight = new System.Windows.Forms.Label();
            this.lblMildeStoneCount = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2ContextMenuStrip1 = new Guna.UI2.WinForms.Guna2ContextMenuStrip();
            this.mainContainer.SuspendLayout();
            this.middleContainer.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            this.heaadContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BackColor = System.Drawing.Color.Silver;
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.middleContainer);
            this.mainContainer.Controls.Add(this.bottomContainer);
            this.mainContainer.Controls.Add(this.heaadContainer);
            this.mainContainer.FillColor = System.Drawing.Color.Silver;
            this.mainContainer.Location = new System.Drawing.Point(15, 21);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(890, 696);
            this.mainContainer.TabIndex = 0;
            // 
            // middleContainer
            // 
            this.middleContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleContainer.Controls.Add(this.MileStoneLayout);
            this.middleContainer.Controls.Add(this.btnAddMileStones);
            this.middleContainer.FillColor = System.Drawing.Color.White;
            this.middleContainer.Location = new System.Drawing.Point(13, 184);
            this.middleContainer.Name = "middleContainer";
            this.middleContainer.Size = new System.Drawing.Size(860, 369);
            this.middleContainer.TabIndex = 2;
            // 
            // MileStoneLayout
            // 
            this.MileStoneLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MileStoneLayout.AutoScroll = true;
            this.MileStoneLayout.BackColor = System.Drawing.Color.Transparent;
            this.MileStoneLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.MileStoneLayout.Location = new System.Drawing.Point(18, 45);
            this.MileStoneLayout.Name = "MileStoneLayout";
            this.MileStoneLayout.Size = new System.Drawing.Size(826, 229);
            this.MileStoneLayout.TabIndex = 1;
            this.MileStoneLayout.WrapContents = false;
            this.MileStoneLayout.Resize += new System.EventHandler(this.MileStoneLayout_Resize);
            // 
            // btnAddMileStones
            // 
            this.btnAddMileStones.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnAddMileStones.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMileStones.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnAddMileStones.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnAddMileStones.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnAddMileStones.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnAddMileStones.ForeColor = System.Drawing.Color.White;
            this.btnAddMileStones.Location = new System.Drawing.Point(101, 308);
            this.btnAddMileStones.Name = "btnAddMileStones";
            this.btnAddMileStones.Size = new System.Drawing.Size(686, 45);
            this.btnAddMileStones.TabIndex = 0;
            this.btnAddMileStones.Text = "Add MileStone";
            this.btnAddMileStones.Click += new System.EventHandler(this.btnAddMileStones_Click);
            // 
            // bottomContainer
            // 
            this.bottomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomContainer.Controls.Add(this.btnSaveMileStone);
            this.bottomContainer.Controls.Add(this.btnCancel);
            this.bottomContainer.Controls.Add(this.lblMileStonePercentage);
            this.bottomContainer.FillColor = System.Drawing.Color.White;
            this.bottomContainer.Location = new System.Drawing.Point(13, 559);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(860, 137);
            this.bottomContainer.TabIndex = 1;
            // 
            // btnSaveMileStone
            // 
            this.btnSaveMileStone.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMileStone.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnSaveMileStone.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnSaveMileStone.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnSaveMileStone.FillColor = System.Drawing.Color.Lime;
            this.btnSaveMileStone.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnSaveMileStone.ForeColor = System.Drawing.Color.White;
            this.btnSaveMileStone.Location = new System.Drawing.Point(556, 66);
            this.btnSaveMileStone.Name = "btnSaveMileStone";
            this.btnSaveMileStone.Size = new System.Drawing.Size(180, 45);
            this.btnSaveMileStone.TabIndex = 2;
            this.btnSaveMileStone.Text = "Save Milestones";
            this.btnSaveMileStone.Click += new System.EventHandler(this.btnSaveMileStone_Click);
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
            this.btnCancel.Location = new System.Drawing.Point(250, 66);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(180, 45);
            this.btnCancel.TabIndex = 1;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // lblMileStonePercentage
            // 
            this.lblMileStonePercentage.AutoSize = true;
            this.lblMileStonePercentage.BackColor = System.Drawing.Color.Transparent;
            this.lblMileStonePercentage.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileStonePercentage.Location = new System.Drawing.Point(14, 23);
            this.lblMileStonePercentage.Name = "lblMileStonePercentage";
            this.lblMileStonePercentage.Size = new System.Drawing.Size(55, 23);
            this.lblMileStonePercentage.TabIndex = 0;
            this.lblMileStonePercentage.Text = "label3";
            // 
            // heaadContainer
            // 
            this.heaadContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.heaadContainer.Controls.Add(this.lblTotalWeight);
            this.heaadContainer.Controls.Add(this.lblMildeStoneCount);
            this.heaadContainer.Controls.Add(this.label2);
            this.heaadContainer.Controls.Add(this.label1);
            this.heaadContainer.FillColor = System.Drawing.Color.White;
            this.heaadContainer.Location = new System.Drawing.Point(13, 15);
            this.heaadContainer.Name = "heaadContainer";
            this.heaadContainer.Size = new System.Drawing.Size(860, 163);
            this.heaadContainer.TabIndex = 0;
            // 
            // lblTotalWeight
            // 
            this.lblTotalWeight.AutoSize = true;
            this.lblTotalWeight.BackColor = System.Drawing.Color.Transparent;
            this.lblTotalWeight.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTotalWeight.Location = new System.Drawing.Point(340, 18);
            this.lblTotalWeight.Name = "lblTotalWeight";
            this.lblTotalWeight.Size = new System.Drawing.Size(139, 28);
            this.lblTotalWeight.TabIndex = 3;
            this.lblTotalWeight.Text = "Delivery Plan";
            // 
            // lblMildeStoneCount
            // 
            this.lblMildeStoneCount.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMildeStoneCount.BackColor = System.Drawing.Color.Transparent;
            this.lblMildeStoneCount.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMildeStoneCount.Location = new System.Drawing.Point(617, 18);
            this.lblMildeStoneCount.Name = "lblMildeStoneCount";
            this.lblMildeStoneCount.Size = new System.Drawing.Size(216, 34);
            this.lblMildeStoneCount.TabIndex = 2;
            this.lblMildeStoneCount.Text = "Mile Stone";
            this.lblMildeStoneCount.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(23, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(821, 62);
            this.label2.TabIndex = 1;
            this.label2.Text = "Give each milestone a clear title and assign its share of the work. Weights must " +
    "add up to 100%.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(23, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(139, 28);
            this.label1.TabIndex = 0;
            this.label1.Text = "Delivery Plan";
            // 
            // guna2ContextMenuStrip1
            // 
            this.guna2ContextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.guna2ContextMenuStrip1.Name = "guna2ContextMenuStrip1";
            this.guna2ContextMenuStrip1.RenderStyle.ArrowColor = System.Drawing.Color.FromArgb(((int)(((byte)(151)))), ((int)(((byte)(143)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.BorderColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.ColorTable = null;
            this.guna2ContextMenuStrip1.RenderStyle.RoundedEdges = true;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionArrowColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.guna2ContextMenuStrip1.RenderStyle.SelectionForeColor = System.Drawing.Color.White;
            this.guna2ContextMenuStrip1.RenderStyle.SeparatorColor = System.Drawing.Color.Gainsboro;
            this.guna2ContextMenuStrip1.RenderStyle.TextRenderingHint = System.Drawing.Text.TextRenderingHint.SystemDefault;
            this.guna2ContextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // SettingMileStone
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(917, 729);
            this.Controls.Add(this.mainContainer);
            this.Name = "SettingMileStone";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "SettingMileStone";
            this.Load += new System.EventHandler(this.SettingMileStone_Load);
            this.mainContainer.ResumeLayout(false);
            this.middleContainer.ResumeLayout(false);
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            this.heaadContainer.ResumeLayout(false);
            this.heaadContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel heaadContainer;
        private System.Windows.Forms.Label lblMildeStoneCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2Panel bottomContainer;
        private System.Windows.Forms.Label lblMileStonePercentage;
        private Guna.UI2.WinForms.Guna2Button btnSaveMileStone;
        private Guna.UI2.WinForms.Guna2Button btnCancel;
        private Guna.UI2.WinForms.Guna2Panel middleContainer;
        private System.Windows.Forms.FlowLayoutPanel MileStoneLayout;
        private Guna.UI2.WinForms.Guna2Button btnAddMileStones;
        private Guna.UI2.WinForms.Guna2ContextMenuStrip guna2ContextMenuStrip1;
        private System.Windows.Forms.Label lblTotalWeight;
    }
}