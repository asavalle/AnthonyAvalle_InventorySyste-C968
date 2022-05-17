
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
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.label_PartID = new System.Windows.Forms.Label();
            this.label_PartName = new System.Windows.Forms.Label();
            this.label_PartInventory = new System.Windows.Forms.Label();
            this.label_PartMax = new System.Windows.Forms.Label();
            this.label_PartMin = new System.Windows.Forms.Label();
            this.labelMachineID = new System.Windows.Forms.Label();
            this.labelCompName = new System.Windows.Forms.Label();
            this.btn_SavePart = new System.Windows.Forms.Button();
            this.btn_CancelPart = new System.Windows.Forms.Button();
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
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(274, 75);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 23);
            this.textBox1.TabIndex = 3;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(274, 127);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 23);
            this.textBox2.TabIndex = 4;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(274, 179);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 23);
            this.textBox3.TabIndex = 5;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(274, 231);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(56, 23);
            this.textBox4.TabIndex = 6;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(413, 231);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(56, 23);
            this.textBox5.TabIndex = 7;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(274, 283);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(100, 23);
            this.textBox6.TabIndex = 8;
            // 
            // label_PartID
            // 
            this.label_PartID.AutoSize = true;
            this.label_PartID.Location = new System.Drawing.Point(206, 79);
            this.label_PartID.Name = "label_PartID";
            this.label_PartID.Size = new System.Drawing.Size(18, 15);
            this.label_PartID.TabIndex = 9;
            this.label_PartID.Text = "ID";
            // 
            // label_PartName
            // 
            this.label_PartName.AutoSize = true;
            this.label_PartName.Location = new System.Drawing.Point(185, 131);
            this.label_PartName.Name = "label_PartName";
            this.label_PartName.Size = new System.Drawing.Size(39, 15);
            this.label_PartName.TabIndex = 10;
            this.label_PartName.Text = "Name";
            // 
            // label_PartInventory
            // 
            this.label_PartInventory.AutoSize = true;
            this.label_PartInventory.Location = new System.Drawing.Point(167, 183);
            this.label_PartInventory.Name = "label_PartInventory";
            this.label_PartInventory.Size = new System.Drawing.Size(57, 15);
            this.label_PartInventory.TabIndex = 11;
            this.label_PartInventory.Text = "Inventory";
            // 
            // label_PartMax
            // 
            this.label_PartMax.AutoSize = true;
            this.label_PartMax.Location = new System.Drawing.Point(194, 235);
            this.label_PartMax.Name = "label_PartMax";
            this.label_PartMax.Size = new System.Drawing.Size(30, 15);
            this.label_PartMax.TabIndex = 12;
            this.label_PartMax.Text = "Max";
            // 
            // label_PartMin
            // 
            this.label_PartMin.AutoSize = true;
            this.label_PartMin.Location = new System.Drawing.Point(367, 235);
            this.label_PartMin.Name = "label_PartMin";
            this.label_PartMin.Size = new System.Drawing.Size(28, 15);
            this.label_PartMin.TabIndex = 13;
            this.label_PartMin.Text = "Min";
            // 
            // labelMachineID
            // 
            this.labelMachineID.AutoSize = true;
            this.labelMachineID.Location = new System.Drawing.Point(157, 287);
            this.labelMachineID.Name = "labelMachineID";
            this.labelMachineID.Size = new System.Drawing.Size(67, 15);
            this.labelMachineID.TabIndex = 14;
            this.labelMachineID.Text = "Machine ID";
            // 
            // labelCompName
            // 
            this.labelCompName.AutoSize = true;
            this.labelCompName.Location = new System.Drawing.Point(130, 287);
            this.labelCompName.Name = "labelCompName";
            this.labelCompName.Size = new System.Drawing.Size(94, 15);
            this.labelCompName.TabIndex = 15;
            this.labelCompName.Text = "Company Name";
            this.labelCompName.Visible = false;
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
            // AddPart
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(519, 450);
            this.Controls.Add(this.btn_CancelPart);
            this.Controls.Add(this.btn_SavePart);
            this.Controls.Add(this.labelCompName);
            this.Controls.Add(this.labelMachineID);
            this.Controls.Add(this.label_PartMin);
            this.Controls.Add(this.label_PartMax);
            this.Controls.Add(this.label_PartInventory);
            this.Controls.Add(this.label_PartName);
            this.Controls.Add(this.label_PartID);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox1);
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
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Label label_PartID;
        private System.Windows.Forms.Label label_PartName;
        private System.Windows.Forms.Label label_PartInventory;
        private System.Windows.Forms.Label label_PartMax;
        private System.Windows.Forms.Label label_PartMin;
        private System.Windows.Forms.Label labelMachineID;
        private System.Windows.Forms.Label labelCompName;
        private System.Windows.Forms.Button btn_SavePart;
        private System.Windows.Forms.Button btn_CancelPart;
    }
}