namespace MobilePhoneStore
{
    partial class ManageProduct
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
            this.gbProductInformation = new System.Windows.Forms.GroupBox();
            this.btUpdate = new System.Windows.Forms.Button();
            this.cbCategory = new System.Windows.Forms.ComboBox();
            this.tbProductQuantity = new System.Windows.Forms.TextBox();
            this.tbProductPrice = new System.Windows.Forms.TextBox();
            this.tbProductName = new System.Windows.Forms.TextBox();
            this.tbProductCode = new System.Windows.Forms.TextBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.lbCategory = new System.Windows.Forms.Label();
            this.lbProductQuantity = new System.Windows.Forms.Label();
            this.lbProductPrice = new System.Windows.Forms.Label();
            this.lbProductName = new System.Windows.Forms.Label();
            this.lbProductCode = new System.Windows.Forms.Label();
            this.gbProductData = new System.Windows.Forms.GroupBox();
            this.dtgProduct = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.btBack = new System.Windows.Forms.Button();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.gbProductInformation.SuspendLayout();
            this.gbProductData.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).BeginInit();
            this.SuspendLayout();
            // 
            // gbProductInformation
            // 
            this.gbProductInformation.Controls.Add(this.btUpdate);
            this.gbProductInformation.Controls.Add(this.cbCategory);
            this.gbProductInformation.Controls.Add(this.tbProductQuantity);
            this.gbProductInformation.Controls.Add(this.tbProductPrice);
            this.gbProductInformation.Controls.Add(this.tbProductName);
            this.gbProductInformation.Controls.Add(this.tbProductCode);
            this.gbProductInformation.Controls.Add(this.btClear);
            this.gbProductInformation.Controls.Add(this.btDelete);
            this.gbProductInformation.Controls.Add(this.btAdd);
            this.gbProductInformation.Controls.Add(this.lbCategory);
            this.gbProductInformation.Controls.Add(this.lbProductQuantity);
            this.gbProductInformation.Controls.Add(this.lbProductPrice);
            this.gbProductInformation.Controls.Add(this.lbProductName);
            this.gbProductInformation.Controls.Add(this.lbProductCode);
            this.gbProductInformation.Location = new System.Drawing.Point(12, 12);
            this.gbProductInformation.Name = "gbProductInformation";
            this.gbProductInformation.Size = new System.Drawing.Size(378, 397);
            this.gbProductInformation.TabIndex = 0;
            this.gbProductInformation.TabStop = false;
            this.gbProductInformation.Text = "Product Information";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(191, 296);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 18;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // cbCategory
            // 
            this.cbCategory.FormattingEnabled = true;
            this.cbCategory.Location = new System.Drawing.Point(158, 253);
            this.cbCategory.Name = "cbCategory";
            this.cbCategory.Size = new System.Drawing.Size(134, 24);
            this.cbCategory.TabIndex = 17;
            // 
            // tbProductQuantity
            // 
            this.tbProductQuantity.Location = new System.Drawing.Point(158, 170);
            this.tbProductQuantity.Name = "tbProductQuantity";
            this.tbProductQuantity.Size = new System.Drawing.Size(134, 22);
            this.tbProductQuantity.TabIndex = 13;
            // 
            // tbProductPrice
            // 
            this.tbProductPrice.Location = new System.Drawing.Point(158, 130);
            this.tbProductPrice.Name = "tbProductPrice";
            this.tbProductPrice.Size = new System.Drawing.Size(134, 22);
            this.tbProductPrice.TabIndex = 12;
            // 
            // tbProductName
            // 
            this.tbProductName.Location = new System.Drawing.Point(158, 90);
            this.tbProductName.Name = "tbProductName";
            this.tbProductName.Size = new System.Drawing.Size(134, 22);
            this.tbProductName.TabIndex = 11;
            // 
            // tbProductCode
            // 
            this.tbProductCode.Location = new System.Drawing.Point(158, 51);
            this.tbProductCode.Name = "tbProductCode";
            this.tbProductCode.Size = new System.Drawing.Size(134, 22);
            this.tbProductCode.TabIndex = 10;
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(191, 336);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 9;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(66, 336);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 8;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(66, 296);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 6;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // lbCategory
            // 
            this.lbCategory.AutoSize = true;
            this.lbCategory.Location = new System.Drawing.Point(30, 253);
            this.lbCategory.Name = "lbCategory";
            this.lbCategory.Size = new System.Drawing.Size(62, 16);
            this.lbCategory.TabIndex = 5;
            this.lbCategory.Text = "Category";
            // 
            // lbProductQuantity
            // 
            this.lbProductQuantity.AutoSize = true;
            this.lbProductQuantity.Location = new System.Drawing.Point(30, 170);
            this.lbProductQuantity.Name = "lbProductQuantity";
            this.lbProductQuantity.Size = new System.Drawing.Size(104, 16);
            this.lbProductQuantity.TabIndex = 3;
            this.lbProductQuantity.Text = "Product Quantity";
            // 
            // lbProductPrice
            // 
            this.lbProductPrice.AutoSize = true;
            this.lbProductPrice.Location = new System.Drawing.Point(30, 130);
            this.lbProductPrice.Name = "lbProductPrice";
            this.lbProductPrice.Size = new System.Drawing.Size(87, 16);
            this.lbProductPrice.TabIndex = 2;
            this.lbProductPrice.Text = "Product Price";
            // 
            // lbProductName
            // 
            this.lbProductName.AutoSize = true;
            this.lbProductName.Location = new System.Drawing.Point(30, 90);
            this.lbProductName.Name = "lbProductName";
            this.lbProductName.Size = new System.Drawing.Size(93, 16);
            this.lbProductName.TabIndex = 1;
            this.lbProductName.Text = "Product Name";
            // 
            // lbProductCode
            // 
            this.lbProductCode.AutoSize = true;
            this.lbProductCode.Location = new System.Drawing.Point(30, 51);
            this.lbProductCode.Name = "lbProductCode";
            this.lbProductCode.Size = new System.Drawing.Size(89, 16);
            this.lbProductCode.TabIndex = 0;
            this.lbProductCode.Text = "Product Code";
            // 
            // gbProductData
            // 
            this.gbProductData.Controls.Add(this.dtgProduct);
            this.gbProductData.Controls.Add(this.tbSearch);
            this.gbProductData.Location = new System.Drawing.Point(396, 12);
            this.gbProductData.Name = "gbProductData";
            this.gbProductData.Size = new System.Drawing.Size(392, 397);
            this.gbProductData.TabIndex = 1;
            this.gbProductData.TabStop = false;
            this.gbProductData.Text = "Product Data";
            // 
            // dtgProduct
            // 
            this.dtgProduct.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgProduct.Location = new System.Drawing.Point(6, 64);
            this.dtgProduct.Name = "dtgProduct";
            this.dtgProduct.RowHeadersWidth = 51;
            this.dtgProduct.RowTemplate.Height = 24;
            this.dtgProduct.Size = new System.Drawing.Size(380, 327);
            this.dtgProduct.TabIndex = 16;
            this.dtgProduct.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellClick);
            this.dtgProduct.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgProduct_CellContentClick);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(242, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(134, 22);
            this.tbSearch.TabIndex = 15;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(29, 415);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 10;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // ManageProduct
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.gbProductData);
            this.Controls.Add(this.gbProductInformation);
            this.Name = "ManageProduct";
            this.Text = "ManageProduct";
            this.gbProductInformation.ResumeLayout(false);
            this.gbProductInformation.PerformLayout();
            this.gbProductData.ResumeLayout(false);
            this.gbProductData.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgProduct)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbProductInformation;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Label lbCategory;
        private System.Windows.Forms.Label lbProductQuantity;
        private System.Windows.Forms.Label lbProductPrice;
        private System.Windows.Forms.Label lbProductName;
        private System.Windows.Forms.Label lbProductCode;
        private System.Windows.Forms.GroupBox gbProductData;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox tbProductQuantity;
        private System.Windows.Forms.TextBox tbProductPrice;
        private System.Windows.Forms.TextBox tbProductName;
        private System.Windows.Forms.TextBox tbProductCode;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ComboBox cbCategory;
        private System.Windows.Forms.DataGridView dtgProduct;
        private System.Windows.Forms.Button btUpdate;
    }
}