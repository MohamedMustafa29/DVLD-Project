using DVLD.People;
using DVLD_Business;
using System;
using System.Data;
using System.Windows.Forms;

namespace DVLD
{
    public partial class FrmManagePeople : Form
    {
        private DataTable _dtAllPeople;

        public FrmManagePeople()
        {
            InitializeComponent();
        }

        private void ViewAllPeople()
        {
            _dtAllPeople = clsPerson.FindAllPeople();
            dgvPeopleView.DataSource = _dtAllPeople;

            lblNumber.Text = (_dtAllPeople != null) ? dgvPeopleView.Rows.Count.ToString() : "0";

            if (_dtAllPeople != null && dgvPeopleView.Rows.Count > 0)
            {
                dgvPeopleView.Columns[0].HeaderText = "Person ID";
                dgvPeopleView.Columns[1].HeaderText = "National No.";
                dgvPeopleView.Columns[2].HeaderText = "First Name";
                dgvPeopleView.Columns[3].HeaderText = "Second Name";
                dgvPeopleView.Columns[4].HeaderText = "Third Name";
                dgvPeopleView.Columns[5].HeaderText = "Last Name";
                dgvPeopleView.Columns[6].HeaderText = "Gender";
                dgvPeopleView.Columns[7].HeaderText = "Date Of Birth";
                dgvPeopleView.Columns[8].HeaderText = "Nationality ID";
                dgvPeopleView.Columns[9].HeaderText = "Phone";
                dgvPeopleView.Columns[10].HeaderText = "Email";
            }
        }

        private void FrmManagePeople_Load(object sender, EventArgs e)
        {
            ViewAllPeople();
            cbFilter.SelectedIndex = 0;
        }

        private void cbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cbFilter.SelectedIndex == 0)
            {
                txtChangeNameFilter.Visible = false;
                if (_dtAllPeople != null)
                {
                    _dtAllPeople.DefaultView.RowFilter = "";
                    lblNumber.Text = dgvPeopleView.Rows.Count.ToString();
                }
            }
            else
            {
                txtChangeNameFilter.Visible = true;
                txtChangeNameFilter.Text = "";
                txtChangeNameFilter.Focus();
            }
        }

        private void txtChangeNameFilter_TextChanged_1(object sender, EventArgs e)
        {
            if (_dtAllPeople == null)
                return;

            string filterColumn = "";

            switch (cbFilter.Text)
            {
                case "Person ID":
                    filterColumn = "PersonID";
                    break;
                case "National No.":
                    filterColumn = "NationalNo";
                    break;
                case "First Name":
                    filterColumn = "FirstName";
                    break;
                case "Second Name":
                    filterColumn = "SecondName";
                    break;
                case "Third Name":
                    filterColumn = "ThirdName";
                    break;
                case "Last Name":
                    filterColumn = "LastName";
                    break;
                case "Gender":
                    filterColumn = "Gendor";
                    break;
                case "Phone":
                    filterColumn = "Phone";
                    break;
                case "Email":
                    filterColumn = "Email";
                    break;
                default:
                    filterColumn = "None";
                    break;
            }

            if (txtChangeNameFilter.Text.Trim() == "" || filterColumn == "None")
            {
                _dtAllPeople.DefaultView.RowFilter = "";
                lblNumber.Text = dgvPeopleView.Rows.Count.ToString();
                return;
            }

            if (filterColumn == "PersonID")
            {
                if (int.TryParse(txtChangeNameFilter.Text.Trim(), out int tempID))
                {
                    _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = {1}", filterColumn, tempID);
                }
                else
                {
                    _dtAllPeople.DefaultView.RowFilter = "1 = 0";
                }
            }
            else if (filterColumn == "Gendor")
            {
                string userInput = txtChangeNameFilter.Text.Trim().ToLower();

                if (userInput == "male" || userInput == "m" || userInput == "ذكر")
                {
                    _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = 0", filterColumn);
                }
                else if (userInput == "female" || userInput == "f" || userInput == "أنثى" || userInput == "انثى")
                {
                    _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] = 1", filterColumn);
                }
                else
                {
                    _dtAllPeople.DefaultView.RowFilter = "1 = 0";
                }
            }
            else
            {
                _dtAllPeople.DefaultView.RowFilter = string.Format("[{0}] LIKE '{1}%'", filterColumn, txtChangeNameFilter.Text.Trim());
            }

            lblNumber.Text = dgvPeopleView.Rows.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.ShowDialog();
            ViewAllPeople();
        }

        private void addPersonToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddUpdatePeople frm = new frmAddUpdatePeople();
            frm.ShowDialog();
            ViewAllPeople();
        }

        private void eToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleView.CurrentRow == null || dgvPeopleView.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            int personID = (int)dgvPeopleView.CurrentRow.Cells[0].Value;

            frmAddUpdatePeople frm = new frmAddUpdatePeople(personID);
            frm.ShowDialog();
            ViewAllPeople();
        }

        private void showToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleView.CurrentRow == null || dgvPeopleView.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            int personID = (int)dgvPeopleView.CurrentRow.Cells[0].Value;

            frmShowPersonInfo frm = new frmShowPersonInfo(personID);
            frm.ShowDialog();
            ViewAllPeople();
        }

        private void deleteToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvPeopleView.CurrentRow == null || dgvPeopleView.CurrentRow.Cells[0].Value == DBNull.Value)
                return;

            int personID = (int)dgvPeopleView.CurrentRow.Cells[0].Value;

            if (MessageBox.Show("Are you sure you want to delete person [" + personID + "]?", "Confirm Delete", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
            {
                if (clsPerson.DeletePerson(personID))
                {
                    MessageBox.Show("Person deleted successfully.", "Successful", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    ViewAllPeople();
                }
                else
                {
                    MessageBox.Show("Person was not deleted because it has data linked to it.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}