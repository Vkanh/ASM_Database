namespace MobilePhoneStore
{
    partial class AdminFrom
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btManageCustomer = new System.Windows.Forms.Button();
            this.btViewStatistic = new System.Windows.Forms.Button();
            this.btManageImport = new System.Windows.Forms.Button();
            this.btManageOrder = new System.Windows.Forms.Button();
            this.btManageProduct = new System.Windows.Forms.Button();
            this.btManageEmployee = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btManageCustomer);
            this.groupBox1.Controls.Add(this.btViewStatistic);
            this.groupBox1.Controls.Add(this.btManageImport);
            this.groupBox1.Controls.Add(this.btManageOrder);
            this.groupBox1.Controls.Add(this.btManageProduct);
            this.groupBox1.Controls.Add(this.btManageEmployee);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(776, 426);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Admin feature";
            // 
            // btManageCustomer
            // 
            this.btManageCustomer.Location = new System.Drawing.Point(82, 134);
            this.btManageCustomer.Name = "btManageCustomer";
            this.btManageCustomer.Size = new System.Drawing.Size(226, 62);
            this.btManageCustomer.TabIndex = 6;
            this.btManageCustomer.Text = "ManageCustomer";
            this.btManageCustomer.UseVisualStyleBackColor = true;
            this.btManageCustomer.Click += new System.EventHandler(this.btManageCustomer_Click_1);
            // 
            // btViewStatistic
            // 
            this.btViewStatistic.Location = new System.Drawing.Point(82, 321);
            this.btViewStatistic.Name = "btViewStatistic";
            this.btViewStatistic.Size = new System.Drawing.Size(588, 62);
            this.btViewStatistic.TabIndex = 5;
            this.btViewStatistic.Text = "ViewStatistic";
            this.btViewStatistic.UseVisualStyleBackColor = true;
            this.btViewStatistic.Click += new System.EventHandler(this.btViewStatistic_Click);
            // 
            // btManageImport
            // 
            this.btManageImport.Location = new System.Drawing.Point(82, 230);
            this.btManageImport.Name = "btManageImport";
            this.btManageImport.Size = new System.Drawing.Size(226, 62);
            this.btManageImport.TabIndex = 4;
            this.btManageImport.Text = "ManageImport";
            this.btManageImport.UseVisualStyleBackColor = true;
            this.btManageImport.Click += new System.EventHandler(this.btManageImport_Click);
            // 
            // btManageOrder
            // 
            this.btManageOrder.Location = new System.Drawing.Point(444, 134);
            this.btManageOrder.Name = "btManageOrder";
            this.btManageOrder.Size = new System.Drawing.Size(226, 62);
            this.btManageOrder.TabIndex = 3;
            this.btManageOrder.Text = "ManageOrder";
            this.btManageOrder.UseVisualStyleBackColor = true;
            this.btManageOrder.Click += new System.EventHandler(this.btManageOrder_Click);
            // 
            // btManageProduct
            // 
            this.btManageProduct.Location = new System.Drawing.Point(444, 38);
            this.btManageProduct.Name = "btManageProduct";
            this.btManageProduct.Size = new System.Drawing.Size(226, 62);
            this.btManageProduct.TabIndex = 1;
            this.btManageProduct.Text = "ManageProduct";
            this.btManageProduct.UseVisualStyleBackColor = true;
            this.btManageProduct.Click += new System.EventHandler(this.btManageProduct_Click);
            // 
            // btManageEmployee
            // 
            this.btManageEmployee.Location = new System.Drawing.Point(82, 38);
            this.btManageEmployee.Name = "btManageEmployee";
            this.btManageEmployee.Size = new System.Drawing.Size(226, 62);
            this.btManageEmployee.TabIndex = 0;
            this.btManageEmployee.Text = "ManageEmployee";
            this.btManageEmployee.UseVisualStyleBackColor = true;
            this.btManageEmployee.Click += new System.EventHandler(this.btManageEmployee_Click);
            // 
            // AdminFrom
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.groupBox1);
            this.Name = "AdminFrom";
            this.Text = "AdminFrom";
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btViewStatistic;
        private System.Windows.Forms.Button btManageImport;
        private System.Windows.Forms.Button btManageOrder;
        private System.Windows.Forms.Button btManageProduct;
        private System.Windows.Forms.Button btManageEmployee;
        private System.Windows.Forms.Button btManageCustomer;
    }
}