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
    public partial class CtrlUsersList : UserControl
    {
        private static DataTable _dtListUsers;
        public CtrlUsersList()
        {
            InitializeComponent();
        }

        private void CtrlUsersList_Load(object sender, EventArgs e)
        {
            _dtListUsers = ClsUsers.GetAllUsers();
            DGVUsers.DataSource = _dtListUsers;
            CbFilterBy.SelectedIndex = 0;
            LblCountRe.Text = DGVUsers.RowCount.ToString();
            if (DGVUsers.Rows.Count > 0)
            {
                DGVUsers.Columns[0].HeaderText = "User ID";
                DGVUsers.Columns[0].Width = 110;

                DGVUsers.Columns[1].HeaderText = "Person ID";
                DGVUsers.Columns[1].Width = 120;

                DGVUsers.Columns[2].HeaderText = "Full Name";
                DGVUsers.Columns[2].Width = 848;

                DGVUsers.Columns[3].HeaderText = "User Name";
                DGVUsers.Columns[3].Width = 200;

                DGVUsers.Columns[4].HeaderText = "Is Active";
                DGVUsers.Columns[4].Width = 120;
            }



        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CbFilterBy.Text == "Is Active")
            {
                TxtFilterValue.Visible = false;
                CbIsActive.Visible = true;
                CbIsActive.Focus();
                CbIsActive.SelectedIndex = 0;
            }

            else
            {
                TxtFilterValue.Visible = (CbFilterBy.Text != "None");

                CbIsActive.Visible = false;
                TxtFilterValue.Text = "";
                TxtFilterValue.Focus();
            }
            if (CbFilterBy.Text.ToString() == "None")
            {
                CtrlUsersList_Load(null, null);
            }
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (CbFilterBy.Text.ToString())
            {
                case "User ID":
                    FilterColumn = "UserID";
                    break;
                case "UserName":
                    FilterColumn = "UserName";
                    break;

                case "Person ID":
                    FilterColumn = "PersonID";
                    break;


                case "Full Name":
                    FilterColumn = "FullName";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (TxtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _dtListUsers.DefaultView.RowFilter = "";
                LblCountRe.Text = DGVUsers.Rows.Count.ToString();
                return;
            }

            if (FilterColumn != "FullName" && FilterColumn != "UserName")
            {
                _dtListUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TxtFilterValue.Text.Trim());
            }
            else
            {
                _dtListUsers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TxtFilterValue.Text.Trim());
            }
            LblCountRe.Text = _dtListUsers.Rows.Count.ToString();
        }

        private void CbIsActive_SelectedIndexChanged(object sender, EventArgs e)
        {
            string FilterColumn = "IsActive";
            string FilterValue = CbIsActive.Text;
            switch (FilterValue)
            {
                case "All":
                    break;
                case "Yes":
                    FilterValue = "1";
                    break;
                case "No":
                    FilterValue = "0";
                    break;
            }

            if (FilterValue == "All")
                _dtListUsers.DefaultView.RowFilter = "";
            else
                
                _dtListUsers.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, FilterValue);

            LblCountRe.Text = _dtListUsers.Rows.Count.ToString();
        }

        private void BtnAddNewUser_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser  frmAddUpdateUser = new FrmAddUpdateUser();
            frmAddUpdateUser.ShowDialog();
            CtrlUsersList_Load(null,null);
        }

        

        private void DGVUsers_CellContentDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            FrmUserInfo Frm1 = new FrmUserInfo((int)DGVUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            CtrlUsersList_Load(null, null);
        }

        private void addNewUserToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmAddUpdateUser Frm1 = new FrmAddUpdateUser();
            Frm1.ShowDialog();
            CtrlUsersList_Load(null, null);
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmUserInfo Frm1 = new FrmUserInfo((int)DGVUsers.CurrentRow.Cells[0].Value);
            Frm1.ShowDialog();
            CtrlUsersList_Load(null, null);
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
           FrmAddUpdateUser frmAdd = new FrmAddUpdateUser((int)DGVUsers.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            CtrlUsersList_Load(null, null);
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmChangePassword frmAdd = new FrmChangePassword((int)DGVUsers.CurrentRow.Cells[0].Value);
            frmAdd.ShowDialog();
            CtrlUsersList_Load(null, null);
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int UserID = (int)DGVUsers.CurrentRow.Cells[0].Value;
            if (ClsUsers.DeleteUser(UserID))
            {
                MessageBox.Show("User has been deleted successfully", "Deleted", MessageBoxButtons.OK, MessageBoxIcon.Information);
                CtrlUsersList_Load(null, null);
            }

            else
            {
                MessageBox.Show("User is not delted due to data connected to it.", "Faild", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text == "Person ID" || CbFilterBy.Text == "User ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
