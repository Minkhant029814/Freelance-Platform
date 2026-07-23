namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class myBidsView
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
            this.guna2TabControl1 = new Guna.UI2.WinForms.Guna2TabControl();
            this.Accepted = new System.Windows.Forms.TabPage();
            this.acceptedLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Pending = new System.Windows.Forms.TabPage();
            this.PendingLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.Rejected = new System.Windows.Forms.TabPage();
            this.RejectedLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.headContainer = new Guna.UI2.WinForms.Guna2Panel();
            this.iconPictureBox1 = new FontAwesome.Sharp.IconPictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            this.guna2TabControl1.SuspendLayout();
            this.Accepted.SuspendLayout();
            this.Pending.SuspendLayout();
            this.Rejected.SuspendLayout();
            this.headContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.Controls.Add(this.guna2TabControl1);
            this.mainContainer.Controls.Add(this.headContainer);
            this.mainContainer.Location = new System.Drawing.Point(13, 15);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(792, 661);
            this.mainContainer.TabIndex = 0;
            // 
            // guna2TabControl1
            // 
            this.guna2TabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2TabControl1.Controls.Add(this.Accepted);
            this.guna2TabControl1.Controls.Add(this.Pending);
            this.guna2TabControl1.Controls.Add(this.Rejected);
            this.guna2TabControl1.ItemSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.Location = new System.Drawing.Point(14, 170);
            this.guna2TabControl1.Name = "guna2TabControl1";
            this.guna2TabControl1.SelectedIndex = 0;
            this.guna2TabControl1.Size = new System.Drawing.Size(763, 469);
            this.guna2TabControl1.TabButtonHoverState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonHoverState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonHoverState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(52)))), ((int)(((byte)(70)))));
            this.guna2TabControl1.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonIdleState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonIdleState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(156)))), ((int)(((byte)(160)))), ((int)(((byte)(167)))));
            this.guna2TabControl1.TabButtonIdleState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabButtonSelectedState.BorderColor = System.Drawing.Color.Empty;
            this.guna2TabControl1.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(29)))), ((int)(((byte)(37)))), ((int)(((byte)(49)))));
            this.guna2TabControl1.TabButtonSelectedState.Font = new System.Drawing.Font("Segoe UI Semibold", 10F);
            this.guna2TabControl1.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.guna2TabControl1.TabButtonSelectedState.InnerColor = System.Drawing.Color.FromArgb(((int)(((byte)(76)))), ((int)(((byte)(132)))), ((int)(((byte)(255)))));
            this.guna2TabControl1.TabButtonSize = new System.Drawing.Size(180, 40);
            this.guna2TabControl1.TabIndex = 1;
            this.guna2TabControl1.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(42)))), ((int)(((byte)(57)))));
            this.guna2TabControl1.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            this.guna2TabControl1.SelectedIndexChanged += new System.EventHandler(this.guna2TabControl1_SelectedIndexChanged);
            // 
            // Accepted
            // 
            this.Accepted.Controls.Add(this.acceptedLayout);
            this.Accepted.Location = new System.Drawing.Point(4, 44);
            this.Accepted.Name = "Accepted";
            this.Accepted.Padding = new System.Windows.Forms.Padding(3);
            this.Accepted.Size = new System.Drawing.Size(755, 421);
            this.Accepted.TabIndex = 0;
            this.Accepted.Text = "Accepted";
            this.Accepted.UseVisualStyleBackColor = true;
            // 
            // acceptedLayout
            // 
            this.acceptedLayout.AutoScroll = true;
            this.acceptedLayout.BackColor = System.Drawing.Color.Silver;
            this.acceptedLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.acceptedLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.acceptedLayout.Location = new System.Drawing.Point(3, 3);
            this.acceptedLayout.Name = "acceptedLayout";
            this.acceptedLayout.Size = new System.Drawing.Size(749, 415);
            this.acceptedLayout.TabIndex = 0;
            this.acceptedLayout.WrapContents = false;
            this.acceptedLayout.Resize += new System.EventHandler(this.acceptedLayout_Resize);
            // 
            // Pending
            // 
            this.Pending.Controls.Add(this.PendingLayout);
            this.Pending.Location = new System.Drawing.Point(4, 44);
            this.Pending.Name = "Pending";
            this.Pending.Padding = new System.Windows.Forms.Padding(3);
            this.Pending.Size = new System.Drawing.Size(755, 421);
            this.Pending.TabIndex = 1;
            this.Pending.Text = "Pending Decisions";
            this.Pending.UseVisualStyleBackColor = true;
            // 
            // PendingLayout
            // 
            this.PendingLayout.AutoScroll = true;
            this.PendingLayout.BackColor = System.Drawing.Color.Silver;
            this.PendingLayout.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PendingLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.PendingLayout.Location = new System.Drawing.Point(3, 3);
            this.PendingLayout.Name = "PendingLayout";
            this.PendingLayout.Size = new System.Drawing.Size(749, 415);
            this.PendingLayout.TabIndex = 0;
            this.PendingLayout.WrapContents = false;
            this.PendingLayout.Resize += new System.EventHandler(this.PendingLayout_Resize);
            // 
            // Rejected
            // 
            this.Rejected.Controls.Add(this.RejectedLayout);
            this.Rejected.Location = new System.Drawing.Point(4, 44);
            this.Rejected.Name = "Rejected";
            this.Rejected.Padding = new System.Windows.Forms.Padding(3);
            this.Rejected.Size = new System.Drawing.Size(755, 421);
            this.Rejected.TabIndex = 2;
            this.Rejected.Text = "Not Selected";
            this.Rejected.UseVisualStyleBackColor = true;
            // 
            // RejectedLayout
            // 
            this.RejectedLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RejectedLayout.AutoScroll = true;
            this.RejectedLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.RejectedLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.RejectedLayout.Location = new System.Drawing.Point(9, 6);
            this.RejectedLayout.Name = "RejectedLayout";
            this.RejectedLayout.Size = new System.Drawing.Size(713, 409);
            this.RejectedLayout.TabIndex = 0;
            this.RejectedLayout.WrapContents = false;
            this.RejectedLayout.Resize += new System.EventHandler(this.RejectedLayout_Resize);
            // 
            // headContainer
            // 
            this.headContainer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.headContainer.BorderRadius = 15;
            this.headContainer.Controls.Add(this.iconPictureBox1);
            this.headContainer.Controls.Add(this.label2);
            this.headContainer.Controls.Add(this.label1);
            this.headContainer.FillColor = System.Drawing.Color.White;
            this.headContainer.Location = new System.Drawing.Point(14, 14);
            this.headContainer.Name = "headContainer";
            this.headContainer.Size = new System.Drawing.Size(763, 121);
            this.headContainer.TabIndex = 0;
            // 
            // iconPictureBox1
            // 
            this.iconPictureBox1.BackColor = System.Drawing.SystemColors.Control;
            this.iconPictureBox1.ForeColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconChar = FontAwesome.Sharp.IconChar.File;
            this.iconPictureBox1.IconColor = System.Drawing.SystemColors.ActiveBorder;
            this.iconPictureBox1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconPictureBox1.IconSize = 78;
            this.iconPictureBox1.Location = new System.Drawing.Point(13, 18);
            this.iconPictureBox1.Name = "iconPictureBox1";
            this.iconPictureBox1.Size = new System.Drawing.Size(78, 87);
            this.iconPictureBox1.TabIndex = 2;
            this.iconPictureBox1.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(98, 82);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(543, 23);
            this.label2.TabIndex = 1;
            this.label2.Text = "Track client decisions and define the work plan for accepted contracts.";
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(97, 18);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(192, 45);
            this.label1.TabIndex = 0;
            this.label1.Text = "Bid Decisions";
            // 
            // myBidsView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "myBidsView";
            this.Size = new System.Drawing.Size(820, 690);
            this.mainContainer.ResumeLayout(false);
            this.guna2TabControl1.ResumeLayout(false);
            this.Accepted.ResumeLayout(false);
            this.Pending.ResumeLayout(false);
            this.Rejected.ResumeLayout(false);
            this.headContainer.ResumeLayout(false);
            this.headContainer.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.iconPictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2TabControl guna2TabControl1;
        private System.Windows.Forms.TabPage Accepted;
        private System.Windows.Forms.TabPage Pending;
        private Guna.UI2.WinForms.Guna2Panel headContainer;
        private FontAwesome.Sharp.IconPictureBox iconPictureBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TabPage Rejected;
        private System.Windows.Forms.FlowLayoutPanel acceptedLayout;
        private System.Windows.Forms.FlowLayoutPanel PendingLayout;
        private System.Windows.Forms.FlowLayoutPanel RejectedLayout;
    }
}
