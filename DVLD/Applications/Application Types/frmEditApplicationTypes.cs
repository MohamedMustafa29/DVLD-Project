using DVLD.general;
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

namespace DVLD.Applications
{
    public partial class frmEditApplicationTypes : Form
    {

        private int _applicationID = -1;
        private clsApplicationTypes _application;
        public frmEditApplicationTypes(int applicationID)
        {
            InitializeComponent();
            _applicationID = applicationID;
        }


        private void _ResetDefaultValues()
        {
            lblID.Text = "";
            txtApplicationTitle.Text = "";
            txtFees.Text = "";
        }


        private void _Load()
        {
            _application = clsApplicationTypes.Find(_applicationID);


            if (_application == null)
            {
                MessageBox.Show("No User with ID = " + _applicationID, "User Not Found", MessageBoxButtons.OK, MessageBoxIcon.Error);
                this.Close();
                return;
            }
            lblID.Text = _application.ApplicationTypeID.ToString();
            txtApplicationTitle.Text = _application.ApplicationTypeTitle.ToString();
            txtFees.Text = _application.ApplicationFees.ToString();




        }


        private void btnSave_Click(object sender, EventArgs e)
        {
            if (!this.ValidateChildren())
            {
                MessageBox.Show("Please correct the errors before saving.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            _application.ApplicationTypeTitle = txtApplicationTitle.Text;
            _application.ApplicationFees = Convert.ToDecimal(txtFees.Text);

            if (_application.Save())
            {


                MessageBox.Show("Data Saved Successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            else
            {
                MessageBox.Show("Error: Data Is not Saved Successfully.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }

        private void frmEditApplicationTypes_Load(object sender, EventArgs e)
        {
            _ResetDefaultValues();
            _Load();
        }

        private void txtApplicationTitle_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(txtApplicationTitle.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtApplicationTitle, "This field is required!");
            }
            else
            {
                errorProvider1.SetError(txtApplicationTitle, null);
            }
        }

        private void txtFees_Validating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Fees cannot be blank.");
            }
            else
            {
                errorProvider1.SetError(txtApplicationTitle, null);
            }


            if (!clsValidation.IsNumber(txtFees.Text.Trim()))
            {
                e.Cancel = true;
                errorProvider1.SetError(txtFees, "Invalid Number.");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(txtFees, null);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
