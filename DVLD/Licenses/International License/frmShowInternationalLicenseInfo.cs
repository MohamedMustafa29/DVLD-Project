using DVLD_Business;
using System;
using System.Windows.Forms;

namespace DVLD.Licenses.International_License
{
    public partial class frmShowInternationalLicenseInfo : Form
    {
        private int _internationalLicenseID = -1;

        public frmShowInternationalLicenseInfo(int internationalLicenseID)
        {
            InitializeComponent();
            _internationalLicenseID = internationalLicenseID;
        }

        private void frmShowInternationalLicenseInfo_Load(object sender, EventArgs e)
        {
            ctrlDriverInternationalLicenseInfo1.LoadInternationalLicenseInfo(_internationalLicenseID);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}