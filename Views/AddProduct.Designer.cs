
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
            this.components = new System.ComponentModel.Container();
            this.addProductTitle = new System.Windows.Forms.Label();
            this.btn_AddProdSearch = new System.Windows.Forms.Button();
            this.tb_AddProdSearch = new System.Windows.Forms.TextBox();
            this.dgvAllParts = new System.Windows.Forms.DataGridView();
            this.dgvAssocParts = new System.Windows.Forms.DataGridView();
            this.label_AllParts = new System.Windows.Forms.Label();
            this.tb_ProductID = new System.Windows.Forms.TextBox();
            this.label_ProductID = new System.Windows.Forms.Label();
            this.label_ProductName = new System.Windows.Forms.Label();
            this.label_ProductInventory = new System.Windows.Forms.Label();
            this.label_ProductPrice = new System.Windows.Forms.Label();
            this.label_ProductMax = new System.Windows.Forms.Label();
            this.label_ProductMin = new System.Windows.Forms.Label();
            this.tb_AddProdName = new System.Windows.Forms.TextBox();
            this.tb_AddProdInventory = new System.Windows.Forms.TextBox();
            this.tb_AddProdPrice = new System.Windows.Forms.TextBox();
            this.tb_AddProdMax = new System.Windows.Forms.TextBox();
            this.tb_AddProdMin = new System.Windows.Forms.TextBox();
            this.btn_AddAssocPart = new System.Windows.Forms.Button();
            this.btn_DelAscPart = new System.Windows.Forms.Button();
            this.btn_ProdCancel = new System.Windows.Forms.Button();
            this.btnSaveProd = new System.Windows.Forms.Button();
            this.label_AssocParts = new System.Windows.Forms.Label();
            this.btn_AddProdResetSrch = new System.Windows.Forms.Button();
            this.label_errorAddProd = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider2 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider3 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider4 = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProvider5 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).BeginInit();
            this.SuspendLayout();
            // 
            // addProductTitle
            // 
            this.addProductTitle.AutoSize = true;
            this.addProductTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.addProductTitle.Location = new System.Drawing.Point(12, 9);
            this.addProductTitle.Name = "addProductTitle";
            this.addProductTitle.Size = new System.Drawing.Size(129, 30);
            this.addProductTitle.TabIndex = 0;
            this.addProductTitle.Text = "Add Product";
            // 
            // btn_AddProdSearch
            // 
            this.btn_AddProdSearch.Location = new System.Drawing.Point(758, 17);
            this.btn_AddProdSearch.Name = "btn_AddProdSearch";
            this.btn_AddProdSearch.Size = new System.Drawing.Size(67, 23);
            this.btn_AddProdSearch.TabIndex = 1;
            this.btn_AddProdSearch.Text = "Search";
            this.btn_AddProdSearch.UseVisualStyleBackColor = true;
            this.btn_AddProdSearch.Click += new System.EventHandler(this.btn_AddProdSearch_Click);
            // 
            // tb_AddProdSearch
            // 
            this.tb_AddProdSearch.Location = new System.Drawing.Point(489, 17);
            this.tb_AddProdSearch.Name = "tb_AddProdSearch";
            this.tb_AddProdSearch.Size = new System.Drawing.Size(263, 23);
            this.tb_AddProdSearch.TabIndex = 2;
            // 
            // dgvAllParts
            // 
            this.dgvAllParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllParts.Location = new System.Drawing.Point(489, 84);
            this.dgvAllParts.MultiSelect = false;
            this.dgvAllParts.Name = "dgvAllParts";
            this.dgvAllParts.ReadOnly = true;
            this.dgvAllParts.RowHeadersVisible = false;
            this.dgvAllParts.RowTemplate.Height = 25;
            this.dgvAllParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllParts.Size = new System.Drawing.Size(601, 281);
            this.dgvAllParts.TabIndex = 3;
            this.dgvAllParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllParts_CellClick);
            // 
            // dgvAssocParts
            // 
            this.dgvAssocParts.AllowUserToAddRows = false;
            this.dgvAssocParts.AllowUserToDeleteRows = false;
            this.dgvAssocParts.AllowUserToResizeRows = false;
            this.dgvAssocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAssocParts.Location = new System.Drawing.Point(489, 457);
            this.dgvAssocParts.MultiSelect = false;
            this.dgvAssocParts.Name = "dgvAssocParts";
            this.dgvAssocParts.ReadOnly = true;
            this.dgvAssocParts.RowHeadersVisible = false;
            this.dgvAssocParts.RowTemplate.Height = 25;
            this.dgvAssocParts.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAssocParts.Size = new System.Drawing.Size(601, 281);
            this.dgvAssocParts.TabIndex = 4;
            this.dgvAssocParts.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAssocParts_CellClick);
            // 
            // label_AllParts
            // 
            this.label_AllParts.AutoSize = true;
            this.label_AllParts.Location = new System.Drawing.Point(489, 63);
            this.label_AllParts.Name = "label_AllParts";
            this.label_AllParts.Size = new System.Drawing.Size(105, 15);
            this.label_AllParts.TabIndex = 5;
            this.label_AllParts.Text = "All candidate Parts";
            // 
            // tb_ProductID
            // 
            this.tb_ProductID.Enabled = false;
            this.tb_ProductID.Location = new System.Drawing.Point(91, 241);
            this.tb_ProductID.Name = "tb_ProductID";
            this.tb_ProductID.Size = new System.Drawing.Size(184, 23);
            this.tb_ProductID.TabIndex = 6;
            // 
            // label_ProductID
            // 
            this.label_ProductID.AutoSize = true;
            this.label_ProductID.Location = new System.Drawing.Point(48, 249);
            this.label_ProductID.Name = "label_ProductID";
            this.label_ProductID.Size = new System.Drawing.Size(18, 15);
            this.label_ProductID.TabIndex = 7;
            this.label_ProductID.Text = "ID";
            // 
            // label_ProductName
            // 
            this.label_ProductName.AutoSize = true;
            this.label_ProductName.Location = new System.Drawing.Point(27, 297);
            this.label_ProductName.Name = "label_ProductName";
            this.label_ProductName.Size = new System.Drawing.Size(39, 15);
            this.label_ProductName.TabIndex = 8;
            this.label_ProductName.Text = "Name";
            // 
            // label_ProductInventory
            // 
            this.label_ProductInventory.AutoSize = true;
            this.label_ProductInventory.Location = new System.Drawing.Point(9, 338);
            this.label_ProductInventory.Name = "label_ProductInventory";
            this.label_ProductInventory.Size = new System.Drawing.Size(57, 15);
            this.label_ProductInventory.TabIndex = 9;
            this.label_ProductInventory.Text = "Inventory";
            // 
            // label_ProductPrice
            // 
            this.label_ProductPrice.AutoSize = true;
            this.label_ProductPrice.Location = new System.Drawing.Point(33, 373);
            this.label_ProductPrice.Name = "label_ProductPrice";
            this.label_ProductPrice.Size = new System.Drawing.Size(33, 15);
            this.label_ProductPrice.TabIndex = 10;
            this.label_ProductPrice.Text = "Price";
            // 
            // label_ProductMax
            // 
            this.label_ProductMax.AutoSize = true;
            this.label_ProductMax.Location = new System.Drawing.Point(36, 411);
            this.label_ProductMax.Name = "label_ProductMax";
            this.label_ProductMax.Size = new System.Drawing.Size(30, 15);
            this.label_ProductMax.TabIndex = 11;
            this.label_ProductMax.Text = "Max";
            // 
            // label_ProductMin
            // 
            this.label_ProductMin.AutoSize = true;
            this.label_ProductMin.Location = new System.Drawing.Point(176, 411);
            this.label_ProductMin.Name = "label_ProductMin";
            this.label_ProductMin.Size = new System.Drawing.Size(28, 15);
            this.label_ProductMin.TabIndex = 12;
            this.label_ProductMin.Text = "Min";
            // 
            // tb_AddProdName
            // 
            this.tb_AddProdName.Location = new System.Drawing.Point(91, 289);
            this.tb_AddProdName.Name = "tb_AddProdName";
            this.tb_AddProdName.Size = new System.Drawing.Size(184, 23);
            this.tb_AddProdName.TabIndex = 13;
            this.tb_AddProdName.TextChanged += new System.EventHandler(this.tb_AddProdName_TextChanged);
            this.tb_AddProdName.Leave += new System.EventHandler(this.tb_AddProdName_Leave);
            // 
            // tb_AddProdInventory
            // 
            this.tb_AddProdInventory.Location = new System.Drawing.Point(91, 335);
            this.tb_AddProdInventory.Name = "tb_AddProdInventory";
            this.tb_AddProdInventory.Size = new System.Drawing.Size(184, 23);
            this.tb_AddProdInventory.TabIndex = 14;
            this.tb_AddProdInventory.TextChanged += new System.EventHandler(this.tb_AddProdInventory_TextChanged);
            this.tb_AddProdInventory.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AddProdInventory_KeyPress);
            this.tb_AddProdInventory.Leave += new System.EventHandler(this.tb_AddProdInventory_Leave);
            // 
            // tb_AddProdPrice
            // 
            this.tb_AddProdPrice.Location = new System.Drawing.Point(91, 373);
            this.tb_AddProdPrice.Name = "tb_AddProdPrice";
            this.tb_AddProdPrice.Size = new System.Drawing.Size(184, 23);
            this.tb_AddProdPrice.TabIndex = 15;
            this.tb_AddProdPrice.TextChanged += new System.EventHandler(this.tb_AddProdPrice_TextChanged);
            this.tb_AddProdPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AddProdPrice_KeyPress);
            this.tb_AddProdPrice.Leave += new System.EventHandler(this.tb_AddProdPrice_Leave);
            // 
            // tb_AddProdMax
            // 
            this.tb_AddProdMax.Location = new System.Drawing.Point(91, 408);
            this.tb_AddProdMax.Name = "tb_AddProdMax";
            this.tb_AddProdMax.Size = new System.Drawing.Size(79, 23);
            this.tb_AddProdMax.TabIndex = 16;
            this.tb_AddProdMax.TextChanged += new System.EventHandler(this.tb_AddProdMax_TextChanged);
            this.tb_AddProdMax.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AddProdMax_KeyPress);
            // 
            // tb_AddProdMin
            // 
            this.tb_AddProdMin.Location = new System.Drawing.Point(210, 408);
            this.tb_AddProdMin.Name = "tb_AddProdMin";
            this.tb_AddProdMin.Size = new System.Drawing.Size(79, 23);
            this.tb_AddProdMin.TabIndex = 17;
            this.tb_AddProdMin.TextChanged += new System.EventHandler(this.tb_AddProdMin_TextChanged);
            this.tb_AddProdMin.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.tb_AddProdMin_KeyPress);
            // 
            // btn_AddAssocPart
            // 
            this.btn_AddAssocPart.Location = new System.Drawing.Point(416, 84);
            this.btn_AddAssocPart.Name = "btn_AddAssocPart";
            this.btn_AddAssocPart.Size = new System.Drawing.Size(67, 31);
            this.btn_AddAssocPart.TabIndex = 18;
            this.btn_AddAssocPart.Text = "Add";
            this.btn_AddAssocPart.UseVisualStyleBackColor = true;
            this.btn_AddAssocPart.Click += new System.EventHandler(this.btn_AddAssocPart_Click);
            // 
            // btn_DelAscPart
            // 
            this.btn_DelAscPart.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.btn_DelAscPart.ForeColor = System.Drawing.Color.White;
            this.btn_DelAscPart.Location = new System.Drawing.Point(416, 457);
            this.btn_DelAscPart.Name = "btn_DelAscPart";
            this.btn_DelAscPart.Size = new System.Drawing.Size(67, 35);
            this.btn_DelAscPart.TabIndex = 19;
            this.btn_DelAscPart.Text = "Delete";
            this.btn_DelAscPart.UseVisualStyleBackColor = false;
            this.btn_DelAscPart.Click += new System.EventHandler(this.btn_DelAscPart_Click);
            // 
            // btn_ProdCancel
            // 
            this.btn_ProdCancel.Location = new System.Drawing.Point(1151, 773);
            this.btn_ProdCancel.Name = "btn_ProdCancel";
            this.btn_ProdCancel.Size = new System.Drawing.Size(72, 35);
            this.btn_ProdCancel.TabIndex = 20;
            this.btn_ProdCancel.Text = "Cancel";
            this.btn_ProdCancel.UseVisualStyleBackColor = true;
            this.btn_ProdCancel.Click += new System.EventHandler(this.btn_ProdCancel_Click);
            // 
            // btnSaveProd
            // 
            this.btnSaveProd.Location = new System.Drawing.Point(1056, 773);
            this.btnSaveProd.Name = "btnSaveProd";
            this.btnSaveProd.Size = new System.Drawing.Size(72, 35);
            this.btnSaveProd.TabIndex = 21;
            this.btnSaveProd.Text = "Save";
            this.btnSaveProd.UseVisualStyleBackColor = true;
            this.btnSaveProd.Click += new System.EventHandler(this.btnSaveProd_Click);
            // 
            // label_AssocParts
            // 
            this.label_AssocParts.AutoSize = true;
            this.label_AssocParts.Location = new System.Drawing.Point(489, 439);
            this.label_AssocParts.Name = "label_AssocParts";
            this.label_AssocParts.Size = new System.Drawing.Size(93, 15);
            this.label_AssocParts.TabIndex = 23;
            this.label_AssocParts.Text = "Associated Parts";
            // 
            // btn_AddProdResetSrch
            // 
            this.btn_AddProdResetSrch.Location = new System.Drawing.Point(831, 17);
            this.btn_AddProdResetSrch.Name = "btn_AddProdResetSrch";
            this.btn_AddProdResetSrch.Size = new System.Drawing.Size(75, 23);
            this.btn_AddProdResetSrch.TabIndex = 24;
            this.btn_AddProdResetSrch.Text = "Reset";
            this.btn_AddProdResetSrch.UseVisualStyleBackColor = true;
            this.btn_AddProdResetSrch.Click += new System.EventHandler(this.btn_AddProdResetSrch_Click);
            // 
            // label_errorAddProd
            // 
            this.label_errorAddProd.AutoSize = true;
            this.label_errorAddProd.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point);
            this.label_errorAddProd.ForeColor = System.Drawing.Color.Red;
            this.label_errorAddProd.Location = new System.Drawing.Point(33, 520);
            this.label_errorAddProd.Name = "label_errorAddProd";
            this.label_errorAddProd.Size = new System.Drawing.Size(0, 18);
            this.label_errorAddProd.TabIndex = 25;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // errorProvider2
            // 
            this.errorProvider2.ContainerControl = this;
            // 
            // errorProvider3
            // 
            this.errorProvider3.ContainerControl = this;
            // 
            // errorProvider4
            // 
            this.errorProvider4.ContainerControl = this;
            // 
            // errorProvider5
            // 
            this.errorProvider5.ContainerControl = this;
            // 
            // AddProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1235, 820);
            this.Controls.Add(this.label_errorAddProd);
            this.Controls.Add(this.btn_AddProdResetSrch);
            this.Controls.Add(this.label_AssocParts);
            this.Controls.Add(this.btnSaveProd);
            this.Controls.Add(this.btn_ProdCancel);
            this.Controls.Add(this.btn_DelAscPart);
            this.Controls.Add(this.btn_AddAssocPart);
            this.Controls.Add(this.tb_AddProdMin);
            this.Controls.Add(this.tb_AddProdMax);
            this.Controls.Add(this.tb_AddProdPrice);
            this.Controls.Add(this.tb_AddProdInventory);
            this.Controls.Add(this.tb_AddProdName);
            this.Controls.Add(this.label_ProductMin);
            this.Controls.Add(this.label_ProductMax);
            this.Controls.Add(this.label_ProductPrice);
            this.Controls.Add(this.label_ProductInventory);
            this.Controls.Add(this.label_ProductName);
            this.Controls.Add(this.label_ProductID);
            this.Controls.Add(this.tb_ProductID);
            this.Controls.Add(this.label_AllParts);
            this.Controls.Add(this.dgvAssocParts);
            this.Controls.Add(this.dgvAllParts);
            this.Controls.Add(this.tb_AddProdSearch);
            this.Controls.Add(this.btn_AddProdSearch);
            this.Controls.Add(this.addProductTitle);
            this.Name = "AddProduct";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Add Product";
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAssocParts)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider5)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addProductTitle;
        private System.Windows.Forms.Button btn_AddProdSearch;
        private System.Windows.Forms.TextBox tb_AddProdSearch;
        private System.Windows.Forms.DataGridView dgvAllParts;
        private System.Windows.Forms.DataGridView dgvAssocParts;
        private System.Windows.Forms.TextBox tb_ProductID;
        private System.Windows.Forms.Label label_ProductID;
        private System.Windows.Forms.Label label_ProductName;
        private System.Windows.Forms.Label label_ProductInventory;
        private System.Windows.Forms.Label label_ProductPrice;
        private System.Windows.Forms.Label label_ProductMax;
        private System.Windows.Forms.Label label_ProductMin;
        private System.Windows.Forms.Button btn_AddAssocPart;
        private System.Windows.Forms.Button btn_DelAscPart;
        private System.Windows.Forms.Button btn_ProdCancel;
        private System.Windows.Forms.Button btnSaveProd;
        private System.Windows.Forms.Label label_AllParts;
        private System.Windows.Forms.Label label_AssocParts;
        private System.Windows.Forms.TextBox tb_AddProdName;
        private System.Windows.Forms.TextBox tb_AddProdInventory;
        private System.Windows.Forms.TextBox tb_AddProdPrice;
        private System.Windows.Forms.TextBox tb_AddProdMax;
        private System.Windows.Forms.TextBox tb_AddProdMin;
        private System.Windows.Forms.Button btn_AddProdResetSrch;
        private System.Windows.Forms.Label label_errorAddProd;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.ErrorProvider errorProvider2;
        private System.Windows.Forms.ErrorProvider errorProvider3;
        private System.Windows.Forms.ErrorProvider errorProvider4;
        private System.Windows.Forms.ErrorProvider errorProvider5;
    }
}