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

namespace DVLD___Driving_License_Management.User.UserCtrls
{
    public partial class CtrlUserCard : UserControl
    {
        private ClsUsers _User;
        private short _UserID = -1;
        public short UserID
        {
            get { return _UserID; }
        }
        public CtrlUserCard()
        {
            InitializeComponent();
        }
        public void LoadUserInfo(int UserID)
        {
            _User = ClsUsers.FindByUserID(UserID);
            if (_User == null)
            {
                _ResetPersonInfo();
                MessageBox.Show("No User with UserID = " + UserID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillUserInfo();
        }
        private void _FillUserInfo()
        {

            ctrlPersonCard1.LoadPersonInfo(_User.PersonID);
            LblUserID.Text = _User.UserID.ToString();
            LblUserName.Text = _User.UserName.ToString();

            if (_User.IsActive)
                LblIsActive.Text = "Yes";
            else
                LblIsActive.Text = "No";

        }

        private void _ResetPersonInfo()
        {

            ctrlPersonCard1.ResetPersonInfo();
            LblUserID.Text = "No Data";
            LblUserName.Text = "No Data";
            LblIsActive.Text = "No Data";
        }
    }
}
