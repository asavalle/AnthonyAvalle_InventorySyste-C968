using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryTrackingApp.Views
{
    public partial class AddPart : Form
    {

        private MainScreen mainScreen = new MainScreen();

        public AddPart()
        {
            InitializeComponent();
            btn_SavePart.Enabled = false;
        }

        

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Company Name";
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartSource.Text = "Machine ID";
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }

        private void btn_SavePart_Click(object sender, EventArgs e)
        {
            BindingList<Part> list = new BindingList<Part>();   


            if (rbInhouse.Checked)
            {
                var priceRounded = string.Format("{0:0.00}", (string)tbAddPriceCost.Text);
                Inhouse newInhouse = new Inhouse
                (
                    tbAddPartName.Text,
                    Convert.ToDecimal(priceRounded),
                    Convert.ToInt32(tbAddPartInventory.Text),
                    Convert.ToInt32(tbAddPartMin.Text),
                    Convert.ToInt32(tbAddPartMax.Text),
                    Convert.ToInt32(tbCompanyOrMachine.Text)
                );
                             

                Inventory.addPart(newInhouse);
            }
            else
            {
                Outsourced newOutsourced = new Outsourced
                (
                    tbAddPartName.Text,
                    Convert.ToDecimal(tbAddPriceCost.Text),
                    Convert.ToInt32(tbAddPartInventory.Text),
                    Convert.ToInt32(tbAddPartMin.Text),
                    Convert.ToInt32(tbAddPartMax.Text),
                    tbCompanyOrMachine.Text
                );

                Inventory.addPart(newOutsourced);

            }


            MessageBox.Show("Part Added");
            this.Close();
            mainScreen.Show();
        }

        private void tbAddPartName_TextChanged(object sender, EventArgs e)
        {
            btn_SavePart.Enabled = true;
        }
    }
}
