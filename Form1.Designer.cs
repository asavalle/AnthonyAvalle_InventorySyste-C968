
namespace InventoryTrackingApp
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.btnProdSearch = new System.Windows.Forms.Button();
            this.btnPartSearch = new System.Windows.Forms.Button();
            this.labelProducts = new System.Windows.Forms.Label();
            this.labelParts = new System.Windows.Forms.Label();
            this.btnDelPart = new System.Windows.Forms.Button();
            this.btnModPart = new System.Windows.Forms.Button();
            this.btnAddPart = new System.Windows.Forms.Button();
            this.dgvParts = new System.Windows.Forms.DataGridView();
            this.dgvProducts = new System.Windows.Forms.DataGridView();
            this.btnAddProduct = new System.Windows.Forms.Button();
            this.btnModProduct = new System.Windows.Forms.Button();
            this.btnDelProduct = new System.Windows.Forms.Button();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(850, 115);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(399, 23);
            this.textBox2.TabIndex = 14;
            this.textBox2.TextChanged += new System.EventHandler(this.textBox2_TextChanged);
            // 
            // btnProdSearch
            // 
            this.btnProdSearch.Location = new System.Drawing.Point(1296, 116);
            this.btnProdSearch.Name = "btnProdSearch";
            this.btnProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProdSearch.TabIndex = 12;
            this.btnProdSearch.Text = "Search";
            this.btnProdSearch.UseVisualStyleBackColor = true;
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(546, 115);
            this.btnPartSearch.Name = "btnPartSearch";
            this.btnPartSearch.Size = new System.Drawing.Size(75, 23);
            this.btnPartSearch.TabIndex = 11;
            this.btnPartSearch.Text = "Search";
            this.btnPartSearch.UseVisualStyleBackColor = true;
            this.btnPartSearch.Click += new System.EventHandler(this.btnPartSearch_Click);
            // 
            // labelProducts
            // 
            this.labelProducts.AutoSize = true;
            this.labelProducts.Location = new System.Drawing.Point(850, 75);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(54, 15);
            this.labelProducts.TabIndex = 9;
            this.labelProducts.Text = "Products";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Location = new System.Drawing.Point(100, 75);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(33, 15);
            this.labelParts.TabIndex = 8;
            this.labelParts.Text = "Parts";
            // 
            // btnDelPart
            // 
            this.btnDelPart.Location = new System.Drawing.Point(627, 279);
            this.btnDelPart.Name = "btnDelPart";
            this.btnDelPart.Size = new System.Drawing.Size(75, 23);
            this.btnDelPart.TabIndex = 4;
            this.btnDelPart.Text = "DELETE";
            this.btnDelPart.UseVisualStyleBackColor = true;
            // 
            // btnModPart
            // 
            this.btnModPart.Location = new System.Drawing.Point(627, 214);
            this.btnModPart.Name = "btnModPart";
            this.btnModPart.Size = new System.Drawing.Size(75, 23);
            this.btnModPart.TabIndex = 3;
            this.btnModPart.Text = "MODIFY";
            this.btnModPart.UseVisualStyleBackColor = true;
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(627, 155);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "ADD";
            this.btnAddPart.UseVisualStyleBackColor = true;
            // 
            // dgvParts
            // 
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(100, 155);
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.RowTemplate.Height = 25;
            this.dgvParts.Size = new System.Drawing.Size(521, 474);
            this.dgvParts.TabIndex = 15;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(850, 155);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(521, 474);
            this.dgvProducts.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1377, 155);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            // 
            // btnModProduct
            // 
            this.btnModProduct.Location = new System.Drawing.Point(1377, 214);
            this.btnModProduct.Name = "btnModProduct";
            this.btnModProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModProduct.TabIndex = 6;
            this.btnModProduct.Text = "MODIFY";
            this.btnModProduct.UseVisualStyleBackColor = true;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Location = new System.Drawing.Point(1377, 279);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDelProduct.TabIndex = 7;
            this.btnDelProduct.Text = "DELETE";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(100, 116);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(399, 23);
            this.textBox1.TabIndex = 13;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(100, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(371, 32);
            this.label1.TabIndex = 17;
            this.label1.Text = "Inventory Management System";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1524, 777);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnModProduct);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.btnProdSearch);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnModPart);
            this.Controls.Add(this.btnDelPart);
            this.Name = "Form1";
            this.Text = "Main Screen";
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label labelProducts;
        private System.Windows.Forms.Label labelParts;
        private System.Windows.Forms.Button btnDelPart;
        private System.Windows.Forms.Button btnModPart;
        private System.Windows.Forms.Button btnAddPart;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Button btnProdSearch;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label1;
    }
}

