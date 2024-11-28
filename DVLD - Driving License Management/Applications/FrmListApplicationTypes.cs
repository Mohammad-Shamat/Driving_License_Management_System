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

namespace DVLD___Driving_License_Management.Applications
{
    public partial class FrmListApplicationTypes : Form
    {
        private DataTable _dtAllApplicationTypes;

        public FrmListApplicationTypes()
        {
            InitializeComponent();
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmListApplicationTypes_Load(object sender, EventArgs e)
        {
            _dtAllApplicationTypes = ClsApplicationType.GetAllApplicationTypes();
            DGVApplicationTypes.DataSource = _dtAllApplicationTypes;
            LblCountRe.Text= DGVApplicationTypes.Rows.Count.ToString();

            if (DGVApplicationTypes.Rows.Count>0)
            {
                lblNoDataShow.Visible = false;
                PBnoDatatoShow.Visible = false; 
                DGVApplicationTypes.Columns[0].HeaderText = "ID";
                DGVApplicationTypes.Columns[0].Width = 110;

                DGVApplicationTypes.Columns[1].HeaderText = "Title";
                DGVApplicationTypes.Columns[1].Width = 400;

                DGVApplicationTypes.Columns[2].HeaderText = "Fees";
                DGVApplicationTypes.Columns[2].Width = 100;

            }
            else
            {
                DGVApplicationTypes.DataSource = null;
                LblCountRe.Text = "No Data";
                lblNoDataShow.Visible = true;
                PBnoDatatoShow.Visible = true;
            }

        }

        private void editApplicationTypeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            FrmEditApplicationType frm = new FrmEditApplicationType((int)DGVApplicationTypes.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            FrmListApplicationTypes_Load(null, null);
        }
    }
}
