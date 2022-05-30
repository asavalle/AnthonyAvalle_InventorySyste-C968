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
        public AddProduct()
        {
            InitializeComponent();
            btnSaveProd.Enabled = false;
            
            dgvAllParts.DataSource = Inventory.AllParts;
            dgvAllParts.RowHeadersVisible = false;
            dgvAllParts.MultiSelect = false;
            dgvAllParts.ReadOnly = true;
            dgvAllParts.DefaultCellStyle.BackColor = Color.White;
            dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
            dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;
            dgvAllParts.ClearSelection();

            dgvAssocParts.DataSource = Product.AssociatedParts;
        }

        private void AddProduct_Load(object sender, EventArgs e) { }

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

                int selectedIndex = e.RowIndex;
                dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Aqua;
                dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.BlueViolet;
                Inventory.CurrentPartID = (int)dgvAllParts.Rows[selectedIndex].Cells[0].Value;
                Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
                testLableAP.Text = Inventory.CurrentPartID.ToString();
            }
            catch
            {
                dgvAllParts.DefaultCellStyle.SelectionBackColor = Color.Transparent;
                dgvAllParts.DefaultCellStyle.SelectionForeColor = Color.Black;


                MessageBox.Show("You clicked a header. Please select a row.");
            }
        }

        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if(tb_AddProdName.Text != "") {
                Product newProd = new Product
                {
                    Name = tb_AddProdName.Text,
                    InStock = Convert.ToInt32(tb_AddProdInventory.Text),
                    Price = Convert.ToDecimal(tb_AddProdPrice.Text),
                    Max = Convert.ToInt32(tb_AddProdMax.Text),
                    Min = Convert.ToInt32(tb_AddProdMin.Text)
                };
                Inventory.addProduct(newProd);
                MessageBox.Show($"New Product, {tb_AddProdName.Text}, Added.");
            }
            else
            {
                MessageBox.Show("Please enter a Part Name as a minimum requirement.");
            }

        }

        private void tb_AddProdName_TextChanged(object sender, EventArgs e)
        {
            btnSaveProd.Enabled = true;

        }

        private void btn_AddAssocPart_Click(object sender, EventArgs e)
        {
            
            Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
            Product.AssociatedParts.Add(Inventory.CurrentPart); 
            
        }

        private void btn_DelProduct_Click(object sender, EventArgs e)
        {

        }
    }
}
