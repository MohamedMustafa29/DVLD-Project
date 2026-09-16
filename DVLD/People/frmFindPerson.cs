using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace DVLD.People
{
    public delegate void DataBackEventHandler(object sender, int PersonID);
    public partial class frmFindPerson : Form
    {
        public event DataBackEventHandler DataBack;
        public frmFindPerson()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DataBack?.Invoke(this, ctrlClsPeopleWithFilter1.PersonID);
        }
    }
}
