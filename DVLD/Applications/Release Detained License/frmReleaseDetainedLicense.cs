using DVLD.Drivers;
using DVLD.Global;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmReleaseDetainedLicense : Form
    {
        private int _selectedLicenseID = -1;

        public frmReleaseDetainedLicense()
        {
            InitializeComponent();
        }

        public frmReleaseDetainedLicense(int licenseId)
        {
            InitializeComponent();

            _selectedLicenseID = licenseId;

            ctrlDriverLicenseInfoControlwithFilter1.LoadInfo(_selectedLicenseID);
            ctrlDriverLicenseInfoControlwithFilter1.IsFilterEnabled = false;
        }

        private void frmReleaseDetainedLicense_Load(object sender, EventArgs e)
        {
            clsApplicationTypes appType = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense);
            lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";

            lblCreatedByUser.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";
        }

        private void ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected(int obj)
        {
            _selectedLicenseID = obj;

            lblLicenseID.Text = _selectedLicenseID.ToString();
            llShowLicensesHistory.Enabled = (_selectedLicenseID != -1);

            if (_selectedLicenseID == -1 || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                btnRelease.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsDetained || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DetainedInfo == null)
            {
                MessageBox.Show("Selected License is not detained, choose another one.", "Not allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRelease.Enabled = false;
                return;
            }

            clsApplicationTypes appType = clsApplicationTypes.Find((int)clsApplication.enApplicationType.ReleaseDetainedDrivingLicense);
            lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";

            lblCreatedByUser.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";

            lblDetainID.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DetainedInfo.DetainID.ToString();
            lblLicenseID.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseID.ToString();

            lblDetainDate.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DetainedInfo.DetainDate.ToString("dd/MM/yyyy");
            lblFineFees.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DetainedInfo.FineFees.ToString();

            float applicationFees = Convert.ToSingle(lblApplicationFees.Text);
            float fineFees = Convert.ToSingle(lblFineFees.Text);
            lblTotalFees.Text = (applicationFees + fineFees).ToString();

            btnRelease.Enabled = true;
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
                return;

            if (MessageBox.Show("Are you sure you want to release this detained license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int applicationID = -1;
            int currentUserID = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserID : 1;

            bool isReleased = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.ReleaseDetainedLicense(currentUserID, ref applicationID);

            lblApplicationID.Text = applicationID.ToString();

            if (!isReleased)
            {
                MessageBox.Show("Failed to release the Detain License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            MessageBox.Show("Detained License released Successfully", "Detained License Released", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRelease.Enabled = false;
            ctrlDriverLicenseInfoControlwithFilter1.IsFilterEnabled = false;
            llShowNewLicenseInfo.Enabled = true;
        }

        private void llShowLicensesHistory_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo == null)
            {
                MessageBox.Show("Please select a license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int personID = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.DriverInfo.PersonID;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(personID);
            frm.ShowDialog();
        }

        private void llShowNewLicenseInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (_selectedLicenseID == -1)
            {
                MessageBox.Show("Please select a license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(_selectedLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}