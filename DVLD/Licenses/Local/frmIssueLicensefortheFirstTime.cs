using DVLD.Global;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmIssueLicensefortheFirstTime : Form
    {
        private int _localDrivingLicenseApplicationID = -1;
        private clsLocalDrivingLicenseApplication _localDrivingLicenseApplication;

        public frmIssueLicensefortheFirstTime(int localDrivingLicenseApplicationID)
        {
            InitializeComponent();
            _localDrivingLicenseApplicationID = localDrivingLicenseApplicationID;
        }

        private void frmIssueLicensefortheFirstTime_Load(object sender, EventArgs e)
        {
            txtNotes.Focus();

            _localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);

            if (_localDrivingLicenseApplication == null)
            {
                MessageBox.Show("No Application with ID = " + _localDrivingLicenseApplicationID, "Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            if (!_localDrivingLicenseApplication.PassedAllTests())
            {
                MessageBox.Show("Person Should Pass All Tests First.", "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            int licenseID = _localDrivingLicenseApplication.GetActiveLicenseID();
            if (licenseID != -1)
            {
                MessageBox.Show("Person already has License before with License ID = " + licenseID, "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnSave.Enabled = false;
                this.Close();
                return;
            }

            ctrlLocalDrivingLicenseApplicationInfo1.LoadByLocalDrivingLicenseApplicationID(_localDrivingLicenseApplicationID);
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            int licenseID = _localDrivingLicenseApplication.IssuelicensefortheFirstTime(txtNotes.Text.Trim(), clsGlobal.currentUser.UserID);

            if (licenseID == -1)
            {
                MessageBox.Show("Error in issuing license for the first time.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                MessageBox.Show("License issued successfully with ID = " + licenseID, "Succeeded", MessageBoxButtons.OK, MessageBoxIcon.Information);

                btnSave.Enabled = false;
                this.Close();
            }
        }

   
    }
}