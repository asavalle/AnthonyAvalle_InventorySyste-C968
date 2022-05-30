using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace InventoryTrackingApp.Views
{
    public partial class ModifyParts : Form
    {
        public ModifyParts()
        {
            InitializeComponent();
            rb_ModPartInHouse.Checked = true;  //Set Inhouse checked by default
            //btn_ModPartSave.Enabled = false;
            //Check if CurrentPart is of type Inhouse
            if (Inventory.CurrentPart is Inhouse)
            {
                /*Set the Inventory property, CurrentPart, which is type Part, to a new Inhouse type before adding the objects from the
                selected row.
                Set the Text value for all the textboxes to the value stored in the CurrentPart object.
                Because the CurrentPart was cast as an Inhouse, the MachineID is available.
                Perform the same task for Outsourced.*/

                rb_ModPartInHouse.Checked = true;
                label_ModPartSource.Text = "Machine ID";

                Inhouse ihPart = (Inhouse)Inventory.CurrentPart;
                tb_ModPartID.Text = ihPart.PartID.ToString();
                tb_ModPartName.Text = ihPart.Name.ToString(); ;
                tb_ModPartInventory.Text = ihPart.InStock.ToString();
                tb_ModPartPrice.Text = ihPart.Price.ToString();
                tb_ModPartMax.Text = ihPart.Max.ToString();
                tb_ModPartMin.Text = ihPart.Min.ToString();
                tb_ModPartMachineCompany.Text = ihPart.MachineID.ToString();
                Inventory.CurrentPartID = ihPart.PartID;
                
            }
            else if(Inventory.CurrentPart is Outsourced)
            {
                rb_ModPartOutsourced.Checked = true;
                label_ModPartSource.Text = "Company Name";
                Outsourced oPart = (Outsourced)Inventory.CurrentPart;
                tb_ModPartID.Text = oPart.PartID.ToString();
                tb_ModPartName.Text = oPart.Name.ToString(); ;
                tb_ModPartInventory.Text = oPart.InStock.ToString();
                tb_ModPartPrice.Text = oPart.Price.ToString();
                tb_ModPartMax.Text = oPart.Max.ToString();
                tb_ModPartMin.Text = oPart.Min.ToString();
                tb_ModPartMachineCompany.Text = oPart.CompanyName;
                Inventory.CurrentPartID = oPart.PartID;

            }
        }

               
        private void btn_ModPartCancel_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Close();
            main.Show();
            
        }
        
        private void btn_ModPartSave_Click(object sender, EventArgs e)
        {
            var dialogResult = MessageBox.Show($"Do you want to Modify '{Inventory.CurrentPart.Name}'?", "Modify Part?", MessageBoxButtons.YesNo);
            if(dialogResult == DialogResult.Yes)
            {
                 if (rb_ModPartInHouse.Checked)
                {
                    Part updated = new Inhouse{PartID=Inventory.CurrentPartID, Name = tb_ModPartName.Text, InStock= Convert.ToInt32(tb_ModPartInventory.Text),Price= Convert.ToDecimal(tb_ModPartPrice.Text), Max= Convert.ToInt32(tb_ModPartMax.Text),Min= Convert.ToInt32(tb_ModPartMin.Text), MachineID= Convert.ToInt32(tb_ModPartMachineCompany.Text) };
                    Inventory.updatePart(Inventory.CurrentPartID, updated);
                }
                else
                {
                    Part updated = new Outsourced { PartID = Inventory.CurrentPartID, Name = tb_ModPartName.Text, InStock = Convert.ToInt32(tb_ModPartInventory.Text), Price = Convert.ToDecimal(tb_ModPartPrice.Text), Max = Convert.ToInt32(tb_ModPartMax.Text), Min = Convert.ToInt32(tb_ModPartMin.Text), CompanyName = tb_ModPartMachineCompany.Text};
                    Inventory.updatePart(Inventory.CurrentPartID, updated);

                }
                MainScreen main = new MainScreen();
                MessageBox.Show("Part has been updated!");
                this.Close();
                main.Show();

            }




        }

        

        private void rb_ModPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            label_ModPartSource.Text = "Machine ID";
        }

        private void rb_ModPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            label_ModPartSource.Text = "Company Name";
        }
    }
}
