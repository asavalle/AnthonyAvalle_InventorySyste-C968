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
        //private int rowIndex = 0;

        public ModifyParts()
        {
            InitializeComponent();
            rb_ModPartInHouse.Checked = true;
            label_ModPartCompanyName.Visible = false;


            if (Inventory.CurrentPart is Inhouse)
            {
                rb_ModPartInHouse.Checked = true;

                Inhouse ihPart = (Inhouse)Inventory.CurrentPart;
                tb_ModPartID.Text = ihPart.PartID.ToString();
                tb_ModPartName.Text = ihPart.Name.ToString(); ;
                tb_ModPartInventory.Text = ihPart.InStock.ToString();
                tb_ModPartPrice.Text = ihPart.Price.ToString();
                tb_ModPartMax.Text = ihPart.Max.ToString();
                tb_ModPartMin.Text = ihPart.Min.ToString();
                tb_ModPartMachineCompany.Text = ihPart.MachineID.ToString();
                
            }
            else if(Inventory.CurrentPart is Outsourced)
            {
                rb_ModPartOutsourced.Checked = true;

                Outsourced oPart = (Outsourced)Inventory.CurrentPart;
                tb_ModPartID.Text = oPart.PartID.ToString();
                tb_ModPartName.Text = oPart.Name.ToString(); ;
                tb_ModPartInventory.Text = oPart.InStock.ToString();
                tb_ModPartPrice.Text = oPart.Price.ToString();
                tb_ModPartMax.Text = oPart.Max.ToString();
                tb_ModPartMin.Text = oPart.Min.ToString();
                tb_ModPartMachineCompany.Text = oPart.CompanyName;

            }
        }

        

       
        private void btn_ModPartCancel_Click(object sender, EventArgs e)
        {
            MainScreen main = new MainScreen();
            this.Close();
            main.Show();
            
        }
    }
}
