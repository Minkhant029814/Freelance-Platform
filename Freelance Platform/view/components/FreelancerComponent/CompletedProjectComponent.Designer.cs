namespace Freelance_Platform.view.components.FreelancerComponent
{
    partial class CompletedProjectComponent
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
            this.CompletedProjectLayout = new System.Windows.Forms.FlowLayoutPanel();
            this.mainContainer.SuspendLayout();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.CompletedProjectLayout);
            this.mainContainer.FillColor = System.Drawing.Color.White;
            this.mainContainer.Location = new System.Drawing.Point(17, 15);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(941, 383);
            this.mainContainer.TabIndex = 1;
            // 
            // CompletedProjectLayout
            // 
            this.CompletedProjectLayout.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.CompletedProjectLayout.AutoScroll = true;
            this.CompletedProjectLayout.BackColor = System.Drawing.Color.Silver;
            this.CompletedProjectLayout.FlowDirection = System.Windows.Forms.FlowDirection.TopDown;
            this.CompletedProjectLayout.Location = new System.Drawing.Point(22, 29);
            this.CompletedProjectLayout.Name = "CompletedProjectLayout";
            this.CompletedProjectLayout.Size = new System.Drawing.Size(897, 332);
            this.CompletedProjectLayout.TabIndex = 0;
            this.CompletedProjectLayout.WrapContents = false;
            this.CompletedProjectLayout.Resize += new System.EventHandler(this.CompletedProjectLayout_Resize);
            // 
            // CompletedProjectComponent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "CompletedProjectComponent";
            this.Size = new System.Drawing.Size(988, 413);
            this.mainContainer.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private System.Windows.Forms.FlowLayoutPanel CompletedProjectLayout;
    }
}
