
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
            this.components = new System.ComponentModel.Container();
            this.addPartTitle = new System.Windows.Forms.Label();
            this.rbInhouse = new System.Windows.Forms.RadioButton();
            this.rbOutsourced = new System.Windows.Forms.RadioButton();
            this.tbPartID = new System.Windows.Forms.TextBox();
            this.tbAddPartMax = new System.Windows.Forms.TextBox();
            this.tbAddPartMin = new System.Windows.Forms.TextBox();
            this.tbCompanyOrMachine = new System.Windows.Forms.TextBox();
            this.label_AddPartID = new System.Windows.Forms.Label();
            this.label_AddPartName = new System.Windows.Forms.Label();
            this.label_AddPartPriceCost = new System.Windows.Forms.Label();
            this.label_AddPartMax = new System.Windows.Forms.Label();
            this.label_AddPartMin = new System.Windows.Forms.Label();
            this.label_AddPartSource = new System.Windows.Forms.Label();
            this.btn_SavePart = new System.Windows.Forms.Button();
            this.btn_CancelPart = new System.Windows.Forms.Button();
            this.label_AddPartInventory = new System.Windows.Forms.Label();
            this.tbAddPartInventory = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.tbAddPartName = new System.Windows.Forms.TextBox();
            this.tbAddPriceCost = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
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
            this.rbInhouse.Checked = true;
            this.rbInhouse.Location = new System.Drawing.Point(172, 79);
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
            this.rbOutsourced.Location = new System.Drawing.Point(296, 80);
            this.rbOutsourced.Name = "rbOutsourced";
            this.rbOutsourced.Size = new System.Drawing.Size(87, 19);
            this.rbOutsourced.TabIndex = 2;
            this.rbOutsourced.Text = "Outsourced";
            this.rbOutsourced.UseVisualStyleBackColor = true;
            this.rbOutsourced.CheckedChanged += new System.EventHandler(this.rbOutsourced_CheckedChanged);
            // 
            // tbPartID
            // 
            this.tbPartID.Enabled = false;
            this.tbPartID.Location = new System.Drawing.Point(194, 142);
            this.tbPartID.Name = "tbPartID";
            this.tbPartID.ReadOnly = true;
            this.tbPartID.Size = new System.Drawing.Size(100, 23);
            this.tbPartID.TabIndex = 3;
            // 
            // tbAddPartMax
            // 
            this.tbAddPartMax.Location = new System.Drawing.Point(194, 333);
            this.tbAddPartMax.Name = "tbAddPartMax";
            this.tbAddPartMax.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartMax.TabIndex = 7;
            this.tbAddPartMax.TextChanged += new System.EventHandler(this.tbAddPartMax_TextChanged);
            this.tbAddPartMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddPartMax_KeyPress);
            // 
            // tbAddPartMin
            // 
            this.tbAddPartMin.Location = new System.Drawing.Point(362, 333);
            this.tbAddPartMin.Name = "tbAddPartMin";
            this.tbAddPartMin.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartMin.TabIndex = 8;
            this.tbAddPartMin.TextChanged += new System.EventHandler(this.tbAddPartMin_TextChanged);
            this.tbAddPartMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddPartMin_KeyPress);
            this.tbAddPartMin.Leave += new System.EventHandler(this.tbAddPartMin_Leave);
            // 
            // tbCompanyOrMachine
            // 
            this.tbCompanyOrMachine.Location = new System.Drawing.Point(194, 385);
            this.tbCompanyOrMachine.Name = "tbCompanyOrMachine";
            this.tbCompanyOrMachine.Size = new System.Drawing.Size(268, 23);
            this.tbCompanyOrMachine.TabIndex = 9;
            this.tbCompanyOrMachine.TextChanged += new System.EventHandler(this.tbCompanyOrMachine_TextChanged);
            this.tbCompanyOrMachine.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbCompanyOrMachine_KeyPress);
            // 
            // label_AddPartID
            // 
            this.label_AddPartID.AutoSize = true;
            this.label_AddPartID.Location = new System.Drawing.Point(144, 145);
            this.label_AddPartID.Name = "label_AddPartID";
            this.label_AddPartID.Size = new System.Drawing.Size(18, 15);
            this.label_AddPartID.TabIndex = 9;
            this.label_AddPartID.Text = "ID";
            // 
            // label_AddPartName
            // 
            this.label_AddPartName.AutoSize = true;
            this.label_AddPartName.Location = new System.Drawing.Point(123, 197);
            this.label_AddPartName.Name = "label_AddPartName";
            this.label_AddPartName.Size = new System.Drawing.Size(39, 15);
            this.label_AddPartName.TabIndex = 10;
            this.label_AddPartName.Text = "Name";
            // 
            // label_AddPartPriceCost
            // 
            this.label_AddPartPriceCost.AutoSize = true;
            this.label_AddPartPriceCost.Location = new System.Drawing.Point(94, 284);
            this.label_AddPartPriceCost.Name = "label_AddPartPriceCost";
            this.label_AddPartPriceCost.Size = new System.Drawing.Size(68, 15);
            this.label_AddPartPriceCost.TabIndex = 11;
            this.label_AddPartPriceCost.Text = "Price / Cost";
            // 
            // label_AddPartMax
            // 
            this.label_AddPartMax.AutoSize = true;
            this.label_AddPartMax.Location = new System.Drawing.Point(132, 336);
            this.label_AddPartMax.Name = "label_AddPartMax";
            this.label_AddPartMax.Size = new System.Drawing.Size(30, 15);
            this.label_AddPartMax.TabIndex = 12;
            this.label_AddPartMax.Text = "Max";
            // 
            // label_AddPartMin
            // 
            this.label_AddPartMin.AutoSize = true;
            this.label_AddPartMin.Location = new System.Drawing.Point(316, 337);
            this.label_AddPartMin.Name = "label_AddPartMin";
            this.label_AddPartMin.Size = new System.Drawing.Size(28, 15);
            this.label_AddPartMin.TabIndex = 13;
            this.label_AddPartMin.Text = "Min";
            // 
            // label_AddPartSource
            // 
            this.label_AddPartSource.AutoSize = true;
            this.label_AddPartSource.Location = new System.Drawing.Point(95, 388);
            this.label_AddPartSource.Name = "label_AddPartSource";
            this.label_AddPartSource.Size = new System.Drawing.Size(67, 15);
            this.label_AddPartSource.TabIndex = 14;
            this.label_AddPartSource.Text = "Machine ID";
            this.label_AddPartSource.TextAlign = System.Drawing.ContentAlignment.BottomRight;
            // 
            // btn_SavePart
            // 
            this.btn_SavePart.Location = new System.Drawing.Point(581, 439);
            this.btn_SavePart.Name = "btn_SavePart";
            this.btn_SavePart.Size = new System.Drawing.Size(75, 41);
            this.btn_SavePart.TabIndex = 11;
            this.btn_SavePart.Text = "Save";
            this.btn_SavePart.UseVisualStyleBackColor = true;
            this.btn_SavePart.Click += new System.EventHandler(this.btn_SavePart_Click);
            // 
            // btn_CancelPart
            // 
            this.btn_CancelPart.Location = new System.Drawing.Point(681, 439);
            this.btn_CancelPart.Name = "btn_CancelPart";
            this.btn_CancelPart.Size = new System.Drawing.Size(75, 41);
            this.btn_CancelPart.TabIndex = 10;
            this.btn_CancelPart.Text = "Cancel";
            this.btn_CancelPart.UseVisualStyleBackColor = true;
            this.btn_CancelPart.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // label_AddPartInventory
            // 
            this.label_AddPartInventory.AutoSize = true;
            this.label_AddPartInventory.Location = new System.Drawing.Point(105, 240);
            this.label_AddPartInventory.Name = "label_AddPartInventory";
            this.label_AddPartInventory.Size = new System.Drawing.Size(57, 15);
            this.label_AddPartInventory.TabIndex = 19;
            this.label_AddPartInventory.Text = "Inventory";
            // 
            // tbAddPartInventory
            // 
            this.tbAddPartInventory.HideSelection = false;
            this.tbAddPartInventory.Location = new System.Drawing.Point(194, 237);
            this.tbAddPartInventory.Name = "tbAddPartInventory";
            this.tbAddPartInventory.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartInventory.TabIndex = 5;
            this.tbAddPartInventory.TextChanged += new System.EventHandler(this.tbAddPartInventory_TextChanged);
            this.tbAddPartInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddPartInventory_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // tbAddPartName
            // 
            this.tbAddPartName.Location = new System.Drawing.Point(194, 194);
            this.tbAddPartName.Name = "tbAddPartName";
            this.tbAddPartName.Size = new System.Drawing.Size(100, 23);
            this.tbAddPartName.TabIndex = 4;
            this.tbAddPartName.TextChanged += new System.EventHandler(this.tbAddPartName_TextChanged);
            // 
            // tbAddPriceCost
            // 
            this.tbAddPriceCost.Location = new System.Drawing.Point(194, 284);
            this.tbAddPriceCost.Name = "tbAddPriceCost";
            this.tbAddPriceCost.Size = new System.Drawing.Size(100, 23);
            this.tbAddPriceCost.TabIndex = 6;
            this.tbAddPriceCost.TextChanged += new System.EventHandler(this.tbAddPriceCost_TextChanged);
            this.tbAddPriceCost.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tbAddPriceCost_KeyPress);
            this.tbAddPriceCost.Leave += new System.EventHandler(this.tbAddPriceCost_Leave);
            // 
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(768, 492);
            this.Controls.Add(this.tbAddPriceCost);
            this.Controls.Add(this.label_AddPartInventory);
            this.Controls.Add(this.tbAddPartInventory);
            this.Controls.Add(this.btn_CancelPart);
            this.Controls.Add(this.btn_SavePart);
            this.Controls.Add(this.label_AddPartSource);
            this.Controls.Add(this.label_AddPartMin);
            this.Controls.Add(this.label_AddPartMax);
            this.Controls.Add(this.label_AddPartPriceCost);
            this.Controls.Add(this.label_AddPartName);
            this.Controls.Add(this.label_AddPartID);
            this.Controls.Add(this.tbCompanyOrMachine);
            this.Controls.Add(this.tbAddPartMin);
            this.Controls.Add(this.tbAddPartMax);
            this.Controls.Add(this.tbAddPartName);
            this.Controls.Add(this.tbPartID);
            this.Controls.Add(this.rbOutsourced);
            this.Controls.Add(this.rbInhouse);
            this.Controls.Add(this.addPartTitle);
            this.Name = "AddPart";
            this.Text = "Add Part";
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addPartTitle;
        private System.Windows.Forms.RadioButton rbInhouse;
        private System.Windows.Forms.RadioButton rbOutsourced;
        private System.Windows.Forms.TextBox tbPartID;
        private System.Windows.Forms.TextBox tbAddPartMax;
        private System.Windows.Forms.TextBox tbAddPartMin;
        private System.Windows.Forms.TextBox tbCompanyOrMachine;
        private System.Windows.Forms.Label label_AddPartID;
        private System.Windows.Forms.Label label_AddPartName;
        private System.Windows.Forms.Label label_AddPartPriceCost;
        private System.Windows.Forms.Label label_AddPartMax;
        private System.Windows.Forms.Label label_AddPartMin;
        private System.Windows.Forms.Label label_AddPartSource;
        private System.Windows.Forms.Button btn_SavePart;
        private System.Windows.Forms.Button btn_CancelPart;
        private System.Windows.Forms.Label label_AddPartInventory;
        private System.Windows.Forms.TextBox tbAddPartInventory;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.TextBox tbAddPartName;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox tbAddPriceCost;
        private System.Windows.Forms.MaskedTextBox maskedTextBox1;
    }
}