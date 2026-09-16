using DVLD.People;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Drivers
{
    public partial class frmDrivers : Form
    {
        private DataTable _dtDrivers;

        public frmDrivers()
        {
            InitializeComponent();
        }

        private void ViewAllDrivers()
        {
            _dtDrivers = clsDriver.GetAllDrivers();
            dgvDriversList.DataSource = _dtDrivers;

            lblNumberOfDrivers.Text = (_dtDrivers != null) ? dgvDriversList.Rows.Count.ToString() : "0";

            if (_dtDrivers != null && dgvDriversList.Rows.Count > 0)
            {
                dgvDriversList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvDriversList.Columns[0].HeaderText = "Driver ID";
                dgvDriversList.Columns[1].HeaderText = "Person ID";
                dgvDriversList.Columns[2].HeaderText = "National No.";
                dgvDriversList.Columns[3].HeaderText = "Full Name";
                dgvDriversList.Columns[4].HeaderText = "Created Date";
                dgvDriversList.Columns[5].HeaderText = "Active Licenses";

                dgvDriversList.Columns[0].FillWeight = 80;
                dgvDriversList.Columns[1].FillWeight = 90;
                dgvDriversList.Columns[2].FillWeight = 100;
                dgvDriversList.Columns[3].FillWeight = 300;
                dgvDriversList.Columns[4].FillWeight = 160;
                dgvDriversList.Columns[5].FillWeight = 110;
            }
        }

        private void frmDrivers_Load(object sender, EventArgs e)
        {
            ViewAllDrivers();
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txtChangeNameFilter.Visible = false;
                if (_dtDrivers != null)
                {
                    _dtDrivers.DefaultView.RowFilter = "";
                    lblNumberOfDrivers.Text = dgvDriversList.Rows.Count.ToString();
                }
            }
            else
            {
                txtChangeNameFilter.Visible = true;
                txtChangeNameFilter.Text = "";
                txtChangeNameFilter.Focus();
            }
        }

        private void txtChangeNameFilter_TextChanged(object sender, EventArgs e)
        {
            if (_dtDrivers == null)
                return;

            string filterColumn = "";

            switch (cbFilter.Text.Trim())
            {
                case "Driver ID":
                    filterColumn = "DriverID";
                    break;
                case "Person No":
                    filterColumn = "PersonID";
                    break;
                case "National No":
                    filterColumn = "NationalNo";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (txtChangeNameFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtDrivers.DefaultView.RowFilter = "";
                lblNumberOfDrivers.Text = dgvDriversList.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "DriverID" || filterColumn == "PersonID")
            {
                _dtDrivers.DefaultView.RowFilter = string.Format("CONVERT([{0}], 'System.String') LIKE '{1}%'", filterColumn, txtChangeNameFilter.Text.Trim());
            }
            else
            {
                _dtDrivers.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtChangeNameFilter.Text.Trim().Replace("'", "''"));
            }

            lblNumberOfDrivers.Text = dgvDriversList.Rows.Count.ToString();
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            if (dgvDriversList.CurrentRow == null || dgvDriversList.CurrentRow.Cells[1].Value == DBNull.Value)
                return;

            int personID = (int)dgvDriversList.CurrentRow.Cells[1].Value;

            frmShowPersonInfo frm = new frmShowPersonInfo(personID);
            frm.ShowDialog();
            ViewAllDrivers();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvDriversList.CurrentRow == null || dgvDriversList.CurrentRow.Cells[1].Value == DBNull.Value)
                return;

            int personID = (int)dgvDriversList.CurrentRow.Cells[1].Value;

            frmShowPersonLicenseHistory frm = new frmShowPersonLicenseHistory(personID);
            frm.ShowDialog();

            ViewAllDrivers();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}