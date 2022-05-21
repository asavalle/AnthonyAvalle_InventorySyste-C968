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
        private int rowIndex = 0;

        public ModifyParts()
        {
            InitializeComponent();
        }

        public void getSelectedRow(DataGridViewSelectedRowCollection dgvSelectedRow) {
            foreach(DataGridViewRow cell in dgvSelectedRow)
            {
                int rowIndex = (int)cell.Index;
                Inventory.updatePart(rowIndex);

            }

        }
        //public void getCurrentRow(DataGridView dgv)
        //{

        //    if (rb_ModPartInHouse.Checked) {

        //        WORKs...DO NOT DELETE
        //        foreach (DataGridViewRow row in dgv.SelectedRows)
        //        {

        //            Gets Row Index/PartID from selected row
        //             But I don't know how best tp use this in Inventory.updatePart()

        //            int rowIndex = (int)row.Cells[0].Value;
        //            Inventory.updatePart(rowIndex);
        //            Inventory.SetCurrentSelectedDGV(dgv.Rows[rowIndex]);


        //            tb_ModPartID.Text = row.Cells[0].Value.ToString();
        //            tb_ModPartName.Text = row.Cells[1].Value.ToString();
        //            tb_ModPartInventory.Text = row.Cells[2].Value.ToString();
        //            tb_ModPartPrice.Text = row.Cells[3].Value.ToString();
        //            tb_ModPartMax.Text = row.Cells[4].Value.ToString();
        //            tb_ModPartMin.Text = row.Cells[5].Value.ToString();
        //            tb_ModPartMachineCompany.Text = row.Cells[6].Value.ToString(); //The AllParts list is populated by type Part, but Part doesn't contain the additional fields for MachineID or CompanyName

        //            ....need to complete the form fields
        //        }
        //    }

        //}

        private void rb_ModPartInHouse_CheckedChanged(object sender, EventArgs e)
        {
            this.label_ModPartMachineID.Visible = false;
            this.label_ModPartCompanyName.Visible = true;
        }

        private void rb_ModPartOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.label_ModPartMachineID.Visible = true;
            this.label_ModPartCompanyName.Visible = false;
        }
    }
}
