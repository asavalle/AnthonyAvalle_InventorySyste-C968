
namespace InventoryTrackingApp.Views
{
    partial class AddProduct
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
            this.addProductTitle = new System.Windows.Forms.Label();
            this.btn_SearchProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dataGridView2 = new System.Windows.Forms.DataGridView();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_ProductID = new System.Windows.Forms.TextBox();
            this.label_ProductID = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_ProductInventory = new System.Windows.Forms.Label();
            this.label_ProductPrice = new System.Windows.Forms.Label();
            this.label_ProductMax = new System.Windows.Forms.Label();
            this.label_ProductMin = new System.Windows.Forms.Label();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.btn_AddProdcut = new System.Windows.Forms.Button();
            this.btn_DelProduct = new System.Windows.Forms.Button();
            this.btn_ProdCancel = new System.Windows.Forms.Button();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.testLableAP = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductTitle.Location = new System.Drawing.Point(37, 13);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(129, 30);
            this.addProductTitle.TabIndex = 0;
            this.addProductTitle.Text = "Add Product";
            // 
            // btn_SearchProduct
            // 
            this.btn_SearchProduct.Location = new System.Drawing.Point(413, 19);
            this.btn_SearchProduct.Name = "btn_SearchProduct";
            this.btn_SearchProduct.Size = new System.Drawing.Size(67, 23);
            this.btn_SearchProduct.TabIndex = 1;
            this.btn_SearchProduct.Text = "Search";
            this.btn_SearchProduct.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(486, 19);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(263, 23);
            this.textBox1.TabIndex = 2;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(413, 84);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(447, 232);
            this.dataGridView1.TabIndex = 3;
            // 
            // dataGridView2
            // 
            this.dataGridView2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView2.Location = new System.Drawing.Point(413, 365);
            this.dataGridView2.Name = "dataGridView2";
            this.dataGridView2.RowTemplate.Height = 25;
            this.dataGridView2.Size = new System.Drawing.Size(447, 232);
            this.dataGridView2.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(413, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 15);
            this.label2.TabIndex = 5;
            this.label2.Text = "All candidate Parts";
            // 
            // tb_ProductID
            // 
            this.tb_ProductID.Location = new System.Drawing.Point(116, 245);
            this.tb_ProductID.Name = "tb_ProductID";
            this.tb_ProductID.Size = new System.Drawing.Size(184, 23);
            this.tb_ProductID.TabIndex = 6;
            // 
            // label_ProductID
            // 
            this.label_ProductID.AutoSize = true;
            this.label_ProductID.Location = new System.Drawing.Point(73, 253);
            this.label_ProductID.Name = "label_ProductID";
            this.label_ProductID.Size = new System.Drawing.Size(18, 15);
            this.label_ProductID.TabIndex = 7;
            this.label_ProductID.Text = "ID";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(52, 301);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(39, 15);
            this.label_ProductName.TabIndex = 8;
            this.label_ProductName.Text = "Name";
            // 
            // label_ProductInventory
            // 
            this.label_ProductInventory.AutoSize = true;
            this.label_ProductInventory.Location = new System.Drawing.Point(34, 342);
            this.label_ProductInventory.Name = "label_ProductInventory";
            this.label_ProductInventory.Size = new System.Drawing.Size(57, 15);
            this.label_ProductInventory.TabIndex = 9;
            this.label_ProductInventory.Text = "Inventory";
            // 
            // label_ProductPrice
            // 
            this.label_ProductPrice.AutoSize = true;
            this.label_ProductPrice.Location = new System.Drawing.Point(58, 377);
            this.label_ProductPrice.Name = "label_ProductPrice";
            this.label_ProductPrice.Size = new System.Drawing.Size(33, 15);
            this.label_ProductPrice.TabIndex = 10;
            this.label_ProductPrice.Text = "Price";
            // 
            // label_ProductMax
            // 
            this.label_ProductMax.AutoSize = true;
            this.label_ProductMax.Location = new System.Drawing.Point(61, 415);
            this.label_ProductMax.Name = "label_ProductMax";
            this.label_ProductMax.Size = new System.Drawing.Size(30, 15);
            this.label_ProductMax.TabIndex = 11;
            this.label_ProductMax.Text = "Max";
            // 
            // label_ProductMin
            // 
            this.label_ProductMin.AutoSize = true;
            this.label_ProductMin.Location = new System.Drawing.Point(201, 415);
            this.label_ProductMin.Name = "label_ProductMin";
            this.label_ProductMin.Size = new System.Drawing.Size(28, 15);
            this.label_ProductMin.TabIndex = 12;
            this.label_ProductMin.Text = "Min";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(116, 293);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(184, 23);
            this.textBox2.TabIndex = 13;
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(116, 339);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(184, 23);
            this.textBox3.TabIndex = 14;
            // 
            // textBox4
            // 
            this.textBox4.Location = new System.Drawing.Point(116, 377);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(184, 23);
            this.textBox4.TabIndex = 15;
            // 
            // textBox5
            // 
            this.textBox5.Location = new System.Drawing.Point(116, 412);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(79, 23);
            this.textBox5.TabIndex = 16;
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(235, 412);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(79, 23);
            this.textBox6.TabIndex = 17;
            // 
            // btn_AddProdcut
            // 
            this.btn_AddProdcut.Location = new System.Drawing.Point(808, 322);
            this.btn_AddProdcut.Name = "btn_AddProdcut";
            this.btn_AddProdcut.Size = new System.Drawing.Size(52, 23);
            this.btn_AddProdcut.TabIndex = 18;
            this.btn_AddProdcut.Text = "Add";
            this.btn_AddProdcut.UseVisualStyleBackColor = true;
            // 
            // btn_DelProduct
            // 
            this.btn_DelProduct.Location = new System.Drawing.Point(808, 603);
            this.btn_DelProduct.Name = "btn_DelProduct";
            this.btn_DelProduct.Size = new System.Drawing.Size(52, 23);
            this.btn_DelProduct.TabIndex = 19;
            this.btn_DelProduct.Text = "Delete";
            this.btn_DelProduct.UseVisualStyleBackColor = true;
            // 
            // btn_ProdCancel
            // 
            this.btn_ProdCancel.Location = new System.Drawing.Point(808, 679);
            this.btn_ProdCancel.Name = "btn_ProdCancel";
            this.btn_ProdCancel.Size = new System.Drawing.Size(72, 35);
            this.btn_ProdCancel.TabIndex = 20;
            this.btn_ProdCancel.Text = "Cancel";
            this.btn_ProdCancel.UseVisualStyleBackColor = true;
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(713, 679);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(72, 35);
            this.btnSaveProd.TabIndex = 21;
            this.btnSaveProd.Text = "Save";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            // 
            // testLableAP
            // 
            this.testLableAP.AutoSize = true;
            this.testLableAP.Location = new System.Drawing.Point(73, 552);
            this.testLableAP.Name = "testLableAP";
            this.testLableAP.Size = new System.Drawing.Size(31, 15);
            this.testLableAP.TabIndex = 22;
            this.testLableAP.Text = "TEST";
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(908, 726);
            this.Controls.Add(this.testLableAP);
            this.Controls.Add(this.btnSaveProd);
            this.Controls.Add(this.btn_ProdCancel);
            this.Controls.Add(this.btn_DelProduct);
            this.Controls.Add(this.btn_AddProdcut);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label_ProductMin);
            this.Controls.Add(this.label_ProductMax);
            this.Controls.Add(this.label_ProductPrice);
            this.Controls.Add(this.label_ProductInventory);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_ProductID);
            this.Controls.Add(this.tb_ProductID);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.dataGridView2);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btn_SearchProduct);
            this.Controls.Add(this.addProductTitle);
            this.Name = "AddProduct";
            this.Text = "AddProduct";
            this.Load += new System.EventHandler(this.AddProduct_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Button btn_SearchProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridView dataGridView2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_ProductID;
        private System.Windows.Forms.Label label_ProductID;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_ProductInventory;
        private System.Windows.Forms.Label label_ProductPrice;
        private System.Windows.Forms.Label label_ProductMax;
        private System.Windows.Forms.Label label_ProductMin;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.Button btn_AddProdcut;
        private System.Windows.Forms.Button btn_DelProduct;
        private System.Windows.Forms.Button btn_ProdCancel;
        private System.Windows.Forms.Button btnSaveProd;
        private System.Windows.Forms.Label testLableAP;
    }
}