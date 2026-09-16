using DVLD.Properties;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.IO;

namespace DVLD.Licenses.Controls
{
    public partial class ctrlDriverLicenseInfoControl : UserControl
    {
        private clsLicense _license;
    
        private int _licenseID;
        public int LicenseID
        {
            get { return _licenseID; }

        }

        public clsLicense SelectedLicensesInfo
        { get { return _license; } }




        public ctrlDriverLicenseInfoControl()
        {
            InitializeComponent();
        }


        private void _LoadPersonImage()
        {
            if (_license.DriverInfo.personInfo.Gender == 0)
                pbPersonImage.Image = Resources.Male_512;
            else
                pbPersonImage.Image = Resources.Female_512;

            string imagePath = _license.DriverInfo.personInfo.ImagePath;

            if (!string.IsNullOrEmpty(imagePath))
            {
                if (File.Exists(imagePath))
                    pbPersonImage.Load(imagePath);
                else
                    MessageBox.Show("Could not find this image: = " + imagePath);
            }
        }


        public void LoadLicenseInfo(int licenseID)
        {
            _licenseID = licenseID;
            _license = clsLicense.Find(licenseID);
            if (_license == null)
            {
                MessageBox.Show("License not found.");
                return;
            }
            lblClassName.Text = _license.LicenseClassInfo.ClassName;
            lblLicenseID.Text = _license.LicenseID.ToString();
            lblName.Text = _license.DriverInfo.personInfo.FullName;
            lblGender.Text = _license.DriverInfo.personInfo.Gender==0?"male":"female";
            lblIsActive.Text = _license.IsActive ? "Active" : "Inactive";
            lblExpirationDate.Text = _license.ExpirationDate.ToShortDateString();
            lblDataOfBrith.Text = _license.DriverInfo.personInfo.DateOfBirth.ToShortDateString();
            lblIssueDate.Text = _license.IssueDate.ToShortDateString();
            lblDriverID.Text = _license.DriverInfo.DriverID.ToString();
            lblISDetained.Text = _license.IsDetained ? "Yes" : "No";
            lblIssueReason.Text = _license.IssueReason.ToString();
            lblNotes.Text = _license.Notes==""?"No Notes":_license.Notes;
            lblNAtionalNumber.Text = _license.DriverInfo.personInfo.NationalNo;


            _LoadPersonImage();



        }
    }
}
