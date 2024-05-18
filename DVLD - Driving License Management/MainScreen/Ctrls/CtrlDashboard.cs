using DVLD___Driving_License_Management.Applications.Ctrls;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Text;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DVLD___Driving_License_Management.MainScreen
{
    public partial class CtrlDashboard : UserControl
    {
        private bool _showApp = false;
        public event Action<bool> BtnClicked;
        protected virtual void ApplyBtnClicked(bool IsClicked)
        {
            Action<bool> handler = BtnClicked;
            if (handler != null)
            {
                handler(IsClicked);
            }
        }

        public CtrlDashboard()
        {
            InitializeComponent();
        }

        private void BtnApplyNow_Click(object sender, EventArgs e)
        {
            _showApp = true;
            if (BtnClicked != null && _showApp)
            {
                ApplyBtnClicked(_showApp);
            }
        }
    }
}
