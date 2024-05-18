using DVLD___Driving_License_Management.Applications.Ctrls;
using DVLD___Driving_License_Management.MainScreen;
using DVLD___Driving_License_Management.People.Controls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management
{
    public partial class FrmMain : Form
    {
        private CtrlListPeople ctrlListPeople = new CtrlListPeople();
        private CtrlMainApplication ctrlMainApplication = new CtrlMainApplication();
       
        public FrmMain()
        {
            InitializeComponent();
            timer1.Start();
        }
        private void AddCtrl(UserControl ctrl)
        {
            ctrl.Dock = DockStyle.Fill;
            PanelMain.Controls.Clear();
            PanelMain.Controls.Add(ctrl);
            ctrl.BringToFront();

        }

        private void BtnPeople_Click(object sender, EventArgs e)
        {
            AddCtrl(ctrlListPeople);
        }

        private void BtnDashboard_Click(object sender, EventArgs e)
        {
            AddCtrl(ctrlDashboard1);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            LblTime.Text = DateTime.Now.ToShortTimeString();
            LblDate.Text = DateTime.Now.ToShortDateString();
            LblDay.Text = DateTime.Now.DayOfWeek.ToString();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnMinimize_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BtnApplications_Click(object sender, EventArgs e)
        {
            AddCtrl(ctrlMainApplication);
        }

        private void ctrlDashboard1_BtnClicked(bool obj)
        {
            if (obj)
            {
                AddCtrl(ctrlMainApplication);
            }
        }
    }
}
