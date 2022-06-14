
namespace InventoryTrackingApp.Views
{
    partial class ModifyParts
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.label_ModPartID = new System.Windows.Forms.Label();
            this.label_ModPartName = new System.Windows.Forms.Label();
            this.label_ModPartInventory = new System.Windows.Forms.Label();
            this.label_ModPartPrice = new System.Windows.Forms.Label();
            this.label_ModPartMax = new System.Windows.Forms.Label();
            this.label_ModPartMin = new System.Windows.Forms.Label();
            this.tb_ModPartID = new System.Windows.Forms.TextBox();
            this.tb_ModPartName = new System.Windows.Forms.TextBox();
            this.tb_ModPartInventory = new System.Windows.Forms.TextBox();
            this.tb_ModPartPrice = new System.Windows.Forms.TextBox();
            this.tb_ModPartMax = new System.Windows.Forms.TextBox();
            this.tb_ModPartMin = new System.Windows.Forms.TextBox();
            this.tb_ModPartMachineCompany = new System.Windows.Forms.TextBox();
            this.label_ModPartSource = new System.Windows.Forms.Label();
            this.rb_ModPartInHouse = new System.Windows.Forms.RadioButton();
            this.rb_ModPartOutsourced = new System.Windows.Forms.RadioButton();
            this.label_ModPartTitle = new System.Windows.Forms.Label();
            this.btn_ModPartSave = new System.Windows.Forms.Button();
            this.btn_ModPartCancel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_ModPartID
            // 
            this.label_ModPartID.AutoSize = true;
            this.label_ModPartID.Location = new System.Drawing.Point(137, 136);
            this.label_ModPartID.Name = "label_ModPartID";
            this.label_ModPartID.Size = new System.Drawing.Size(18, 15);
            this.label_ModPartID.TabIndex = 0;
            this.label_ModPartID.Text = "ID";
            // 
            // label_ModPartName
            // 
            this.label_ModPartName.AutoSize = true;
            this.label_ModPartName.Location = new System.Drawing.Point(116, 189);
            this.label_ModPartName.Name = "label_ModPartName";
            this.label_ModPartName.Size = new System.Drawing.Size(39, 15);
            this.label_ModPartName.TabIndex = 1;
            this.label_ModPartName.Text = "Name";
            // 
            // label_ModPartInventory
            // 
            this.label_ModPartInventory.AutoSize = true;
            this.label_ModPartInventory.Location = new System.Drawing.Point(98, 242);
            this.label_ModPartInventory.Name = "label_ModPartInventory";
            this.label_ModPartInventory.Size = new System.Drawing.Size(57, 15);
            this.label_ModPartInventory.TabIndex = 2;
            this.label_ModPartInventory.Text = "Inventory";
            // 
            // label_ModPartPrice
            // 
            this.label_ModPartPrice.AutoSize = true;
            this.label_ModPartPrice.Location = new System.Drawing.Point(87, 295);
            this.label_ModPartPrice.Name = "label_ModPartPrice";
            this.label_ModPartPrice.Size = new System.Drawing.Size(68, 15);
            this.label_ModPartPrice.TabIndex = 3;
            this.label_ModPartPrice.Text = "Price / Cost";
            // 
            // label_ModPartMax
            // 
            this.label_ModPartMax.AutoSize = true;
            this.label_ModPartMax.Location = new System.Drawing.Point(125, 348);
            this.label_ModPartMax.Name = "label_ModPartMax";
            this.label_ModPartMax.Size = new System.Drawing.Size(30, 15);
            this.label_ModPartMax.TabIndex = 4;
            this.label_ModPartMax.Text = "Max";
            // 
            // label_ModPartMin
            // 
            this.label_ModPartMin.AutoSize = true;
            this.label_ModPartMin.Location = new System.Drawing.Point(338, 348);
            this.label_ModPartMin.Name = "label_ModPartMin";
            this.label_ModPartMin.Size = new System.Drawing.Size(28, 15);
            this.label_ModPartMin.TabIndex = 5;
            this.label_ModPartMin.Text = "Min";
            // 
            // tb_ModPartID
            // 
            this.tb_ModPartID.Enabled = false;
            this.tb_ModPartID.Location = new System.Drawing.Point(201, 133);
            this.tb_ModPartID.Name = "tb_ModPartID";
            this.tb_ModPartID.ReadOnly = true;
            this.tb_ModPartID.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartID.TabIndex = 0;
            // 
            // tb_ModPartName
            // 
            this.tb_ModPartName.Location = new System.Drawing.Point(201, 186);
            this.tb_ModPartName.Name = "tb_ModPartName";
            this.tb_ModPartName.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartName.TabIndex = 1;
            this.tb_ModPartName.TextChanged += new System.EventHandler(this.tb_ModPartName_TextChanged);
            // 
            // tb_ModPartInventory
            // 
            this.tb_ModPartInventory.Location = new System.Drawing.Point(201, 239);
            this.tb_ModPartInventory.Name = "tb_ModPartInventory";
            this.tb_ModPartInventory.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartInventory.TabIndex = 2;
            this.tb_ModPartInventory.TextChanged += new System.EventHandler(this.tb_ModPartInventory_TextChanged);
            this.tb_ModPartInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ModPartInventory_KeyPress);
            // 
            // tb_ModPartPrice
            // 
            this.tb_ModPartPrice.Location = new System.Drawing.Point(201, 292);
            this.tb_ModPartPrice.Name = "tb_ModPartPrice";
            this.tb_ModPartPrice.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartPrice.TabIndex = 3;
            this.tb_ModPartPrice.TextChanged += new System.EventHandler(this.tb_ModPartPrice_TextChanged);
            this.tb_ModPartPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ModPartPrice_KeyPress);
            this.tb_ModPartPrice.Leave += new System.EventHandler(this.tb_ModPartPrice_Leave);
            // 
            // tb_ModPartMax
            // 
            this.tb_ModPartMax.Location = new System.Drawing.Point(201, 345);
            this.tb_ModPartMax.Name = "tb_ModPartMax";
            this.tb_ModPartMax.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartMax.TabIndex = 4;
            this.tb_ModPartMax.TextChanged += new System.EventHandler(this.tb_ModPartMax_TextChanged);
            this.tb_ModPartMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ModPartMax_KeyPress);
            // 
            // tb_ModPartMin
            // 
            this.tb_ModPartMin.Location = new System.Drawing.Point(372, 344);
            this.tb_ModPartMin.Name = "tb_ModPartMin";
            this.tb_ModPartMin.Size = new System.Drawing.Size(100, 23);
            this.tb_ModPartMin.TabIndex = 5;
            this.tb_ModPartMin.TextChanged += new System.EventHandler(this.tb_ModPartMin_TextChanged);
            this.tb_ModPartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ModPartMin_KeyPress);
            this.tb_ModPartMin.Leave += new System.EventHandler(this.tb_ModPartMin_Leave);
            // 
            // tb_ModPartMachineCompany
            // 
            this.tb_ModPartMachineCompany.Location = new System.Drawing.Point(201, 398);
            this.tb_ModPartMachineCompany.Name = "tb_ModPartMachineCompany";
            this.tb_ModPartMachineCompany.Size = new System.Drawing.Size(271, 23);
            this.tb_ModPartMachineCompany.TabIndex = 6;
            this.tb_ModPartMachineCompany.TextChanged += new System.EventHandler(this.tb_ModPartMachineCompany_TextChanged);
            this.tb_ModPartMachineCompany.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_ModPartMachineCompany_KeyPress);
            // 
            // label_ModPartSource
            // 
            this.label_ModPartSource.AutoSize = true;
            this.label_ModPartSource.Location = new System.Drawing.Point(88, 401);
            this.label_ModPartSource.Name = "label_ModPartSource";
            this.label_ModPartSource.Size = new System.Drawing.Size(67, 15);
            this.label_ModPartSource.TabIndex = 13;
            this.label_ModPartSource.Text = "Machine ID";
            // 
            // rb_ModPartInHouse
            // 
            this.rb_ModPartInHouse.AutoSize = true;
            this.rb_ModPartInHouse.Checked = true;
            this.rb_ModPartInHouse.Location = new System.Drawing.Point(184, 63);
            this.rb_ModPartInHouse.Name = "rb_ModPartInHouse";
            this.rb_ModPartInHouse.Size = new System.Drawing.Size(74, 19);
            this.rb_ModPartInHouse.TabIndex = 14;
            this.rb_ModPartInHouse.TabStop = true;
            this.rb_ModPartInHouse.Text = "In-House";
            this.rb_ModPartInHouse.UseVisualStyleBackColor = true;
            this.rb_ModPartInHouse.CheckedChanged += new System.EventHandler(this.rb_ModPartInHouse_CheckedChanged);
            // 
            // rb_ModPartOutsourced
            // 
            this.rb_ModPartOutsourced.AutoSize = true;
            this.rb_ModPartOutsourced.Location = new System.Drawing.Point(338, 63);
            this.rb_ModPartOutsourced.Name = "rb_ModPartOutsourced";
            this.rb_ModPartOutsourced.Size = new System.Drawing.Size(87, 19);
            this.rb_ModPartOutsourced.TabIndex = 15;
            this.rb_ModPartOutsourced.Text = "Outsourced";
            this.rb_ModPartOutsourced.UseVisualStyleBackColor = true;
            this.rb_ModPartOutsourced.CheckedChanged += new System.EventHandler(this.rb_ModPartOutsourced_CheckedChanged);
            // 
            // label_ModPartTitle
            // 
            this.label_ModPartTitle.AutoSize = true;
            this.label_ModPartTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.label_ModPartTitle.Location = new System.Drawing.Point(12, 9);
            this.label_ModPartTitle.Name = "label_ModPartTitle";
            this.label_ModPartTitle.Size = new System.Drawing.Size(120, 30);
            this.label_ModPartTitle.TabIndex = 17;
            this.label_ModPartTitle.Text = "Modify Part";
            // 
            // btn_ModPartSave
            // 
            this.btn_ModPartSave.Location = new System.Drawing.Point(575, 445);
            this.btn_ModPartSave.Name = "btn_ModPartSave";
            this.btn_ModPartSave.Size = new System.Drawing.Size(75, 35);
            this.btn_ModPartSave.TabIndex = 8;
            this.btn_ModPartSave.Text = "Save";
            this.btn_ModPartSave.UseVisualStyleBackColor = true;
            this.btn_ModPartSave.Click += new System.EventHandler(this.btn_ModPartSave_Click);
            // 
            // btn_ModPartCancel
            // 
            this.btn_ModPartCancel.Location = new System.Drawing.Point(681, 445);
            this.btn_ModPartCancel.Name = "btn_ModPartCancel";
            this.btn_ModPartCancel.Size = new System.Drawing.Size(75, 35);
            this.btn_ModPartCancel.TabIndex = 7;
            this.btn_ModPartCancel.Text = "Cancel";
            this.btn_ModPartCancel.UseVisualStyleBackColor = true;
            this.btn_ModPartCancel.Click += new System.EventHandler(this.btn_ModPartCancel_Click);
            // 
            // ModifyParts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.btn_ModPartCancel);
            this.Controls.Add(this.btn_ModPartSave);
            this.Controls.Add(this.label_ModPartTitle);
            this.Controls.Add(this.rb_ModPartOutsourced);
            this.Controls.Add(this.rb_ModPartInHouse);
            this.Controls.Add(this.label_ModPartSource);
            this.Controls.Add(this.tb_ModPartMachineCompany);
            this.Controls.Add(this.tb_ModPartMin);
            this.Controls.Add(this.tb_ModPartMax);
            this.Controls.Add(this.tb_ModPartPrice);
            this.Controls.Add(this.tb_ModPartInventory);
            this.Controls.Add(this.tb_ModPartName);
            this.Controls.Add(this.tb_ModPartID);
            this.Controls.Add(this.label_ModPartMin);
            this.Controls.Add(this.label_ModPartMax);
            this.Controls.Add(this.label_ModPartPrice);
            this.Controls.Add(this.label_ModPartInventory);
            this.Controls.Add(this.label_ModPartName);
            this.Controls.Add(this.label_ModPartID);
            this.Name = "ModifyParts";
            this.Text = "Modify Part";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label_ModPartName;
        private System.Windows.Forms.Label label_ModPartInventory;
        private System.Windows.Forms.Label label_ModPartPrice;
        private System.Windows.Forms.Label label_ModPartMax;
        private System.Windows.Forms.Label label_ModPartMin;
        private System.Windows.Forms.Label label_ModPartSource;
        private System.Windows.Forms.RadioButton rb_ModPartInHouse;
        private System.Windows.Forms.RadioButton rb_ModPartOutsourced;
        private System.Windows.Forms.Label label_ModPartTitle;
        private System.Windows.Forms.Button btn_ModPartSave;
        private System.Windows.Forms.Button btn_ModPartCancel;
        public System.Windows.Forms.TextBox tb_ModPartID;
        public System.Windows.Forms.TextBox tb_ModPartName;
        public System.Windows.Forms.TextBox tb_ModPartInventory;
        public System.Windows.Forms.TextBox tb_ModPartPrice;
        public System.Windows.Forms.TextBox tb_ModPartMax;
        public System.Windows.Forms.TextBox tb_ModPartMin;
        public System.Windows.Forms.TextBox tb_ModPartMachineCompany;
        public System.Windows.Forms.Label label_ModPartID;
    }
}