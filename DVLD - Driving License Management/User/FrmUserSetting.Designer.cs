namespace DVLD___Driving_License_Management.User
{
    partial class FrmUserSetting
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
            this.components = new System.ComponentModel.Container();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnUserInfo = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.BtnChangePassord = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.BtnChangePassord);
            this.guna2Panel1.Controls.Add(this.BtnUserInfo);
            this.guna2Panel1.Controls.Add(this.BtnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(400, 200);
            this.guna2Panel1.TabIndex = 31;
            // 
            // BtnUserInfo
            // 
            this.BtnUserInfo.Animated = true;
            this.BtnUserInfo.AutoRoundedCorners = true;
            this.BtnUserInfo.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserInfo.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnUserInfo.BorderRadius = 24;
            this.BtnUserInfo.CustomBorderColor = System.Drawing.Color.White;
            this.BtnUserInfo.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.dashboards;
            this.BtnUserInfo.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUserInfo.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnUserInfo.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUserInfo.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUserInfo.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUserInfo.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUserInfo.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnUserInfo.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnUserInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnUserInfo.Location = new System.Drawing.Point(86, 46);
            this.BtnUserInfo.Name = "BtnUserInfo";
            this.BtnUserInfo.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnUserInfo.Size = new System.Drawing.Size(250, 50);
            this.BtnUserInfo.TabIndex = 31;
            this.BtnUserInfo.Text = "User Info";
            this.BtnUserInfo.Click += new System.EventHandler(this.BtnUserInfo_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(356, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 27);
            this.BtnExit.TabIndex = 30;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // BtnChangePassord
            // 
            this.BtnChangePassord.Animated = true;
            this.BtnChangePassord.AutoRoundedCorners = true;
            this.BtnChangePassord.BackColor = System.Drawing.Color.Transparent;
            this.BtnChangePassord.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnChangePassord.BorderRadius = 24;
            this.BtnChangePassord.CustomBorderColor = System.Drawing.Color.White;
            this.BtnChangePassord.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.dashboards;
            this.BtnChangePassord.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnChangePassord.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnChangePassord.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangePassord.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnChangePassord.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnChangePassord.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnChangePassord.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnChangePassord.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnChangePassord.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnChangePassord.Location = new System.Drawing.Point(86, 115);
            this.BtnChangePassord.Name = "BtnChangePassord";
            this.BtnChangePassord.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnChangePassord.Size = new System.Drawing.Size(250, 50);
            this.BtnChangePassord.TabIndex = 32;
            this.BtnChangePassord.Text = "Change Password";
            this.BtnChangePassord.Click += new System.EventHandler(this.BtnChangePassord_Click);
            // 
            // FrmUserSetting
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 200);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmUserSetting";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmUserSetting";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Button BtnUserInfo;
        private Guna.UI2.WinForms.Guna2Button BtnChangePassord;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
    }
}