using System;
using System.Data;
using System.Windows.Forms;
using DVLD.Drivers;
using DVLD.Licenses.International_License;
using DVLD.People;
using DVLD_Business;

namespace DVLD.Applications.International_License
{
    public partial class frmListInternationalLicesnseApplications : Form
    {
        private DataTable _dtInternationalLicenseApplications;

        public frmListInternationalLicesnseApplications()
        {
            InitializeComponent();
        }

        private void ViewAllInternationalLicenses()
        {
            _dtInternationalLicenseApplications = clsInternationalLicense.GetAllInternationalLicenses();
            dgvInternationalLicenses.DataSource = _dtInternationalLicenseApplications;
            lblInternationalLicensesRecords.Text = _dtInternationalLicenseApplications.Rows.Count.ToString();

            if (dgvInternationalLicenses.Rows.Count > 0)
            {
                dgvInternationalLicenses.Columns[0].HeaderText = "Int.License ID";
                dgvInternationalLicenses.Columns[0].Width = 160;

                dgvInternationalLicenses.Columns[1].HeaderText = "Application ID";
                dgvInternationalLicenses.Columns[1].Width = 150;

                dgvInternationalLicenses.Columns[2].HeaderText = "Driver ID";
                dgvInternationalLicenses.Columns[2].Width = 130;

                dgvInternationalLicenses.Columns[3].HeaderText = "L.License ID";
                dgvInternationalLicenses.Columns[3].Width = 130;

                dgvInternationalLicenses.Columns[4].HeaderText = "Issue Date";
                dgvInternationalLicenses.Columns[4].Width = 180;

                dgvInternationalLicenses.Columns[5].HeaderText = "Expiration Date";
                dgvInternationalLicenses.Columns[5].Width = 180;

                dgvInternationalLicenses.Columns[6].HeaderText = "Is Active";
                dgvInternationalLicenses.Columns[6].Width = 120;
            }
        }

        private void frmListInternationalLicesnseApplications_Load(object sender, EventArgs e)
        {
            ViewAllInternationalLicenses();
            cbFilterBy.SelectedIndex = 0;
        }

        private void cbFilterBy_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilterBy.SelectedIndex == 0 || cbFilterBy.Text == "None")
            {
                txtFilterValue.Visible = false;
                if (_dtInternationalLicenseApplications != null)
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                    lblInternationalLicensesRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
                }
                return;
            }

            txtFilterValue.Visible = true;
            txtFilterValue.Text = "";
            txtFilterValue.Focus();
        }

        private void txtFilterValue_TextChanged(object sender, EventArgs e)
        {
            if (_dtInternationalLicenseApplications == null)
                return;

            string filterColumn = "";

            switch (cbFilterBy.Text)
            {
                case "International License ID":
                    filterColumn = "InternationalLicenseID";
                    break;
                case "Application ID":
                    filterColumn = "ApplicationID";
                    break;
                case "Driver ID":
                    filterColumn = "DriverID";
                    break;
                case "Local License ID":
                    filterColumn = "IssuedUsingLocalLicenseID";
                    break;
                case "Is Active":
                    filterColumn = "IsActive";
                    break;
            }

            if (txtFilterValue.Text.Trim() == "" || cbFilterBy.Text == "None")
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = "";
                lblInternationalLicensesRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "InternationalLicenseID" || filterColumn == "ApplicationID" || filterColumn == "DriverID" || filterColumn == "IssuedUsingLocalLicenseID")
            {
                if (int.TryParse(txtFilterValue.Text.Trim(), out int tempID))
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tempID);
                }
                else
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = "1 = 0";
                }
            }
            else if (filterColumn == "IsActive")
            {
                string userInput = txtFilterValue.Text.Trim().ToLower();

                if (userInput == "yes" || userInput == "1" || userInput == "true" || userInput == "نشط")
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = 1", filterColumn);
                }
                else if (userInput == "no" || userInput == "0" || userInput == "false" || userInput == "غير نشط")
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] = 0", filterColumn);
                }
                else
                {
                    _dtInternationalLicenseApplications.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtInternationalLicenseApplications.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilterValue.Text.Trim());
            }

            lblInternationalLicensesRecords.Text = dgvInternationalLicenses.Rows.Count.ToString();
        }

        private void btnNewApplication_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
            ViewAllInternationalLicenses();
        }

        private void showDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.CurrentRow == null)
                return;

            int internationalLicenseID = (int)dgvInternationalLicenses.CurrentRow.Cells[0].Value;
            frmShowInternationalLicenseInfo frm = new frmShowInternationalLicenseInfo(internationalLicenseID);
            frm.ShowDialog();
        }

        private void PesonDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.CurrentRow == null)
                return;

            int driverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            clsDriver driver = clsDriver.FindByDriverID(driverID);

            if (driver != null)
            {
                frmShowPersonInfo frm = new frmShowPersonInfo(driver.PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Driver not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void showPersonLicenseHistoryToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvInternationalLicenses.CurrentRow == null)
                return;

            int driverID = (int)dgvInternationalLicenses.CurrentRow.Cells[2].Value;
            clsDriver driver = clsDriver.FindByDriverID(driverID);

            if (driver != null)
            {
                frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(driver.PersonID);
                frm.ShowDialog();
            }
            else
            {
                MessageBox.Show("Driver not found!", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}