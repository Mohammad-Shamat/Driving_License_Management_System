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

namespace DVLD___Driving_License_Management.User
{
    public partial class FrmChangePassword : Form
    {
        private short _UserID;
        private ClsUsers _User;
        public FrmChangePassword(short UserID)
        {
            InitializeComponent();
            _UserID = UserID;
        }
        private void _ResetDefualtValues()
        {
            TxtConfirmPassword.Text = string.Empty;
            TxtCurrentPassword.Text = string.Empty;
            TxtNewPassword.Text = string.Empty;
            TxtCurrentPassword.Focus();
        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmChangePassword_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            _User = ClsUsers.FindByUserID(_UserID);
            if (_User == null)
            {
                MessageBox.Show("Could not Find User with id = " + _UserID,
                    "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            ctrlUserCard1.LoadUserInfo(_UserID);
        }

        private void TxtCurrentPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCurrentPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCurrentPassword, "Username cannot be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCurrentPassword, null);
            }
            if (_User.Password != TxtCurrentPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCurrentPassword, "Current password is wrong!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtCurrentPassword, null);
            }

        }

        private void TxtNewPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNewPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtNewPassword, "New Password cannot be blank");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(TxtNewPassword, null);
            };
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtConfirmPassword.Text.Trim() != TxtNewPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtConfirmPassword, "Password Confirmation does not match New Password!");
            }
            else
            {
                errorProvider1.SetError(TxtConfirmPassword, null);
            };
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                   "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _User.Password = TxtNewPassword.Text;
            if (_User.Save())
            {
                MessageBox.Show("Password Changed Successfully.",
                   "Saved.", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _ResetDefualtValues();
            }
            else
            {
                MessageBox.Show("An Error Occured, Password did not change.",
                                 "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
