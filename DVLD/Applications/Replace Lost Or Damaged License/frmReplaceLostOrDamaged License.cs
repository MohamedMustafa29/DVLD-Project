using DVLD.Drivers;
using DVLD.Global;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Replace_Lost_Or_Damaged_License
{
    public partial class frmReplaceLostOrDamaged_License : Form
    {
        private int _newLicenseID = -1;

        public frmReplaceLostOrDamaged_License()
        {
            InitializeComponent();
        }

        private int _GetApplicationTypeID()
        {
            return rbDamaged.Checked
                ? (int)clsApplication.enApplicationType.ReplaceDamagedDrivingLicense
                : (int)clsApplication.enApplicationType.ReplaceLostDrivingLicense;
        }

        private clsLicense.enIssueReason _GetIssueReason()
        {
            return rbDamaged.Checked
                ? clsLicense.enIssueReason.DamagedReplacement
                : clsLicense.enIssueReason.LostReplacement;
        }

        private void frmReplaceLostOrDamaged_License_Load(object sender, EventArgs e)
        {
            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblCreatedBy.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";

            rbDamaged.Checked = true;
        }

        private void ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected(int obj)
        {
            int selectedLicenseID = obj;
            lblOldLicenseID.Text = selectedLicenseID.ToString();
            llShowLicensesHistory.Enabled = (selectedLicenseID != -1);

            if (selectedLicenseID == -1 || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                btnIssueReplacement.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Detained, you cannot replace a detained license. Release it first.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsActive)
            {
                MessageBox.Show("Selected License is not Active, choose another license.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnIssueReplacement.Enabled = false;
                return;
            }

            btnIssueReplacement.Enabled = true;
        }

        private void rbDamaged_CheckedChanged(object sender, EventArgs e)
        {
            if (rbDamaged.Checked)
            {
                lblTitle.Text = "Replacement for Damaged License";
                this.Text = lblTitle.Text;

                clsApplicationTypes appType = clsApplicationTypes.Find(_GetApplicationTypeID());
                lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";
            }
        }

        private void rbLost_CheckedChanged(object sender, EventArgs e)
        {
            if (rbLost.Checked)
            {
                lblTitle.Text = "Replacement for Lost License";
                this.Text = lblTitle.Text;

                clsApplicationTypes appType = clsApplicationTypes.Find(_GetApplicationTypeID());
                lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";
            }
        }

        private void btnIssueReplacement_Click(object sender, EventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                MessageBox.Show("Please select a valid license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Issue a Replacement for the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int createdByUserID = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserID : 1;

            clsLicense newLicense = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.Replace(_GetIssueReason(), createdByUserID);

            if (newLicense == null)
            {
                MessageBox.Show("Failed to Issue a replacement for this License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRLApplicationID.Text = newLicense.ApplicationID.ToString();
            _newLicenseID = newLicense.LicenseID;
            lblRreplacedLicenseID.Text = _newLicenseID.ToString();

            MessageBox.Show("License Replaced Successfully with ID=" + _newLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnIssueReplacement.Enabled = false;
            gbReplacementFor.Enabled = false;
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
            if (_newLicenseID == -1)
            {
                MessageBox.Show("Please issue a replacement license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(_newLicenseID);
            frm.ShowDialog();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}