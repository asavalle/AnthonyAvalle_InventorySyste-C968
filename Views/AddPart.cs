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

            foreach (TextBox tb in this.Controls.OfType<TextBox>().Where(x => x.Text == ""))
            {
                if(tb != tbPartID)
                  tb.BackColor = Color.Crimson;


            }

        }

        

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Company Name";
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Machine ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }

        private void btn_SavePart_Click(object sender, EventArgs e)
        {
            BindingList<Part> list = new BindingList<Part>();

            try
            {
                if (rbInhouse.Checked)
                {
                    var priceRounded = string.Format("{0:0.00}", (string)tbAddPriceCost.Text);

                    Inhouse newInhouse = new Inhouse
                    (
                        tbAddPartName.Text.ToLower(),
                        Convert.ToDecimal(priceRounded),
                        Convert.ToInt32(tbAddPartInventory.Text),
                        Convert.ToInt32(tbAddPartMin.Text),
                        Convert.ToInt32(tbAddPartMax.Text),
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
                        Convert.ToDecimal(priceRounded),
                        Convert.ToInt32(tbAddPartInventory.Text),
                        Convert.ToInt32(tbAddPartMin.Text),
                        Convert.ToInt32(tbAddPartMax.Text),
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




        /*****************************************************
         * CHANGE TEXTBOX COLOR WHEN TEXT IS CHANGED OR ADDED*
         *****************************************************/
        private void tbAddPartName_TextChanged(object sender, EventArgs e)
        {
            tbAddPartName.BackColor = Color.Crimson;
            bool blank = true;
            while(blank == true)
            {

                if (tbAddPartName.Text != "")
                {
                    tbAddPartName.BackColor = Color.White;
                    blank = false;
                }
                else
                    blank = false;
                    
            }
           

        }

        private void tbAddPartInventory_TextChanged(object sender, EventArgs e)
        {
            tbAddPartInventory.BackColor = Color.Crimson;
            bool blank = true;
            while (blank == true)
            {

                if (tbAddPartInventory.Text != "")
                {
                    tbAddPartInventory.BackColor = Color.White;
                    blank = false;
                    
                }
                else
                    blank = false;

            }
        }

        private void tbAddPriceCost_TextChanged(object sender, EventArgs e)
        {
            tbAddPriceCost.BackColor = Color.Crimson;
            bool blank = true;
            while (blank == true)
            {

                if (tbAddPriceCost.Text != "")
                {
                    tbAddPriceCost.BackColor = Color.White;
                    blank = false;

                }
                else
                    blank = false;

            }
        }

        private void tbAddPartMax_TextChanged(object sender, EventArgs e)
        {
            tbAddPartMax.BackColor = Color.Crimson;
            bool blank = true;
            while (blank == true)
            {

                if (tbAddPartMax.Text != "")
                {
                    tbAddPartMax.BackColor = Color.White;
                    blank = false;

                }
                else
                    blank = false;

            }
        }

        private void tbAddPartMin_TextChanged(object sender, EventArgs e)
        {
            tbAddPartMin.BackColor = Color.Crimson;
            bool blank = true;
            while (blank == true)
            {

                if (tbAddPartMin.Text != "")
                {
                    tbAddPartMin.BackColor = Color.White;
                    blank = false;

                }
                else
                    blank = false;

            }
        }

        private void tbCompanyOrMachine_TextChanged(object sender, EventArgs e)
        {
            tbCompanyOrMachine.BackColor = Color.Crimson;
            bool blank = true;
            while (blank == true)
            {

                if (tbCompanyOrMachine.Text != "" || tbCompanyOrMachine.Text != null)
                {
                    tbCompanyOrMachine.BackColor = Color.White;
                    blank = false;

                }
                else
                    blank = false;

            }

            btn_SavePart.Enabled = true;

        }


        /*****************************************************
         * FIRES EVENT WHEN LEAVING TEXTBOX TO FORMAT STRING**
         *****************************************************/
        private void tbAddPriceCost_Leave(object sender, EventArgs e)
        {
            if (tbAddPriceCost.Text.IndexOf(".") == -1)
            {

                tbAddPriceCost.Text = string.Format(new CultureInfo("en-US"), "{0:0.00}", decimal.Parse(tbAddPriceCost.Text));
            }
        }

        private void tbAddPartMin_Leave(object sender, EventArgs e)
        {
            if (Convert.ToInt32(tbAddPartMin.Text) > Convert.ToInt32(tbAddPartMax.Text))
            {
                MessageBox.Show("Minimum stock level cannot exceed Maximum stock level.");
            }
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
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;
          

            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
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

        
    }
}
