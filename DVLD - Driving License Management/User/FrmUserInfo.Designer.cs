namespace DVLD___Driving_License_Management.User
{
    partial class FrmUserInfo
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
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlUserCard1 = new DVLD___Driving_License_Management.User.UserCtrls.CtrlUserCard();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.ctrlUserCard1);
            this.guna2Panel1.Controls.Add(this.BtnClose);
            this.guna2Panel1.Controls.Add(this.LblTitle);
            this.guna2Panel1.Controls.Add(this.BtnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(914, 680);
            this.guna2Panel1.TabIndex = 30;
            // 
            // BtnClose
            // 
            this.BtnClose.Animated = true;
            this.BtnClose.BorderRadius = 6;
            this.BtnClose.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.BtnClose.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnClose.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnClose.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnClose.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnClose.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnClose.ForeColor = System.Drawing.Color.White;
            this.BtnClose.HoverState.FillColor = System.Drawing.Color.Crimson;
            this.BtnClose.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnClose.HoverState.Image = global::DVLD___Driving_License_Management.Properties.Resources.cross__1_1;
            this.BtnClose.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnClose.Location = new System.Drawing.Point(722, 610);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(180, 45);
            this.BtnClose.TabIndex = 32;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblTitle.Location = new System.Drawing.Point(365, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(128, 37);
            this.LblTitle.TabIndex = 31;
            this.LblTitle.Text = "User Info";
            // 
            // BtnExit
            // 
            this.BtnExit.Animated = true;
            this.BtnExit.AutoRoundedCorners = true;
            this.BtnExit.BackColor = System.Drawing.Color.Transparent;
            this.BtnExit.BorderColor = System.Drawing.Color.Transparent;
            this.BtnExit.BorderRadius = 12;
            this.BtnExit.CausesValidation = false;
            this.BtnExit.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnExit.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnExit.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnExit.FillColor = System.Drawing.Color.Transparent;
            this.BtnExit.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnExit.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnExit.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtnExit.HoverState.Image = global::DVLD___Driving_License_Management.Properties.Resources.cross;
            this.BtnExit.Image = global::DVLD___Driving_License_Management.Properties.Resources.app;
            this.BtnExit.Location = new System.Drawing.Point(870, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 27);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.Click += new System.EventHandler(this.BtnClose_Click);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(9, 61);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(895, 528);
            this.ctrlUserCard1.TabIndex = 33;
            // 
            // FrmUserInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(914, 680);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserInfo";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserInfo";
            this.Load += new System.EventHandler(this.FrmUserInfo_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private UserCtrls.CtrlUserCard ctrlUserCard1;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
    }
}