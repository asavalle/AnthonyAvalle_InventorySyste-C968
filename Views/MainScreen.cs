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
        }
     
        //Parts Search button event
        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            
            //********WoRKS************
            foreach (DataGridViewRow part in dgvParts.Rows)
            {
                if (part.Cells[1].Value.ToString().Contains(searchParts.Text))
                {
                    tempLabelForTest.Text = dgvParts.Rows[part.Index].ToString();
                    dgvParts.Rows[part.Index].Selected = true;

                }
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
    }
}
