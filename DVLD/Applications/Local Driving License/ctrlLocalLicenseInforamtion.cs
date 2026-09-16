using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Application
{

    public partial class ctrlLocalLicenseInforamtion : UserControl
    {
        private int _localLicenseID = -1;
        private clsLocalDrivingLicenseApplication _localLicense;

        public ctrlLocalLicenseInforamtion()
        {
            InitializeComponent();
        }

        private void _ResetLocalLicense()
        {
            lblID.Text = "";
            lblPassedTests.Text = "";
            lblClassLicenseName.Text = "";
        }

        public void _LoadInformationByLocalLicenseID(int localLicenseID)
        {
            _localLicense = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localLicenseID);
            if (_localLicense == null)
            {
                MessageBox.Show("No localDrivingLinceseApplication with ID = " + localLicenseID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                _ResetLocalLicense();
                return;
            }
            _localLicenseID = localLicenseID;
            _FillLocalLicenseBasicInfo();
        }


        private void _FillLocalLicenseBasicInfo()
        {
            lblID.Text = _localLicense.LocalDrivingLicenseApplicationID.ToString();

            lblClassLicenseName.Text = clsLicenseClass.Find(_localLicense.LicenseClassID).ClassName;
            lblPassedTests.Text = clsTest.GetPassedTestCount(_localLicenseID).ToString() + "/3";
        }

       
    }
}
