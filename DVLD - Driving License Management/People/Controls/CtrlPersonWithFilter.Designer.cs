namespace DVLD___Driving_License_Management.People.Controls
{
    partial class CtrlPersonWithFilter
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CtrlPersonWithFilter));
            this.PanelFilter = new Guna.UI2.WinForms.Guna2GradientPanel();
            this.BtnFind = new Guna.UI2.WinForms.Guna2Button();
            this.BtnAddNewPerson = new Guna.UI2.WinForms.Guna2Button();
            this.txtFilterValue = new Guna.UI2.WinForms.Guna2TextBox();
            this.CbFilterBy = new Guna.UI2.WinForms.Guna2ComboBox();
            this.guna2HtmlLabel1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.ctrlPersonCard1 = new DVLD___Driving_License_Management.People.Controls.CtrlPersonCard();
            this.PanelFilter.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // PanelFilter
            // 
            this.PanelFilter.BorderRadius = 12;
            this.PanelFilter.BorderThickness = 18;
            this.PanelFilter.Controls.Add(this.BtnFind);
            this.PanelFilter.Controls.Add(this.BtnAddNewPerson);
            this.PanelFilter.Controls.Add(this.txtFilterValue);
            this.PanelFilter.Controls.Add(this.CbFilterBy);
            this.PanelFilter.Controls.Add(this.guna2HtmlLabel1);
            this.PanelFilter.CustomBorderColor = System.Drawing.Color.Transparent;
            this.PanelFilter.CustomBorderThickness = new System.Windows.Forms.Padding(0, 5, 0, 0);
            this.PanelFilter.Dock = System.Windows.Forms.DockStyle.Top;
            this.PanelFilter.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.PanelFilter.FillColor2 = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.PanelFilter.Location = new System.Drawing.Point(0, 0);
            this.PanelFilter.Name = "PanelFilter";
            this.PanelFilter.Size = new System.Drawing.Size(889, 104);
            this.PanelFilter.TabIndex = 1;
            // 
            // BtnFind
            // 
            this.BtnFind.Animated = true;
            this.BtnFind.BackColor = System.Drawing.Color.Transparent;
            this.BtnFind.BorderColor = System.Drawing.Color.Transparent;
            this.BtnFind.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnFind.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnFind.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnFind.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnFind.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnFind.FillColor = System.Drawing.Color.Transparent;
            this.BtnFind.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnFind.ForeColor = System.Drawing.Color.Transparent;
            this.BtnFind.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnFind.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnFind.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnFind.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtnFind.Image = global::DVLD___Driving_License_Management.Properties.Resources.magnifier;
            this.BtnFind.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnFind.Location = new System.Drawing.Point(581, 23);
            this.BtnFind.Name = "BtnFind";
            this.BtnFind.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnFind.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnFind.Size = new System.Drawing.Size(48, 42);
            this.BtnFind.TabIndex = 4;
            this.BtnFind.UseTransparentBackground = true;
            this.BtnFind.Click += new System.EventHandler(this.BtnFind_Click);
            // 
            // BtnAddNewPerson
            // 
            this.BtnAddNewPerson.Animated = true;
            this.BtnAddNewPerson.BackColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.CustomImages.ImageAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.BtnAddNewPerson.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewPerson.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.BtnAddNewPerson.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.BtnAddNewPerson.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.BtnAddNewPerson.FillColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.BtnAddNewPerson.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.HoverState.BorderColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.HoverState.CustomBorderColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.HoverState.FillColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.HoverState.ForeColor = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.Image = global::DVLD___Driving_License_Management.Properties.Resources.add_user;
            this.BtnAddNewPerson.ImageSize = new System.Drawing.Size(40, 40);
            this.BtnAddNewPerson.Location = new System.Drawing.Point(635, 23);
            this.BtnAddNewPerson.Name = "BtnAddNewPerson";
            this.BtnAddNewPerson.PressedColor = System.Drawing.Color.DodgerBlue;
            this.BtnAddNewPerson.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnAddNewPerson.Size = new System.Drawing.Size(48, 42);
            this.BtnAddNewPerson.TabIndex = 3;
            this.BtnAddNewPerson.UseTransparentBackground = true;
            this.BtnAddNewPerson.Click += new System.EventHandler(this.BtnAddNewPerson_Click);
            // 
            // txtFilterValue
            // 
            this.txtFilterValue.Animated = true;
            this.txtFilterValue.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtFilterValue.DefaultText = "";
            this.txtFilterValue.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtFilterValue.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtFilterValue.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtFilterValue.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.txtFilterValue.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtFilterValue.Location = new System.Drawing.Point(320, 29);
            this.txtFilterValue.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtFilterValue.Name = "txtFilterValue";
            this.txtFilterValue.PasswordChar = '\0';
            this.txtFilterValue.PlaceholderText = "";
            this.txtFilterValue.SelectedText = "";
            this.txtFilterValue.Size = new System.Drawing.Size(229, 36);
            this.txtFilterValue.TabIndex = 2;
            this.txtFilterValue.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtFilterValue_KeyPress);
            this.txtFilterValue.Validating += new System.ComponentModel.CancelEventHandler(this.txtFilterValue_Validating);
            // 
            // CbFilterBy
            // 
            this.CbFilterBy.BackColor = System.Drawing.Color.Transparent;
            this.CbFilterBy.BorderThickness = 0;
            this.CbFilterBy.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.CbFilterBy.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CbFilterBy.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbFilterBy.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.CbFilterBy.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F);
            this.CbFilterBy.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(68)))), ((int)(((byte)(88)))), ((int)(((byte)(112)))));
            this.CbFilterBy.ItemHeight = 30;
            this.CbFilterBy.Items.AddRange(new object[] {
            "Person ID",
            "National No."});
            this.CbFilterBy.ItemsAppearance.Font = new System.Drawing.Font("Yu Gothic UI", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CbFilterBy.ItemsAppearance.ForeColor = System.Drawing.SystemColors.ControlText;
            this.CbFilterBy.Location = new System.Drawing.Point(115, 29);
            this.CbFilterBy.Name = "CbFilterBy";
            this.CbFilterBy.Size = new System.Drawing.Size(199, 36);
            this.CbFilterBy.Style = Guna.UI2.WinForms.Enums.TextBoxStyle.Material;
            this.CbFilterBy.TabIndex = 1;
            this.CbFilterBy.SelectedIndexChanged += new System.EventHandler(this.CbFilterBy_SelectedIndexChanged);
            // 
            // guna2HtmlLabel1
            // 
            this.guna2HtmlLabel1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.guna2HtmlLabel1.AutoSize = false;
            this.guna2HtmlLabel1.AutoSizeHeightOnly = true;
            this.guna2HtmlLabel1.BackColor = System.Drawing.Color.Transparent;
            this.guna2HtmlLabel1.Font = new System.Drawing.Font("Yu Gothic UI Semibold", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.guna2HtmlLabel1.ForeColor = System.Drawing.Color.Black;
            this.guna2HtmlLabel1.Location = new System.Drawing.Point(33, 29);
            this.guna2HtmlLabel1.Name = "guna2HtmlLabel1";
            this.guna2HtmlLabel1.Size = new System.Drawing.Size(76, 26);
            this.guna2HtmlLabel1.TabIndex = 0;
            this.guna2HtmlLabel1.Text = "Find By :";
            this.guna2HtmlLabel1.TextAlignment = System.Drawing.ContentAlignment.TopCenter;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            this.errorProvider1.Icon = ((System.Drawing.Icon)(resources.GetObject("errorProvider1.Icon")));
            // 
            // ctrlPersonCard1
            // 
            this.ctrlPersonCard1.BackColor = System.Drawing.Color.White;
            this.ctrlPersonCard1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ctrlPersonCard1.Location = new System.Drawing.Point(0, 110);
            this.ctrlPersonCard1.Name = "ctrlPersonCard1";
            this.ctrlPersonCard1.Size = new System.Drawing.Size(889, 405);
            this.ctrlPersonCard1.TabIndex = 0;
            // 
            // CtrlPersonWithFilter
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.Controls.Add(this.PanelFilter);
            this.Controls.Add(this.ctrlPersonCard1);
            this.Name = "CtrlPersonWithFilter";
            this.Size = new System.Drawing.Size(889, 515);
            this.Load += new System.EventHandler(this.CtrlPersonWithFilter_Load);
            this.PanelFilter.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private CtrlPersonCard ctrlPersonCard1;
        private Guna.UI2.WinForms.Guna2GradientPanel PanelFilter;
        private Guna.UI2.WinForms.Guna2HtmlLabel guna2HtmlLabel1;
        private Guna.UI2.WinForms.Guna2ComboBox CbFilterBy;
        private Guna.UI2.WinForms.Guna2TextBox txtFilterValue;
        private Guna.UI2.WinForms.Guna2Button BtnAddNewPerson;
        private Guna.UI2.WinForms.Guna2Button BtnFind;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}
