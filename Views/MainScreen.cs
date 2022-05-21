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
            dgvParts.DataSource = Inventory.AllParts;
            dgvParts.ClearSelection();

            dgvParts.DefaultCellStyle.BackColor = Color.White;
            dgvParts.DefaultCellStyle.SelectionBackColor = Color.Chocolate;

            dgvParts.RowHeadersVisible = false;
            dgvParts.ClearSelection();
        }

        //Parts Search button event
        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            
            dgvParts.ClearSelection();
            dgvParts.DefaultCellStyle.SelectionForeColor = Color.Aquamarine;
            bool found = false;
            BindingList<Part> TempList = new BindingList<Part>();

            if (searchParts.Text != "")
            {

                for (int i = 0; i < Inventory.AllParts.Count; i++)
                {
                    if (Inventory.AllParts[i].Name.Contains(searchParts.Text))
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

        

        //Product Search button event
        private void btnProdSearch_Click(object sender, EventArgs e)
        {

        }
        //Open AddPart screen
        private void btnAddPart_Click(object sender, EventArgs e)
        {
            AddPart addPart = new AddPart();
            this.Hide();
            addPart.Show();
        }
        //Open AddProduct screen
        private void btnAddProduct_Click(object sender, EventArgs e)
        {
            AddProduct addProduct = new AddProduct();
            addProduct.Show();
        }
        //Close Main Window
        private void bt_Exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_RestSearch_Click(object sender, EventArgs e)
        {
            dgvParts.ClearSelection();
            searchParts.Text = "";
            dgvParts.DataSource = Inventory.AllParts;
        }

        private void btnModPart_Click(object sender, EventArgs e)
        {
            ModifyParts modifyParts = new ModifyParts();
            this.Hide();
            modifyParts.Show();
         
        }

        private void dgvParts_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            int selectedIndex = e.RowIndex;
            Inventory.CurrentPartID = (int)dgvParts.Rows[selectedIndex].Cells[0].Value;
            Inventory.CurrentPart = Inventory.lookupPart(Inventory.CurrentPartID);
        }


    }









}
