
namespace InventoryTrackingApp
{
    partial class MainScreen
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
            this.searchProducts = new System.Windows.Forms.TextBox();
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
            this.searchParts = new System.Windows.Forms.TextBox();
            this.labelTitle = new System.Windows.Forms.Label();
            this.bt_Exit = new System.Windows.Forms.Button();
            this.btn_RestSearch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvProducts)).BeginInit();
            this.SuspendLayout();
            // 
            // searchProducts
            // 
            this.searchProducts.Location = new System.Drawing.Point(789, 115);
            this.searchProducts.Name = "searchProducts";
            this.searchProducts.Size = new System.Drawing.Size(399, 23);
            this.searchProducts.TabIndex = 14;
            // 
            // btnProdSearch
            // 
            this.btnProdSearch.Location = new System.Drawing.Point(1235, 116);
            this.btnProdSearch.Name = "btnProdSearch";
            this.btnProdSearch.Size = new System.Drawing.Size(75, 23);
            this.btnProdSearch.TabIndex = 12;
            this.btnProdSearch.Text = "Search";
            this.btnProdSearch.UseVisualStyleBackColor = true;
            this.btnProdSearch.Click += new System.EventHandler(this.btnProdSearch_Click);
            // 
            // btnPartSearch
            // 
            this.btnPartSearch.Location = new System.Drawing.Point(481, 116);
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
            this.labelProducts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelProducts.Location = new System.Drawing.Point(789, 75);
            this.labelProducts.Name = "labelProducts";
            this.labelProducts.Size = new System.Drawing.Size(94, 30);
            this.labelProducts.TabIndex = 9;
            this.labelProducts.Text = "Products";
            // 
            // labelParts
            // 
            this.labelParts.AutoSize = true;
            this.labelParts.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.labelParts.Location = new System.Drawing.Point(35, 76);
            this.labelParts.Name = "labelParts";
            this.labelParts.Size = new System.Drawing.Size(58, 30);
            this.labelParts.TabIndex = 8;
            this.labelParts.Text = "Parts";
            // 
            // btnDelPart
            // 
            this.btnDelPart.Location = new System.Drawing.Point(610, 519);
            this.btnDelPart.Name = "btnDelPart";
            this.btnDelPart.Size = new System.Drawing.Size(75, 23);
            this.btnDelPart.TabIndex = 4;
            this.btnDelPart.Text = "DELETE";
            this.btnDelPart.UseVisualStyleBackColor = true;
            // 
            // btnModPart
            // 
            this.btnModPart.Location = new System.Drawing.Point(610, 457);
            this.btnModPart.Name = "btnModPart";
            this.btnModPart.Size = new System.Drawing.Size(75, 23);
            this.btnModPart.TabIndex = 3;
            this.btnModPart.Text = "MODIFY";
            this.btnModPart.UseVisualStyleBackColor = true;
            this.btnModPart.Click += new System.EventHandler(this.btnModPart_Click);
            // 
            // btnAddPart
            // 
            this.btnAddPart.Location = new System.Drawing.Point(488, 457);
            this.btnAddPart.Name = "btnAddPart";
            this.btnAddPart.Size = new System.Drawing.Size(75, 23);
            this.btnAddPart.TabIndex = 2;
            this.btnAddPart.Text = "ADD";
            this.btnAddPart.UseVisualStyleBackColor = true;
            this.btnAddPart.Click += new System.EventHandler(this.btnAddPart_Click);
            // 
            // dgvParts
            // 
            this.dgvParts.AllowUserToAddRows = false;
            this.dgvParts.AllowUserToDeleteRows = false;
            this.dgvParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvParts.Location = new System.Drawing.Point(35, 155);
            this.dgvParts.MultiSelect = false;
            this.dgvParts.Name = "dgvParts";
            this.dgvParts.ReadOnly = true;
            this.dgvParts.RowTemplate.Height = 25;
            this.dgvParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvParts.Size = new System.Drawing.Size(650, 281);
            this.dgvParts.TabIndex = 15;
            // 
            // dgvProducts
            // 
            this.dgvProducts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvProducts.Location = new System.Drawing.Point(789, 155);
            this.dgvProducts.Name = "dgvProducts";
            this.dgvProducts.RowTemplate.Height = 25;
            this.dgvProducts.Size = new System.Drawing.Size(650, 281);
            this.dgvProducts.TabIndex = 16;
            // 
            // btnAddProduct
            // 
            this.btnAddProduct.Location = new System.Drawing.Point(1242, 457);
            this.btnAddProduct.Name = "btnAddProduct";
            this.btnAddProduct.Size = new System.Drawing.Size(75, 23);
            this.btnAddProduct.TabIndex = 5;
            this.btnAddProduct.Text = "ADD";
            this.btnAddProduct.UseVisualStyleBackColor = true;
            this.btnAddProduct.Click += new System.EventHandler(this.btnAddProduct_Click);
            // 
            // btnModProduct
            // 
            this.btnModProduct.Location = new System.Drawing.Point(1364, 457);
            this.btnModProduct.Name = "btnModProduct";
            this.btnModProduct.Size = new System.Drawing.Size(75, 23);
            this.btnModProduct.TabIndex = 6;
            this.btnModProduct.Text = "MODIFY";
            this.btnModProduct.UseVisualStyleBackColor = true;
            // 
            // btnDelProduct
            // 
            this.btnDelProduct.Location = new System.Drawing.Point(1364, 519);
            this.btnDelProduct.Name = "btnDelProduct";
            this.btnDelProduct.Size = new System.Drawing.Size(75, 23);
            this.btnDelProduct.TabIndex = 7;
            this.btnDelProduct.Text = "DELETE";
            this.btnDelProduct.UseVisualStyleBackColor = true;
            // 
            // searchParts
            // 
            this.searchParts.Location = new System.Drawing.Point(35, 117);
            this.searchParts.Name = "searchParts";
            this.searchParts.Size = new System.Drawing.Size(399, 23);
            this.searchParts.TabIndex = 13;
            // 
            // labelTitle
            // 
            this.labelTitle.AutoSize = true;
            this.labelTitle.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.labelTitle.Location = new System.Drawing.Point(100, 27);
            this.labelTitle.Name = "labelTitle";
            this.labelTitle.Size = new System.Drawing.Size(371, 32);
            this.labelTitle.TabIndex = 17;
            this.labelTitle.Text = "Inventory Management System";
            // 
            // bt_Exit
            // 
            this.bt_Exit.Location = new System.Drawing.Point(1193, 649);
            this.bt_Exit.Name = "bt_Exit";
            this.bt_Exit.Size = new System.Drawing.Size(117, 46);
            this.bt_Exit.TabIndex = 18;
            this.bt_Exit.Text = "EXIT";
            this.bt_Exit.UseVisualStyleBackColor = true;
            this.bt_Exit.Click += new System.EventHandler(this.bt_Exit_Click);
            // 
            // btn_RestSearch
            // 
            this.btn_RestSearch.Location = new System.Drawing.Point(610, 115);
            this.btn_RestSearch.Name = "btn_RestSearch";
            this.btn_RestSearch.Size = new System.Drawing.Size(75, 25);
            this.btn_RestSearch.TabIndex = 20;
            this.btn_RestSearch.Text = "Reset";
            this.btn_RestSearch.UseVisualStyleBackColor = true;
            this.btn_RestSearch.Click += new System.EventHandler(this.btn_RestSearch_Click);
            // 
            // MainScreen
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1504, 720);
            this.Controls.Add(this.btn_RestSearch);
            this.Controls.Add(this.bt_Exit);
            this.Controls.Add(this.labelTitle);
            this.Controls.Add(this.dgvParts);
            this.Controls.Add(this.btnDelProduct);
            this.Controls.Add(this.btnModProduct);
            this.Controls.Add(this.btnPartSearch);
            this.Controls.Add(this.btnAddProduct);
            this.Controls.Add(this.searchParts);
            this.Controls.Add(this.dgvProducts);
            this.Controls.Add(this.labelParts);
            this.Controls.Add(this.searchProducts);
            this.Controls.Add(this.btnProdSearch);
            this.Controls.Add(this.labelProducts);
            this.Controls.Add(this.btnAddPart);
            this.Controls.Add(this.btnModPart);
            this.Controls.Add(this.btnDelPart);
            this.Name = "MainScreen";
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
        private System.Windows.Forms.TextBox searchProducts;
        private System.Windows.Forms.Button btnProdSearch;
        private System.Windows.Forms.Button btnPartSearch;
        private System.Windows.Forms.DataGridView dgvProducts;
        private System.Windows.Forms.DataGridView dgvParts;
        private System.Windows.Forms.Button btnAddProduct;
        private System.Windows.Forms.Button btnModProduct;
        private System.Windows.Forms.Button btnDelProduct;
        private System.Windows.Forms.TextBox searchParts;
        private System.Windows.Forms.Label labelTitle;
        private System.Windows.Forms.Button bt_Exit;
        private System.Windows.Forms.Button btn_RestSearch;
    }
}

