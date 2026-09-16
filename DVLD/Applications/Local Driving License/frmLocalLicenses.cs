using DVLD.Applications.Test.Sechdule_Test;
using DVLD.Drivers;
using DVLD.Licenses;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Manage_Application
{
    public partial class frmLocalLicenses : Form
    {
        public DataTable dtAllApplications;

        public frmLocalLicenses()
        {
            InitializeComponent();
        }

        private void _RefreshLocalDrivingLicenseApplicationsList()
        {
            dtAllApplications = clsLocalDrivingLicenseApplication.GetAllLocalDrivingLicenseApplications();

            dgvAddLocalLincense.DataSource = dtAllApplications;
            lblNumbers.Text = dtAllApplications != null ? dtAllApplications.Rows.Count.ToString() : "0";

            if (dtAllApplications != null && dgvAddLocalLincense.Rows.Count > 0)
            {
                dgvAddLocalLincense.Columns[0].HeaderText = "L.D.L.AppID";
                dgvAddLocalLincense.Columns[0].Width = 100;

                dgvAddLocalLincense.Columns[1].HeaderText = "Driving Class";
                dgvAddLocalLincense.Columns[1].Width = 250;

                dgvAddLocalLincense.Columns[2].HeaderText = "National No.";
                dgvAddLocalLincense.Columns[2].Width = 120;

                dgvAddLocalLincense.Columns[3].HeaderText = "Full Name";
                dgvAddLocalLincense.Columns[3].Width = 300;

                dgvAddLocalLincense.Columns[4].HeaderText = "Application Date";
                dgvAddLocalLincense.Columns[4].Width = 170;

                dgvAddLocalLincense.Columns[5].HeaderText = "Passed Tests";
                dgvAddLocalLincense.Columns[5].Width = 120;

                dgvAddLocalLincense.Columns[6].HeaderText = "Status";
                dgvAddLocalLincense.Columns[6].Width = 110;
            }
        }

        private void frmLocalLicenses_Load(object sender, EventArgs e)
        {
            _RefreshLocalDrivingLicenseApplicationsList();
            cbFilter.SelectedIndex = 0;
        }

        private void btnAddLicense_Click(object sender, EventArgs e)
        {
            frmAddLocalLicense frm = new frmAddLocalLicense();
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void editApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null)
                return;

            frmAddLocalLicense frm = new frmAddLocalLicense((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void deleteApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            if (MessageBox.Show("Are you sure you want to delete this Application ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int localDrivingLicenseApplicationID = (int)dgvAddLocalLincense.CurrentRow.Cells[0].Value;

                clsLocalDrivingLicenseApplication localDrivingLicenseApplication = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

                if (localDrivingLicenseApplication != null)
                {
                    if (localDrivingLicenseApplication.Delete())
                    {
                        MessageBox.Show("Application Deleted Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        _RefreshLocalDrivingLicenseApplicationsList();
                    }
                    else
                    {
                        MessageBox.Show("Could not delete this application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
        }

        private void canslToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            if (MessageBox.Show("Are you sure you want to Cancel this Application ?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                int localAppID = (int)dgvAddLocalLincense.CurrentRow.Cells[0].Value;

                clsLocalDrivingLicenseApplication localApp = clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localAppID);

                if (localApp != null && clsLocalDrivingLicenseApplication.CancelApplication(localApp.ApplicationID))
                {
                    _RefreshLocalDrivingLicenseApplicationsList();
                    MessageBox.Show("Application Canceled successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {
                    MessageBox.Show("Failed to Canceled Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                if (dtAllApplications != null)
                {
                    dtAllApplications.DefaultView.RowFilter = "";
                    lblNumbers.Text = dgvAddLocalLincense.Rows.Count.ToString();
                }
                return;
            }

            txtFilter.Visible = true;
            txtFilter.Text = "";
            txtFilter.Focus();
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (dtAllApplications == null)
                return;

            string filterColumn = null;

            switch (cbFilter.Text)
            {
                case "L.D.L.AppID":
                    filterColumn = "LocalDrivingLicenseApplicationID";
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "FullName":
                    filterColumn = "FullName";
                    break;
                case "Status":
                    filterColumn = "Status";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || cbFilter.Text == "None")
            {
                dtAllApplications.DefaultView.RowFilter = "";
                lblNumbers.Text = dgvAddLocalLincense.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "LocalDrivingLicenseApplicationID")
            {
                if (int.TryParse(txtFilter.Text.Trim(), out int tempID))
                {
                    dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tempID);
                }
                else
                {
                    dtAllApplications.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                dtAllApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilter.Text.Trim());
            }

            lblNumbers.Text = dgvAddLocalLincense.Rows.Count.ToString();
        }

        private void showDetaToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            frmLocalDrivingLicenseApplicationInfo frm = new frmLocalDrivingLicenseApplicationInfo((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void contextMenuStrip1_Opening(object sender, CancelEventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null)
                return;

            int localDrivingLicenseApplicationID = (int)dgvAddLocalLincense.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication == null)
                return;

            int totalPassedTests = (int)dgvAddLocalLincense.CurrentRow.Cells[5].Value;
            bool licenseExists = localDrivingLicenseApplication.IsLicenseIssued();

            bool isApplicationNew = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.New);
            bool isCompleted = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.Completed);
            bool isCanceled = (localDrivingLicenseApplication.ApplicationStatus == clsApplication.enApplicationStatus.Cancelled);

            showLicenseToolStripMenuItem.Enabled = isCompleted;
            issueDrivingLicenseFirstTimeToolStripMenuItem.Enabled = (totalPassedTests == 3) && !licenseExists && !isCanceled;

            editApplicationToolStripMenuItem.Enabled = !licenseExists && isApplicationNew;
            canslToolStripMenuItem.Enabled = isApplicationNew;
            deleteApplicationToolStripMenuItem.Enabled = isApplicationNew;

            bool passedVisionTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.VisionTest);
            bool passedWrittenTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.WrittenTest);
            bool passedStreetTest = localDrivingLicenseApplication.DoesPassTestType(clsTestTypes.enTestType.StreetTest);

            ScheduleTestsMenue.Enabled = (!passedVisionTest || !passedWrittenTest || !passedStreetTest) && !licenseExists && isApplicationNew;

            if (ScheduleTestsMenue.Enabled)
            {
                scheduleVisionTestToolStripMenuItem.Enabled = !passedVisionTest;
                scheduleWrittenTestToolStripMenuItem.Enabled = passedVisionTest && !passedWrittenTest;
                scheduleStreetTestToolStripMenuItem.Enabled = passedVisionTest && passedWrittenTest && !passedStreetTest;
            }
        }

        private void scheduleVisionTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) return;

            frmscheduleTests frm = new frmscheduleTests((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value, clsTestTypes.enTestType.VisionTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void scheduleWrittenTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null)
                return;

            frmscheduleTests frm = new frmscheduleTests((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value, clsTestTypes.enTestType.WrittenTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void scheduleStreetTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            frmscheduleTests frm = new frmscheduleTests((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value, clsTestTypes.enTestType.StreetTest);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void issueLicenseForTheFirstTimeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            frmIssueLicensefortheFirstTime frm = new frmIssueLicensefortheFirstTime((int)dgvAddLocalLincense.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _RefreshLocalDrivingLicenseApplicationsList();
        }

        private void showDriverLicenseInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null)
                return;

            int localDrivingLicenseApplicationID = (int)dgvAddLocalLincense.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication != null)
            {
                int licenseID = localDrivingLicenseApplication.GetActiveLicenseID();

                if (licenseID != -1)
                {
                    frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(licenseID);
                    frm.ShowDialog();
                    _RefreshLocalDrivingLicenseApplicationsList();
                }
                else
                {
                    MessageBox.Show("No License Found for this Application.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void showPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvAddLocalLincense.CurrentRow == null) 
                return;

            int localDrivingLicenseApplicationID = (int)dgvAddLocalLincense.CurrentRow.Cells[0].Value;

            clsLocalDrivingLicenseApplication localDrivingLicenseApplication =
                clsLocalDrivingLicenseApplication.FindByLocalDrivingLicenseApplicationID(localDrivingLicenseApplicationID);

            if (localDrivingLicenseApplication != null)
            {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(localDrivingLicenseApplication.ApplicantPersonID);
                frm.ShowDialog();
                _RefreshLocalDrivingLicenseApplicationsList();
            }
        }
    }
}