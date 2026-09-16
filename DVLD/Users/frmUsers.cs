using DVLD.People;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmUsers : Form
    {
        private DataTable _dtAllUser;

        public frmUsers()
        {
            InitializeComponent();
        }

        private void _ViewAllUsers()
        {
            _dtAllUser = clsUsers.FindAllPeople();
            dgvUsersList.DataSource = _dtAllUser;
            lblNumberOfUsers.Text = _dtAllUser.Rows.Count.ToString();

            if (dgvUsersList.Rows.Count > 0)
            {
                dgvUsersList.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

                dgvUsersList.Columns[0].HeaderText = "User ID";
                dgvUsersList.Columns[1].HeaderText = "Person ID";
                dgvUsersList.Columns[2].HeaderText = "Full Name";
                dgvUsersList.Columns[3].HeaderText = "UserName";
                dgvUsersList.Columns[4].HeaderText = "Is Active";

                dgvUsersList.Columns[0].FillWeight = 90;
                dgvUsersList.Columns[1].FillWeight = 90;
                dgvUsersList.Columns[2].FillWeight = 200;
                dgvUsersList.Columns[3].FillWeight = 120;
                dgvUsersList.Columns[4].FillWeight = 80;
            }
        }

        private void frmUsers_Load(object sender, EventArgs e)
        {
            _ViewAllUsers();
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.Text == "None")
            {
                txtFilter.Visible = false;
                cbActivFilter.Visible = false;
                if (_dtAllUser != null)
                {
                    _dtAllUser.DefaultView.RowFilter = "";
                    lblNumberOfUsers.Text = dgvUsersList.Rows.Count.ToString();
                }
                return;
            }
            else if (cbFilter.Text == "IS Active")
            {
                txtFilter.Visible = false;
                cbActivFilter.Visible = true;
                cbActivFilter.SelectedIndex = 0;
            }
            else
            {
                cbActivFilter.Visible = false;
                txtFilter.Visible = true;
                txtFilter.Text = "";
                txtFilter.Focus();
            }
        }

        private void txtFilter_TextChanged(object sender, EventArgs e)
        {
            if (_dtAllUser == null)
                return;

            string filterColumn = null;

            switch (cbFilter.Text)
            {
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "User ID":
                    filterColumn = "UserID";
                    break;
                case "Full Name":
                    filterColumn = "FullName";
                    break;
                case "User Name":
                    filterColumn = "UserName";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (txtFilter.Text.Trim() == "" || cbFilter.Text == "None")
            {
                _dtAllUser.DefaultView.RowFilter = "";
                lblNumberOfUsers.Text = dgvUsersList.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "PersonID" || filterColumn == "UserID")
            {
                if (int.TryParse(txtFilter.Text.Trim(), out int tempID))
                {
                    _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tempID);
                }
                else
                {
                    _dtAllUser.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtAllUser.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtFilter.Text.Trim());
            }

            lblNumberOfUsers.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void cbActivFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (_dtAllUser == null)
                return;

            switch (cbActivFilter.Text)
            {
                case "Yes":
                    _dtAllUser.DefaultView.RowFilter = "IsActive = true";
                    break;

                case "No":
                    _dtAllUser.DefaultView.RowFilter = "IsActive = false";
                    break;

                default:
                    _dtAllUser.DefaultView.RowFilter = "";
                    break;
            }

            lblNumberOfUsers.Text = dgvUsersList.Rows.Count.ToString();
        }

        private void btnAddUser_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            _ViewAllUsers();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            if (MessageBox.Show("Are you sure you want to delete this person?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsUsers.DeleteUser((int)dgvUsersList.CurrentRow.Cells[0].Value))
                {
                    _ViewAllUsers();
                    MessageBox.Show("Person deleted successfully.");
                }
                else
                {
                    MessageBox.Show("Failed to delete Person.");
                }
            }
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            frmAddUser frm = new frmAddUser((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ViewAllUsers();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvUsersList.CurrentRow == null || dgvUsersList.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            frmUserCard frm = new frmUserCard((int)dgvUsersList.CurrentRow.Cells[0].Value);
            frm.ShowDialog();
            _ViewAllUsers();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUser frm = new frmAddUser();
            frm.ShowDialog();
            _ViewAllUsers();
        }
    }
}