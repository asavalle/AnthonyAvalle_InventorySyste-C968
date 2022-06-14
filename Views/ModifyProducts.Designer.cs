
namespace InventoryTrackingApp.Views
{
    partial class ModifyProducts
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
            this.label_AssocParts = new System.Windows.Forms.Label();
            this.btn_ModSaveProd = new System.Windows.Forms.Button();
            this.btn_ModProdCancel = new System.Windows.Forms.Button();
            this.btn_ModDelProduct = new System.Windows.Forms.Button();
            this.btn_ModAssocPart = new System.Windows.Forms.Button();
            this.tb_ModProdMin = new System.Windows.Forms.TextBox();
            this.tb_ModProdMax = new System.Windows.Forms.TextBox();
            this.tb_ModProdPrice = new System.Windows.Forms.TextBox();
            this.tb_ModProdInventory = new System.Windows.Forms.TextBox();
            this.tb_ModProdName = new System.Windows.Forms.TextBox();
            this.label_ProductMin = new System.Windows.Forms.Label();
            this.label_ProductMax = new System.Windows.Forms.Label();
            this.label_ProductPrice = new System.Windows.Forms.Label();
            this.label_ProductInventory = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_ProductID = new System.Windows.Forms.Label();
            this.tb_ModProductID = new System.Windows.Forms.TextBox();
            this.label_AllParts = new System.Windows.Forms.Label();
            this.dgvModAssocParts = new System.Windows.Forms.DataGridView();
            this.dgvModAllParts = new System.Windows.Forms.DataGridView();
            this.tb_ModProdSearch = new System.Windows.Forms.TextBox();
            this.btn_ModSearchProduct = new System.Windows.Forms.Button();
            this.ModifyProductTitle = new System.Windows.Forms.Label();
            this.btn_ModProdResetSrch = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAllParts)).BeginInit();
            this.SuspendLayout();
            // 
            // label_AssocParts
            // 
            this.label_AssocParts.AutoSize = true;
            this.label_AssocParts.Location = new System.Drawing.Point(489, 442);
            this.label_AssocParts.Name = "label_AssocParts";
            this.label_AssocParts.Size = new System.Drawing.Size(93, 15);
            this.label_AssocParts.TabIndex = 47;
            this.label_AssocParts.Text = "Associated Parts";
            // 
            // btn_ModSaveProd
            // 
            this.btn_ModSaveProd.Enabled = false;
            this.btn_ModSaveProd.Location = new System.Drawing.Point(1056, 773);
            this.btn_ModSaveProd.Name = "btn_ModSaveProd";
            this.btn_ModSaveProd.Size = new System.Drawing.Size(72, 35);
            this.btn_ModSaveProd.TabIndex = 45;
            this.btn_ModSaveProd.Text = "Save";
            this.btn_ModSaveProd.UseVisualStyleBackColor = true;
            this.btn_ModSaveProd.Click += new System.EventHandler(this.btn_ModSaveProd_Click);
            // 
            // btn_ModProdCancel
            // 
            this.btn_ModProdCancel.Location = new System.Drawing.Point(1151, 773);
            this.btn_ModProdCancel.Name = "btn_ModProdCancel";
            this.btn_ModProdCancel.Size = new System.Drawing.Size(72, 35);
            this.btn_ModProdCancel.TabIndex = 44;
            this.btn_ModProdCancel.Text = "Cancel";
            this.btn_ModProdCancel.UseVisualStyleBackColor = true;
            this.btn_ModProdCancel.Click += new System.EventHandler(this.btn_ModProdCancel_Click);
            // 
            // btn_ModDelProduct
            // 
            this.btn_ModDelProduct.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_ModDelProduct.ForeColor = System.Drawing.Color.White;
            this.btn_ModDelProduct.Location = new System.Drawing.Point(413, 459);
            this.btn_ModDelProduct.Name = "btn_ModDelProduct";
            this.btn_ModDelProduct.Size = new System.Drawing.Size(70, 34);
            this.btn_ModDelProduct.TabIndex = 43;
            this.btn_ModDelProduct.Text = "Delete";
            this.btn_ModDelProduct.UseVisualStyleBackColor = false;
            this.btn_ModDelProduct.Click += new System.EventHandler(this.btn_ModDelProduct_Click);
            // 
            // btn_ModAssocPart
            // 
            this.btn_ModAssocPart.Location = new System.Drawing.Point(413, 84);
            this.btn_ModAssocPart.Name = "btn_ModAssocPart";
            this.btn_ModAssocPart.Size = new System.Drawing.Size(70, 31);
            this.btn_ModAssocPart.TabIndex = 42;
            this.btn_ModAssocPart.Text = "Add";
            this.btn_ModAssocPart.UseVisualStyleBackColor = true;
            this.btn_ModAssocPart.Click += new System.EventHandler(this.btn_ModAssocPart_Click);
            // 
            // tb_ModProdMin
            // 
            this.tb_ModProdMin.Location = new System.Drawing.Point(210, 408);
            this.tb_ModProdMin.Name = "tb_ModProdMin";
            this.tb_ModProdMin.Size = new System.Drawing.Size(79, 23);
            this.tb_ModProdMin.TabIndex = 41;
            // 
            // tb_ModProdMax
            // 
            this.tb_ModProdMax.Location = new System.Drawing.Point(91, 408);
            this.tb_ModProdMax.Name = "tb_ModProdMax";
            this.tb_ModProdMax.Size = new System.Drawing.Size(79, 23);
            this.tb_ModProdMax.TabIndex = 40;
            // 
            // tb_ModProdPrice
            // 
            this.tb_ModProdPrice.Location = new System.Drawing.Point(91, 373);
            this.tb_ModProdPrice.Name = "tb_ModProdPrice";
            this.tb_ModProdPrice.Size = new System.Drawing.Size(184, 23);
            this.tb_ModProdPrice.TabIndex = 39;
            // 
            // tb_ModProdInventory
            // 
            this.tb_ModProdInventory.Location = new System.Drawing.Point(91, 335);
            this.tb_ModProdInventory.Name = "tb_ModProdInventory";
            this.tb_ModProdInventory.Size = new System.Drawing.Size(184, 23);
            this.tb_ModProdInventory.TabIndex = 38;
            // 
            // tb_ModProdName
            // 
            this.tb_ModProdName.Location = new System.Drawing.Point(91, 289);
            this.tb_ModProdName.Name = "tb_ModProdName";
            this.tb_ModProdName.Size = new System.Drawing.Size(184, 23);
            this.tb_ModProdName.TabIndex = 37;
            this.tb_ModProdName.TextChanged += new System.EventHandler(this.tb_ModProdName_TextChanged);
            // 
            // label_ProductMin
            // 
            this.label_ProductMin.AutoSize = true;
            this.label_ProductMin.Location = new System.Drawing.Point(176, 411);
            this.label_ProductMin.Name = "label_ProductMin";
            this.label_ProductMin.Size = new System.Drawing.Size(28, 15);
            this.label_ProductMin.TabIndex = 36;
            this.label_ProductMin.Text = "Min";
            // 
            // label_ProductMax
            // 
            this.label_ProductMax.AutoSize = true;
            this.label_ProductMax.Location = new System.Drawing.Point(36, 411);
            this.label_ProductMax.Name = "label_ProductMax";
            this.label_ProductMax.Size = new System.Drawing.Size(30, 15);
            this.label_ProductMax.TabIndex = 35;
            this.label_ProductMax.Text = "Max";
            // 
            // label_ProductPrice
            // 
            this.label_ProductPrice.AutoSize = true;
            this.label_ProductPrice.Location = new System.Drawing.Point(33, 373);
            this.label_ProductPrice.Name = "label_ProductPrice";
            this.label_ProductPrice.Size = new System.Drawing.Size(33, 15);
            this.label_ProductPrice.TabIndex = 34;
            this.label_ProductPrice.Text = "Price";
            // 
            // label_ProductInventory
            // 
            this.label_ProductInventory.AutoSize = true;
            this.label_ProductInventory.Location = new System.Drawing.Point(9, 338);
            this.label_ProductInventory.Name = "label_ProductInventory";
            this.label_ProductInventory.Size = new System.Drawing.Size(57, 15);
            this.label_ProductInventory.TabIndex = 33;
            this.label_ProductInventory.Text = "Inventory";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(27, 297);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(39, 15);
            this.label_ProductName.TabIndex = 32;
            this.label_ProductName.Text = "Name";
            // 
            // label_ProductID
            // 
            this.label_ProductID.AutoSize = true;
            this.label_ProductID.Location = new System.Drawing.Point(48, 249);
            this.label_ProductID.Name = "label_ProductID";
            this.label_ProductID.Size = new System.Drawing.Size(18, 15);
            this.label_ProductID.TabIndex = 31;
            this.label_ProductID.Text = "ID";
            // 
            // tb_ModProductID
            // 
            this.tb_ModProductID.Enabled = false;
            this.tb_ModProductID.Location = new System.Drawing.Point(91, 241);
            this.tb_ModProductID.Name = "tb_ModProductID";
            this.tb_ModProductID.Size = new System.Drawing.Size(184, 23);
            this.tb_ModProductID.TabIndex = 30;
            // 
            // label_AllParts
            // 
            this.label_AllParts.AutoSize = true;
            this.label_AllParts.Location = new System.Drawing.Point(489, 66);
            this.label_AllParts.Name = "label_AllParts";
            this.label_AllParts.Size = new System.Drawing.Size(105, 15);
            this.label_AllParts.TabIndex = 29;
            this.label_AllParts.Text = "All candidate Parts";
            // 
            // dgvModAssocParts
            // 
            this.dgvModAssocParts.AllowUserToAddRows = false;
            this.dgvModAssocParts.AllowUserToDeleteRows = false;
            this.dgvModAssocParts.AllowUserToResizeRows = false;
            this.dgvModAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModAssocParts.Location = new System.Drawing.Point(489, 457);
            this.dgvModAssocParts.MultiSelect = false;
            this.dgvModAssocParts.Name = "dgvModAssocParts";
            this.dgvModAssocParts.RowTemplate.Height = 25;
            this.dgvModAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModAssocParts.Size = new System.Drawing.Size(601, 281);
            this.dgvModAssocParts.TabIndex = 28;
            this.dgvModAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModAssocParts_CellClick);
            // 
            // dgvModAllParts
            // 
            this.dgvModAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvModAllParts.Location = new System.Drawing.Point(489, 84);
            this.dgvModAllParts.MultiSelect = false;
            this.dgvModAllParts.Name = "dgvModAllParts";
            this.dgvModAllParts.RowTemplate.Height = 25;
            this.dgvModAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvModAllParts.Size = new System.Drawing.Size(601, 281);
            this.dgvModAllParts.TabIndex = 27;
            this.dgvModAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvModAllParts_CellClick);
            // 
            // tb_ModProdSearch
            // 
            this.tb_ModProdSearch.Location = new System.Drawing.Point(486, 19);
            this.tb_ModProdSearch.Name = "tb_ModProdSearch";
            this.tb_ModProdSearch.Size = new System.Drawing.Size(263, 23);
            this.tb_ModProdSearch.TabIndex = 26;
            // 
            // btn_ModSearchProduct
            // 
            this.btn_ModSearchProduct.Location = new System.Drawing.Point(755, 19);
            this.btn_ModSearchProduct.Name = "btn_ModSearchProduct";
            this.btn_ModSearchProduct.Size = new System.Drawing.Size(67, 23);
            this.btn_ModSearchProduct.TabIndex = 25;
            this.btn_ModSearchProduct.Text = "Search";
            this.btn_ModSearchProduct.UseVisualStyleBackColor = true;
            this.btn_ModSearchProduct.Click += new System.EventHandler(this.btn_ModSearchProduct_Click);
            // 
            // ModifyProductTitle
            // 
            this.ModifyProductTitle.AutoSize = true;
            this.ModifyProductTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.ModifyProductTitle.Location = new System.Drawing.Point(12, 9);
            this.ModifyProductTitle.Name = "ModifyProductTitle";
            this.ModifyProductTitle.Size = new System.Drawing.Size(156, 30);
            this.ModifyProductTitle.TabIndex = 24;
            this.ModifyProductTitle.Text = "Modify Product";
            // 
            // btn_ModProdResetSrch
            // 
            this.btn_ModProdResetSrch.Location = new System.Drawing.Point(828, 19);
            this.btn_ModProdResetSrch.Name = "btn_ModProdResetSrch";
            this.btn_ModProdResetSrch.Size = new System.Drawing.Size(75, 23);
            this.btn_ModProdResetSrch.TabIndex = 48;
            this.btn_ModProdResetSrch.Text = "Reset";
            this.btn_ModProdResetSrch.UseVisualStyleBackColor = true;
            this.btn_ModProdResetSrch.Click += new System.EventHandler(this.btn_ModProdResetSrch_Click);
            // 
            // ModifyProducts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 820);
            this.Controls.Add(this.btn_ModProdResetSrch);
            this.Controls.Add(this.label_AssocParts);
            this.Controls.Add(this.btn_ModSaveProd);
            this.Controls.Add(this.btn_ModProdCancel);
            this.Controls.Add(this.btn_ModDelProduct);
            this.Controls.Add(this.btn_ModAssocPart);
            this.Controls.Add(this.tb_ModProdMin);
            this.Controls.Add(this.tb_ModProdMax);
            this.Controls.Add(this.tb_ModProdPrice);
            this.Controls.Add(this.tb_ModProdInventory);
            this.Controls.Add(this.tb_ModProdName);
            this.Controls.Add(this.label_ProductMin);
            this.Controls.Add(this.label_ProductMax);
            this.Controls.Add(this.label_ProductPrice);
            this.Controls.Add(this.label_ProductInventory);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_ProductID);
            this.Controls.Add(this.tb_ModProductID);
            this.Controls.Add(this.label_AllParts);
            this.Controls.Add(this.dgvModAssocParts);
            this.Controls.Add(this.dgvModAllParts);
            this.Controls.Add(this.tb_ModProdSearch);
            this.Controls.Add(this.btn_ModSearchProduct);
            this.Controls.Add(this.ModifyProductTitle);
            this.Name = "ModifyProducts";
            this.Text = "ModifyProducts";
            this.Load += new System.EventHandler(this.ModifyProducts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvModAllParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label_AssocParts;
        private System.Windows.Forms.Button btn_ModSaveProd;
        private System.Windows.Forms.Button btn_ModProdCancel;
        private System.Windows.Forms.Button btn_ModDelProduct;
        private System.Windows.Forms.Button btn_ModAssocPart;
        private System.Windows.Forms.TextBox tb_ModProdMin;
        private System.Windows.Forms.TextBox tb_ModProdMax;
        private System.Windows.Forms.TextBox tb_ModProdPrice;
        private System.Windows.Forms.TextBox tb_ModProdInventory;
        private System.Windows.Forms.TextBox tb_ModProdName;
        private System.Windows.Forms.Label label_ProductMin;
        private System.Windows.Forms.Label label_ProductMax;
        private System.Windows.Forms.Label label_ProductPrice;
        private System.Windows.Forms.Label label_ProductInventory;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_ProductID;
        private System.Windows.Forms.TextBox tb_ModProductID;
        private System.Windows.Forms.Label label_AllParts;
        private System.Windows.Forms.DataGridView dgvModAssocParts;
        private System.Windows.Forms.DataGridView dgvModAllParts;
        private System.Windows.Forms.TextBox tb_ModProdSearch;
        private System.Windows.Forms.Button btn_ModSearchProduct;
        private System.Windows.Forms.Label ModifyProductTitle;
        private System.Windows.Forms.Button btn_ModProdResetSrch;
    }
}