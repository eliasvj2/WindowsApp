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
    public partial class frmCreditCardRegistrationMSForm : Form
    {
        public frmCreditCardRegistrationMSForm()
        {
            InitializeComponent();
        }

        private void bntExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void bntApply_Click(object sender, EventArgs e)
        {
            try
            {
                //Step1 - Create Credit Card Object
                CreditCard objCreditCard = new CreditCard();

                objCreditCard.CreditCardNumber = txtBoxCCNumber.Text.Trim();
                objCreditCard.CreditCardOwnerName = txtCCOwner.Text.Trim();
                objCreditCard.CreditCardIssuingCompany = txtBoxCCICompany.Text.Trim();
                objCreditCard.MerchantCode = Convert.ToByte(txtBoxMC.Text);
                objCreditCard.ExpDate = dtpExpDate.Value;
                objCreditCard.AddressLine1 = txtBoxAddl1.Text.Trim();
                objCreditCard.AddressLine2 = txtBoxAddl2.Text.Trim();
                objCreditCard.City = txtBoxCity.Text.Trim();
                objCreditCard.StateCode = cbBoxState.SelectedValue.ToString();
                objCreditCard.ZipCode = txtBoxZipCode.Text.Trim();
                objCreditCard.Country = cbBoxCountry.Text.Trim();
                objCreditCard.CreditCardLimit = Convert.ToDecimal(txtBoxCCLimit.Text.Trim());
                objCreditCard.CreditCardBalance = Convert.ToDecimal(txtBoxCCBalance.Text.Trim());

                if(cbBoxAC.Text == "Activate")
                {
                    objCreditCard.Activate();
                }
                else
                {
                    objCreditCard.Deactivate();
                }
                bool success = objCreditCard.Insert();

                if (success)
                {
                    MessageBox.Show("Customer Added");

                    //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
                    cbBoxState.DataSource = USState.GetAllUSStates();

                    //Set DisplayMember property to indicate which property gets displayed on the combobox
                    //Set ValueMember Property to indicate which property to get data from in the code
                    cbBoxState.DisplayMember = "StateName";
                    cbBoxState.ValueMember = "StateCode";           //in this case we return the state code


                    //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
                    cbBoxCountry.DataSource = Country.GetAllCountries();

                    //Set DisplayMember property to indicate which property gets displayed on the combobox
                    //Set ValueMember Property to indicate which property is GOTTEN to used in the code
                    cbBoxCountry.DisplayMember = "CountryName";
                    cbBoxCountry.ValueMember = "CountryName";


                    txtBoxCCNumber.Text = "";
                    txtCCOwner.Text = "";
                    txtBoxCCICompany.Text = "";
                    txtBoxMC.Text = "";
                    dtpExpDate.Text = "";
                    txtBoxAddl1.Text = "";
                    txtBoxAddl2.Text = "";
                    txtBoxCity.Text = "";                   
                    txtBoxZipCode.Text = "";                   
                    txtBoxCCLimit.Text = "3000";
                    txtBoxCCBalance.Text = "3000";
                    cbBoxAC.Text = "Activate";

                }
                else
                {
                    MessageBox.Show("Error! Customer was not added!");

                }//End of else


            }//End of try
            catch (System.Exception)
            {
                MessageBox.Show("Error! Customer was not added!");
            }
        }

        private void frmCreditCardRegistrationMSForm_Load(object sender, EventArgs e)
        {
            
            //BINDING State ComboBox to the USState Class GetAllUSStates Static Method
            cbBoxState.DataSource = USState.GetAllUSStates();

            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property to get data from in the code
            cbBoxState.DisplayMember = "StateName";
            cbBoxState.ValueMember = "StateCode";           //in this case we return the state code
            
            
            //BINDING Country ComboBox to the Country Class GetAllCountry Static Method
            cbBoxCountry.DataSource = Country.GetAllCountries();

            //Set DisplayMember property to indicate which property gets displayed on the combobox
            //Set ValueMember Property to indicate which property is GOTTEN to used in the code
            cbBoxCountry.DisplayMember = "CountryName";
            cbBoxCountry.ValueMember = "CountryName";        //in this case we return the country name
            
            //Programmatically set the properties to the Activation Status Combo Box
            //and ADD the activated and deactivated items to the Combo Box
            cbBoxAC.Items.Add("Activate");
            cbBoxAC.Items.Add("Deactivate");

            //SET SELECTED TEXT Property to populate the ActivationStatus ComboBox to Activated
            cbBoxAC.SelectedText = "Activate";


            //Initialized Credit Card Limit & Credit Card Balance Combo boxes
            txtBoxCCBalance.Text = "3000";
            txtBoxCCLimit.Text = "3000";

            //Other Code needed inside the Form_Load()Event Handler
        }
    }
}
