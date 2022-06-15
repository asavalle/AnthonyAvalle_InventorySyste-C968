﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            dgvModAllParts.DataSource = Inventory.AllParts;
            dgvModAssocParts.DataSource = Inventory.CurrentProduct.AssociatedParts;

            dgvModAllParts.RowHeadersVisible = false;
            btn_ModSaveProd.Enabled = true;

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

            if(dgvModAssocParts.RowCount > 0) { 
                var confirm = MessageBox.Show("Update Product", "Do you want to update this Product?", MessageBoxButtons.YesNo);
                if(confirm == DialogResult.Yes)
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

       

        private void dgvModAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = e.RowIndex;
            Inventory.CurrentPartID = selectedIndex;
        }

        private void btn_ModDelProduct_Click(object sender, EventArgs e)
        {
            tempProd.removeAssociatedPart(Inventory.CurrentPartID);

        }

        private void tb_ModProdName_TextChanged(object sender, EventArgs e)
        {
            //Inventory.CurrentProduct.Name =  tb_ModProdName.Text;
        }

        private void btn_ModProdResetSrch_Click(object sender, EventArgs e)
        {
            dgvModAllParts.DataSource = Inventory.AllParts;

        }
    }
}
