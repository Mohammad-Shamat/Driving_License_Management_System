namespace DVLD___Driving_License_Management.User
{
    partial class FrmChangePassword
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmChangePassword));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.PanelLoginInfo = new Guna.UI2.WinForms.Guna2Panel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblLoginUser = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.TxtCurrentPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtNewPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.ctrlUserCard1 = new DVLD___Driving_License_Management.User.UserCtrls.CtrlUserCard();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1.SuspendLayout();
            this.PanelLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BackColor = System.Drawing.Color.White;
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.BtnSave);
            this.guna2Panel1.Controls.Add(this.PanelLoginInfo);
            this.guna2Panel1.Controls.Add(this.ctrlUserCard1);
            this.guna2Panel1.Controls.Add(this.BtnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(968, 873);
            this.guna2Panel1.TabIndex = 8;
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
            this.BtnExit.Location = new System.Drawing.Point(911, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 27);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelLoginInfo
            // 
            this.PanelLoginInfo.Controls.Add(this.TxtConfirmPassword);
            this.PanelLoginInfo.Controls.Add(this.TxtNewPassword);
            this.PanelLoginInfo.Controls.Add(this.TxtCurrentPassword);
            this.PanelLoginInfo.Controls.Add(this.guna2HtmlLabel3);
            this.PanelLoginInfo.Controls.Add(this.guna2HtmlLabel1);
            this.PanelLoginInfo.Controls.Add(this.guna2HtmlLabel2);
            this.PanelLoginInfo.Controls.Add(this.LblLoginUser);
            this.PanelLoginInfo.Location = new System.Drawing.Point(33, 579);
            this.PanelLoginInfo.Name = "PanelLoginInfo";
            this.PanelLoginInfo.Size = new System.Drawing.Size(895, 186);
            this.PanelLoginInfo.TabIndex = 3;
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(242, 137);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(168, 27);
            this.guna2HtmlLabel3.TabIndex = 16;
            this.guna2HtmlLabel3.Text = "Confirm Password :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(242, 83);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(137, 27);
            this.guna2HtmlLabel1.TabIndex = 15;
            this.guna2HtmlLabel1.Text = "New Password :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(242, 34);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(163, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "Current Password :";
            // 
            // LblLoginUser
            // 
            this.LblLoginUser.BackColor = System.Drawing.Color.Transparent;
            this.LblLoginUser.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblLoginUser.ForeColor = System.Drawing.Color.Black;
            this.LblLoginUser.IsSelectionEnabled = false;
            this.LblLoginUser.Location = new System.Drawing.Point(3, 3);
            this.LblLoginUser.Name = "LblLoginUser";
            this.LblLoginUser.Size = new System.Drawing.Size(153, 27);
            this.LblLoginUser.TabIndex = 2;
            this.LblLoginUser.Text = "Change Password";
            // 
            // TxtCurrentPassword
            // 
            this.TxtCurrentPassword.Animated = true;
            this.TxtCurrentPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtCurrentPassword.BorderRadius = 8;
            this.TxtCurrentPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtCurrentPassword.DefaultText = "";
            this.TxtCurrentPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtCurrentPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtCurrentPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCurrentPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtCurrentPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtCurrentPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TxtCurrentPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TxtCurrentPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtCurrentPassword.Location = new System.Drawing.Point(412, 25);
            this.TxtCurrentPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtCurrentPassword.Name = "TxtCurrentPassword";
            this.TxtCurrentPassword.PasswordChar = '*';
            this.TxtCurrentPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtCurrentPassword.PlaceholderText = "Current Password";
            this.TxtCurrentPassword.SelectedText = "";
            this.TxtCurrentPassword.Size = new System.Drawing.Size(160, 36);
            this.TxtCurrentPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtCurrentPassword.TabIndex = 17;
            this.TxtCurrentPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtCurrentPassword_Validating);
            // 
            // TxtNewPassword
            // 
            this.TxtNewPassword.Animated = true;
            this.TxtNewPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtNewPassword.BorderRadius = 8;
            this.TxtNewPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtNewPassword.DefaultText = "";
            this.TxtNewPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtNewPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtNewPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtNewPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtNewPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TxtNewPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TxtNewPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtNewPassword.Location = new System.Drawing.Point(412, 73);
            this.TxtNewPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtNewPassword.Name = "TxtNewPassword";
            this.TxtNewPassword.PasswordChar = '*';
            this.TxtNewPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtNewPassword.PlaceholderText = "New Password";
            this.TxtNewPassword.SelectedText = "";
            this.TxtNewPassword.Size = new System.Drawing.Size(160, 36);
            this.TxtNewPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtNewPassword.TabIndex = 18;
            this.TxtNewPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtNewPassword_Validating);
            // 
            // TxtConfirmPassword
            // 
            this.TxtConfirmPassword.Animated = true;
            this.TxtConfirmPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtConfirmPassword.BorderRadius = 8;
            this.TxtConfirmPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtConfirmPassword.DefaultText = "";
            this.TxtConfirmPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtConfirmPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtConfirmPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtConfirmPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtConfirmPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TxtConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TxtConfirmPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtConfirmPassword.Location = new System.Drawing.Point(417, 128);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtConfirmPassword.PlaceholderText = "Confirm Password";
            this.TxtConfirmPassword.SelectedText = "";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(160, 36);
            this.TxtConfirmPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtConfirmPassword.TabIndex = 19;
            this.TxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassword_Validating);
            // 
            // ctrlUserCard1
            // 
            this.ctrlUserCard1.BackColor = System.Drawing.Color.White;
            this.ctrlUserCard1.Location = new System.Drawing.Point(33, 45);
            this.ctrlUserCard1.Name = "ctrlUserCard1";
            this.ctrlUserCard1.Size = new System.Drawing.Size(895, 528);
            this.ctrlUserCard1.TabIndex = 2;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // BtnSave
            // 
            this.BtnSave.Animated = true;
            this.BtnSave.BorderRadius = 6;
            this.BtnSave.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSave.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnSave.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnSave.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnSave.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnSave.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.BtnSave.ForeColor = System.Drawing.Color.White;
            this.BtnSave.HoverState.FillColor = System.Drawing.Color.MediumSeaGreen;
            this.BtnSave.HoverState.ForeColor = System.Drawing.Color.Black;
            this.BtnSave.HoverState.Image = global::DVLD___Driving_License_Management.Properties.Resources.save1;
            this.BtnSave.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnSave.Location = new System.Drawing.Point(748, 807);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(180, 45);
            this.BtnSave.TabIndex = 27;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // FrmChangePassword
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(968, 873);
            this.Controls.Add(this.guna2Panel1);
            this.ForeColor = System.Drawing.Color.Black;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmChangePassword";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmChangePassword";
            this.Load += new System.EventHandler(this.FrmChangePassword_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.PanelLoginInfo.ResumeLayout(false);
            this.PanelLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private UserCtrls.CtrlUserCard ctrlUserCard1;
        private Guna.UI2.WinForms.Guna2Panel PanelLoginInfo;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblLoginUser;
        private Guna.UI2.WinForms.Guna2TextBox TxtNewPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtCurrentPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
    }
}