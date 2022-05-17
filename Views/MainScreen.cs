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
        //Search parts list
        private void searchParts_TextChanged(object sender, EventArgs e)
        {

        }
        //Search Products
        private void searchProducts_TextChanged(object sender, EventArgs e)
        {

        }
        //Parts Search button event
        private void btnPartSearch_Click(object sender, EventArgs e)
        {
            /*var product = new Product
            {
                ProductID = 1
            };*/

           //product.addAssociatedPart(new Inhouse(1, "part1", 1.00, 20, 5, 30));
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
