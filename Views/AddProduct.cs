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

        Product tempProd = new Product
        {
            Name = "",
            InStock = 0,
            Price = Convert.ToDecimal(0.00),
            Max = 0,
            Min = 0
        };

        public AddProduct()
        {
            InitializeComponent();
            btnSaveProd.Enabled = false;
            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAssocParts.DataSource = Product.AssociatedParts;
            dgvAllParts.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dgvAllParts.RowHeadersVisible = false;
            dgvAllParts.MultiSelect = false;
            dgvAllParts.ReadOnly = true;
            dgvAllParts.DefaultCellStyle.BackColor = Color.White;
            dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllParts.ClearSelection();

            

        }

        private void AddProduct_Load(object sender, EventArgs e) {
           

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
                //Inventory.CurrentPartID = (int)dgvAllParts.Rows[selectedIndex].Cells[0].Value;
                Inventory.CurrentPartID = selectedIndex;
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
            if (tb_AddProdName.Text != "")
            {
                tempProd.Name = tb_AddProdName.Text;
                tempProd.InStock = Convert.ToInt32(tb_AddProdInventory.Text);
                tempProd.Price = Convert.ToDecimal(tb_AddProdPrice.Text);
                tempProd.Max = Convert.ToInt32(tb_AddProdMax.Text);
                tempProd.Min = Convert.ToInt32(tb_AddProdMin.Text);
                
                MessageBox.Show($"New Product, {tb_AddProdName.Text}, Added.");
            }
            else
            {
                MessageBox.Show("Please enter a Part Name as a minimum requirement.");
            }
            Product.addAssociatedPart(Inventory.CurrentPart);


        }
        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            Inventory.CurrentProduct = tempProd;
            Inventory.addProduct(Inventory.CurrentProduct);
            dgvAssocParts.Rows.Clear();
            this.Close();
            MainScreen main = new MainScreen();
            main.Show();

        }

        private void tb_AddProdName_TextChanged(object sender, EventArgs e)
        {
            btnSaveProd.Enabled = true;

        }

       

        private void btn_DelProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
