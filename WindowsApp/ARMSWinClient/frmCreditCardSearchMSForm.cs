using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ARMSBOLayer;

namespace ARMSWinClient
{
    public partial class frmCreditCardSearchMSForm : Form
    {

        private CreditCard objCreditCard;

        public frmCreditCardSearchMSForm()
        {
            InitializeComponent();
        }

        private void printPreviewControl1_Click(object sender, EventArgs e)
        {

        }

        private void lblTitle_Click(object sender, EventArgs e)
        {

        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            try
            {
                //Step1 - Create Credit Card Object
                objCreditCard = new CreditCard();

                bool success = objCreditCard.Load(txtBoxCCSearch.Text.Trim());

                if (success)
                {
                    txtBoxCCNumber.Text = objCreditCard.CreditCardNumber;
                    txtBoxCardowner.Text = objCreditCard.CreditCardOwnerName;
                    txtBoxCCIssuingCompany.Text = objCreditCard.CreditCardIssuingCompany;
                    txtBoxMC.Text = objCreditCard.MerchantCode.ToString();
                    txtBoxExpDate.Text = objCreditCard.ExpDate.ToString("yyyy-M-dd");
                    txtBoxAddl1.Text = objCreditCard.AddressLine1;
                    txtBoxAddl2.Text = objCreditCard.AddressLine2;
                    txtBoxCity.Text = objCreditCard.City;
                    txtBoxState.Text = objCreditCard.StateCode;
                    txtBoxZipCode.Text = objCreditCard.ZipCode;
                    txtBoxCountry.Text = objCreditCard.Country;
                    txtBoxCCLimit.Text = objCreditCard.CreditCardLimit.ToString();
                    txtBoxCCBalance.Text = objCreditCard.CreditCardBalance.ToString();
                    txtBoxAC.Text = objCreditCard.ActivationStatus.ToString();

                }
                else
                {
                    MessageBox.Show("Customer Not Found");

                    //set the object to null
                    objCreditCard = null;

                    txtBoxCCNumber.Text = "";
                    txtBoxCardowner.Text = "";
                    txtBoxCCIssuingCompany.Text = "";
                    txtBoxMC.Text = "";
                    txtBoxExpDate.Text = "";
                    txtBoxAddl1.Text = "";
                    txtBoxAddl2.Text = "";
                    txtBoxCity.Text = "";
                    txtBoxState.Text = "";
                    txtBoxZipCode.Text = "";
                    txtBoxCountry.Text = "";
                    txtBoxCCLimit.Text = "";
                    txtBoxCCBalance.Text = "";
                    txtBoxAC.Text = "";

                }//End of else


            }//End of try
            catch (System.Exception)
            {
                MessageBox.Show("Error in search!");
            }
        }

        private void frmCreditCardSearchMSForm_Load(object sender, EventArgs e)
        {
             
        }

        private void bntPrint_Click(object sender, EventArgs e)
        {
            if(objCreditCard == null)
            {
                MessageBox.Show("Customer Not Found");
            }
            else
            {
                objCreditCard.Print();

                MessageBox.Show("Customer record sent to printer");

                //set the object to null
                objCreditCard = null;

                txtBoxCCSearch.Text = "";
                txtBoxCCNumber.Text = "";
                txtBoxCardowner.Text = "";
                txtBoxCCIssuingCompany.Text = "";
                txtBoxMC.Text = "";
                txtBoxExpDate.Text = "";
                txtBoxAddl1.Text = "";
                txtBoxAddl2.Text = "";
                txtBoxCity.Text = "";
                txtBoxState.Text = "";
                txtBoxZipCode.Text = "";
                txtBoxCountry.Text = "";
                txtBoxCCLimit.Text = "";
                txtBoxCCBalance.Text = "";
                txtBoxAC.Text = "";
            }
            
        }

        private void txtBoxExpDate_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
