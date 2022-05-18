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
        }

        

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartMachineID.Visible = false;
            this.label_AddPartCompName.Visible = true;
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            this.label_AddPartMachineID.Visible = true;
            this.label_AddPartCompName.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
            mainScreen.Show();
        }

        private void btn_SavePart_Click(object sender, EventArgs e)
        {

            if (rbInhouse.Checked)
            {
                Inventory.AllParts.Add(new Inhouse{ Name = tbAddPartName.Text, Price = Convert.ToDecimal(tbAddPriceCost.Text), InStock=Convert.ToInt32(tbAddPartInventory.Text),Min=Convert.ToInt32(tbAddPartMin.Text), Max=Convert.ToInt32(tbAddPartMax.Text) , MachineID= Convert.ToInt32(tbCompanyOrMachine.Text)});
            }
            else
            {
                Inventory.AllParts.Add(new Outsourced { Name = tbAddPartName.Text, Price = Convert.ToDecimal(tbAddPriceCost.Text), InStock = Convert.ToInt32(tbAddPartInventory.Text), Min = Convert.ToInt32(tbAddPartMin.Text), Max = Convert.ToInt32(tbAddPartMax.Text), CompanyName = tbCompanyOrMachine.Text, Outsorced = true }) ;

            }
            MessageBox.Show("Part Added");
            this.Close();
            mainScreen.Show();
        }
    }
}
