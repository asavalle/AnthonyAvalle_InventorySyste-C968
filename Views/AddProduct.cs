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
        Product tempProd = new Product
        (
            "",
            Convert.ToDecimal(0.00),
            0,
            0,
            0,
            tempList
        );

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
            tempList.Add(Inventory.CurrentPart);

        }
        private void btnSaveProd_Click(object sender, EventArgs e)
        {
            if (tb_AddProdName.Text != "")
            {
                /*
                Inventory.Products.Add(new Product(tb_AddProdName.Text,
                    Convert.ToDecimal(tb_AddProdPrice.Text),
                    Convert.ToInt32(tb_AddProdInventory.Text),
                    Convert.ToInt32(tb_AddProdMax.Text),
                    Convert.ToInt32(tb_AddProdMin.Text),
                    tempList));
                */

                tempProd.Name = tb_AddProdName.Text;
                tempProd.Price = Convert.ToDecimal(tb_AddProdPrice.Text);
                tempProd.InStock = Convert.ToInt32(tb_AddProdInventory.Text);
                tempProd.Max = Convert.ToInt32(tb_AddProdMax.Text);
                tempProd.Min = Convert.ToInt32(tb_AddProdMin.Text);
               
            }
            else
            {
                MessageBox.Show("Please enter a Part Name as a minimum requirement.");
            }

            //Product.addAssociatedPart(Inventory.CurrentPart);
            MessageBox.Show($"New Product Added.");


            Inventory.CurrentProduct = tempProd;
            Inventory.addProduct(Inventory.CurrentProduct);
            //dgvAssocParts.Rows.Clear();
            this.Close();
            MainScreen main = new MainScreen();
            main.Show();

        }

        private void tb_AddProdName_TextChanged(object sender, EventArgs e)
        {
            btnSaveProd.Enabled = true;

        }

       

        private void btn_DelAscPart_Click(object sender, EventArgs e)
        {
            Product.removeAssociatedPart(selectedIndex);

        }

        private void dgvAssocParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            var selectedIndex = e.RowIndex;
            //Inventory.CurrentPartID = (int)dgvAllParts.Rows[selectedIndex].Cells[0].Value;
            Inventory.CurrentPartID = selectedIndex;
            
        }
    }
}
