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

namespace DVLD___Driving_License_Management.People.Controls
{
    public partial class CtrlListPeople : UserControl
    {
        private static DataTable _DataTableAllPeople = ClsPerson.GetAllPeople();
        private DataTable _DataTablePeopleCopy;
        public CtrlListPeople()
        {
            InitializeComponent();
        }
        private void _RefreshPeopleList()
        {
            
            _DataTablePeopleCopy = _DataTableAllPeople.DefaultView.ToTable(false, "PersonID", "NationalNo",
                                                       "FirstName", "SecondName", "ThirdName", "LastName",
                                                       "GendorCaption", "DateOfBirth", "CountryName",
                                                       "Phone", "Email");

            DGVPeople.DataSource = _DataTablePeopleCopy;
            LblCountRe.Text = DGVPeople.RowCount.ToString();
        }
        

        private void BtnAddNewPerson_Click(object sender, EventArgs e)
        {
            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        

        private void CtrlListPeople_Load(object sender, EventArgs e)
        {
            DGVPeople.DataSource = _DataTablePeopleCopy;
            CbFilterBy.SelectedIndex = 0;
            LblCountRe.Text = DGVPeople.Rows.Count.ToString();
            if (DGVPeople.Rows.Count > 0)
            {
                DGVPeople.Columns[0].HeaderText = "Person ID";
                DGVPeople.Columns[0].Width = 110;

                DGVPeople.Columns[1].HeaderText = "National No";
                DGVPeople.Columns[1].Width = 140;

                DGVPeople.Columns[2].HeaderText = "First Name";
                DGVPeople.Columns[2].Width = 120;

                DGVPeople.Columns[3].HeaderText = "Second Name";
                DGVPeople.Columns[3].Width = 140;

                DGVPeople.Columns[4].HeaderText = "Third Name";
                DGVPeople.Columns[4].Width = 120;

                DGVPeople.Columns[5].HeaderText = "Last Name";
                DGVPeople.Columns[5].Width = 120;

                DGVPeople.Columns[6].HeaderText = "Gendor";
                DGVPeople.Columns[6].Width = 110;

                DGVPeople.Columns[7].HeaderText = "Date Of Birth";
                DGVPeople.Columns[7].Width = 140;

                DGVPeople.Columns[8].HeaderText = "Nationality";
                DGVPeople.Columns[8].Width = 120;

                DGVPeople.Columns[9].HeaderText = "Phone";
                DGVPeople.Columns[9].Width = 120;

                DGVPeople.Columns[10].HeaderText = "Email";
                DGVPeople.Columns[10].Width = 160;
            }
        }

        private void TxtFilterValue_TextChanged(object sender, EventArgs e)
        {
            string FilterColumn = "";
            switch (CbFilterBy.Text)
            {
                case "Person ID":
                    FilterColumn = "PersonID";
                    break;
                case "National No":
                    FilterColumn = "NationalNo";
                    break;

                case "First Name":
                    FilterColumn = "FirstName";
                    break;

                case "Second Name":
                    FilterColumn = "SecondName";
                    break;

                case "Third Name":
                    FilterColumn = "ThirdName";
                    break;

                case "Last Name":
                    FilterColumn = "LastName";
                    break;

                case "Nationality":
                    FilterColumn = "CountryName";
                    break;

                case "Gendor":
                    FilterColumn = "GendorCaption";
                    break;

                case "Phone":
                    FilterColumn = "Phone";
                    break;

                case "Email":
                    FilterColumn = "Email";
                    break;

                default:
                    FilterColumn = "None";
                    break;
            }

            if (TxtFilterValue.Text.Trim() == "" || FilterColumn == "None")
            {
                _DataTablePeopleCopy.DefaultView.RowFilter = "";
                LblCountRe.Text = DGVPeople.Rows.Count.ToString();
                return;
            }

            if (FilterColumn == "PersonID")
                _DataTablePeopleCopy.DefaultView.RowFilter = string.Format("[{0}] = {1}", FilterColumn, TxtFilterValue.Text.Trim());
            else
                _DataTablePeopleCopy.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", FilterColumn, TxtFilterValue.Text.Trim());

            LblCountRe.Text = DGVPeople.Rows.Count.ToString();
        }

        private void CbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            TxtFilterValue.Visible = (CbFilterBy.Text != "None");

            if (TxtFilterValue.Visible)
            {
                TxtFilterValue.Text = "";
                TxtFilterValue.Focus();
            }
            if (CbFilterBy.Text == "None")
            {
                _RefreshPeopleList();
            }
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVPeople.CurrentRow.Cells[0].Value;
            FrmShowPerson PersonInfo = new FrmShowPerson(PersonID);
            PersonInfo.ShowDialog();
            _RefreshPeopleList();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            int PersonID = (int)DGVPeople.CurrentRow.Cells[0].Value;
            FrmAddUpdatePerson EditPersonInfo = new FrmAddUpdatePerson(PersonID);
            EditPersonInfo.ShowDialog();
            _RefreshPeopleList();
            
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            int PersonId = (int)DGVPeople.CurrentRow.Cells[0].Value;
            if (MessageBox.Show("Are you sure you want to delete Person [" + PersonId.ToString() + "]", "Confirm Delete", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)

            {
                if (ClsPerson.DeletePerson(PersonId))
                {
                    MessageBox.Show("Person Deleted Successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    _RefreshPeopleList();
                }

                else
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

            }

        }

        private void DGVPeople_DoubleClick(object sender, EventArgs e)
        {
            FrmShowPerson PersonInfo = new FrmShowPerson((int)DGVPeople.CurrentRow.Cells[0].Value);
            PersonInfo.ShowDialog();
            _RefreshPeopleList();
        }

        

        private void BtnAddNewPerson_Click_1(object sender, EventArgs e)
        {

            FrmAddUpdatePerson frm = new FrmAddUpdatePerson();
            frm.ShowDialog();
            _RefreshPeopleList();
        }

        private void TxtFilterValue_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (CbFilterBy.Text == "Person ID")
                e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
