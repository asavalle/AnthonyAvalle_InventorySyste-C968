
namespace InventoryTrackingApp.Views
{
    partial class AddPart
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
            this.addPartTitle = new System.Windows.Forms.Label();
            this.rbInhouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.tbAddPartName = new System.Windows.Forms.TextBox();
            this.tbAddPriceCost = new System.Windows.Forms.TextBox();
            this.tbAddPartMax = new System.Windows.Forms.TextBox();
            this.tbAddPartMin = new System.Windows.Forms.TextBox();
            this.tbCompanyOrMachine = new System.Windows.Forms.TextBox();
            this.label_AddPartID = new System.Windows.Forms.Label();
            this.label_AddPartName = new System.Windows.Forms.Label();
            this.label_AddPartPriceCost = new System.Windows.Forms.Label();
            this.label_AddPartMax = new System.Windows.Forms.Label();
            this.label_AddPartMin = new System.Windows.Forms.Label();
            this.label_AddPartMachineID = new System.Windows.Forms.Label();
            this.label_AddPartCompName = new System.Windows.Forms.Label();
            this.btn_SavePart = new System.Windows.Forms.Button();
            this.btn_CancelPart = new System.Windows.Forms.Button();
            this.label_AddPartInventory = new System.Windows.Forms.Label();
            this.tbAddPartInventory = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // addPartTitle
            // 
            this.addPartTitle.AutoSize = true;
            this.addPartTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addPartTitle.Location = new System.Drawing.Point(13, 13);
            this.addPartTitle.Name = "addPartTitle";
            this.addPartTitle.Size = new System.Drawing.Size(93, 30);
            this.addPartTitle.TabIndex = 0;
            this.addPartTitle.Text = "Add Part";
            // 
            // rbInhouse
            // 
            this.rbInhouse.AutoSize = true;
            this.rbInhouse.Location = new System.Drawing.Point(150, 23);
            this.rbInhouse.Name = "rbInhouse";
            this.rbInhouse.Size = new System.Drawing.Size(74, 19);
            this.rbInhouse.TabIndex = 1;
            this.rbInhouse.TabStop = true;
            this.rbInhouse.Text = "In-House";
            this.rbInhouse.UseVisualStyleBackColor = true;
            this.rbInhouse.CheckedChanged += new System.EventHandler(this.rbInhouse_CheckedChanged);
            // 
            // rbOutsourced
            // 
            this.rbOutsourced.AutoSize = true;
            this.rbOutsourced.Location = new System.Drawing.Point(274, 24);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(87, 19);
            this.rbOutsourced.TabIndex = 2;
            this.rbOutsourced.TabStop = true;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.rbOutsourced_CheckedChanged);
            // 
            // tbPartID
            // 
            this.tbPartID.Location = new System.Drawing.Point(274, 75);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(100, 23);
            this.tbPartID.TabIndex = 3;
            // 
            // tbAddPartName
            // 
            this.tbAddPartName.Location = new System.Drawing.Point(274, 127);
            this.tbAddPartName.Name = "tbAddPartName";
            this.tbAddPartName.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartName.TabIndex = 4;
            // 
            // tbAddPriceCost
            // 
            this.tbAddPriceCost.Location = new System.Drawing.Point(274, 214);
            this.tbAddPriceCost.Name = "tbAddPriceCost";
            this.tbAddPriceCost.Size = new System.Drawing.Size(100, 23);
            this.tbAddPriceCost.TabIndex = 5;
            // 
            // tbAddPartMax
            // 
            this.tbAddPartMax.Location = new System.Drawing.Point(274, 266);
            this.tbAddPartMax.Name = "tbAddPartMax";
            this.tbAddPartMax.Size = new System.Drawing.Size(56, 23);
            this.tbAddPartMax.TabIndex = 6;
            // 
            // tbAddPartMin
            // 
            this.tbAddPartMin.Location = new System.Drawing.Point(413, 266);
            this.tbAddPartMin.Name = "tbAddPartMin";
            this.tbAddPartMin.Size = new System.Drawing.Size(56, 23);
            this.tbAddPartMin.TabIndex = 7;
            // 
            // tbCompanyOrMachine
            // 
            this.tbCompanyOrMachine.Location = new System.Drawing.Point(274, 318);
            this.tbCompanyOrMachine.Name = "tbCompanyOrMachine";
            this.tbCompanyOrMachine.Size = new System.Drawing.Size(100, 23);
            this.tbCompanyOrMachine.TabIndex = 8;
            // 
            // label_AddPartID
            // 
            this.label_AddPartID.AutoSize = true;
            this.label_AddPartID.Location = new System.Drawing.Point(206, 79);
            this.label_AddPartID.Name = "label_AddPartID";
            this.label_AddPartID.Size = new System.Drawing.Size(18, 15);
            this.label_AddPartID.TabIndex = 9;
            this.label_AddPartID.Text = "ID";
            // 
            // label_AddPartName
            // 
            this.label_AddPartName.AutoSize = true;
            this.label_AddPartName.Location = new System.Drawing.Point(185, 131);
            this.label_AddPartName.Name = "label_AddPartName";
            this.label_AddPartName.Size = new System.Drawing.Size(39, 15);
            this.label_AddPartName.TabIndex = 10;
            this.label_AddPartName.Text = "Name";
            // 
            // label_AddPartPriceCost
            // 
            this.label_AddPartPriceCost.AutoSize = true;
            this.label_AddPartPriceCost.Location = new System.Drawing.Point(167, 218);
            this.label_AddPartPriceCost.Name = "label_AddPartPriceCost";
            this.label_AddPartPriceCost.Size = new System.Drawing.Size(68, 15);
            this.label_AddPartPriceCost.TabIndex = 11;
            this.label_AddPartPriceCost.Text = "Price / Cost";
            // 
            // label_AddPartMax
            // 
            this.label_AddPartMax.AutoSize = true;
            this.label_AddPartMax.Location = new System.Drawing.Point(194, 270);
            this.label_AddPartMax.Name = "label_AddPartMax";
            this.label_AddPartMax.Size = new System.Drawing.Size(30, 15);
            this.label_AddPartMax.TabIndex = 12;
            this.label_AddPartMax.Text = "Max";
            // 
            // label_AddPartMin
            // 
            this.label_AddPartMin.AutoSize = true;
            this.label_AddPartMin.Location = new System.Drawing.Point(367, 270);
            this.label_AddPartMin.Name = "label_AddPartMin";
            this.label_AddPartMin.Size = new System.Drawing.Size(28, 15);
            this.label_AddPartMin.TabIndex = 13;
            this.label_AddPartMin.Text = "Min";
            // 
            // label_AddPartMachineID
            // 
            this.label_AddPartMachineID.AutoSize = true;
            this.label_AddPartMachineID.Location = new System.Drawing.Point(157, 322);
            this.label_AddPartMachineID.Name = "label_AddPartMachineID";
            this.label_AddPartMachineID.Size = new System.Drawing.Size(67, 15);
            this.label_AddPartMachineID.TabIndex = 14;
            this.label_AddPartMachineID.Text = "Machine ID";
            // 
            // label_AddPartCompName
            // 
            this.label_AddPartCompName.AutoSize = true;
            this.label_AddPartCompName.Location = new System.Drawing.Point(130, 321);
            this.label_AddPartCompName.Name = "label_AddPartCompName";
            this.label_AddPartCompName.Size = new System.Drawing.Size(94, 15);
            this.label_AddPartCompName.TabIndex = 15;
            this.label_AddPartCompName.Text = "Company Name";
            this.label_AddPartCompName.Visible = false;
            // 
            // btn_SavePart
            // 
            this.btn_SavePart.Location = new System.Drawing.Point(285, 360);
            this.btn_SavePart.Name = "btn_SavePart";
            this.btn_SavePart.Size = new System.Drawing.Size(75, 41);
            this.btn_SavePart.TabIndex = 16;
            this.btn_SavePart.Text = "Save";
            this.btn_SavePart.UseVisualStyleBackColor = true;
            this.btn_SavePart.Click += new System.EventHandler(this.btn_SavePart_Click);
            // 
            // btn_CancelPart
            // 
            this.btn_CancelPart.Location = new System.Drawing.Point(413, 360);
            this.btn_CancelPart.Name = "btn_CancelPart";
            this.btn_CancelPart.Size = new System.Drawing.Size(75, 41);
            this.btn_CancelPart.TabIndex = 17;
            this.btn_CancelPart.Text = "Cancel";
            this.btn_CancelPart.UseVisualStyleBackColor = true;
            this.btn_CancelPart.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label_AddPartInventory
            // 
            this.label_AddPartInventory.AutoSize = true;
            this.label_AddPartInventory.Location = new System.Drawing.Point(185, 174);
            this.label_AddPartInventory.Name = "label_AddPartInventory";
            this.label_AddPartInventory.Size = new System.Drawing.Size(57, 15);
            this.label_AddPartInventory.TabIndex = 19;
            this.label_AddPartInventory.Text = "Inventory";
            // 
            // tbAddPartInventory
            // 
            this.tbAddPartInventory.HideSelection = false;
            this.tbAddPartInventory.Location = new System.Drawing.Point(274, 170);
            this.tbAddPartInventory.Name = "tbAddPartInventory";
            this.tbAddPartInventory.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartInventory.TabIndex = 18;
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(576, 485);
            this.Controls.Add(this.label_AddPartInventory);
            this.Controls.Add(this.tbAddPartInventory);
            this.Controls.Add(this.btn_CancelPart);
            this.Controls.Add(this.btn_SavePart);
            this.Controls.Add(this.label_AddPartCompName);
            this.Controls.Add(this.label_AddPartMachineID);
            this.Controls.Add(this.label_AddPartMin);
            this.Controls.Add(this.label_AddPartMax);
            this.Controls.Add(this.label_AddPartPriceCost);
            this.Controls.Add(this.label_AddPartName);
            this.Controls.Add(this.label_AddPartID);
            this.Controls.Add(this.tbCompanyOrMachine);
            this.Controls.Add(this.tbAddPartMin);
            this.Controls.Add(this.tbAddPartMax);
            this.Controls.Add(this.tbAddPriceCost);
            this.Controls.Add(this.tbAddPartName);
            this.Controls.Add(this.tbPartID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInhouse);
            this.Controls.Add(this.addPartTitle);
            this.Name = "AddPart";
            this.Text = "AddPart";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartTitle;
        private System.Windows.Forms.RadioButton rbInhouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.TextBox tbAddPartName;
        private System.Windows.Forms.TextBox tbAddPriceCost;
        private System.Windows.Forms.TextBox tbAddPartMax;
        private System.Windows.Forms.TextBox tbAddPartMin;
        private System.Windows.Forms.TextBox tbCompanyOrMachine;
        private System.Windows.Forms.Label label_AddPartID;
        private System.Windows.Forms.Label label_AddPartName;
        private System.Windows.Forms.Label label_AddPartPriceCost;
        private System.Windows.Forms.Label label_AddPartMax;
        private System.Windows.Forms.Label label_AddPartMin;
        private System.Windows.Forms.Label label_AddPartMachineID;
        private System.Windows.Forms.Label label_AddPartCompName;
        private System.Windows.Forms.Button btn_SavePart;
        private System.Windows.Forms.Button btn_CancelPart;
        private System.Windows.Forms.Label label_AddPartInventory;
        private System.Windows.Forms.TextBox tbAddPartInventory;
    }
}