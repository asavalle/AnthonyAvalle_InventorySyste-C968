using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryTrackingApp.Views
{
    public partial class AddPart : Form
    {

        private MainScreen mainScreen = new MainScreen();

        public AddPart()
        {
            InitializeComponent();
            btn_SavePart.Enabled = false;

            /**************************************
             * SET ALL TEXTBOX BACKGROUNDS TO RED**
             **************************************/
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                
                if(tb.Name != "tbPartID" && tb.Text == "")
                  tb.BackColor = Color.OrangeRed;
                
                  btn_SavePart.Enabled = true;
            }

        }

        

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Company Name";
            tbCompanyOrMachine.Text = "";
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Machine ID";
            tbCompanyOrMachine.Text = "";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }

        private void btn_SavePart_Click(object sender, EventArgs e)
        {
            BindingList<Part> list = new BindingList<Part>();

            var numEmptyFields = 0;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.BackColor == Color.OrangeRed)
                {
                    numEmptyFields++;    
                    
                }
                if(numEmptyFields > 0)
                {
                    MessageBox.Show("Form is not complete. Please verify all fields are filled out.");
                    return;
                }


            }
            if (numEmptyFields < 6)
            {
                try
                {
                    if (rbInhouse.Checked)
                    {
                        var priceRounded = string.Format("{0:0.00}", (string)tbAddPriceCost.Text);

                        Inhouse newInhouse = new Inhouse
                        (
                            tbAddPartName.Text.ToLower(),
                            Convert.ToInt32(tbAddPartInventory.Text),
                            Convert.ToDecimal(priceRounded),
                            Convert.ToInt32(tbAddPartMax.Text),
                            Convert.ToInt32(tbAddPartMin.Text),
                            Convert.ToInt32(tbCompanyOrMachine.Text)
                        );

                        Inventory.addPart(newInhouse);
                    }
                    else
                    {
                        var priceRounded = string.Format("{0:0.00}", (string)tbAddPriceCost.Text);
                        Outsourced newOutsourced = new Outsourced
                        (
                            tbAddPartName.Text.ToLower(),
                            Convert.ToInt32(tbAddPartInventory.Text),
                            Convert.ToDecimal(priceRounded),
                            Convert.ToInt32(tbAddPartMax.Text),
                            Convert.ToInt32(tbAddPartMin.Text),
                            tbCompanyOrMachine.Text.ToLower()
                        );

                        Inventory.addPart(newOutsourced);

                    }


                    MessageBox.Show("Part Added");
                    this.Close();
                    mainScreen.Show();
                }
                catch (FormatException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
        }




        /*****************************************************
         * CHANGE TEXTBOX COLOR WHEN TEXT IS CHANGED OR ADDED*
         *****************************************************/
        private void tbAddPartName_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }      
        private void tbAddPartInventory_TextChanged(object sender, EventArgs e)
        {
            validateInventory();          
        }
        private void tbAddPriceCost_TextChanged(object sender, EventArgs e)
        {
            validatePrice();               
        }
        private void tbAddPartMax_TextChanged(object sender, EventArgs e)
        {
            validateMax();           
        }       
        private void tbAddPartMin_TextChanged(object sender, EventArgs e)
        {
            validateMin();                
        }       
        private void tbCompanyOrMachine_TextChanged(object sender, EventArgs e)
        {

            validateCompanyMachineID();
        }




        /*****************************************************
         * FIRES EVENT WHEN LEAVING TEXTBOX TO FORMAT STRING**
         *****************************************************/
        private void tbAddPartInventory_Leave(object sender, EventArgs e)
        {
            validateInventory();
        }
        private void tbAddPriceCost_Leave(object sender, EventArgs e)
        {
            //Formats price to a currency
            try
            {
                if (tbAddPriceCost.Text.IndexOf(".") == -1)
                {
                    tbAddPriceCost.Text = string.Format(new CultureInfo("en-US"), "{0:0.00}", decimal.Parse(tbAddPriceCost.Text));
                }
            }
            catch { }
            
        }

        

        /*************************************************************************
         * KEY PRESS VALIDATION - ONLY ALLOW APPROPRIATE INPUT KEYS TO BE PRESSED*
         *************************************************************************/
        private void tbAddPriceCost_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int DECIMAL_POINT = 46;
            const int ZERO = 48;
            const int NINE = 57;
            const int NOT_FOUND = -1;

            int keyvalue = e.KeyChar; 

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            // Allow one decimal point if the text does not already contain a decimal point.
            if ((keyvalue == DECIMAL_POINT) && (tbAddPriceCost.Text.IndexOf(".") == NOT_FOUND)) return;
           
            e.Handled = true;
        }

        private void tbCompanyOrMachine_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rbInhouse.Checked) //Only allow numbers for Machine, but allows AlphaNumeric for Company Names
            { 
                const int BACKSPACE = 8;
                const int ZERO = 48;
                const int NINE = 57;
          

                int keyvalue = e.KeyChar;
                if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;//Allow the Backspace, 0-9 keys only
                

                e.Handled = true;
            }
            
        }

        private void tbAddPartInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tbAddPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tbAddPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;
            
            e.Handled = true;
        }



        /**************************************
        ********* VALIDATION METHODS **********
        **************************************/
        private void validateName()
        {
            try
            {
                if (string.IsNullOrEmpty(tbAddPartName.Text.Trim()))
                {
                    tbAddPartName.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(tbAddPartName, "Part Name is required.");

                }
                else
                {
                    tbAddPartName.BackColor = Color.White;
                    errorProvider1.SetError(tbAddPartName, string.Empty);
                }
            }
            catch { }
        }
        private void validateInventory()
        {
            try
            {
                if (string.IsNullOrEmpty(tbAddPartInventory.Text.Trim()))
                {
                    tbAddPartInventory.BackColor = Color.OrangeRed;
                    errorProvider3.SetError(tbAddPartInventory, "Inventory is required to be between Max and Min values.");
                }
                else if (Convert.ToInt32(tbAddPartMax.Text) < Convert.ToInt32(tbAddPartInventory.Text) || Convert.ToInt32(tbAddPartMin.Text) > Convert.ToInt32(tbAddPartInventory.Text))
                {

                    tbAddPartInventory.BackColor = Color.OrangeRed;
                    errorProvider3.SetError(tbAddPartInventory, "Must be between Max and Min values.");
                }

                else
                {
                    tbAddPartInventory.BackColor = Color.White;
                    errorProvider3.SetError(tbAddPartInventory, string.Empty);
                }

            }
            catch {
                
            }
        }
        private void validatePrice()
        {
            try
            {
                if (string.IsNullOrEmpty(tbAddPriceCost.Text.Trim()))
                {
                    tbAddPriceCost.BackColor = Color.OrangeRed;
                    errorProvider4.SetError(tbAddPriceCost, "Price is required.");
                }
                else
                {
                    tbAddPriceCost.BackColor = Color.White;
                    errorProvider4.SetError(tbAddPriceCost, string.Empty);
                }

            }
            catch { }
        }
        private void validateMax()
        {
            try
            {
                if (string.IsNullOrEmpty(tbAddPartMax.Text.Trim()))
                {
                    tbAddPartMax.BackColor = Color.OrangeRed;
                    errorProvider5.SetError(tbAddPartMax, "Please enter a maximum stock level.");

                }
                else if (Convert.ToInt32(tbAddPartMax.Text) < Convert.ToInt32(tbAddPartInventory.Text))
                {
                    errorProvider5.SetError(tbAddPartMax, "Enter a maximum limit greater than or equal to stock level.");
                    tbAddPartMax.BackColor = Color.OrangeRed;
                    tbAddPartInventory.BackColor = Color.OrangeRed;

                }
                else
                {
                    errorProvider5.SetError(tbAddPartMax, string.Empty);
                    tbAddPartMax.BackColor = Color.White;
                    tbAddPartInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
        private void validateMin()
        {
            try
            {
                if (string.IsNullOrEmpty(tbAddPartMin.Text.Trim()))
                {
                    tbAddPartMin.BackColor = Color.OrangeRed;
                    errorProvider6.SetError(tbAddPartMin, "Please enter a minimum stock level.");

                }
                else if (Convert.ToInt32(tbAddPartMin.Text) > Convert.ToInt32(tbAddPartInventory.Text))
                {
                    errorProvider6.SetError(tbAddPartMin, "Enter a minimum limit less than or equal to stock level.");
                    tbAddPartMin.BackColor = Color.OrangeRed;
                    tbAddPartInventory.BackColor = Color.OrangeRed;

                }
                else if (Convert.ToInt32(tbAddPartMin.Text) > Convert.ToInt32(tbAddPartMax.Text))
                {
                    errorProvider6.SetError(tbAddPartMin, "Minimum cannot be larger than Maximum value.");
                    tbAddPartMin.BackColor = Color.OrangeRed;
                    tbAddPartMax.BackColor = Color.OrangeRed;
                }
                else
                {
                    errorProvider6.SetError(tbAddPartMin, string.Empty);
                    tbAddPartMin.BackColor = Color.White;
                    tbAddPartInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
        private void validateCompanyMachineID()
        {
            try
            {
                if (string.IsNullOrEmpty(tbCompanyOrMachine.Text.Trim()))
                {
                    tbCompanyOrMachine.BackColor = Color.OrangeRed;
                    errorProvider7.SetError(tbCompanyOrMachine, "Enter a Machine ID or Company Name.");
                }
                else
                {
                    tbCompanyOrMachine.BackColor = Color.White;
                    errorProvider7.SetError(tbCompanyOrMachine, string.Empty);
                }

            }
            catch { }
        }

        
    }
}
