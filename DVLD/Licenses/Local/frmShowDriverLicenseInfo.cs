using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Licenses
{
    public partial class frmShowDriverLicenseInfo : Form
    {

        private int _licenseID;
        private clsLicense _license;
        public frmShowDriverLicenseInfo(int licenseID)
        {
            InitializeComponent();
            _licenseID = licenseID;
        }

        private void ctrlDriverLicenseInfoControl1_Load(object sender, EventArgs e)
        {

        }

        private void frmShowDriverLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverLicenseInfoControl1.LoadLicenseInfo(_licenseID);
        }

        

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
