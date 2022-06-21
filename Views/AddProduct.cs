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
    public partial class AddProduct : Form
    {
        static BindingList<Part> tempList = new BindingList<Part>();

        public AddProduct()
        {
            InitializeComponent();
            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAssocParts.DataSource = tempList;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.RowHeadersVisible = false;
            dgvAllParts.MultiSelect = false;
            dgvAllParts.ReadOnly = true;
            dgvAllParts.DefaultCellStyle.BackColor = Color.White;
            dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllParts.ClearSelection();
            dgvAssocParts.Rows.Clear();     


            /**************************************
             * SET ALL TEXTBOX BACKGROUNDS TO RED**
             **************************************/

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if ( ((tb.Name != "tb_ProductID")&&(tb.Name != "tb_AddProdSearch")) && (tb.Text == "") )
                { 
                    tb.BackColor = Color.OrangeRed;
                }
            }
        }
       

        


        private void ClearForm()
        {
            tb_AddProdName.Clear();
            tb_AddProdPrice.Clear();
            tb_AddProdInventory.Clear();
            tb_AddProdMax.Clear();
            tb_AddProdMin.Clear();
        }

        private Product BuildTempProduct()
        {
            var newProdList = new BindingList<Part>();
            var priceRounded = string.Format("{0:0.00}", (string)tb_AddProdPrice.Text);
            Product tempProd = new Product(
                        tb_AddProdName.Text.ToLower(),                       
                        Convert.ToInt32(tb_AddProdInventory.Text),
                        Convert.ToDecimal(priceRounded),
                        Convert.ToInt32(tb_AddProdMax.Text),
                        Convert.ToInt32(tb_AddProdMin.Text),
                        newProdList
                    );
            
            return tempProd;
        }

        private void btn_AddProdSearch_Click(object sender, EventArgs e)
        {
            bool found = false;
            BindingList<Part> tempList = new BindingList<Part>();

            if (tb_AddProdSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.Contains(tb_AddProdSearch.Text.ToLower()))
                    {
                        tempList.Add(Inventory.AllParts[i]);

                        found = true;
                    }
                }
                if (found)
                {
                    dgvAllParts.DataSource = tempList;
                }
                else
                {
                    MessageBox.Show("No Part found matching that criteria!");
                }
            }
        }

        private void btn_AddProdResetSrch_Click(object sender, EventArgs e)
        {
            dgvAllParts.DataSource = Inventory.AllParts;
            
        }

        
        private void btn_ProdCancel_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Close();
            main.Show();
        }

        
        private void dgvAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*Find the RowIndex of the selected (clicked) row and set the CurrentPartID property in the Inventory class to the row index.
                 Then set the CurrentPart property to the Part object via the lookUpPart method in the Inventory class*/
                dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

                var selectedIndex = e.RowIndex;
                Inventory.CurrentPart = Inventory.lookupPart(selectedIndex);
            }
            catch
            {
                dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;

                MessageBox.Show("You clicked a header. Please select a row.");
            }
        }

        
        private void btn_AddAssocPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (Inventory.CurrentPart != null)
                {
                    tempList.Add(Inventory.CurrentPart);
                    Inventory.CurrentPart = null;
                }
                else
                MessageBox.Show("Complete form or choose a part to associate.");
            }
            catch { }
            
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            try {
                bool emptyForm = false;
                foreach (TextBox tb in this.Controls.OfType<TextBox>())
                {
                    if (tb.BackColor == Color.OrangeRed)
                    {
                        MessageBox.Show("Form is not complete. Please verify all fields are filled out.");
                        emptyForm = true;
                    }
                }
                    if (emptyForm == false)
                    {
                    
                    Product tempProduct = BuildTempProduct();
                    
                    foreach (Part p in tempList)
                    {
                        tempProduct.addAssociatedPart(p);
                    }

                    var confirmResult = MessageBox.Show("Are you sure you want to add this product?", "Confirm Add Product.", MessageBoxButtons.YesNo);

                    if (confirmResult == DialogResult.Yes)
                    {
                        Inventory.addProduct(tempProduct);
                    }
                    else
                    {
                        return;
                    }
                    this.Close();
                    MainScreen main = new MainScreen();
                    main.Show();
                    }
                else
                {
                    MessageBox.Show("Please add at least ONE(1) Associated Part.");
                }

            }
            catch (FormatException)
            {
                MessageBox.Show("Please complete form.");
            }

        }

        

        private void dgvAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = Convert.ToInt32(dgvAssocParts.Rows[e.RowIndex].Cells[0].Value);
            Inventory.CurrentPart = Inventory.lookupPart(selectedIndex); //sets the current part so it can be removed from list
            //Inventory.CurrentPartID = Inventory.CurrentPart.PartID;

        }

        private void btn_DelAscPart_Click(object sender, EventArgs e)
        {
            try
            {
                if (dgvAssocParts.RowCount != 0 && Inventory.CurrentPart != null)
                {
                    tempList.Remove(Inventory.CurrentPart);
                }
                else
                {
                    MessageBox.Show("Associated Part not selected.");

                }

            }
            catch
            {

            }
            
        }


        /*****************************************************
        * CHANGE TEXTBOX COLOR WHEN TEXT IS CHANGED OR ADDED*
        *****************************************************/
        private void tb_AddProdName_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }

        private void tb_AddProdInventory_TextChanged(object sender, EventArgs e)
        {
            validateInventory();
        }

        private void tb_AddProdPrice_TextChanged(object sender, EventArgs e)
        {
            validatePrice();
        }

        private void tb_AddProdMax_TextChanged(object sender, EventArgs e)
        {
            validateMax();
        }

        private void tb_AddProdMin_TextChanged(object sender, EventArgs e)
        {
            validateMin();
        }


        /*****************************************************
         * FIRES EVENT WHEN LEAVING TEXTBOX TO FORMAT STRING**
         *****************************************************/
        private void tb_AddProdName_Leave(object sender, EventArgs e)
        {
            validateName();
        }
        private void tb_AddProdInventory_Leave(object sender, EventArgs e)
        {
            validateInventory();
        }


        private void tb_AddProdPrice_Leave(object sender, EventArgs e)
        {
            //Formats price to a currency
            try
            {
                if (tb_AddProdPrice.Text.IndexOf(".") == -1)
                {

                    tb_AddProdPrice.Text = string.Format(new CultureInfo("en-US"), "{0:0.00}", decimal.Parse(tb_AddProdPrice.Text));
                }
            }
           catch { }

        }
        
      

        



        /*************************************************************************
         * KEY PRESS VALIDATION - ONLY ALLOW APPROPRIATE INPUT KEYS TO BE PRESSED*
         *************************************************************************/
        private void tb_AddProdInventory_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tb_AddProdPrice_KeyPress(object sender, KeyPressEventArgs e)
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
            if ((keyvalue == DECIMAL_POINT) && (tb_AddProdPrice.Text.IndexOf(".") == NOT_FOUND)) return;

            e.Handled = true;
        }

        private void tb_AddProdMax_KeyPress(object sender, KeyPressEventArgs e)
        {
            const int BACKSPACE = 8;
            const int ZERO = 48;
            const int NINE = 57;


            int keyvalue = e.KeyChar;

            //Allow the Backspace, 0-9 keys only
            if ((keyvalue == BACKSPACE) || ((keyvalue >= ZERO) && (keyvalue <= NINE))) return;

            e.Handled = true;
        }

        private void tb_AddProdMin_KeyPress(object sender, KeyPressEventArgs e)
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
                if (string.IsNullOrEmpty(tb_AddProdName.Text.Trim()))
                {
                    tb_AddProdName.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(tb_AddProdName, "Name is required.");

                }
                else
                {
                    tb_AddProdName.BackColor = Color.White;
                    errorProvider1.SetError(tb_AddProdName, string.Empty);
                }
            }
            catch { }
        }

        private void validateInventory() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_AddProdInventory.Text.Trim()))
                {
                    tb_AddProdInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_AddProdInventory, "Inventory is required to be between Max and Min values.");
                }
                else if (Convert.ToInt32(tb_AddProdMax.Text) < Convert.ToInt32(tb_AddProdInventory.Text) || Convert.ToInt32(tb_AddProdMin.Text) > Convert.ToInt32(tb_AddProdInventory.Text))
                {

                    tb_AddProdInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_AddProdInventory, "Must be between Max and Min values.");
                }

                else
                {
                    tb_AddProdInventory.BackColor = Color.White;
                    errorProvider2.SetError(tb_AddProdInventory, string.Empty);
                }

            }
            catch
            {

            }
        }

        private void validatePrice() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_AddProdPrice.Text.Trim()))
                {
                    tb_AddProdPrice.BackColor = Color.OrangeRed;
                    errorProvider3.SetError(tb_AddProdPrice, "Price is required.");
                }
                else
                {
                    tb_AddProdPrice.BackColor = Color.White;
                    errorProvider3.SetError(tb_AddProdPrice, string.Empty);
                }

            }
            catch { }
        }

        private void validateMax() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_AddProdMax.Text.Trim()))
                {
                    tb_AddProdMax.BackColor = Color.OrangeRed;
                    errorProvider4.SetError(tb_AddProdMax, "Please enter a maximum stock level.");

                }
                else if (Convert.ToInt32(tb_AddProdMax.Text) < Convert.ToInt32(tb_AddProdInventory.Text))
                {
                    errorProvider4.SetError(tb_AddProdMax, "Enter a maximum limit greater than or equal to stock level.");
                    tb_AddProdMax.BackColor = Color.OrangeRed;
                    tb_AddProdInventory.BackColor = Color.OrangeRed;

                }
                else
                {
                    errorProvider4.SetError(tb_AddProdMax, string.Empty);
                    tb_AddProdMax.BackColor = Color.White;
                    tb_AddProdInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
        private void validateMin() 
        {
            try
            {
                if (string.IsNullOrEmpty(tb_AddProdMin.Text.Trim()))
                {
                    tb_AddProdMin.BackColor = Color.OrangeRed;
                    errorProvider5.SetError(tb_AddProdMin, "Please enter a minimum stock level.");

                }
                else if (Convert.ToInt32(tb_AddProdMin.Text) > Convert.ToInt32(tb_AddProdInventory.Text))
                {
                    errorProvider5.SetError(tb_AddProdMin, "Enter a minimum limit less than or equal to stock level.");
                    tb_AddProdMin.BackColor = Color.OrangeRed;
                    tb_AddProdInventory.BackColor = Color.OrangeRed;

                }
                else if (Convert.ToInt32(tb_AddProdMin.Text) > Convert.ToInt32(tb_AddProdMax.Text))
                {
                    errorProvider5.SetError(tb_AddProdMin, "Minimum cannot be larger than Maximum value.");
                    tb_AddProdMin.BackColor = Color.OrangeRed;
                    tb_AddProdMax.BackColor = Color.OrangeRed;
                }
                else
                {
                    errorProvider5.SetError(tb_AddProdMin, string.Empty);
                    tb_AddProdMin.BackColor = Color.White;
                    tb_AddProdInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
    }
}
