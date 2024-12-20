namespace MobilePhoneStore
{
    partial class WarehouseManagerForm
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
            this.gbWarehouseManagerFeature = new System.Windows.Forms.GroupBox();
            this.btManageProduct = new System.Windows.Forms.Button();
            this.gbWarehouseManagerFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbWarehouseManagerFeature
            // 
            this.gbWarehouseManagerFeature.Controls.Add(this.btManageProduct);
            this.gbWarehouseManagerFeature.Location = new System.Drawing.Point(12, 12);
            this.gbWarehouseManagerFeature.Name = "gbWarehouseManagerFeature";
            this.gbWarehouseManagerFeature.Size = new System.Drawing.Size(776, 426);
            this.gbWarehouseManagerFeature.TabIndex = 0;
            this.gbWarehouseManagerFeature.TabStop = false;
            this.gbWarehouseManagerFeature.Text = "WarehouseManagerFeature";
            // 
            // btManageProduct
            // 
            this.btManageProduct.Location = new System.Drawing.Point(60, 62);
            this.btManageProduct.Name = "btManageProduct";
            this.btManageProduct.Size = new System.Drawing.Size(209, 87);
            this.btManageProduct.TabIndex = 0;
            this.btManageProduct.Text = "ManageProduct";
            this.btManageProduct.UseVisualStyleBackColor = true;
            this.btManageProduct.Click += new System.EventHandler(this.btManageProduct_Click);
            // 
            // WarehouseManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbWarehouseManagerFeature);
            this.Name = "WarehouseManagerForm";
            this.Text = "WarehouseManagerForm";
            this.gbWarehouseManagerFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbWarehouseManagerFeature;
        private System.Windows.Forms.Button btManageProduct;
    }
}