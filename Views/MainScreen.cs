using InventoryTrackingApp.Views;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
 
namespace InventoryTrackingApp
{
    public partial class MainScreen : Form
    {
        public MainScreen()
        {
            InitializeComponent();

            /***********SETUP Parts DATA GRID***************/
            dgvParts.DataSource = Inventory.AllParts;
            dgvParts.DefaultCellStyle.BackColor = Color.White;
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvParts.DefaultCellStyle.SelectionForeColor = Color.Black;

            dgvParts.RowHeadersVisible = false;
            dgvParts.ClearSelection();

            btnModPart.Enabled = false;

            /**************SETUP Products DATA GRID***********/
            dgvProducts.DataSource = Inventory.Products;
            dgvProducts.DefaultCellStyle.BackColor = Color.White;
            dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvProducts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvProducts.ReadOnly = true;
            dgvProducts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            dgvProducts.RowHeadersVisible = false;
            dgvProducts.ClearSelection();

            btnModProduct.Enabled = false;
        }

        /*************************************************
                              PARTS  
         *************************************************/

        private void btnPartSearch_Click(object sender, EventArgs e)
        {

            /*Creates a temporary BindingLIst to house the search results.
             if the search textbox is not an empty string (blank) the loop through the list of AllParts
            for the Part object that contains the text entered into the text box. If it matches add it to the 
            temporary list. After all the objects are located, set the Found boolean to true. Then set the DataGridView control's
            DataSource to the temp list to show the results.
            If the search term is not found, display the message box.*/


            dgvParts.ClearSelection();
            bool found = false;
            BindingList<Part> TempList = new BindingList<Part>();

            if (searchParts.Text != "")
            {

                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.Contains(searchParts.Text.ToLower()))
                    {
                        TempList.Add(Inventory.AllParts[i]);
                        
                        found = true;
                    }
                }
                if (found)
                {
                    dgvParts.DataSource = TempList ;
                }
            
            }
            if (!found)
            {
                MessageBox.Show("No Part found matching that criteria!");
            }
        }

        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            this.Hide();
            addPart.Show();
        }

        private void btnDelPart_Click(object sender, EventArgs e)
        {
            if (Inventory.CurrentPart != null)
            {
                var dialogResult = MessageBox.Show("Are you sure you want to delete this Part?", "Delete Part?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    Inventory.deletePart(Inventory.CurrentPart);
                    dgvParts.DataSource = Inventory.AllParts;
                    dgvParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                    dgvParts.ClearSelection();
                    MessageBox.Show("Part has been deleted.");
                }
                else
                    return;
            }
            else
                MessageBox.Show("Please select a part to delete.");
           
            
        }

        private void btnModPart_Click(object sender, EventArgs e)
        {
            ModifyParts modifyParts = new ModifyParts();
            this.Hide();
            modifyParts.Show();

        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            try
            {
                /*Find the RowIndex of the selected (clicked) row and set the CurrentPartID property in the Inventory class to the row index.
                 Then set the CurrentPart property to the Part object via the lookUpPart method in the Inventory class*/

                int selectedIndex = e.RowIndex;
                dgvParts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgvParts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
                Inventory.CurrentPartID = (int)dgvParts.Rows[selectedIndex].Cells[0].Value;
                Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
                btnModPart.Enabled = true;
            }
            catch
            {
                dgvParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dgvParts.DefaultCellStyle.SelectionForeColor = Color.Black;

                btnModPart.Enabled = false;

                MessageBox.Show("You clicked a header. Please select a row.");
            }
        }



        /*************************************************
                              PRODUCTS
         *************************************************/

        private void btnProdSearch_Click(object sender, EventArgs e)
        {
            BindingList<Product> tempProducts = new BindingList<Product>();
            dgvProducts.ClearSelection();
            bool found = false;

            if(searchProducts.Text != "")
            {
                foreach(Product product in Inventory.Products)
                {
                    if (product.Name.Contains(searchProducts.Text.ToLower()))
                    {
                        tempProducts.Add(product);
                        found = true;
                    }
                }
                if (found) { dgvProducts.DataSource = tempProducts; }
            }
            if (!found) { MessageBox.Show("No Product found matching that criteria!"); }

        }

        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            this.Hide();
            addProduct.Show();
        }

        private void DgvProducts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                /*Find the RowIndex of the selected (clicked) row and set the CurrentPartID property in the Inventory class to the row index.
                 Then set the CurrentPart property to the Part object via the lookUpPart method in the Inventory class*/
                dgvProducts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgvProducts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;

                int selectedIndex = e.RowIndex;               
                Inventory.CurrentProductID = (int)dgvProducts.Rows[selectedIndex].Cells[0].Value;
                Inventory.CurrentProduct = Inventory.lookupProduct(Inventory.CurrentProductID);
                btnModProduct.Enabled = true;
            }
            catch
            {
                dgvParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dgvParts.DefaultCellStyle.SelectionForeColor = Color.Black;

                btnModProduct.Enabled = false;

                MessageBox.Show("You clicked a header. Please select a row.");
            }
        }

        private void btnModProduct_Click(object sender, EventArgs e)
        {

            ModifyProducts modProd = new ModifyProducts();
            this.Hide();
            modProd.Show();
        }

        private void btnResetProdSearch_Click(object sender, EventArgs e)
        {
            dgvProducts.DataSource = Inventory.Products;
        }
        private void btnDelProduct_Click(object sender, EventArgs e)
        {

            if (Inventory.CurrentProduct != null)
            {
               var dialogResult = MessageBox.Show("Are you sure you want to delete this Product?", "Delete Product?", MessageBoxButtons.YesNo);
               if(dialogResult == DialogResult.Yes)
                    Inventory.Products.Remove(Inventory.CurrentProduct);
            }
            else
                MessageBox.Show("Please select a product to delete.");
           
        }



        /*************************************************
                        MAINSCREEN FUNCTIONS
         *************************************************/
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
            
        }

        private void btn_ResetSearch_Click(object sender, EventArgs e)
        {
            searchParts.Text = "";
            dgvParts.DataSource = Inventory.AllParts;
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            btnModPart.Enabled = false;
            dgvParts.ClearSelection();
        }

        
    }









}
