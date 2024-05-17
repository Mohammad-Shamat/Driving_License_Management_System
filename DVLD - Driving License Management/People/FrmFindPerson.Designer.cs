namespace DVLD___Driving_License_Management.People
{
    partial class FrmFindPerson
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FrmFindPerson));
            this.LblTitle = new System.Windows.Forms.Label();
            this.BtnExit = new Guna.UI2.WinForms.Guna2Button();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.ctrlPersonWithFilter1 = new DVLD___Driving_License_Management.People.Controls.CtrlPersonWithFilter();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // LblTitle
            // 
            this.LblTitle.AutoSize = true;
            this.LblTitle.Font = new System.Drawing.Font("Yu Gothic UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.LblTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(39)))), ((int)(((byte)(55)))), ((int)(((byte)(77)))));
            this.LblTitle.Location = new System.Drawing.Point(384, 24);
            this.LblTitle.Name = "LblTitle";
            this.LblTitle.Size = new System.Drawing.Size(160, 37);
            this.LblTitle.TabIndex = 2;
            this.LblTitle.Text = "Find Person";
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
            this.BtnExit.Location = new System.Drawing.Point(890, 13);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.PressedColor = System.Drawing.Color.Transparent;
            this.BtnExit.ShadowDecoration.Color = System.Drawing.Color.Transparent;
            this.BtnExit.Size = new System.Drawing.Size(32, 26);
            this.BtnExit.TabIndex = 4;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(221)))), ((int)(((byte)(230)))), ((int)(((byte)(237)))));
            this.guna2Panel1.BorderThickness = 8;
            this.guna2Panel1.Controls.Add(this.BtnExit);
            this.guna2Panel1.Controls.Add(this.ctrlPersonWithFilter1);
            this.guna2Panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.guna2Panel1.Location = new System.Drawing.Point(0, 0);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(931, 607);
            this.guna2Panel1.TabIndex = 5;
            // 
            // ctrlPersonWithFilter1
            // 
            this.ctrlPersonWithFilter1.BackColor = System.Drawing.Color.Transparent;
            this.ctrlPersonWithFilter1.FilterEnabled = true;
            this.ctrlPersonWithFilter1.Location = new System.Drawing.Point(12, 84);
            this.ctrlPersonWithFilter1.Name = "ctrlPersonWithFilter1";
            this.ctrlPersonWithFilter1.ShowAddPerson = true;
            this.ctrlPersonWithFilter1.Size = new System.Drawing.Size(910, 511);
            this.ctrlPersonWithFilter1.TabIndex = 3;
            // 
            // FrmFindPerson
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(931, 607);
            this.Controls.Add(this.LblTitle);
            this.Controls.Add(this.guna2Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FrmFindPerson";
            this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Find Person";
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label LblTitle;
        private Controls.CtrlPersonWithFilter ctrlPersonWithFilter1;
        private Guna.UI2.WinForms.Guna2Button BtnExit;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
    }
}