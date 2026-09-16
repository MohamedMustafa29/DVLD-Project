using DVLD.Licenses;
using DVLD.Licenses.International_License;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Drivers.Controls
{
    public partial class ctrlDriverLicenses : UserControl
    {
        private int _driverId = -1;
        private clsDriver _driver;
        private DataTable _dtDriverLocalLicensesHistory;
        private DataTable _dtDriverInternationalLicensesHistory;

        public ctrlDriverLicenses()
        {
            InitializeComponent();
        }

        private void _LoadDriverLocalLicenses()
        {
            _dtDriverLocalLicensesHistory = clsDriver.GetAllLicenses(_driverId);
            dgvLocalLicenses.DataSource = _dtDriverLocalLicensesHistory;

            lblNumberOfLocalLicenses.Text = dgvLocalLicenses.Rows.Count.ToString();

            if (dgvLocalLicenses.Rows.Count > 0)
            {
                dgvLocalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvLocalLicenses.Columns["LicenseID"].HeaderText = "Lic.ID";
                dgvLocalLicenses.Columns["ApplicationID"].HeaderText = "App.ID";
                dgvLocalLicenses.Columns["ClassName"].HeaderText = "Class Name";
                dgvLocalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvLocalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvLocalLicenses.Columns["IsActive"].HeaderText = "Is Active";

                dgvLocalLicenses.Columns["LicenseID"].FillWeight = 80;
                dgvLocalLicenses.Columns["ApplicationID"].FillWeight = 80;
                dgvLocalLicenses.Columns["ClassName"].FillWeight = 250;
                dgvLocalLicenses.Columns["IssueDate"].FillWeight = 140;
                dgvLocalLicenses.Columns["ExpirationDate"].FillWeight = 140;
                dgvLocalLicenses.Columns["IsActive"].FillWeight = 80;
            }
        }

        private void _LoadDriverInternationalLicenses()
        {
            _dtDriverInternationalLicensesHistory = clsInternationalLicense.GetDriverInternationalLicenses(_driverId);
            dgvInternationalLicenses.DataSource = _dtDriverInternationalLicensesHistory;

            lblNumberOfInternationalLicenses.Text = dgvInternationalLicenses.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvInternationalLicenses.Columns["InternationalLicenseID"].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns["ApplicationID"].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns["IssuedUsingLocalLicenseID"].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns["IssueDate"].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns["ExpirationDate"].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns["IsActive"].HeaderText = "Is Active";

                dgvInternationalLicenses.Columns["InternationalLicenseID"].FillWeight = 100;
                dgvInternationalLicenses.Columns["ApplicationID"].FillWeight = 100;
                dgvInternationalLicenses.Columns["IssuedUsingLocalLicenseID"].FillWeight = 100;
                dgvInternationalLicenses.Columns["IssueDate"].FillWeight = 120;
                dgvInternationalLicenses.Columns["ExpirationDate"].FillWeight = 120;
                dgvInternationalLicenses.Columns["IsActive"].FillWeight = 80;
            }
        }

        public void LoadDriverLicenses(int driverId)
        {
            _driverId = driverId;
            _driver = clsDriver.FindByDriverID(_driverId);

            if (_driver == null)
            {
                MessageBox.Show("Driver with ID = " + driverId + " was not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _LoadDriverLocalLicenses();
            _LoadDriverInternationalLicenses();
        }

        public void LoadInfoBypersonID(int personID)
        {
            _driver = clsDriver.FindByPersonID(personID);

            if (_driver == null)
            {
                MessageBox.Show("No driver linked with Person ID = " + personID, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Clear();
                return;
            }

            _driverId = _driver.DriverID;

            _LoadDriverLocalLicenses();
            _LoadDriverInternationalLicenses();
        }

        public void Clear()
        {
            if (_dtDriverLocalLicensesHistory != null)
                _dtDriverLocalLicensesHistory.Clear();

            if (_dtDriverInternationalLicensesHistory != null)
                _dtDriverInternationalLicensesHistory.Clear();
        }

        private void showLicensesInfoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvLocalLicenses.CurrentRow == null) return;

            int localLicenseID = (int)dgvLocalLicenses.CurrentRow.Cells[0].Value;
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(localLicenseID);
            frm.ShowDialog();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.CurrentRow == null) return;

            int internationalLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(internationalLicenseID);
            frm.ShowDialog();
        }
    }
}