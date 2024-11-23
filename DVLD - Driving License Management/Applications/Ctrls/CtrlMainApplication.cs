using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management.Applications.Ctrls
{
    public partial class CtrlMainApplication : UserControl
    {
        public CtrlMainApplication()
        {
            InitializeComponent();
        }

        private void BtnManageApp_Click(object sender, EventArgs e)
        {
            FrmListApplicationTypes frmListApplicationTypes = new FrmListApplicationTypes();
            frmListApplicationTypes.ShowDialog();
        }
    }
}
