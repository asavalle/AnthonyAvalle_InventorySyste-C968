using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
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
            btnSaveProd.Enabled = false;
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
        }

        private void AddProduct_Load(object sender, EventArgs e) {

            //if (tb_AddProdName.Text == "" ) { tb_AddProdName.BackColor = Color.Red; } else { tb_AddProdName.BackColor = Color.Transparent; }
            //if (tb_AddProdPrice.Text == "") { tb_AddProdPrice.BackColor = Color.Red; } else { tb_AddProdPrice.BackColor = Color.Transparent; }
            //if (tb_AddProdInventory.Text =="") { tb_AddProdInventory.BackColor = Color.Red; } else { tb_AddProdInventory.BackColor = Color.Transparent; }
            //if (tb_AddProdMax.Text == "") { tb_AddProdMax.BackColor = Color.Red; } else { tb_AddProdMax.BackColor = Color.Transparent; }
            //if (tb_AddProdMin.Text == "") { tb_AddProdMin.BackColor = Color.Red; } else { tb_AddProdMin.BackColor = Color.Transparent; }

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
                        Convert.ToDecimal(priceRounded),
                        Convert.ToInt32(tb_AddProdInventory.Text),
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

        /*Feature to search without button. Auto filters list while typing*/
        //private void tb_AddProdSearch_TextChanged(object sender, EventArgs e)
        //{

        //    bool found = false;
        //    BindingList<Part> tempList = new BindingList<Part>();

        //    if(tb_AddProdSearch.Text != "")
        //    {
        //        for (int i = 0; i < Inventory.AllParts.Count; i++)
        //        {
        //            if (Inventory.AllParts[i].Name.Contains(tb_AddProdSearch.Text.ToLower()))
        //            {
        //                tempList.Add(Inventory.AllParts[i]);

        //                found = true;
        //            }
        //        }
        //        if (found)
        //        {
        //            dgvAllParts.DataSource = tempList;
        //        }
        //        else 
        //        {
        //            MessageBox.Show("No Part found matching that criteria!");
        //        }
        //    }
        //    else { dgvAllParts.DataSource = Inventory.AllParts; }



        //}

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
            tempList.Add(Inventory.CurrentPart);
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if (dgvAssocParts.RowCount > 0)
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
                this.Close();
                MainScreen main = new MainScreen();
                main.Show();
            }
            else
            {
                MessageBox.Show("Please add at least ONE(1) Associated Part.");
            }
        }

        private void tb_AddProdName_TextChanged(object sender, EventArgs e)
        {
            btnSaveProd.Enabled = true;

        }

        private void dgvAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = e.RowIndex;
            Inventory.CurrentPartID = selectedIndex;

        }

        private void btn_DelAscPart_Click(object sender, EventArgs e)
        {
            
            Inventory.CurrentProduct.removeAssociatedPart(Inventory.CurrentProductID);
            //Product.removeAssociatedPart(Inventory.CurrentPartID);

        }

        
    }
}
