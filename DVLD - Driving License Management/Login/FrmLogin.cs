using DVLD___Driving_License_Management.Global_Classes;
using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management.Login
{
    public partial class FrmLogin : Form
    {
        public FrmLogin()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {
            ClsUsers User = ClsUsers.FindByUsernameAndPassword(TxtUserName.Text.Trim().ToString(), TxtPassword.Text.Trim().ToString());
            if (User != null )
            {
                if (ChkRememberMe.Checked)
                {
                    clsGlobal.RememberUsernameAndPassword(TxtUserName.Text.Trim().ToString(), TxtPassword.Text.Trim().ToString());
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if (!User.IsActive)
                {
                    TxtUserName.Focus();
                    MessageBox.Show("Your accound is not Active, Contact Admin.", "In Active Account", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobal.CurrentUser = User;
                this.Hide();
                FrmMain frmMain = new FrmMain(this);
                frmMain.ShowDialog();

            }
            else
            {
                TxtUserName.Focus();
                MessageBox.Show("Invalid Username/Password.", "Wrong Credentials", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void FrmLogin_Load(object sender, EventArgs e)
        {
            string UserName = "", Password = "";

            if (clsGlobal.GetStoredCredential(ref UserName, ref Password))
            {
                TxtUserName.Text = UserName;
                TxtPassword.Text = Password;
                ChkRememberMe.Checked = true;
            }
            else
                ChkRememberMe.Checked = false;
        }
    }
}
