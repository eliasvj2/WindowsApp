﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ARMSWinClient
{
    public partial class frmMailWelcomeForm : Form
    {
        public frmMailWelcomeForm()
        {
            InitializeComponent();
        }

       

        private void btnERP_Click_1(object sender, EventArgs e)
        {
            frmERPSystemForm objERP = new frmERPSystemForm();

            this.Hide();

            objERP.ShowDialog();

            this.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();

        }
    }
}
