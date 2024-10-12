using DVLD_Buisness;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management.User
{
    public partial class FrmAddUpdateUser : Form
    {

        public enum enMode { AddNew = 0, Update = 1 };
        private enMode _Mode;
        private int _UserID = -1;
        ClsUsers _User;
        public FrmAddUpdateUser()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FrmAddUpdateUser(int UserID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _UserID = UserID;
        }
        private void _ResetDefultValues()
        {
            if (_Mode == enMode.AddNew)
            {
                LblTitle.Text = "Add New User";
                this.Text = "Add New User";
                _User = new ClsUsers();
                TPLoginInfo.Enabled = false;
                ctrlPersonWithFilter1.FilterFocus();
            }
            else
            {
                LblTitle.Text = "Update User";
                this.Text = "Update User";
                TPLoginInfo.Enabled = true;
                ctrlPersonWithFilter1.FilterFocus();
                BtnSave.Enabled = true;
            }
            TxtUserName.Text = string.Empty;
            TxtPassword.Text = string.Empty;
            TxtConfirmPassword.Text = string.Empty;
            ChBIsActive.Checked = true;
        }
        private void _LoadData()
        {
            _User = ClsUsers.FindByUserID(_UserID);
            ctrlPersonWithFilter1.FilterEnabled = false;
            if (_User == null)
            {
                MessageBox.Show("No User With ID = " + _UserID,
                    "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }
            LblUserID.Text = _User.UserID.ToString();
            TxtUserName.Text = _User.UserName.ToString();
            TxtPassword.Text = _User.Password.ToString();
            TxtConfirmPassword.Text = _User.Password.ToString();
            ChBIsActive.Checked = _User.IsActive;
            ctrlPersonWithFilter1.LoadPersonInfo(_User.PersonID);

        }
        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void BtnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmAddUpdateUser_Load(object sender, EventArgs e)
        {
            _ResetDefultValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();
            }
        }

        private void TxtConfirmPassword_Validating(object sender, CancelEventArgs e)
        {
            if (TxtConfirmPassword.Text.Trim() != TxtPassword.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtConfirmPassword, "Password Confirmation does not match Password!");
            }
            else
            {
                errorProvider1.SetError(TxtConfirmPassword, null);
            }
        }

        private void TxtPassword_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtPassword.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtPassword, "Password cannot be blank");
            }
            else
            {
                errorProvider1.SetError(TxtPassword, null);
            };
        }

        private void TxtUserName_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtUserName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtUserName, "Username cannot be blank");
            }
            else
            {
                errorProvider1.SetError(TxtUserName, null);
            }
            if (_Mode == enMode.AddNew)
            {
                if (ClsUsers.isUserExist(TxtUserName.Text.Trim()))
                {
                    e.Cancel = true;
                    errorProvider1.SetError(TxtUserName, "Username is used by another user,Please try another Username");
                }
                else
                {
                    errorProvider1.SetError(TxtUserName, null);
                };

            }
            else
            {
                if (_User.UserName != TxtUserName.Text.Trim())
                {
                    if (ClsUsers.isUserExist(TxtUserName.Text.Trim()))
                    {
                        e.Cancel = true;
                        errorProvider1.SetError(TxtUserName, "Username is used by another user,Please try another Username");
                        return;
                    }
                    else
                    {
                        errorProvider1.SetError(TxtUserName, null);
                    };
                }
            }
        }

        private void BtnNext_Click(object sender, EventArgs e)
        {
            if (_Mode == enMode.Update)
            {
                BtnSave.Enabled = true;
                TPLoginInfo.Enabled = true;
                TCUserInfo.SelectedTab = TCUserInfo.TabPages["TPLoginInfo"];
                return;

            }

            if (ctrlPersonWithFilter1.PersonId != -1)
            {
                if (ClsUsers.isUserExistForPersonID(ctrlPersonWithFilter1.PersonId))
                {
                    MessageBox.Show("Selected Person already has a user, choose another one.", "Select another Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlPersonWithFilter1.FilterFocus();
                }

                else
                {
                    BtnSave.Enabled = true;
                    TPLoginInfo.Enabled = true;
                    TCUserInfo.SelectedTab = TCUserInfo.TabPages["TPLoginInfo"];
                }


            }
            else

            {
                MessageBox.Show("Please Select a Person", "Select a Person", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlPersonWithFilter1.FilterFocus();

            }

        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro",
                    "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }
            _User.PersonID = ctrlPersonWithFilter1.PersonId;
            _User.UserName = TxtUserName.Text.Trim();
            _User.Password = TxtPassword.Text.Trim();
            _User.IsActive = ChBIsActive.Checked;

            if (_User.Save())
            {
                LblUserID.Text = _User.UserID.ToString();
                _Mode = enMode.Update;
                LblTitle.Text = "Update User";
                this.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        
    }
}
