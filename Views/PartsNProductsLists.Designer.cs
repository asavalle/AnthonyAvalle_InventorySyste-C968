
namespace InventoryTrackingApp.Views
{
    partial class PartsNProductsLists
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
            this.all_products = new System.Windows.Forms.DataGridView();
            this.all_assocParts = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.all_products)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_assocParts)).BeginInit();
            this.SuspendLayout();
            // 
            // all_products
            // 
            this.all_products.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_products.Location = new System.Drawing.Point(12, 28);
            this.all_products.Name = "all_products";
            this.all_products.RowTemplate.Height = 25;
            this.all_products.Size = new System.Drawing.Size(610, 532);
            this.all_products.TabIndex = 0;
            // 
            // all_assocParts
            // 
            this.all_assocParts.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.all_assocParts.Location = new System.Drawing.Point(762, 28);
            this.all_assocParts.Name = "all_assocParts";
            this.all_assocParts.RowTemplate.Height = 25;
            this.all_assocParts.Size = new System.Drawing.Size(659, 532);
            this.all_assocParts.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label1.Location = new System.Drawing.Point(12, 574);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 21);
            this.label1.TabIndex = 2;
            this.label1.Text = "Products";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.label2.Location = new System.Drawing.Point(762, 574);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(134, 21);
            this.label2.TabIndex = 3;
            this.label2.Text = "Associated Parts";
            // 
            // PartsNProductsLists
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1433, 707);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.all_assocParts);
            this.Controls.Add(this.all_products);
            this.Name = "PartsNProductsLists";
            this.Text = "PartsNProductsLists";
            ((System.ComponentModel.ISupportInitialize)(this.all_products)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.all_assocParts)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView all_products;
        private System.Windows.Forms.DataGridView all_assocParts;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
    }
}