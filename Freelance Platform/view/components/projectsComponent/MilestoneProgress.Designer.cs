namespace Freelance_Platform.view.components.projectsComponent
{
    partial class MilestoneProgress
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
            this.btnUpdateProgress = new Guna.UI2.WinForms.Guna2Button();
            this.numProgressValue = new Guna.UI2.WinForms.Guna2NumericUpDown();
            this.iconBtn = new FontAwesome.Sharp.IconButton();
            this.lblProgressValue = new System.Windows.Forms.Label();
            this.lblMileStonetile = new System.Windows.Forms.Label();
            this.mainContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numProgressValue)).BeginInit();
            this.SuspendLayout();
            // 
            // mainContainer
            // 
            this.mainContainer.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.mainContainer.BorderRadius = 15;
            this.mainContainer.Controls.Add(this.btnUpdateProgress);
            this.mainContainer.Controls.Add(this.numProgressValue);
            this.mainContainer.Controls.Add(this.iconBtn);
            this.mainContainer.Controls.Add(this.lblProgressValue);
            this.mainContainer.Controls.Add(this.lblMileStonetile);
            this.mainContainer.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(192)))));
            this.mainContainer.Location = new System.Drawing.Point(14, 16);
            this.mainContainer.Name = "mainContainer";
            this.mainContainer.Size = new System.Drawing.Size(1003, 226);
            this.mainContainer.TabIndex = 0;
            // 
            // btnUpdateProgress
            // 
            this.btnUpdateProgress.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btnUpdateProgress.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProgress.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnUpdateProgress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnUpdateProgress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnUpdateProgress.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.btnUpdateProgress.ForeColor = System.Drawing.Color.White;
            this.btnUpdateProgress.Location = new System.Drawing.Point(740, 159);
            this.btnUpdateProgress.Name = "btnUpdateProgress";
            this.btnUpdateProgress.Size = new System.Drawing.Size(220, 45);
            this.btnUpdateProgress.TabIndex = 4;
            this.btnUpdateProgress.Text = "Update Progress";
            this.btnUpdateProgress.Click += new System.EventHandler(this.btnSaveProgress_Click);
            // 
            // numProgressValue
            // 
            this.numProgressValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.numProgressValue.BackColor = System.Drawing.Color.Transparent;
            this.numProgressValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.numProgressValue.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.numProgressValue.Location = new System.Drawing.Point(852, 71);
            this.numProgressValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numProgressValue.Name = "numProgressValue";
            this.numProgressValue.Size = new System.Drawing.Size(108, 48);
            this.numProgressValue.TabIndex = 3;
            this.numProgressValue.UpDownButtonFillColor = System.Drawing.Color.Lime;
            this.numProgressValue.ValueChanged += new System.EventHandler(this.numProgressValue_ValueChanged);
            // 
            // iconBtn
            // 
            this.iconBtn.IconChar = FontAwesome.Sharp.IconChar.None;
            this.iconBtn.IconColor = System.Drawing.Color.Black;
            this.iconBtn.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.iconBtn.Location = new System.Drawing.Point(21, 59);
            this.iconBtn.Name = "iconBtn";
            this.iconBtn.Size = new System.Drawing.Size(41, 37);
            this.iconBtn.TabIndex = 2;
            this.iconBtn.UseVisualStyleBackColor = true;
            // 
            // lblProgressValue
            // 
            this.lblProgressValue.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.lblProgressValue.Font = new System.Drawing.Font("Segoe UI", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblProgressValue.Location = new System.Drawing.Point(578, 71);
            this.lblProgressValue.Name = "lblProgressValue";
            this.lblProgressValue.Size = new System.Drawing.Size(222, 42);
            this.lblProgressValue.TabIndex = 1;
            this.lblProgressValue.Text = "label2";
            // 
            // lblMileStonetile
            // 
            this.lblMileStonetile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.lblMileStonetile.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblMileStonetile.Location = new System.Drawing.Point(80, 59);
            this.lblMileStonetile.Name = "lblMileStonetile";
            this.lblMileStonetile.Size = new System.Drawing.Size(449, 105);
            this.lblMileStonetile.TabIndex = 0;
            this.lblMileStonetile.Text = "label1";
            // 
            // MilestoneProgress
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.mainContainer);
            this.Name = "MilestoneProgress";
            this.Size = new System.Drawing.Size(1036, 259);
            this.mainContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.numProgressValue)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel mainContainer;
        private Guna.UI2.WinForms.Guna2NumericUpDown numProgressValue;
        private FontAwesome.Sharp.IconButton iconBtn;
        private System.Windows.Forms.Label lblProgressValue;
        private System.Windows.Forms.Label lblMileStonetile;
        private Guna.UI2.WinForms.Guna2Button btnUpdateProgress;
    }
}
