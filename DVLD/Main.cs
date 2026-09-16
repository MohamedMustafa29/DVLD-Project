using DVLD.Applications;
using DVLD.Applications.International_License;
using DVLD.Applications.Manage_Application;
using DVLD.Applications.Release_Detained_License;
using DVLD.Applications.Renew_Driver_License;
using DVLD.Applications.Replace_Lost_Or_Damaged_License;
using DVLD.Applications.Test;
using DVLD.Drivers;
using DVLD.Global;
using DVLD.Licenses.Detain_License;
using DVLD.Login;
using DVLD.Users;

namespace DVLD
{
    public partial class Main : Form
    {
        private frmLogin _frmLogin;
        public Main(frmLogin frm)
        {
            InitializeComponent();
            _frmLogin = frm;

        }



        private void peopleToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new FrmManagePeople();
            frm.ShowDialog();

        }

        private void usersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new frmUsers();
            frm.ShowDialog();
        }

        private void currToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmUserCard frm = new frmUserCard(clsGlobal.currentUser.UserID);
            frm.ShowDialog();

        }

        private void signOutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            clsGlobal.currentUser = null;
            _frmLogin.Show();
            this.Close();
        }

        private void changePasswordToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmChangepassword frm = new frmChangepassword(clsGlobal.currentUser.UserID);
            frm.ShowDialog();
        }



        private void manageApplicationTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmmanageApplicationTypes frm = new frmmanageApplicationTypes();
            frm.ShowDialog();
        }

        private void manageTestTypesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmTestTypes frm = new frmTestTypes();
            frm.ShowDialog();
        }

        private void localLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicenses frm = new frmLocalLicenses();
            frm.ShowDialog();
        }

        private void localLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmAddLocalLicense frm = new frmAddLocalLicense();
            frm.ShowDialog();
        }

        private void retakeTestToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLocalLicenses frm = new frmLocalLicenses();
            frm.ShowDialog();

        }

        private void renewDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmRenewDriverLicense frm = new frmRenewDriverLicense();
            frm.ShowDialog();
        }

        private void replacementForLostOrDamagedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReplaceLostOrDamaged_License frm = new frmReplaceLostOrDamaged_License();
            frm.ShowDialog();
        }

        private void driversToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDrivers frm = new frmDrivers();
            frm.ShowDialog();
        }

        private void detainLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmDetainLicense frm = new frmDetainLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }

        private void manageDetainedLicensesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmManageDetainedLicense frm = new frmManageDetainedLicense();
            frm.ShowDialog();
        }

        private void internationalLicenseApplicationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmListInternationalLicesnseApplications frm = new frmListInternationalLicesnseApplications();
            frm.ShowDialog();
        }

        private void internationalLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmNewInternationalLicense frm = new frmNewInternationalLicense();
            frm.ShowDialog();
        }

        private void releaseDetainedDrivingLicenseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmReleaseDetainedLicense frm = new frmReleaseDetainedLicense();
            frm.ShowDialog();
        }
    }
}
