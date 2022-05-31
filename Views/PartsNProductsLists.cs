using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryTrackingApp.Views
{
    public partial class PartsNProductsLists : Form
    {
        public PartsNProductsLists()
        {
            InitializeComponent();
            all_products.DataSource = Inventory.Products;
            all_assocParts.DataSource = Product.AssociatedParts;
            this.Show();
        }
    }
}
