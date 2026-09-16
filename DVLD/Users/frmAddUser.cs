using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Users
{
    public partial class frmAddUser : Form
    {
        private int _UserID = -1;
        private enum enMode { Add = 1, Update = 2 };
        private enMode _mode = enMode.Add;
        private clsUsers _user;

        public frmAddUser()
        {
            InitializeComponent();
            _mode = enMode.Add;
        }

        public frmAddUser(int userID)
        {
            InitializeComponent();
            _mode = enMode.Update;
            this._UserID = userID;
        }

        private void _ResetDefaultValues()
        {
            if (_mode == enMode.Add)
            {
                lblAddOrEdit.Text = "Add New User";
                _user = new clsUsers();

                tabPageLoginInfo.Enabled = false;
                ctrlClsPeopleWithFilter1.Focus();

            }
            else
            {
                lblAddOrEdit.Text = "Update User";

                btnNextPage.Enabled = true;
                tabPageLoginInfo.Enabled = true;
            }

            txtName.Text = "";
            txtPass.Text = "";
            txtConfirmPass.Text = "";
            cbISActive.Checked = false;
        }

        private void _Load()
        {
            _user = clsUsers.FindUserByUserID(_UserID);
            ctrlClsPeopleWithFilter1.Enabled = false;

            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _UserID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }

            lblUserID.Text = _user.UserID.ToString();
            txtName.Text = _user.UserName;
            txtPass.Text = _user.Password;
            txtConfirmPass.Text = _user.Password;
            cbISActive.Checked = _user.IsActive;
            ctrlClsPeopleWithFilter1.LoadPersonInfo(_user.PersonID);


        }


        private void frmAddUser_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();

            if (_mode == enMode.Update)
            {
                _Load();
            }
        }

        private void btnSaveUser_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            int personID = ctrlClsPeopleWithFilter1.PersonID;

            _user.PersonID = personID;
            _user.UserName = txtName.Text.Trim();
            _user.Password = txtPass.Text.Trim();
            _user.IsActive = cbISActive.Checked;

            if (_user.Save())
            {
                lblUserID.Text = _user.UserID.ToString();
                _mode = enMode.Update;
                lblAddOrEdit.Text = "Update User";

                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnNextPage_Click(object sender, EventArgs e)
        {
            if (_mode == enMode.Update)
            {
                btnNextPage.Enabled = true;
                tabPageLoginInfo.Enabled = true;
                tbSwitch.SelectedTab = tbSwitch.TabPages["tabPageLoginInfo"];
                return;

            }

            if (ctrlClsPeopleWithFilter1.PersonID != -1)
            {
                if (clsUsers.IsUserExistByPersonID(ctrlClsPeopleWithFilter1.PersonID))
                {
                    MessageBox.Show("selected Person is already a User", "Choose another One", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ctrlClsPeopleWithFilter1.Focus();

                }
                else
                {

                    btnNextPage.Enabled = true;
                    tabPageLoginInfo.Enabled = true;
                    tbSwitch.SelectedTab = tbSwitch.TabPages["tabPageLoginInfo"];


                }


            }
            else
            {

                MessageBox.Show("Please Select User", "Select a User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                ctrlClsPeopleWithFilter1.Focus();

            }

        }

        private void btnCloseform_Click(object sender, EventArgs e)
        {
            this.Close();
        }





        private void txtConfirmPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtConfirmPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPass, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPass, null);
            }

            if (txtPass.Text.Trim() != txtConfirmPass.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfirmPass, "Must Be Like Password");
            }
            else
            {
                errorProvider1.SetError(txtConfirmPass, null);
            }
        }

        private void txtPass_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtPass.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtPass, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtPass, null);
            }

        }

        private void txtName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }

            if (clsUsers.IsUserExistByUserName(txtName.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtName, "UserNameIsExist");
            }
            else
            {
                errorProvider1.SetError(txtName, null);
            }





        }



      
    }
}
