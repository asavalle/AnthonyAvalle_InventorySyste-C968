using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace InventoryTrackingApp.Views
{
    public partial class ModifyProducts : Form
    {
        Product tempProd = new Product
                (
                    Inventory.CurrentProduct.Name,                    
                    Inventory.CurrentProduct.InStock,
                    Inventory.CurrentProduct.Price,
                    Inventory.CurrentProduct.Max,
                    Inventory.CurrentProduct.Min,
                    Inventory.CurrentProduct.AssociatedParts
                );
        public ModifyProducts()
        {
            InitializeComponent();
            /*All Parts List setup*/
            dgvModAllParts.DataSource = Inventory.AllParts;
            dgvModAllParts.RowHeadersVisible = false;
            dgvModAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModAllParts.DefaultCellStyle.BackColor = Color.White;
            dgvModAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvModAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvModAllParts.ReadOnly = true;

            /*Associated Parts List setup*/
            dgvModAssocParts.DataSource = Inventory.CurrentProduct.AssociatedParts;
            dgvModAssocParts.RowHeadersVisible = false;
            dgvModAssocParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvModAssocParts.DefaultCellStyle.BackColor = Color.White;
            dgvModAssocParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvModAssocParts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvModAssocParts.ReadOnly = true;

            btn_ModSaveProd.Enabled = true;



            /******************************************
             ** SET ALL TEXTBOX BACKGROUNDS TO Orange**
             ******************************************/

            foreach (TextBox tb in this.Controls.OfType<TextBox>())
            {
                if (tb.Name != "tb_ModProductID" && (tb.Name != "tb_ModProdSearch") && tb.Text == "")
                    tb.BackColor = Color.OrangeRed;
            }

        }

        

        private void ModifyProducts_Load(object sender, EventArgs e)
        {
            BindingList<Part> asscPartList = new BindingList<Part>();

            try
            {
                tb_ModProductID.Text = Inventory.CurrentProduct.ProductID.ToString();
                tb_ModProdName.Text = Inventory.CurrentProduct.Name.ToString();
                tb_ModProdInventory.Text = Inventory.CurrentProduct.InStock.ToString();
                tb_ModProdPrice.Text = Inventory.CurrentProduct.Price.ToString();
                tb_ModProdMax.Text = Inventory.CurrentProduct.Max.ToString();
                tb_ModProdMin.Text = Inventory.CurrentProduct.Min.ToString();
                
                
            }
            catch (NullReferenceException)
            {
                MessageBox.Show("Please select a Product.");
            }

        }

        private void btn_ModSearchProduct_Click(object sender, EventArgs e)
        {
            bool found = false;
            BindingList<Part> tempList = new BindingList<Part>();

            if (tb_ModProdSearch.Text != "")
            {
                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.Contains(tb_ModProdSearch.Text.ToLower()))
                    {
                        tempList.Add(Inventory.AllParts[i]);

                        found = true;
                    }
                }
                if (found)
                {
                    dgvModAllParts.DataSource = tempList;
                }
                else
                {
                    MessageBox.Show("No Part found matching that criteria!");
                }
            }
        }

        private void btn_ModProdCancel_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();

            this.Close();
            main.Show();
        }

        private void dgvModAllParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvModAllParts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
            dgvModAllParts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

            var index = e.RowIndex;
            Inventory.CurrentPartID = index;
            Inventory.CurrentPart = Inventory.lookupPart(index); 

        } 
        
        private void btn_ModAssocPart_Click(object sender, EventArgs e)
        {
            tempProd.addAssociatedPart(Inventory.CurrentPart);
        }

        private void btn_ModSaveProd_Click(object sender, EventArgs e)
        {
            try
            {
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
                    var confirm = MessageBox.Show("Update Product", "Do you want to update this Product?", MessageBoxButtons.YesNo);
                    if (confirm == DialogResult.Yes)
                    {
                        tempProd.Name = tb_ModProdName.Text;
                        tempProd.InStock = Convert.ToInt32(tb_ModProdInventory.Text);
                        tempProd.Price = Convert.ToDecimal(tb_ModProdPrice.Text);
                        tempProd.Max = Convert.ToInt32(tb_ModProdMax.Text);
                        tempProd.Min = Convert.ToInt32(tb_ModProdMin.Text);

                        Inventory.updateProduct(Inventory.CurrentProductID, tempProd);
                        MessageBox.Show("Part has been modified.");
                        MainScreen main = new MainScreen();
                        this.Close();
                        main.Show();

                    }
                    else
                    {
                        MessageBox.Show("Part has NOT been modified.");
                    }
                }
                else
                {
                    MessageBox.Show("Please add at least ONE(1) Associated Part.");
                }
            }
            catch { }
        }

       

        private void dgvModAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            dgvModAssocParts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
            dgvModAssocParts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
            var selectedIndex = e.RowIndex;
            Inventory.CurrentPartID = selectedIndex;
        }

        private void btn_ModDelProduct_Click(object sender, EventArgs e)
        {
            try
            {
                var deleteConfirm = MessageBox.Show("Are you sure you want to delete this part?", "Delete Part", MessageBoxButtons.YesNo);
                if(deleteConfirm == DialogResult.Yes)
                {
                    tempProd.removeAssociatedPart(Inventory.CurrentPartID);

                }
                return;

            }
            catch { }

        }


        private void btn_ModProdResetSrch_Click(object sender, EventArgs e)
        {
            dgvModAllParts.DataSource = Inventory.AllParts;
            tb_ModProdSearch.Text = "";
            dgvModAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvModAllParts.ClearSelection();


        }



        /*****************************************************
         *     CHANGE TEXTBOX COLOR IF TEXTBOX LEFT BLANK    *
         *****************************************************/
        private void tb_ModProdName_TextChanged(object sender, EventArgs e)
        {
            validateName();
        }

        private void tb_ModProdInventory_TextChanged(object sender, EventArgs e)
        {
            validateInventory();
           
        }

        private void tb_ModProdPrice_TextChanged(object sender, EventArgs e)
        {
            validatePrice();
        }

        private void tb_ModProdMax_TextChanged(object sender, EventArgs e)
        {
            validateMax();
        }

        private void tb_ModProdMin_TextChanged(object sender, EventArgs e)
        {
            validateMin();
        }



        /**************************************
       ********* VALIDATION METHODS **********
       **************************************/

        private void validateName()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModProdName.Text.Trim()))
                {
                    tb_ModProdName.BackColor = Color.OrangeRed;
                    errorProvider1.SetError(tb_ModProdName, "Name is required.");

                }
                else
                {
                    tb_ModProdName.BackColor = Color.White;
                    errorProvider1.SetError(tb_ModProdName, string.Empty);
                }
            }
            catch { }
        }

        private void validateInventory()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModProdInventory.Text.Trim()))
                {
                    tb_ModProdInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_ModProdInventory, "Inventory is required to be between Max and Min values.");
                }
                else if (Convert.ToInt32(tb_ModProdMax.Text) < Convert.ToInt32(tb_ModProdInventory.Text) || Convert.ToInt32(tb_ModProdMin.Text) > Convert.ToInt32(tb_ModProdInventory.Text))
                {

                    tb_ModProdInventory.BackColor = Color.OrangeRed;
                    errorProvider2.SetError(tb_ModProdInventory, "Must be between Max and Min values.");
                }

                else
                {
                    tb_ModProdInventory.BackColor = Color.White;
                    errorProvider2.SetError(tb_ModProdInventory, string.Empty);
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
                if (string.IsNullOrEmpty(tb_ModProdPrice.Text.Trim()))
                {
                    tb_ModProdPrice.BackColor = Color.OrangeRed;
                    errorProvider3.SetError(tb_ModProdPrice, "Price is required.");
                }
                else
                {
                    tb_ModProdPrice.BackColor = Color.White;
                    errorProvider3.SetError(tb_ModProdPrice, string.Empty);
                }

            }
            catch { }
        }

        private void validateMax()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModProdMax.Text.Trim()))
                {
                    tb_ModProdMax.BackColor = Color.OrangeRed;
                    errorProvider4.SetError(tb_ModProdMax, "Please enter a maximum stock level.");

                }
                else if (Convert.ToInt32(tb_ModProdMax.Text) < Convert.ToInt32(tb_ModProdInventory.Text))
                {
                    errorProvider4.SetError(tb_ModProdMax, "Enter a maximum limit greater than or equal to stock level.");
                    tb_ModProdMax.BackColor = Color.OrangeRed;
                    tb_ModProdInventory.BackColor = Color.OrangeRed;

                }
                else
                {
                    errorProvider4.SetError(tb_ModProdMax, string.Empty);
                    tb_ModProdMax.BackColor = Color.White;
                    tb_ModProdInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
        private void validateMin()
        {
            try
            {
                if (string.IsNullOrEmpty(tb_ModProdMin.Text.Trim()))
                {
                    tb_ModProdMin.BackColor = Color.OrangeRed;
                    errorProvider5.SetError(tb_ModProdMin, "Please enter a minimum stock level.");

                }
                else if (Convert.ToInt32(tb_ModProdMin.Text) > Convert.ToInt32(tb_ModProdInventory.Text))
                {
                    errorProvider5.SetError(tb_ModProdMin, "Enter a minimum limit less than or equal to stock level.");
                    tb_ModProdMin.BackColor = Color.OrangeRed;
                    tb_ModProdInventory.BackColor = Color.OrangeRed;

                }
                else if (Convert.ToInt32(tb_ModProdMin.Text) > Convert.ToInt32(tb_ModProdMax.Text))
                {
                    errorProvider5.SetError(tb_ModProdMin, "Minimum cannot be larger than Maximum value.");
                    tb_ModProdMin.BackColor = Color.OrangeRed;
                    tb_ModProdMax.BackColor = Color.OrangeRed;
                }
                else
                {
                    errorProvider5.SetError(tb_ModProdMin, string.Empty);
                    tb_ModProdMin.BackColor = Color.White;
                    tb_ModProdInventory.BackColor = Color.White;
                }

                validateInventory();
            }
            catch { }
        }
    }







}
