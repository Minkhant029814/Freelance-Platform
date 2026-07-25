namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class OngoingProjectComponent
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
            this.ongoingProjectLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.ongoingProjectLayout);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(18, 27);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(941, 452);
            this.mainContainer.TabIndex = 0;
            // 
            // ongoingProjectLayout
            // 
            this.ongoingProjectLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.ongoingProjectLayout.AutoScroll = true;
            this.ongoingProjectLayout.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.ongoingProjectLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.ongoingProjectLayout.Location = new System.Drawing.Point(22, 29);
            this.ongoingProjectLayout.Name = "ongoingProjectLayout";
            this.ongoingProjectLayout.Size = new System.Drawing.Size(897, 401);
            this.ongoingProjectLayout.TabIndex = 0;
            this.ongoingProjectLayout.WrapContents = false;
            this.ongoingProjectLayout.Resize += new System.EventHandler(this.ongoingProjectLayout_Resize);
            // 
            // OngoingProjectComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "OngoingProjectComponent";
            this.Size = new System.Drawing.Size(979, 495);
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel ongoingProjectLayout;
    }
}
