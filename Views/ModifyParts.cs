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
    public partial class ModifyParts : Form
    {
        public ModifyParts()
        {
            InitializeComponent();
            rb_ModPartInHouse.Checked = true;  //Set Inhouse checked by default

            if (Inventory.CurrentPart is Inhouse)
            {
                /*Set the Inventory property, CurrentPart, which is type Part, to a new Inhouse type before adding the objects from the
                selected row.
                Set the Text value for all the textboxes to the value stored in the CurrentPart object.
                Because the CurrentPart was cast as an Inhouse, the MachineID is available.
                Perform the same task for Outsourced.*/

                rb_ModPartInHouse.Checked = true;
                label_ModPartSource.Text = "Machine ID";

                Inhouse ihPart = (Inhouse)Inventory.CurrentPart;
                tb_ModPartID.Text = ihPart.PartID.ToString();
                tb_ModPartName.Text = ihPart.Name.ToString(); ;
                tb_ModPartInventory.Text = ihPart.InStock.ToString();
                tb_ModPartPrice.Text = ihPart.Price.ToString();
                tb_ModPartMax.Text = ihPart.Max.ToString();
                tb_ModPartMin.Text = ihPart.Min.ToString();
                tb_ModPartMachineCompany.Text = ihPart.MachineID.ToString();
                Inventory.CurrentPartID = ihPart.PartID;
                
            }
            else if(Inventory.CurrentPart is Outsourced)
            {
                rb_ModPartOutsourced.Checked = true;
                label_ModPartSource.Text = "Company Name";

                Outsourced oPart = (Outsourced)Inventory.CurrentPart;
                tb_ModPartID.Text = oPart.PartID.ToString();
                tb_ModPartName.Text = oPart.Name.ToString(); ;
                tb_ModPartInventory.Text = oPart.InStock.ToString();
                tb_ModPartPrice.Text = oPart.Price.ToString();
                tb_ModPartMax.Text = oPart.Max.ToString();
                tb_ModPartMin.Text = oPart.Min.ToString();
                tb_ModPartMachineCompany.Text = oPart.CompanyName;
                Inventory.CurrentPartID = oPart.PartID;

            }



            /******************************************
             ** SET ALL TEXTBOX BACKGROUNDS TO Orange**
             ******************************************/

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name != "tb_ModPartID" && tb.Text == "")
                    tb.BackColor = Color.OrangeRed;
            }
        }

               
        private void btn_ModPartCancel_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Close();
            main.Show();
            
        }

        private void btn_ModPartSave_Click(object sender, EventArgs e)
        {
            bool emptyForm = false;
            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.BackColor == Color.OrangeRed )
                {
                    MessageBox.Show("Form is not complete. Please verify all fields are filled out.");
                    emptyForm = true;
                }
                
            }
            if (!emptyForm)
            {
                try 
                {
                    var dialogResult = MessageBox.Show($"Do you want to Modify '{Inventory.CurrentPart.Name}'?", "Modify Part?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        if (rb_ModPartInHouse.Checked)
                        {
                            Part updated = new Inhouse
                                (
                                tb_ModPartName.Text, 
                                Convert.ToInt32(tb_ModPartInventory.Text),
                                Convert.ToDecimal(tb_ModPartPrice.Text),
                                Convert.ToInt32(tb_ModPartMax.Text) ,
                                Convert.ToInt32(tb_ModPartMin.Text),
                                Convert.ToInt32(tb_ModPartMachineCompany.Text)
                                );
                            updated.PartID = Inventory.CurrentPartID;
                            Inventory.updatePart(Inventory.CurrentPartID, updated);
                        }
                        else
                        {
                            Part updated = new Outsourced
                                (
                                tb_ModPartName.Text, 
                                Convert.ToInt32(tb_ModPartInventory.Text),
                                Convert.ToDecimal(tb_ModPartPrice.Text),
                                Convert.ToInt32(tb_ModPartMax.Text), 
                                Convert.ToInt32(tb_ModPartMin.Text), 
                                tb_ModPartMachineCompany.Text
                                );
                            updated.PartID = Inventory.CurrentPartID;
                            Inventory.updatePart(Inventory.CurrentPartID, updated);

                        }
                        MainScreen main = new MainScreen();
                        MessageBox.Show("Part has been updated!");
                        this.Close();
                        main.Show();

                    }
                }
                catch (FormatException err)
                {
                    MessageBox.Show(err.Message);
                }
            }
            

        }

        


        /*****************************************************
         **********  CALL VALIDATION UPON TEXT CHANGE*********
         *****************************************************/
        private void tb_ModPartName_TextChanged(object sender, EventArgs e)
        {
            validateName();             
        }

        private void tb_ModPartInventory_TextChanged(object sender, EventArgs e)
        {
            validateInventory();                
        }

        private void tb_ModPartPrice_TextChanged(object sender, EventArgs e)
        {
            validatePrice();
        }

        private void tb_ModPartMax_TextChanged(object sender, EventArgs e)
        {
            validateMax();
        }

        private void tb_ModPartMin_TextChanged(object sender, EventArgs e)
        {
            validateMin();          
        }

        private void tb_ModPartMachineCompany_TextChanged(object sender, EventArgs e)
        {
            validateCompanyMachineID();
        }




        private void rb_ModPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label_ModPartSource.Text = "Machine ID";
        }

        private void rb_ModPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label_ModPartSource.Text = "Company Name";
        }



        /*****************************************************
         *********** FIRES EVENT WHEN LEAVING TEXTBOX TO *****
         *****************************************************/
        private void tb_ModPartPrice_Leave(object sender, EventArgs e)
        {
            try
            {
                //Formats price to a currency
                if (tb_ModPartPrice.Text.IndexOf(".") == -1)
                    tb_ModPartPrice.Text = string.Format(new CultureInfo("en-US"), "{0:0.00}", decimal.Parse(tb_ModPartPrice.Text));
            }
            catch (FormatException)
            {
                MessageBox.Show("Price can not be left blank.");
            }
        }

        private void tb_ModPartInventory_Leave(object sender, EventArgs e)
        {
            validateInventory();
        }


        /*************************************************************************
         * KEY PRESS VALIDATION - ONLY ALLOW APPROPRIATE INPUT KEYS TO BE PRESSED*
         *************************************************************************/

        private void tb_ModPartInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tb_ModPartPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((keyvalue == DECIMAL_POINT) && (tb_ModPartPrice.Text.IndexOf(".") == NOT_FOUND)) return;

            e.Handled = true;
        }

        private void tb_ModPartMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tb_ModPartMin_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tb_ModPartMachineCompany_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (rb_ModPartInHouse.Checked) //Only allow numbers for Machine, but allows AlphaNumeric for Company Names
            {
                const int BACKSPACE = 8;
                const int ZERO = 48;
                const int NINE = 57;


                int keyvalue = e.KeyChar;

                //Allow the Backspace, 0-9 keys only
                if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

                e.Handled = true;
            }
        }





        /**************************************
        ********* VALIDATION METHODS **********
        **************************************/

        private void validateName() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartName.Text.Trim()))
                {
                    tb_ModPartName.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(tb_ModPartName, "Part Name is required.");
                }

                else
                {
                    tb_ModPartName.BackColor = Color.White;
                    errorProvider1.SetError(tb_ModPartName, string.Empty);
                }

            }
            catch { }
        }

        private void validateInventory() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartInventory.Text.Trim()))
                {
                    tb_ModPartInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_ModPartInventory, "Inventory quantity is required.");
                }
                else if (Convert.ToInt32(tb_ModPartMax.Text) < Convert.ToInt32(tb_ModPartInventory.Text) || Convert.ToInt32(tb_ModPartMin.Text) > Convert.ToInt32(tb_ModPartInventory.Text))
                {
                    //tb_ModPartMax.BackColor = Color.OrangeRed;
                    tb_ModPartInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_ModPartInventory, "Must be between Max and Min values.");
                }
                else
                {
                    tb_ModPartInventory.BackColor = Color.White;
                    //tb_ModPartMax.BackColor = Color.White;
                    errorProvider2.SetError(tb_ModPartInventory, string.Empty);
                }

            }
            catch { }
        }

        private void validatePrice()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartPrice.Text.Trim()))
                {
                    tb_ModPartPrice.BackColor = Color.OrangeRed;
                    errorProvider3.SetError(tb_ModPartPrice, "A price is required.");
                }
                else
                {
                    tb_ModPartPrice.BackColor = Color.White;
                    errorProvider3.SetError(tb_ModPartPrice, string.Empty);
                }
            }
            catch { }
        }

        private void validateMax() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartMax.Text.Trim()))
                {
                    tb_ModPartMax.BackColor = Color.OrangeRed;
                    errorProvider4.SetError(tb_ModPartMax, "A Maximum stock level is required.");
                }
                else if (Convert.ToInt32(tb_ModPartMax.Text) < Convert.ToInt32(tb_ModPartInventory.Text))
                {
                    tb_ModPartMax.BackColor = Color.OrangeRed;
                    tb_ModPartInventory.BackColor = Color.OrangeRed;
                    errorProvider4.SetError(tb_ModPartMax, "Must be equal or larger than Inventory.");
                }
                else
                {
                    tb_ModPartMax.BackColor = Color.White;
                    tb_ModPartInventory.BackColor = Color.White;
                    errorProvider4.SetError(tb_ModPartMax, string.Empty);
                }
                validateInventory();

            }
            catch { }
        }
        private void validateMin() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartMin.Text.Trim()))
                {
                    tb_ModPartMin.BackColor = Color.OrangeRed;
                    errorProvider5.SetError(tb_ModPartMin, "Please enter a minimum stock level.");

                }
                else if (Convert.ToInt32(tb_ModPartMin.Text) > Convert.ToInt32(tb_ModPartInventory.Text))
                {
                    errorProvider5.SetError(tb_ModPartMin, "Enter a minimum limit less than or equal to stock level.");
                    tb_ModPartMin.BackColor = Color.OrangeRed;
                    tb_ModPartInventory.BackColor = Color.OrangeRed;

                }
                else if (Convert.ToInt32(tb_ModPartMin.Text) > Convert.ToInt32(tb_ModPartMax.Text))
                {
                    errorProvider5.SetError(tb_ModPartMin, "Minimum cannot be larger than Maximum value.");
                    tb_ModPartMin.BackColor = Color.OrangeRed;
                    tb_ModPartMax.BackColor = Color.OrangeRed;
                }
                else
                {
                    errorProvider5.SetError(tb_ModPartMin, string.Empty);
                    tb_ModPartMin.BackColor = Color.White;
                    tb_ModPartInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
        private void validateCompanyMachineID()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModPartMachineCompany.Text.Trim()))
                {
                    tb_ModPartMachineCompany.BackColor = Color.OrangeRed;
                    errorProvider6.SetError(tb_ModPartMachineCompany, "Enter a Machine ID or Company Name.");
                }
                else
                {
                    tb_ModPartMachineCompany.BackColor = Color.White;
                    errorProvider6.SetError(tb_ModPartMachineCompany, string.Empty);
                }

            }
            catch { }
        }

        
    }

}
