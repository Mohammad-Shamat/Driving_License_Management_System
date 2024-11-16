using DVLD___Driving_License_Management.Global_Classes;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management.User
{
    public partial class FrmUserSetting : Form
    {
       

        public FrmUserSetting()
        {
            InitializeComponent();
            
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnUserInfo_Click(object sender, EventArgs e)
        {
            Form FrmUserInfo = new FrmUserInfo(clsGlobal.CurrentUser.UserID);
            FrmUserInfo.ShowDialog();
        }

        private void BtnChangePassord_Click(object sender, EventArgs e)
        {
            Form FrmChangePassword = new FrmChangePassword(clsGlobal.CurrentUser.UserID);

            FrmChangePassword.ShowDialog();
            
        }
    }
}
