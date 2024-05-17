using DVLD___Driving_License_Management.Global_Classes;
using DVLD___Driving_License_Management.Properties;
using DVLD_Buisness;
using Guna.UI2.WinForms;
using System;
using System.ComponentModel;
using System.Data;
using System.IO;
using System.Windows.Forms;
using TheArtOfDevHtmlRenderer.Adapters;

namespace DVLD___Driving_License_Management.People
{
    public partial class FrmAddUpdatePerson : Form
    {
        public delegate void DataBackEventHandler(object sender, int PersonID);
        public event DataBackEventHandler DataBack;
        public enum enMode
        { AddNew = 0, Update = 1 };
        public enum enGendor
        { Male = 0, Female = 1 };
        private enMode _Mode;
        private int _PersonID = -1;
        ClsPerson _Person;
        public FrmAddUpdatePerson()
        {
            InitializeComponent();
            _Mode = enMode.AddNew;
        }
        public FrmAddUpdatePerson(int PersonID)
        {
            InitializeComponent();
            _Mode = enMode.Update;
            _PersonID = PersonID;

        }
        private void _FillCountiesInComoboBox()
        {
            DataTable dtCountry = ClsCountry.GetAllCountries();
            foreach (DataRow Row in dtCountry.Rows)
            {
                CbCountry.Items.Add(Row["CountryName"].ToString());
            }
        }
        private void _ResetDefualtValues()
        {
            _FillCountiesInComoboBox();
            if (_Mode == enMode.AddNew)
            {
                LblTitle.Text = "Add New Person";
                _Person = new ClsPerson();
            }
            else
            {
                LblTitle.Text = "Update Person";
            }



            lblremove.Visible = (PbPersonImage.ImageLocation != null);
            DTPDateOfBirth.MaxDate = DateTime.Now.AddYears(-18);
            DTPDateOfBirth.Value = DTPDateOfBirth.MaxDate;
            DTPDateOfBirth.MinDate = DateTime.Now.AddYears(-100);

            CbCountry.SelectedIndex = CbCountry.FindString("Syria");
            TxtFirstName.Text = "";
            TxtSecondName.Text = "";
            TxtThirdName.Text = "";
            TxtLastName.Text = "";
            TxtNationalNo.Text = "";
            RbMale.Checked = true;
            TxtPhone.Text = "";
            TxtEmail.Text = "";
            TxtAddress.Text = "";
            if (RbMale.Checked)
            {
                PbPersonImage.Image = Resources.Male;
            }
            else
            {
                PbPersonImage.Image = Resources.Female_;
            }
        }


        private void _LoadData()
        {
            _Person = ClsPerson.FindPersonById(_PersonID);
            if (_Person == null)
            {
                MessageBox.Show("No Person with ID = " + _PersonID, "Person Not Found", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                this.Close();
                return;
            }

            LblPersonID.Text = _Person.PersonID.ToString();
            TxtFirstName.Text = _Person.FirstName;
            TxtSecondName.Text = _Person.SecondName;
            TxtThirdName.Text = _Person.ThirdName;
            TxtLastName.Text = _Person.LastName;
            TxtNationalNo.Text = _Person.NationalNo;
            DTPDateOfBirth.Value = _Person.DateOfBirth;

            if (_Person.Gendor == 0)
            {
                RbMale.Checked = true;
                PbPersonImage.Image = Resources.Male;
            }
             
            else if (_Person.Gendor == 1)
            {
                RbFemale.Checked = true;
                PbPersonImage.Image = Resources.Female_;
            }
               

            TxtAddress.Text = _Person.Address;
            TxtPhone.Text = _Person.Phone;
            TxtEmail.Text = _Person.Email;
            CbCountry.SelectedIndex = CbCountry.FindString(_Person.CountryInfo.CountryName);

            if (_Person.ImagePath != "")
            {
                PbPersonImage.ImageLocation = _Person.ImagePath;

            }



            lblremove.Visible = (_Person.ImagePath != "");
        }
        private void FrmAddUpdatePerson_Load(object sender, EventArgs e)
        {
            _ResetDefualtValues();
            if (_Mode == enMode.Update)
            {
                _LoadData();

            }

        }
        private bool _HandlePersonImage()
        {
            if (PbPersonImage.ImageLocation != _Person.ImagePath)
            {
                if (_Person.ImagePath != string.Empty)
                {
                    try
                    {
                        File.Delete(_Person.ImagePath);
                    }
                    catch (IOException iox)
                    {
                        MessageBox.Show("Error deleting Image File", iox.Message+ "Error" , MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }

                }
                if (PbPersonImage.ImageLocation != null)
                {
                    string SourceFile = PbPersonImage.ImageLocation.ToString();
                    if (clsUtil.CopyImageToProjectImagesFolder(ref SourceFile))
                    {
                        PbPersonImage.ImageLocation = SourceFile;
                        return true;
                    }
                    else
                    {
                        MessageBox.Show("Error Copying Image File", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return false;
                    }
                }


            }

            return true;
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {

                MessageBox.Show("Some fileds are not valide!, put the mouse over the red icon(s) to see the error!", "Validation Error !", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;

            }

            if (!_HandlePersonImage())
                return;

            int NationalityCountryID = ClsCountry.FindByName(CbCountry.Text).CountryID;
            _Person.FirstName = TxtFirstName.Text.Trim();
            _Person.SecondName = TxtSecondName.Text.Trim();
            _Person.ThirdName = TxtThirdName.Text.Trim();
            _Person.LastName = TxtLastName.Text.Trim();
            _Person.NationalNo = TxtNationalNo.Text.Trim();
            _Person.Email = TxtEmail.Text.Trim();
            _Person.Phone = TxtPhone.Text.Trim();
            _Person.Address = TxtAddress.Text.Trim();
            _Person.DateOfBirth = DTPDateOfBirth.Value;

            if (RbMale.Checked)
                _Person.Gendor = (short)enGendor.Male;
            else
                _Person.Gendor = (short)enGendor.Female;

            _Person.NationalityCountryID = NationalityCountryID;

            if (PbPersonImage.ImageLocation != null)
                _Person.ImagePath = PbPersonImage.ImageLocation;
            else
                _Person.ImagePath = "";

            if (_Person.Save())
            {
                LblPersonID.Text = _Person.PersonID.ToString();

                _Mode = enMode.Update;
                LblTitle.Text = "Update Person";

                MessageBox.Show("Data Saved Successfully.", "Saved", MessageBoxButtons.OK, MessageBoxIcon.Information);



                DataBack?.Invoke(this, _Person.PersonID);
            }
            else
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

        private void RbMale_Click(object sender, EventArgs e)
        {
            if (PbPersonImage.ImageLocation == null)
            {
                PbPersonImage.Image = Resources.Male;

            }
        }

        private void RbFemale_Click(object sender, EventArgs e)
        {
            if (PbPersonImage.ImageLocation == null)
            {
                PbPersonImage.Image = Resources.Female_;
            }
        }

        private void ValidateEmptyTextBox(object sender, CancelEventArgs e)
        {


            Guna2TextBox Temp = ((Guna2TextBox)sender);
            if (string.IsNullOrEmpty(Temp.Text.Trim()))
            {
                e.Cancel = true;
                Temp.Focus();
                errorProvider1.SetError(Temp, "This field is required!");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(Temp, null);
            }

        }

        private void BtnClose_Click(object sender, EventArgs e)
        {

            this.Close();
        }

        private void lblSetImage_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            openFileDialog1.Filter = @"Image Files|*.jpg;*.jpeg;*.png;*.gif;*.bmp";
            openFileDialog1.FilterIndex = 1;
            openFileDialog1.RestoreDirectory = true;

            if (openFileDialog1.ShowDialog() == DialogResult.OK)
            {

                string selectedFilePath = openFileDialog1.FileName;
                PbPersonImage.ImageLocation = selectedFilePath;
                lblremove.Visible = true;


            }


        }

        private void lblremove_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            PbPersonImage.ImageLocation = null;

            if (RbMale.Checked)
            {
                PbPersonImage.Image = Resources.Male;
            }
            else
            {
                PbPersonImage.Image = Resources.Female_;
            }
            lblremove.Visible = false;
        }

        private void BtnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void TxtEmail_Validating(object sender, CancelEventArgs e)
        {
            if (TxtEmail.Text.Trim() == string.Empty)
            {
                return;
            }

            if (!ClsValidation.ValidateEmail(TxtEmail.Text))
            {
                e.Cancel = true;
                TxtEmail.Focus();
                errorProvider1.SetError(TxtEmail, "Invalid Email Address Format!");
            }
            else
            {
                errorProvider1.SetError(TxtEmail, null);
            }
        }

        private void TxtNationalNo_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                TxtNationalNo.Focus();
                errorProvider1.SetError(TxtNationalNo, "This field is required!");
                return;
            }
            else
            {
                errorProvider1.SetError(TxtNationalNo, null);
            }

            if (TxtNationalNo.Text.Trim() != _Person.NationalNo && ClsPerson.IsPersonExist(TxtNationalNo.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtNationalNo, "National Number is used for another person!");

            }
            else
            {
                errorProvider1.SetError(TxtNationalNo, null);
            }
        }

        private void TxtPhone_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }
    }
}
