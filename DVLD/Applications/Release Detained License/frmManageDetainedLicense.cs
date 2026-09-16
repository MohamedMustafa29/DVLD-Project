using DVLD.Drivers;
using DVLD.Licenses;
using DVLD.Licenses.Detain_License;
using DVLD.People;
using DVLD_Business;
using System;
using System.ComponentModel;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Applications.Release_Detained_License
{
    public partial class frmManageDetainedLicense : Form
    {
        private DataTable _dtAllDetainedLicenses;

        public frmManageDetainedLicense()
        {
            InitializeComponent();
        }

        private void _RefreshDetainedLicensesList()
        {
            _dtAllDetainedLicenses = clsDetainedLicense.GetAllDetainedLicenses();
            dgvDetainedLicenses.DataSource = _dtAllDetainedLicenses;
            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();

            if (dgvDetainedLicenses.Rows.Count > 0)
            {
                dgvDetainedLicenses.Columns[0].HeaderText = "D.ID";
                dgvDetainedLicenses.Columns[0].Width = 90;

                dgvDetainedLicenses.Columns[1].HeaderText = "L.ID";
                dgvDetainedLicenses.Columns[1].Width = 90;

                dgvDetainedLicenses.Columns[2].HeaderText = "D.Date";
                dgvDetainedLicenses.Columns[2].Width = 160;

                dgvDetainedLicenses.Columns[3].HeaderText = "Is Released";
                dgvDetainedLicenses.Columns[3].Width = 110;

                dgvDetainedLicenses.Columns[4].HeaderText = "Fine Fees";
                dgvDetainedLicenses.Columns[4].Width = 110;

                dgvDetainedLicenses.Columns[5].HeaderText = "Release Date";
                dgvDetainedLicenses.Columns[5].Width = 160;

                dgvDetainedLicenses.Columns[6].HeaderText = "N.No.";
                dgvDetainedLicenses.Columns[6].Width = 90;

                dgvDetainedLicenses.Columns[7].HeaderText = "Full Name";
                dgvDetainedLicenses.Columns[7].Width = 220;

                dgvDetainedLicenses.Columns[8].HeaderText = "Release App.ID";
                dgvDetainedLicenses.Columns[8].Width = 130;
            }
        }

        private void frmManageDetainedLicense_Load(object sender, EventArgs e)
        {
            cbFilter.SelectedIndex = 0;
            _RefreshDetainedLicensesList();
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "Is Released")
            {
                txtChangeNameFilter.Visible = false;
                cbIsReleased.Visible = true;
                cbIsReleased.Focus();
                cbIsReleased.SelectedIndex = 0;
            }
            else
            {
                txtChangeNameFilter.Visible = (cbFilter.Text != "None");
                cbIsReleased.Visible = false;

                txtChangeNameFilter.Text = "";
                if (cbFilter.Text != "None")
                {
                    txtChangeNameFilter.Focus();
                }
            }

            if (_dtAllDetainedLicenses != null)
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
            }
        }

        private void txtChangeNameFilter_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllDetainedLicenses == null)
                return;

            string filterColumn = "";

            switch (cbFilter.Text)
            {
                case "Detain ID":
                    filterColumn = "DetainID";
                    break;
                case "National No":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "Release Application ID":
                    filterColumn = "ReleaseApplicationID";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (txtChangeNameFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "DetainID" || filterColumn == "ReleaseApplicationID")
            {
                if (int.TryParse(txtChangeNameFilter.Text.Trim(), out int tempID))
                {
                    _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tempID);
                }
                else
                {
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtAllDetainedLicenses.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtChangeNameFilter.Text.Trim());
            }

            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void cbIsReleased_SelectedIndexChanged_1(object sender, EventArgs e)
        {
            if (_dtAllDetainedLicenses == null)
                return;

            string filterValue = cbIsReleased.Text;

            switch (filterValue)
            {
                case "All":
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "";
                    break;
                case "Yes":
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 1";
                    break;
                case "No":
                    _dtAllDetainedLicenses.DefaultView.RowFilter = "[IsReleased] = 0";
                    break;
            }

            lblTotalRecords.Text = dgvDetainedLicenses.Rows.Count.ToString();
        }

        private void btnRelease_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void showPersonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
                return;

            string nationalNo = Convert.ToString(dgvDetainedLicenses.CurrentRow.Cells[6].Value);
            clsPerson person = clsPerson.FindPeopleByNationalNo(nationalNo);

            if (person != null)
            {
                frmShowPersonInfo frm = new frmShowPersonInfo(person.PersonID);
                frm.ShowDialog();
            }
        }

        private void showLicenseDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            int licenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            frmShowDriverLicenseInfo frm = new frmShowDriverLicenseInfo(licenseID);
            frm.ShowDialog();
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null) return;

            string nationalNo = Convert.ToString(dgvDetainedLicenses.CurrentRow.Cells[6].Value);
            clsPerson person = clsPerson.FindPeopleByNationalNo(nationalNo);

            if (person != null)
            {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(person.PersonID);
                frm.ShowDialog();
            }
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
                return;

            int licenseID = (int)dgvDetainedLicenses.CurrentRow.Cells[1].Value;
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense(licenseID);
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }

        private void cmsApplications_Opening(object sender, CancelEventArgs e)
        {
            if (dgvDetainedLicenses.CurrentRow == null)
                return;

            bool isReleased = Convert.ToBoolean(dgvDetainedLicenses.CurrentRow.Cells[3].Value);
            releaseDetainedLicenseToolStripMenuItem.Enabled = !isReleased;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnDetained_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
            _RefreshDetainedLicensesList();
        }
    }
}