using DVLD.Drivers;
using DVLD.Global;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Applications.Renew_Driver_License
{
    public partial class frmRenewDriverLicense : Form
    {
        private int _newLicenseID = -1;

        public frmRenewDriverLicense()
        {
            InitializeComponent();
        }

        private void frmRenewDriverLicense_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoControlwithFilter1.txtFilterFocus();

            lblApplicationDate.Text = DateTime.Now.ToString("dd/MM/yyyy");
            lblIssueDate.Text = lblApplicationDate.Text;
            lblExpirationDate.Text = "???";

            clsApplicationTypes appType = clsApplicationTypes.Find((int)clsApplication.enApplicationType.RenewDrivingLicense);
            lblApplicationFees.Text = (appType != null) ? appType.ApplicationFees.ToString() : "0";

            lblCreatedBy.Text = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserName : "";
        }

        private void ctrlDriverLicenseInfoControlwithFilter1_OnLicenseSelected(int obj)
        {
            int selectedLicenseID = obj;
            lblOldLicenseID.Text = selectedLicenseID.ToString();

            llShowLicensesHistory.Enabled = (selectedLicenseID != -1);

            if (selectedLicenseID == -1 || ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                btnRenew.Enabled = false;
                return;
            }

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseClassInfo == null)
            {
                btnRenew.Enabled = false;
                return;
            }

            int defaultValidityLength = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseClassInfo.DefaultValidityLength;
            lblExpirationDate.Text = DateTime.Now.AddYears(defaultValidityLength).ToString("dd/MM/yyyy");
            lblLicenseFees.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.LicenseClassInfo.ClassFees.ToString();

            float appFees = Convert.ToSingle(lblApplicationFees.Text);
            float licenseFees = Convert.ToSingle(lblLicenseFees.Text);
            lblTotalFees.Text = (appFees + licenseFees).ToString();

            txtNotes.Text = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.Notes;

            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsDetained)
            {
                MessageBox.Show("Selected License is Detained, you cannot renew a detained license. Release it first.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsLicenseExpired())
            {
                MessageBox.Show("Selected License is not yet expired, it will expire on: " +
                    ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.ExpirationDate.ToString("dd/MM/yyyy"),
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            if (!ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.IsActive)
            {
                MessageBox.Show("Selected License is Not Active, choose another license.",
                    "Not Allowed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                btnRenew.Enabled = false;
                return;
            }

            btnRenew.Enabled = true;
        }

        private void btnRenew_Click(object sender, EventArgs e)
        {
            if (ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo == null)
            {
                MessageBox.Show("Please select a valid license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (MessageBox.Show("Are you sure you want to Renew the license?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.No)
            {
                return;
            }

            int createdByUserID = (clsGlobal.currentUser != null) ? clsGlobal.currentUser.UserID : 1;

            clsLicense newLicense = ctrlDriverLicenseInfoControlwithFilter1.SelectedLicensesInfo.RenewLicense(txtNotes.Text.Trim(), createdByUserID);

            if (newLicense == null)
            {
                MessageBox.Show("Failed to Renew the License", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            lblRLApplicationID.Text = newLicense.ApplicationID.ToString();
            _newLicenseID = newLicense.LicenseID;
            lblRenewedLicenseID.Text = _newLicenseID.ToString();

            MessageBox.Show("License Renewed Successfully with ID= " + _newLicenseID.ToString(), "License Issued", MessageBoxButtons.OK, MessageBoxIcon.Information);

            btnRenew.Enabled = false;
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
                MessageBox.Show("Please renew the license first.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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