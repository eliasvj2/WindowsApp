using System;
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
    public partial class frmCreditCardMSForm : Form
    {
        public frmCreditCardMSForm()
        {
            InitializeComponent();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            frmCreditCardSearchMSForm objERP = new frmCreditCardSearchMSForm();

            this.Hide();

            objERP.ShowDialog();

            this.Show();
        }

        private void btnRegistration_Click(object sender, EventArgs e)
        {
            frmCreditCardRegistrationMSForm objERP = new frmCreditCardRegistrationMSForm();

            this.Hide();

            objERP.ShowDialog();

            this.Show();
        }
    }
}
