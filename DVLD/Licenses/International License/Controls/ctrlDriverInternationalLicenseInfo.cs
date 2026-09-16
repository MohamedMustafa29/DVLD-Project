using DVLD.Properties;
using DVLD_Business;
using DVLD_Business;
using System;
using System.IO;
using System.Windows.Forms;

namespace DVLD.Licenses.International_License.Controls
{
    public partial class ctrlDriverInternationalLicenseInfo : UserControl
    {
        private clsInternationalLicense _internationalLicense;

        private int _internationalLicenseID = -1;
        public int InternationalLicenseID
        {
            get { return _internationalLicenseID; }
        }

        public clsInternationalLicense SelectedInternationalLicenseInfo
        {
            get { return _internationalLicense; }
        }

        public ctrlDriverInternationalLicenseInfo()
        {
            InitializeComponent();
        }

        private void _LoadPersonImage()
        {
            if (_internationalLicense.DriverInfo.personInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string imagePath = _internationalLicense.DriverInfo.personInfo.ImagePath;

            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                    pbPersonImage.Load(imagePath);
                else
                    MessageBox.Show("Could not find this image: " + imagePath, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        public void LoadInternationalLicenseInfo(int internationalLicenseID)
        {
            _internationalLicenseID = internationalLicenseID;
            _internationalLicense = clsInternationalLicense.Find(internationalLicenseID);

            if (_internationalLicense == null)
            {
                MessageBox.Show("International License with ID = " + internationalLicenseID + " is not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblName.Text = _internationalLicense.DriverInfo.personInfo.FullName;
            lblIntLicenseID.Text = _internationalLicense.InternationalLicenseID.ToString();
            lblLicenseID.Text = _internationalLicense.IssuedUsingLocalLicenseID.ToString();
            lblNAtionalNumber.Text = _internationalLicense.DriverInfo.personInfo.NationalNo;
            lblGender.Text = _internationalLicense.DriverInfo.personInfo.Gender == 0 ? "Male" : "Female";
            lblIssueDate.Text = _internationalLicense.IssueDate.ToShortDateString();

            lblApplicationID.Text = _internationalLicense.ApplicationID.ToString();
            lblIsActive.Text = _internationalLicense.IsActive ? "Yes" : "No";
            lblDataOfBrith.Text = _internationalLicense.DriverInfo.personInfo.DateOfBirth.ToShortDateString();
            lblDriverID.Text = _internationalLicense.DriverID.ToString();
            lblExpirationDate.Text = _internationalLicense.ExpirationDate.ToShortDateString();

            _LoadPersonImage();
        }
    }
}