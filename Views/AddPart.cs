﻿using System;
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
        public AddPart()
        {
            InitializeComponent();
        }

        

        private void rbOutsourced_CheckedChanged(object sender, EventArgs e)
        {
            this.labelMachineID.Visible = false;
            this.labelCompName.Visible = true;
        }

        private void rbInhouse_CheckedChanged(object sender, EventArgs e)
        {
            this.labelMachineID.Visible = true;
            this.labelCompName.Visible = false;
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_SavePart_Click(object sender, EventArgs e)
        {



            if (rbInhouse.Checked)
            {
                Inventory.AllParts.Add(new Inhouse());
            }
        }
    }
}
