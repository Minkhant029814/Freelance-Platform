namespace Freelance_Platform.view.components.projectsComponent
{
    partial class AcceptedProjectCard
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
            this.bottomContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.middleContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblDetails = new System.Windows.Forms.Label();
            this.lblNote = new System.Windows.Forms.Label();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.lblClientName = new System.Windows.Forms.Label();
            this.lblProjectTitle = new System.Windows.Forms.Label();
            this.lblBudget = new System.Windows.Forms.Label();
            this.lblAcceptDate = new System.Windows.Forms.Label();
            this.btnStatus = new Guna.UI2.WinForms.Guna2Button();
            this.btnSetMileStone = new FontAwesome.Sharp.IconButton();
            this.mainContainer.SuspendLayout();
            this.bottomContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.middleContainer.SuspendLayout();
            this.headContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.bottomContainer);
            this.mainContainer.Controls.Add(this.middleContainer);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(13, 12);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1000, 509);
            this.mainContainer.TabIndex = 0;
            // 
            // bottomContainer
            // 
            this.bottomContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.bottomContainer.Controls.Add(this.btnSetMileStone);
            this.bottomContainer.Controls.Add(this.iconPictureBox1);
            this.bottomContainer.Controls.Add(this.label2);
            this.bottomContainer.Controls.Add(this.label1);
            this.bottomContainer.FillColor = System.Drawing.Color.White;
            this.bottomContainer.Location = new System.Drawing.Point(22, 342);
            this.bottomContainer.Name = "bottomContainer";
            this.bottomContainer.Size = new System.Drawing.Size(961, 144);
            this.bottomContainer.TabIndex = 2;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.FileCircleCheck;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ControlText;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 60;
            this.iconPictureBox1.Location = new System.Drawing.Point(8, 26);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(60, 71);
            this.iconPictureBox1.TabIndex = 7;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(79, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(446, 23);
            this.label2.TabIndex = 6;
            this.label2.Text = "Set milestone titles and assign each a percentage weight.";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(79, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(219, 28);
            this.label1.TabIndex = 5;
            this.label1.Text = "Create the Delivery Plan";
            // 
            // middleContainer
            // 
            this.middleContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.middleContainer.Controls.Add(this.lblDetails);
            this.middleContainer.Controls.Add(this.lblNote);
            this.middleContainer.FillColor = System.Drawing.Color.White;
            this.middleContainer.Location = new System.Drawing.Point(22, 190);
            this.middleContainer.Name = "middleContainer";
            this.middleContainer.Size = new System.Drawing.Size(961, 135);
            this.middleContainer.TabIndex = 1;
            // 
            // lblDetails
            // 
            this.lblDetails.AutoSize = true;
            this.lblDetails.BackColor = System.Drawing.Color.Transparent;
            this.lblDetails.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDetails.Location = new System.Drawing.Point(24, 88);
            this.lblDetails.Name = "lblDetails";
            this.lblDetails.Size = new System.Drawing.Size(673, 25);
            this.lblDetails.TabIndex = 1;
            this.lblDetails.Text = "Next: Set a milestone plan so the client can align on deliverables and project we" +
    "ight.";
            // 
            // lblNote
            // 
            this.lblNote.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblNote.BackColor = System.Drawing.Color.Transparent;
            this.lblNote.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNote.Location = new System.Drawing.Point(23, 15);
            this.lblNote.Name = "lblNote";
            this.lblNote.Size = new System.Drawing.Size(919, 60);
            this.lblNote.TabIndex = 0;
            this.lblNote.Text = "label1";
            // 
            // headContainer
            // 
            this.headContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headContainer.Controls.Add(this.lblClientName);
            this.headContainer.Controls.Add(this.lblProjectTitle);
            this.headContainer.Controls.Add(this.lblBudget);
            this.headContainer.Controls.Add(this.lblAcceptDate);
            this.headContainer.Controls.Add(this.btnStatus);
            this.headContainer.FillColor = System.Drawing.Color.White;
            this.headContainer.Location = new System.Drawing.Point(15, 12);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(968, 156);
            this.headContainer.TabIndex = 0;
            this.headContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.headContainer_Paint);
            // 
            // lblClientName
            // 
            this.lblClientName.AutoSize = true;
            this.lblClientName.BackColor = System.Drawing.Color.Transparent;
            this.lblClientName.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClientName.Location = new System.Drawing.Point(10, 115);
            this.lblClientName.Name = "lblClientName";
            this.lblClientName.Size = new System.Drawing.Size(55, 23);
            this.lblClientName.TabIndex = 4;
            this.lblClientName.Text = "label1";
            // 
            // lblProjectTitle
            // 
            this.lblProjectTitle.AutoSize = true;
            this.lblProjectTitle.BackColor = System.Drawing.Color.Transparent;
            this.lblProjectTitle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProjectTitle.Location = new System.Drawing.Point(10, 73);
            this.lblProjectTitle.Name = "lblProjectTitle";
            this.lblProjectTitle.Size = new System.Drawing.Size(65, 28);
            this.lblProjectTitle.TabIndex = 3;
            this.lblProjectTitle.Text = "label1";
            // 
            // lblBudget
            // 
            this.lblBudget.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblBudget.BackColor = System.Drawing.Color.Transparent;
            this.lblBudget.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBudget.Location = new System.Drawing.Point(781, 19);
            this.lblBudget.Name = "lblBudget";
            this.lblBudget.Size = new System.Drawing.Size(140, 39);
            this.lblBudget.TabIndex = 2;
            this.lblBudget.Text = "label1";
            // 
            // lblAcceptDate
            // 
            this.lblAcceptDate.AutoSize = true;
            this.lblAcceptDate.BackColor = System.Drawing.Color.Transparent;
            this.lblAcceptDate.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblAcceptDate.Location = new System.Drawing.Point(214, 33);
            this.lblAcceptDate.Name = "lblAcceptDate";
            this.lblAcceptDate.Size = new System.Drawing.Size(59, 25);
            this.lblAcceptDate.TabIndex = 1;
            this.lblAcceptDate.Text = "label1";
            // 
            // btnStatus
            // 
            this.btnStatus.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStatus.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStatus.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStatus.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnStatus.ForeColor = System.Drawing.Color.White;
            this.btnStatus.Location = new System.Drawing.Point(15, 19);
            this.btnStatus.Name = "btnStatus";
            this.btnStatus.Size = new System.Drawing.Size(155, 39);
            this.btnStatus.TabIndex = 0;
            this.btnStatus.Text = "guna2Button1";
            this.btnStatus.Click += new System.EventHandler(this.btnStatus_Click);
            // 
            // btnSetMileStone
            // 
            this.btnSetMileStone.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnSetMileStone.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(159)))), ((int)(((byte)(223)))), ((int)(((byte)(232)))));
            this.btnSetMileStone.FlatAppearance.BorderSize = 0;
            this.btnSetMileStone.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnSetMileStone.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSetMileStone.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.btnSetMileStone.IconChar = FontAwesome.Sharp.IconChar.PlusCircle;
            this.btnSetMileStone.IconColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(115)))), ((int)(((byte)(168)))));
            this.btnSetMileStone.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.btnSetMileStone.IconSize = 30;
            this.btnSetMileStone.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnSetMileStone.Location = new System.Drawing.Point(682, 47);
            this.btnSetMileStone.Margin = new System.Windows.Forms.Padding(15);
            this.btnSetMileStone.Name = "btnSetMileStone";
            this.btnSetMileStone.Padding = new System.Windows.Forms.Padding(15, 0, 0, 0);
            this.btnSetMileStone.Size = new System.Drawing.Size(247, 50);
            this.btnSetMileStone.TabIndex = 12;
            this.btnSetMileStone.Text = "Set MileStones";
            this.btnSetMileStone.TextImageRelation = System.Windows.Forms.TextImageRelation.ImageBeforeText;
            this.btnSetMileStone.UseVisualStyleBackColor = false;
            this.btnSetMileStone.Click += new System.EventHandler(this.btnSetMileStone_Click_1);
            // 
            // AcceptedProjectCard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "AcceptedProjectCard";
            this.Size = new System.Drawing.Size(1028, 537);
            this.mainContainer.ResumeLayout(false);
            this.bottomContainer.ResumeLayout(false);
            this.bottomContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.middleContainer.ResumeLayout(false);
            this.middleContainer.PerformLayout();
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private Guna.UI2.WinForms.Guna2Button btnStatus;
        private Guna.UI2.WinForms.Guna2Panel middleContainer;
        private System.Windows.Forms.Label lblClientName;
        private System.Windows.Forms.Label lblProjectTitle;
        private System.Windows.Forms.Label lblBudget;
        private System.Windows.Forms.Label lblAcceptDate;
        private Guna.UI2.WinForms.Guna2Panel bottomContainer;
        private System.Windows.Forms.Label lblDetails;
        private System.Windows.Forms.Label lblNote;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private FontAwesome.Sharp.IconButton btnSetMileStone;
    }
}
