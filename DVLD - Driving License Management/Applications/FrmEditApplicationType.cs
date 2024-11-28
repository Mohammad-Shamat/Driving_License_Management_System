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

namespace DVLD___Driving_License_Management.Applications
{
    public partial class FrmEditApplicationType : Form
    {
        private int _ApplicationTypeID = -1;
        private ClsApplicationType _ApplicationType;
        public FrmEditApplicationType(int ApplicationTypeID)
        {
            InitializeComponent();
            _ApplicationTypeID = ApplicationTypeID;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FrmEditApplicationType_Load(object sender, EventArgs e)
        {
            LblID.Text = _ApplicationTypeID.ToString();
            _ApplicationType = ClsApplicationType.Find(_ApplicationTypeID);
            if (_ApplicationType != null)
            {
                TxtTitle.Text = _ApplicationType.Title.ToString();
                TxtFees.Text = _ApplicationType.Fees.ToString();    


            }
        }

        private void TxtTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtTitle, "A Title cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(TxtTitle, null);
            }
        }

        private void TxtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtFees.Text.Trim()))
            {
                e.Cancel= true;
                errorProvider1.SetError(TxtFees, "A Fees cannot be empty!");
            }
            else
            {
                errorProvider1.SetError(TxtFees, null);
            }

            if (!ClsValidation.IsNumber(TxtFees.Text))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtFees, "Invalid Number.");
            }
            else
            {
                errorProvider1.SetError(TxtFees, null);

            }
        }

        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the erro", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _ApplicationType.Title = TxtTitle.Text.Trim();
            _ApplicationType.Fees = Convert.ToSingle(TxtFees.Text.Trim());
            if (_ApplicationType.Save())
            {
                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }
    }
}
