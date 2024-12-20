namespace MobilePhoneStore
{
    partial class SaleForm
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
            this.gbSaleFeature = new System.Windows.Forms.GroupBox();
            this.btManageOrder = new System.Windows.Forms.Button();
            this.btManageCustomer = new System.Windows.Forms.Button();
            this.gbSaleFeature.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSaleFeature
            // 
            this.gbSaleFeature.Controls.Add(this.btManageOrder);
            this.gbSaleFeature.Controls.Add(this.btManageCustomer);
            this.gbSaleFeature.Location = new System.Drawing.Point(12, 12);
            this.gbSaleFeature.Name = "gbSaleFeature";
            this.gbSaleFeature.Size = new System.Drawing.Size(776, 426);
            this.gbSaleFeature.TabIndex = 0;
            this.gbSaleFeature.TabStop = false;
            this.gbSaleFeature.Text = "SaleFeature";
            // 
            // btManageOrder
            // 
            this.btManageOrder.Location = new System.Drawing.Point(466, 60);
            this.btManageOrder.Name = "btManageOrder";
            this.btManageOrder.Size = new System.Drawing.Size(209, 84);
            this.btManageOrder.TabIndex = 1;
            this.btManageOrder.Text = "ManageOrder";
            this.btManageOrder.UseVisualStyleBackColor = true;
            this.btManageOrder.Click += new System.EventHandler(this.btManageOrder_Click);
            // 
            // btManageCustomer
            // 
            this.btManageCustomer.Location = new System.Drawing.Point(82, 60);
            this.btManageCustomer.Name = "btManageCustomer";
            this.btManageCustomer.Size = new System.Drawing.Size(209, 84);
            this.btManageCustomer.TabIndex = 0;
            this.btManageCustomer.Text = "ManageCustomer";
            this.btManageCustomer.UseVisualStyleBackColor = true;
            this.btManageCustomer.Click += new System.EventHandler(this.btManageCustomer_Click);
            // 
            // SaleForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbSaleFeature);
            this.Name = "SaleForm";
            this.Text = "SaleForm";
            this.gbSaleFeature.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSaleFeature;
        private System.Windows.Forms.Button btManageOrder;
        private System.Windows.Forms.Button btManageCustomer;
    }
}