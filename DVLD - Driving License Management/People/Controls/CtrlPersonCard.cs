using DVLD___Driving_License_Management.Properties;
using DVLD_Buisness;
using System.IO;
using System.Windows.Forms;
using static DVLD___Driving_License_Management.People.FrmAddUpdatePerson;

namespace DVLD___Driving_License_Management.People.Controls
{
    public partial class CtrlPersonCard : UserControl
    {
        private ClsPerson _PersonInfo;
        private int _PersonID = -1;
        public CtrlPersonCard()
        {
            InitializeComponent();
        }
        public int PersonID
        {
            get { return _PersonID; }
        }

        public ClsPerson SelectedPersonInfo
        {
            get { return _PersonInfo; }
        }

        public void LoadPersonInfo(int Person)
        {
            _PersonInfo = ClsPerson.FindPersonById(Person);
            if (_PersonInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with that ID = " + PersonID.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            _FillPersonInfo();
        }
        public void LoadPersonInfo(string NationalNo)
        {
            _PersonInfo = ClsPerson.Find(NationalNo);
            if (_PersonInfo == null)
            {
                ResetPersonInfo();
                MessageBox.Show("No Person with National No. = " + NationalNo.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _FillPersonInfo();
        }
        public void ResetPersonInfo()
        {
            _PersonID = -1;
            LblPersonID.Text = "No Data";
            LblNationalNO.Text = "No Data";
            LblFullName.Text = "No Data";
            PbGendor.Image = Resources.icons8_male_5001;
            LblGendor.Text = "No Data";
            LblEmail.Text = "No Data";
            LblPhone.Text = "No Data";
            LblDateBirth.Text = "No Data";
            LblCountry.Text = "No Data";
            LblAddress.Text = "No Data";
            PbPersonImage.Image = Resources.Male;
            llEditPersonInfo.Visible = false;

        }
        private void _FillPersonInfo()
        {
            llEditPersonInfo.Visible = true;
            _PersonID = _PersonInfo.PersonID;
            LblPersonID.Text = _PersonInfo.PersonID.ToString();
            LblNationalNO.Text = _PersonInfo.NationalNo;
            LblFullName.Text = _PersonInfo.FullName;
    
            LblGendor.Text = _PersonInfo.Gendor == 0 ? "Male" : "Female";
            PbGendor.Image = _PersonInfo.Gendor == 0 ? Resources.icons8_male_5001 : Resources.icons8_female_5001;
            LblEmail.Text = _PersonInfo.Email;
            LblPhone.Text = _PersonInfo.Phone;
            LblDateBirth.Text = _PersonInfo.DateOfBirth.ToShortDateString();
            LblCountry.Text = ClsCountry.FindById(_PersonInfo.NationalityCountryID).CountryName;
            LblAddress.Text = _PersonInfo.Address;
            _LoadPersonImage();
        }
        private void _LoadPersonImage()
        {
            if (_PersonInfo.Gendor == 0)
                PbPersonImage.Image = Resources.Male;
            else
                PbPersonImage.Image = Resources.Female_;

            string ImagePath = _PersonInfo.ImagePath;
            if (ImagePath != "")
                if (File.Exists(ImagePath))
                    PbPersonImage.ImageLocation = ImagePath;
                else
                    MessageBox.Show("Could not find this image: = " + ImagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);

        }

        private void llEditPersonInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            FrmAddUpdatePerson newFrmPerson = new FrmAddUpdatePerson(_PersonID);
            newFrmPerson.ShowDialog();

            LoadPersonInfo(_PersonID);
        }
    }
}
