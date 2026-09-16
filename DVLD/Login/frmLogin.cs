using DVLD.Global;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.Login
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            clsUsers user = clsUsers.FindUserByUsernameAndPassword(txtUserName.Text, txtPassword.Text);
            if (user != null)
            {
                if (chkRemember.Checked)
                {

                    clsGlobal.RememberUsernameAndPassword(txtUserName.Text, txtPassword.Text);
                }
                else
                {
                    clsGlobal.RememberUsernameAndPassword("", "");
                }
                if (!user.IsActive)
                {
                    txtUserName.Focus();
                    MessageBox.Show("the User is Not Active ", "Active User", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
                clsGlobal.currentUser = user;
                this.Hide();
                Main frm = new Main(this);
                frm.ShowDialog();
            }
            else
            {
                txtUserName.Focus();
                MessageBox.Show("Invalid UserName Or Password", "try Again", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
           

        }

        private void frmLogin_Load(object sender, EventArgs e)
        {
            string userName = "", password = "";
            if(clsGlobal.GetStoredCredential(ref userName,ref password))
            {
                txtUserName.Text = userName;
                txtPassword.Text = password;
                chkRemember.Checked = true;
            }
            else
            {
                chkRemember.Checked = false;
            }
        }
    }
}
