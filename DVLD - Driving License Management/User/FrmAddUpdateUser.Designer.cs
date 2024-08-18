namespace DVLD___Driving_License_Management.User
{
    partial class FrmAddUpdateUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmAddUpdateUser));
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnClose = new Guna.UI2.WinForms.Guna2Button();
            this.BtnSave = new Guna.UI2.WinForms.Guna2Button();
            this.TCUserInfo = new Guna.UI2.WinForms.Guna2TabControl();
            this.TPPersonInfo = new System.Windows.Forms.TabPage();
            this.BtnNext = new Guna.UI2.WinForms.Guna2Button();
            this.ctrlPersonWithFilter1 = new DVLD___Driving_License_Management.People.Controls.CtrlPersonWithFilter();
            this.TPLoginInfo = new System.Windows.Forms.TabPage();
            this.LblUserID = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ChBIsActive = new Guna.UI2.WinForms.Guna2CheckBox();
            this.TxtConfirmPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.TxtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.guna2HtmlLabel4 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel3 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.guna2HtmlLabel2 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.guna2Panel1.SuspendLayout();
            this.TCUserInfo.SuspendLayout();
            this.TPPersonInfo.SuspendLayout();
            this.TPLoginInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.BtnClose);
            this.guna2Panel1.Controls.Add(this.BtnSave);
            this.guna2Panel1.Controls.Add(this.TCUserInfo);
            this.guna2Panel1.Controls.Add(this.LblTitle);
            this.guna2Panel1.Controls.Add(this.BtnExit);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(934, 743);
            this.guna2Panel1.TabIndex = 7;
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
            this.BtnClose.Location = new System.Drawing.Point(553, 686);
            this.BtnClose.Name = "BtnClose";
            this.BtnClose.Size = new System.Drawing.Size(180, 45);
            this.BtnClose.TabIndex = 27;
            this.BtnClose.Text = "Close";
            this.BtnClose.Click += new System.EventHandler(this.BtnClose_Click);
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
            this.BtnSave.Location = new System.Drawing.Point(739, 686);
            this.BtnSave.Name = "BtnSave";
            this.BtnSave.Size = new System.Drawing.Size(180, 45);
            this.BtnSave.TabIndex = 26;
            this.BtnSave.Text = "Save";
            this.BtnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // TCUserInfo
            // 
            this.TCUserInfo.Controls.Add(this.TPPersonInfo);
            this.TCUserInfo.Controls.Add(this.TPLoginInfo);
            this.TCUserInfo.ItemSize = new System.Drawing.Size(240, 40);
            this.TCUserInfo.Location = new System.Drawing.Point(12, 70);
            this.TCUserInfo.Name = "TCUserInfo";
            this.TCUserInfo.SelectedIndex = 0;
            this.TCUserInfo.Size = new System.Drawing.Size(911, 610);
            this.TCUserInfo.TabButtonHoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TCUserInfo.TabButtonHoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TCUserInfo.TabButtonHoverState.Font = new System.Drawing.Font("Yu Gothic UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUserInfo.TabButtonHoverState.ForeColor = System.Drawing.Color.White;
            this.TCUserInfo.TabButtonHoverState.InnerColor = System.Drawing.Color.Transparent;
            this.TCUserInfo.TabButtonIdleState.BorderColor = System.Drawing.Color.Empty;
            this.TCUserInfo.TabButtonIdleState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.TCUserInfo.TabButtonIdleState.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUserInfo.TabButtonIdleState.ForeColor = System.Drawing.Color.Black;
            this.TCUserInfo.TabButtonIdleState.InnerColor = System.Drawing.Color.Transparent;
            this.TCUserInfo.TabButtonSelectedState.BorderColor = System.Drawing.Color.Transparent;
            this.TCUserInfo.TabButtonSelectedState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TCUserInfo.TabButtonSelectedState.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TCUserInfo.TabButtonSelectedState.ForeColor = System.Drawing.Color.White;
            this.TCUserInfo.TabButtonSelectedState.InnerColor = System.Drawing.Color.DodgerBlue;
            this.TCUserInfo.TabButtonSize = new System.Drawing.Size(240, 40);
            this.TCUserInfo.TabIndex = 3;
            this.TCUserInfo.TabMenuBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.TCUserInfo.TabMenuOrientation = Guna.UI2.WinForms.TabMenuOrientation.HorizontalTop;
            // 
            // TPPersonInfo
            // 
            this.TPPersonInfo.BackColor = System.Drawing.Color.White;
            this.TPPersonInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPPersonInfo.Controls.Add(this.BtnNext);
            this.TPPersonInfo.Controls.Add(this.ctrlPersonWithFilter1);
            this.TPPersonInfo.Location = new System.Drawing.Point(4, 44);
            this.TPPersonInfo.Name = "TPPersonInfo";
            this.TPPersonInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPPersonInfo.Size = new System.Drawing.Size(903, 562);
            this.TPPersonInfo.TabIndex = 0;
            this.TPPersonInfo.Text = "Personal Info";
            // 
            // BtnNext
            // 
            this.BtnNext.Animated = true;
            this.BtnNext.BorderRadius = 6;
            this.BtnNext.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnNext.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnNext.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnNext.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnNext.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnNext.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F);
            this.BtnNext.ForeColor = System.Drawing.Color.Black;
            this.BtnNext.HoverState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnNext.HoverState.Font = new System.Drawing.Font("Yu Gothic UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BtnNext.HoverState.ForeColor = System.Drawing.Color.White;
            this.BtnNext.HoverState.Image = global::DVLD___Driving_License_Management.Properties.Resources.right_chevron___1_;
            this.BtnNext.ImageAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.BtnNext.ImageSize = new System.Drawing.Size(25, 25);
            this.BtnNext.Location = new System.Drawing.Point(715, 511);
            this.BtnNext.Name = "BtnNext";
            this.BtnNext.Size = new System.Drawing.Size(180, 45);
            this.BtnNext.TabIndex = 27;
            this.BtnNext.Text = "Next";
            this.BtnNext.Click += new System.EventHandler(this.BtnNext_Click);
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonWithFilter1.FilterEnabled = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(6, 6);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.ShowAddPerson = true;
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(889, 515);
            this.ctrlPersonWithFilter1.TabIndex = 0;
            // 
            // TPLoginInfo
            // 
            this.TPLoginInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TPLoginInfo.Controls.Add(this.LblUserID);
            this.TPLoginInfo.Controls.Add(this.ChBIsActive);
            this.TPLoginInfo.Controls.Add(this.TxtConfirmPassword);
            this.TPLoginInfo.Controls.Add(this.TxtPassword);
            this.TPLoginInfo.Controls.Add(this.TxtUserName);
            this.TPLoginInfo.Controls.Add(this.guna2HtmlLabel4);
            this.TPLoginInfo.Controls.Add(this.guna2HtmlLabel3);
            this.TPLoginInfo.Controls.Add(this.guna2HtmlLabel1);
            this.TPLoginInfo.Controls.Add(this.guna2HtmlLabel2);
            this.TPLoginInfo.Location = new System.Drawing.Point(4, 44);
            this.TPLoginInfo.Name = "TPLoginInfo";
            this.TPLoginInfo.Padding = new System.Windows.Forms.Padding(3);
            this.TPLoginInfo.Size = new System.Drawing.Size(903, 562);
            this.TPLoginInfo.TabIndex = 1;
            this.TPLoginInfo.Text = "Login Info";
            this.TPLoginInfo.UseVisualStyleBackColor = true;
            // 
            // LblUserID
            // 
            this.LblUserID.BackColor = System.Drawing.Color.Transparent;
            this.LblUserID.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblUserID.IsSelectionEnabled = false;
            this.LblUserID.Location = new System.Drawing.Point(217, 68);
            this.LblUserID.Name = "LblUserID";
            this.LblUserID.Size = new System.Drawing.Size(75, 27);
            this.LblUserID.TabIndex = 12;
            this.LblUserID.Text = "No Data";
            // 
            // ChBIsActive
            // 
            this.ChBIsActive.Animated = true;
            this.ChBIsActive.AutoSize = true;
            this.ChBIsActive.CheckedState.BorderColor = System.Drawing.Color.DodgerBlue;
            this.ChBIsActive.CheckedState.BorderRadius = 4;
            this.ChBIsActive.CheckedState.BorderThickness = 1;
            this.ChBIsActive.CheckedState.FillColor = System.Drawing.Color.DodgerBlue;
            this.ChBIsActive.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 11.25F, System.Drawing.FontStyle.Bold);
            this.ChBIsActive.Location = new System.Drawing.Point(217, 291);
            this.ChBIsActive.Name = "ChBIsActive";
            this.ChBIsActive.Size = new System.Drawing.Size(84, 24);
            this.ChBIsActive.TabIndex = 11;
            this.ChBIsActive.Text = "Is Active";
            this.ChBIsActive.UncheckedState.BorderColor = System.Drawing.Color.Black;
            this.ChBIsActive.UncheckedState.BorderRadius = 4;
            this.ChBIsActive.UncheckedState.BorderThickness = 1;
            this.ChBIsActive.UncheckedState.FillColor = System.Drawing.Color.White;
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
            this.TxtConfirmPassword.Location = new System.Drawing.Point(217, 217);
            this.TxtConfirmPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtConfirmPassword.Name = "TxtConfirmPassword";
            this.TxtConfirmPassword.PasswordChar = '*';
            this.TxtConfirmPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtConfirmPassword.PlaceholderText = "Confirm Password";
            this.TxtConfirmPassword.SelectedText = "";
            this.TxtConfirmPassword.Size = new System.Drawing.Size(160, 36);
            this.TxtConfirmPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtConfirmPassword.TabIndex = 10;
            this.TxtConfirmPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtConfirmPassword_Validating);
            // 
            // TxtPassword
            // 
            this.TxtPassword.Animated = true;
            this.TxtPassword.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPassword.BorderRadius = 8;
            this.TxtPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtPassword.DefaultText = "";
            this.TxtPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtPassword.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TxtPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TxtPassword.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtPassword.Location = new System.Drawing.Point(217, 163);
            this.TxtPassword.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtPassword.Name = "TxtPassword";
            this.TxtPassword.PasswordChar = '*';
            this.TxtPassword.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtPassword.PlaceholderText = "Password";
            this.TxtPassword.SelectedText = "";
            this.TxtPassword.Size = new System.Drawing.Size(160, 36);
            this.TxtPassword.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtPassword.TabIndex = 9;
            this.TxtPassword.Validating += new System.ComponentModel.CancelEventHandler(this.TxtPassword_Validating);
            // 
            // TxtUserName
            // 
            this.TxtUserName.Animated = true;
            this.TxtUserName.BorderColor = System.Drawing.Color.Transparent;
            this.TxtUserName.BorderRadius = 8;
            this.TxtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.TxtUserName.DefaultText = "";
            this.TxtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.TxtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.TxtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.TxtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.TxtUserName.Font = new System.Drawing.Font("Yu Gothic UI", 12F);
            this.TxtUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.TxtUserName.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.TxtUserName.Location = new System.Drawing.Point(217, 109);
            this.TxtUserName.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.TxtUserName.Name = "TxtUserName";
            this.TxtUserName.PasswordChar = '\0';
            this.TxtUserName.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(157)))), ((int)(((byte)(178)))), ((int)(((byte)(191)))));
            this.TxtUserName.PlaceholderText = "UserName";
            this.TxtUserName.SelectedText = "";
            this.TxtUserName.Size = new System.Drawing.Size(160, 36);
            this.TxtUserName.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.TxtUserName.TabIndex = 8;
            this.TxtUserName.Validating += new System.ComponentModel.CancelEventHandler(this.TxtUserName_Validating);
            // 
            // guna2HtmlLabel4
            // 
            this.guna2HtmlLabel4.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel4.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel4.IsSelectionEnabled = false;
            this.guna2HtmlLabel4.Location = new System.Drawing.Point(12, 217);
            this.guna2HtmlLabel4.Name = "guna2HtmlLabel4";
            this.guna2HtmlLabel4.Size = new System.Drawing.Size(168, 27);
            this.guna2HtmlLabel4.TabIndex = 7;
            this.guna2HtmlLabel4.Text = "Confirm Password :";
            // 
            // guna2HtmlLabel3
            // 
            this.guna2HtmlLabel3.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel3.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel3.IsSelectionEnabled = false;
            this.guna2HtmlLabel3.Location = new System.Drawing.Point(87, 169);
            this.guna2HtmlLabel3.Name = "guna2HtmlLabel3";
            this.guna2HtmlLabel3.Size = new System.Drawing.Size(93, 27);
            this.guna2HtmlLabel3.TabIndex = 6;
            this.guna2HtmlLabel3.Text = "Password :";
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.IsSelectionEnabled = false;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(72, 118);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(108, 27);
            this.guna2HtmlLabel1.TabIndex = 5;
            this.guna2HtmlLabel1.Text = "User Name :";
            // 
            // guna2HtmlLabel2
            // 
            this.guna2HtmlLabel2.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel2.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel2.IsSelectionEnabled = false;
            this.guna2HtmlLabel2.Location = new System.Drawing.Point(104, 68);
            this.guna2HtmlLabel2.Name = "guna2HtmlLabel2";
            this.guna2HtmlLabel2.Size = new System.Drawing.Size(76, 27);
            this.guna2HtmlLabel2.TabIndex = 4;
            this.guna2HtmlLabel2.Text = "User ID :";
            // 
            // LblTitle
            // 
            this.LblTitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblTitle.Location = new System.Drawing.Point(373, 12);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(191, 37);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Add New User";
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
            this.BtnExit.Location = new System.Drawing.Point(891, 12);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 27);
            this.BtnExit.TabIndex = 1;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // FrmAddUpdateUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(934, 743);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "FrmAddUpdateUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "FrmAddUpdateUser";
            this.Load += new System.EventHandler(this.FrmAddUpdateUser_Load);
            this.guna2Panel1.ResumeLayout(false);
            this.guna2Panel1.PerformLayout();
            this.TCUserInfo.ResumeLayout(false);
            this.TPPersonInfo.ResumeLayout(false);
            this.TPLoginInfo.ResumeLayout(false);
            this.TPLoginInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private System.Windows.Forms.Label LblTitle;
        private Guna.UI2.WinForms.Guna2TabControl TCUserInfo;
        private System.Windows.Forms.TabPage TPPersonInfo;
        private People.Controls.CtrlPersonWithFilter ctrlPersonWithFilter1;
        private System.Windows.Forms.TabPage TPLoginInfo;
        private Guna.UI2.WinForms.Guna2Button BtnClose;
        private Guna.UI2.WinForms.Guna2Button BtnSave;
        private Guna.UI2.WinForms.Guna2Button BtnNext;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel2;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel4;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel3;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2TextBox TxtConfirmPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtPassword;
        private Guna.UI2.WinForms.Guna2TextBox TxtUserName;
        private Guna.UI2.WinForms.Guna2CheckBox ChBIsActive;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblUserID;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}