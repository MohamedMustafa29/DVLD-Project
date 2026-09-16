using DVLD.Global;
using DVLD.People.UserControl;
using DVLD_Business;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Xml.Linq;

namespace DVLD.Users
{
    public partial class frmChangepassword : Form
    {
        private int _userID;
        private clsUsers _user;



        public frmChangepassword(int userID)
        {
            InitializeComponent();
            _userID = userID;
        }


        private void frmChangepassword_Load(object sender, EventArgs e)
        {

            _user = clsUsers.FindUserByUserID(_userID);

            if (_user == null)
            {
                MessageBox.Show("No User with ID = " + _userID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }


            ctrlUserCard2.LoadUserInfo(_userID);



        }



        private void TxtCurrent_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(TxtCurrent.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCurrent, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(TxtCurrent, null);
            }

            if (clsGlobal.currentUser.Password != TxtCurrent.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(TxtCurrent, "Must Be Like A Current Password");
            }
            else
            {
                errorProvider1.SetError(TxtCurrent, null);
            }
        }

        private void txtNew_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtNew.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtNew, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtNew, null);
            }
        }



        private void txtConfrim_Validating(object sender, CancelEventArgs e)
        {

            if (string.IsNullOrEmpty(txtConfrim.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfrim, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtConfrim, null);
            }

            if (txtNew.Text.Trim() != txtConfrim.Text.Trim())
            {
                e.Cancel = true;
                errorProvider1.SetError(txtConfrim, "Must Be Like Password");
            }
            else
            {
                errorProvider1.SetError(txtConfrim, null);
            }
        }



        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }


            _user.Password = txtNew.Text.Trim();


            if (_user.Save())
            {

                MessageBox.Show("Password Changed Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }




        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
