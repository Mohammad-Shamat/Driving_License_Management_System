namespace DVLD___Driving_License_Management
{
    partial class FrmMain
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmMain));
            this.panel1 = new System.Windows.Forms.Panel();
            this.BtnLogout = new Guna.UI2.WinForms.Guna2Button();
            this.BtnUsers = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDrivers = new Guna.UI2.WinForms.Guna2Button();
            this.BtnPeople = new Guna.UI2.WinForms.Guna2Button();
            this.BtnApplications = new Guna.UI2.WinForms.Guna2Button();
            this.BtnDashboard = new Guna.UI2.WinForms.Guna2Button();
            this.PanelLogo = new System.Windows.Forms.Panel();
            this.guna2PictureBox3 = new Guna.UI2.WinForms.Guna2PictureBox();
            this.PBLogo = new Guna.UI2.WinForms.Guna2PictureBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.LblDay = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblDate = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.LblTime = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.PanelUser = new Guna.UI2.WinForms.Guna2Panel();
            this.BtnUserSetting = new Guna.UI2.WinForms.Guna2CircleButton();
            this.lblUser = new System.Windows.Forms.Label();
            this.lblNameUser = new System.Windows.Forms.Label();
            this.PBUser = new Guna.UI2.WinForms.Guna2PictureBox();
            this.BtnMinimize = new Guna.UI2.WinForms.Guna2Button();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.PanelMain = new System.Windows.Forms.Panel();
            this.ctrlDashboard1 = new DVLD___Driving_License_Management.MainScreen.CtrlDashboard();
            this.guna2Elipse1 = new Guna.UI2.WinForms.Guna2Elipse(this.components);
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.panel1.SuspendLayout();
            this.PanelLogo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).BeginInit();
            this.panel2.SuspendLayout();
            this.PanelUser.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).BeginInit();
            this.PanelMain.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel1.Controls.Add(this.BtnLogout);
            this.panel1.Controls.Add(this.BtnUsers);
            this.panel1.Controls.Add(this.BtnDrivers);
            this.panel1.Controls.Add(this.BtnPeople);
            this.panel1.Controls.Add(this.BtnApplications);
            this.panel1.Controls.Add(this.BtnDashboard);
            this.panel1.Controls.Add(this.PanelLogo);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 1000);
            this.panel1.TabIndex = 0;
            // 
            // BtnLogout
            // 
            this.BtnLogout.Animated = true;
            this.BtnLogout.AutoRoundedCorners = true;
            this.BtnLogout.BackColor = System.Drawing.Color.Transparent;
            this.BtnLogout.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogout.BorderRadius = 27;
            this.BtnLogout.CustomBorderColor = System.Drawing.Color.White;
            this.BtnLogout.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.logout;
            this.BtnLogout.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnLogout.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnLogout.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnLogout.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnLogout.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnLogout.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.BtnLogout.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnLogout.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnLogout.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnLogout.Location = new System.Drawing.Point(0, 943);
            this.BtnLogout.Margin = new System.Windows.Forms.Padding(3, 3, 3, 57);
            this.BtnLogout.Name = "BtnLogout";
            this.BtnLogout.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnLogout.Size = new System.Drawing.Size(249, 57);
            this.BtnLogout.TabIndex = 11;
            this.BtnLogout.Text = "Logout";
            // 
            // BtnUsers
            // 
            this.BtnUsers.Animated = true;
            this.BtnUsers.AutoRoundedCorners = true;
            this.BtnUsers.BackColor = System.Drawing.Color.Transparent;
            this.BtnUsers.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnUsers.BorderRadius = 27;
            this.BtnUsers.CustomBorderColor = System.Drawing.Color.White;
            this.BtnUsers.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.team;
            this.BtnUsers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnUsers.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnUsers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUsers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUsers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUsers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUsers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnUsers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnUsers.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnUsers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnUsers.Location = new System.Drawing.Point(0, 441);
            this.BtnUsers.Name = "BtnUsers";
            this.BtnUsers.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnUsers.Size = new System.Drawing.Size(249, 57);
            this.BtnUsers.TabIndex = 10;
            this.BtnUsers.Text = "Users";
            this.BtnUsers.Click += new System.EventHandler(this.BtnUsers_Click);
            // 
            // BtnDrivers
            // 
            this.BtnDrivers.Animated = true;
            this.BtnDrivers.AutoRoundedCorners = true;
            this.BtnDrivers.BackColor = System.Drawing.Color.Transparent;
            this.BtnDrivers.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnDrivers.BorderRadius = 27;
            this.BtnDrivers.CustomBorderColor = System.Drawing.Color.White;
            this.BtnDrivers.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.license;
            this.BtnDrivers.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDrivers.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnDrivers.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDrivers.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDrivers.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDrivers.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDrivers.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDrivers.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnDrivers.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnDrivers.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnDrivers.Location = new System.Drawing.Point(0, 384);
            this.BtnDrivers.Name = "BtnDrivers";
            this.BtnDrivers.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnDrivers.Size = new System.Drawing.Size(249, 57);
            this.BtnDrivers.TabIndex = 9;
            this.BtnDrivers.Text = "Drivers";
            // 
            // BtnPeople
            // 
            this.BtnPeople.Animated = true;
            this.BtnPeople.AutoRoundedCorners = true;
            this.BtnPeople.BackColor = System.Drawing.Color.Transparent;
            this.BtnPeople.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnPeople.BorderRadius = 27;
            this.BtnPeople.CustomBorderColor = System.Drawing.Color.White;
            this.BtnPeople.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.people;
            this.BtnPeople.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnPeople.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnPeople.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnPeople.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnPeople.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnPeople.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnPeople.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnPeople.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnPeople.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnPeople.Location = new System.Drawing.Point(0, 327);
            this.BtnPeople.Name = "BtnPeople";
            this.BtnPeople.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnPeople.Size = new System.Drawing.Size(249, 57);
            this.BtnPeople.TabIndex = 8;
            this.BtnPeople.Text = "People";
            this.BtnPeople.Click += new System.EventHandler(this.BtnPeople_Click);
            // 
            // BtnApplications
            // 
            this.BtnApplications.Animated = true;
            this.BtnApplications.AutoRoundedCorners = true;
            this.BtnApplications.BackColor = System.Drawing.Color.Transparent;
            this.BtnApplications.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnApplications.BorderRadius = 27;
            this.BtnApplications.CustomBorderColor = System.Drawing.Color.White;
            this.BtnApplications.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.form;
            this.BtnApplications.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnApplications.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnApplications.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnApplications.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnApplications.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnApplications.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnApplications.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnApplications.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnApplications.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnApplications.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnApplications.Location = new System.Drawing.Point(0, 270);
            this.BtnApplications.Name = "BtnApplications";
            this.BtnApplications.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnApplications.Size = new System.Drawing.Size(249, 57);
            this.BtnApplications.TabIndex = 7;
            this.BtnApplications.Text = "Applications";
            this.BtnApplications.Click += new System.EventHandler(this.BtnApplications_Click);
            // 
            // BtnDashboard
            // 
            this.BtnDashboard.Animated = true;
            this.BtnDashboard.AutoRoundedCorners = true;
            this.BtnDashboard.BackColor = System.Drawing.Color.Transparent;
            this.BtnDashboard.BorderColor = System.Drawing.Color.DodgerBlue;
            this.BtnDashboard.BorderRadius = 27;
            this.BtnDashboard.CustomBorderColor = System.Drawing.Color.White;
            this.BtnDashboard.CustomImages.Image = global::DVLD___Driving_License_Management.Properties.Resources.dashboards;
            this.BtnDashboard.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Left;
            this.BtnDashboard.CustomImages.ImageOffset = new System.Drawing.Point(15, 0);
            this.BtnDashboard.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnDashboard.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnDashboard.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnDashboard.Dock = System.Windows.Forms.DockStyle.Top;
            this.BtnDashboard.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.BtnDashboard.Font = new System.Drawing.Font("Yu Gothic UI", 14.25F, System.Drawing.FontStyle.Bold);
            this.BtnDashboard.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.BtnDashboard.Location = new System.Drawing.Point(0, 213);
            this.BtnDashboard.Name = "BtnDashboard";
            this.BtnDashboard.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnDashboard.Size = new System.Drawing.Size(249, 57);
            this.BtnDashboard.TabIndex = 6;
            this.BtnDashboard.Text = "Dashboard";
            this.BtnDashboard.Click += new System.EventHandler(this.BtnDashboard_Click);
            // 
            // PanelLogo
            // 
            this.PanelLogo.Controls.Add(this.guna2PictureBox3);
            this.PanelLogo.Controls.Add(this.PBLogo);
            this.PanelLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelLogo.Location = new System.Drawing.Point(0, 0);
            this.PanelLogo.Name = "PanelLogo";
            this.PanelLogo.Size = new System.Drawing.Size(249, 213);
            this.PanelLogo.TabIndex = 0;
            // 
            // guna2PictureBox3
            // 
            this.guna2PictureBox3.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.guna2PictureBox3.Image = global::DVLD___Driving_License_Management.Properties.Resources.horizontal_rule;
            this.guna2PictureBox3.ImageRotate = 0F;
            this.guna2PictureBox3.Location = new System.Drawing.Point(0, 180);
            this.guna2PictureBox3.Name = "guna2PictureBox3";
            this.guna2PictureBox3.Size = new System.Drawing.Size(249, 33);
            this.guna2PictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.guna2PictureBox3.TabIndex = 0;
            this.guna2PictureBox3.TabStop = false;
            // 
            // PBLogo
            // 
            this.PBLogo.BackColor = System.Drawing.Color.Transparent;
            this.PBLogo.Dock = System.Windows.Forms.DockStyle.Top;
            this.PBLogo.Image = global::DVLD___Driving_License_Management.Properties.Resources.Driving___Vehicle_License_Department_;
            this.PBLogo.ImageRotate = 0F;
            this.PBLogo.Location = new System.Drawing.Point(0, 0);
            this.PBLogo.Name = "PBLogo";
            this.PBLogo.Size = new System.Drawing.Size(249, 185);
            this.PBLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBLogo.TabIndex = 1;
            this.PBLogo.TabStop = false;
            this.PBLogo.UseTransparentBackground = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.panel2.Controls.Add(this.LblDay);
            this.panel2.Controls.Add(this.LblDate);
            this.panel2.Controls.Add(this.LblTime);
            this.panel2.Controls.Add(this.PanelUser);
            this.panel2.Controls.Add(this.BtnMinimize);
            this.panel2.Controls.Add(this.BtnExit);
            this.panel2.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel2.Location = new System.Drawing.Point(249, 0);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(1451, 126);
            this.panel2.TabIndex = 1;
            // 
            // LblDay
            // 
            this.LblDay.BackColor = System.Drawing.Color.Transparent;
            this.LblDay.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDay.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblDay.IsSelectionEnabled = false;
            this.LblDay.Location = new System.Drawing.Point(7, 67);
            this.LblDay.Name = "LblDay";
            this.LblDay.Size = new System.Drawing.Size(37, 27);
            this.LblDay.TabIndex = 10;
            this.LblDay.Text = "Day";
            // 
            // LblDate
            // 
            this.LblDate.BackColor = System.Drawing.Color.Transparent;
            this.LblDate.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblDate.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblDate.IsSelectionEnabled = false;
            this.LblDate.Location = new System.Drawing.Point(6, 40);
            this.LblDate.Name = "LblDate";
            this.LblDate.Size = new System.Drawing.Size(44, 27);
            this.LblDate.TabIndex = 9;
            this.LblDate.Text = "Date";
            // 
            // LblTime
            // 
            this.LblTime.BackColor = System.Drawing.Color.Transparent;
            this.LblTime.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTime.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblTime.IsSelectionEnabled = false;
            this.LblTime.Location = new System.Drawing.Point(6, 12);
            this.LblTime.Name = "LblTime";
            this.LblTime.Size = new System.Drawing.Size(45, 27);
            this.LblTime.TabIndex = 8;
            this.LblTime.Text = "Time";
            // 
            // PanelUser
            // 
            this.PanelUser.Controls.Add(this.BtnUserSetting);
            this.PanelUser.Controls.Add(this.lblUser);
            this.PanelUser.Controls.Add(this.lblNameUser);
            this.PanelUser.Controls.Add(this.PBUser);
            this.PanelUser.Location = new System.Drawing.Point(1227, 35);
            this.PanelUser.Name = "PanelUser";
            this.PanelUser.Size = new System.Drawing.Size(221, 67);
            this.PanelUser.TabIndex = 7;
            // 
            // BtnUserSetting
            // 
            this.BtnUserSetting.Animated = true;
            this.BtnUserSetting.BackColor = System.Drawing.Color.Transparent;
            this.BtnUserSetting.DefaultAutoSize = true;
            this.BtnUserSetting.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnUserSetting.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnUserSetting.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnUserSetting.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnUserSetting.FillColor = System.Drawing.Color.Transparent;
            this.BtnUserSetting.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnUserSetting.ForeColor = System.Drawing.Color.White;
            this.BtnUserSetting.Image = global::DVLD___Driving_License_Management.Properties.Resources.cogwheel;
            this.BtnUserSetting.IndicateFocus = true;
            this.BtnUserSetting.Location = new System.Drawing.Point(178, 23);
            this.BtnUserSetting.Name = "BtnUserSetting";
            this.BtnUserSetting.ShadowDecoration.Mode = Guna.UI2.WinForms.Enums.ShadowMode.Circle;
            this.BtnUserSetting.Size = new System.Drawing.Size(26, 30);
            this.BtnUserSetting.TabIndex = 0;
            this.BtnUserSetting.UseTransparentBackground = true;
            // 
            // lblUser
            // 
            this.lblUser.AutoSize = true;
            this.lblUser.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUser.Location = new System.Drawing.Point(54, 40);
            this.lblUser.Name = "lblUser";
            this.lblUser.Size = new System.Drawing.Size(38, 20);
            this.lblUser.TabIndex = 2;
            this.lblUser.Text = "User";
            // 
            // lblNameUser
            // 
            this.lblNameUser.AutoSize = true;
            this.lblNameUser.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNameUser.Location = new System.Drawing.Point(54, 12);
            this.lblNameUser.Name = "lblNameUser";
            this.lblNameUser.Size = new System.Drawing.Size(79, 20);
            this.lblNameUser.TabIndex = 1;
            this.lblNameUser.Text = "Mohamad";
            // 
            // PBUser
            // 
            this.PBUser.BackColor = System.Drawing.Color.Transparent;
            this.PBUser.Image = global::DVLD___Driving_License_Management.Properties.Resources.icons8_person_64;
            this.PBUser.ImageRotate = 0F;
            this.PBUser.Location = new System.Drawing.Point(3, 12);
            this.PBUser.Name = "PBUser";
            this.PBUser.Size = new System.Drawing.Size(45, 48);
            this.PBUser.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.PBUser.TabIndex = 0;
            this.PBUser.TabStop = false;
            this.PBUser.UseTransparentBackground = true;
            // 
            // BtnMinimize
            // 
            this.BtnMinimize.Animated = true;
            this.BtnMinimize.AutoRoundedCorners = true;
            this.BtnMinimize.BackColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BorderColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.BorderRadius = 12;
            this.BtnMinimize.CausesValidation = false;
            this.BtnMinimize.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnMinimize.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnMinimize.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnMinimize.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.FocusedColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnMinimize.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.HoverState.Image = global::DVLD___Driving_License_Management.Properties.Resources.minimize__8_;
            this.BtnMinimize.Image = global::DVLD___Driving_License_Management.Properties.Resources.minimize;
            this.BtnMinimize.Location = new System.Drawing.Point(1391, 3);
            this.BtnMinimize.Name = "BtnMinimize";
            this.BtnMinimize.PressedColor = System.Drawing.Color.Transparent;
            this.BtnMinimize.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnMinimize.Size = new System.Drawing.Size(32, 26);
            this.BtnMinimize.TabIndex = 6;
            this.BtnMinimize.Click += new System.EventHandler(this.BtnMinimize_Click);
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
            this.BtnExit.Location = new System.Drawing.Point(1418, 3);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 26);
            this.BtnExit.TabIndex = 5;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PanelMain
            // 
            this.PanelMain.BackColor = System.Drawing.Color.White;
            this.PanelMain.Controls.Add(this.ctrlDashboard1);
            this.PanelMain.Dock = System.Windows.Forms.DockStyle.Fill;
            this.PanelMain.Location = new System.Drawing.Point(249, 126);
            this.PanelMain.Name = "PanelMain";
            this.PanelMain.Size = new System.Drawing.Size(1451, 874);
            this.PanelMain.TabIndex = 2;
            // 
            // ctrlDashboard1
            // 
            this.ctrlDashboard1.BackColor = System.Drawing.Color.White;
            this.ctrlDashboard1.Location = new System.Drawing.Point(0, 0);
            this.ctrlDashboard1.Name = "ctrlDashboard1";
            this.ctrlDashboard1.Size = new System.Drawing.Size(1430, 900);
            this.ctrlDashboard1.TabIndex = 0;
            this.ctrlDashboard1.BtnClicked += new System.Action<bool>(this.ctrlDashboard1_BtnClicked);
            // 
            // guna2Elipse1
            // 
            this.guna2Elipse1.BorderRadius = 12;
            this.guna2Elipse1.TargetControl = this;
            // 
            // FrmMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1700, 1000);
            this.Controls.Add(this.PanelMain);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.IsMdiContainer = true;
            this.Name = "FrmMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Driving License Management";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.panel1.ResumeLayout(false);
            this.PanelLogo.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.guna2PictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PBLogo)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.PanelUser.ResumeLayout(false);
            this.PanelUser.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.PBUser)).EndInit();
            this.PanelMain.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel PanelMain;
        private Guna.UI2.WinForms.Guna2Elipse guna2Elipse1;
        private System.Windows.Forms.Panel PanelLogo;
        private Guna.UI2.WinForms.Guna2PictureBox PBLogo;
        private Guna.UI2.WinForms.Guna2Button BtnUsers;
        private Guna.UI2.WinForms.Guna2Button BtnDrivers;
        private Guna.UI2.WinForms.Guna2Button BtnPeople;
        private Guna.UI2.WinForms.Guna2Button BtnApplications;
        private Guna.UI2.WinForms.Guna2Button BtnDashboard;
        private Guna.UI2.WinForms.Guna2Button BtnMinimize;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Panel PanelUser;
        private Guna.UI2.WinForms.Guna2CircleButton BtnUserSetting;
        private System.Windows.Forms.Label lblUser;
        private System.Windows.Forms.Label lblNameUser;
        private Guna.UI2.WinForms.Guna2PictureBox PBUser;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDay;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblDate;
        private Guna.UI2.WinForms.Guna2HtmlLabel LblTime;
        private System.Windows.Forms.Timer timer1;
        private Guna.UI2.WinForms.Guna2Button BtnLogout;
        private Guna.UI2.WinForms.Guna2PictureBox guna2PictureBox3;
        private MainScreen.CtrlDashboard ctrlDashboard1;
    }
}