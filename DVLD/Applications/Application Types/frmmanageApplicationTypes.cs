using DVLD.Users;
using DVLD_Business;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;


namespace DVLD.Applications
{
    public partial class frmmanageApplicationTypes : Form
    {
        public frmmanageApplicationTypes()
        {
            InitializeComponent();
        }

        private void _ViewApplicationTypes()
        {
            DataTable _dtApplicationTypes = clsApplicationTypes.GetAllApplicationTypes();
            dgvApplicationTypes.DataSource = _dtApplicationTypes;
            lblNumberOfApplication.Text = _dtApplicationTypes.Rows.Count.ToString();

            if (dgvApplicationTypes.Rows.Count > 0)
            {
                dgvApplicationTypes.Columns[0].HeaderText = "Application Type ID";
                dgvApplicationTypes.Columns[0].Width = 160;

                dgvApplicationTypes.Columns[1].HeaderText = "Title";
                dgvApplicationTypes.Columns[1].Width = 350;

                dgvApplicationTypes.Columns[2].HeaderText = "Fees";
                dgvApplicationTypes.Columns[2].Width = 120;
            }
        }



        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (dgvApplicationTypes.CurrentRow == null)
                return;

            int applicationTypeID = Convert.ToInt32(dgvApplicationTypes.CurrentRow.Cells[0].Value);

            frmEditApplicationTypes frm = new frmEditApplicationTypes(applicationTypeID);
            frm.ShowDialog();

            _ViewApplicationTypes();

        }


        private void frmmanageApplicationTypes_Load(object sender, EventArgs e)
        {
            _ViewApplicationTypes();
        }
    }
}
