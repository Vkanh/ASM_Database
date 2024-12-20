namespace MobilePhoneStore
{
    partial class OrderHistory
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
            this.gbPurchasehistory = new System.Windows.Forms.GroupBox();
            this.btBack = new System.Windows.Forms.Button();
            this.dtgOrderHistory = new System.Windows.Forms.DataGridView();
            this.gbPurchasehistory.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).BeginInit();
            this.SuspendLayout();
            // 
            // gbPurchasehistory
            // 
            this.gbPurchasehistory.Controls.Add(this.btBack);
            this.gbPurchasehistory.Controls.Add(this.dtgOrderHistory);
            this.gbPurchasehistory.Location = new System.Drawing.Point(12, 12);
            this.gbPurchasehistory.Name = "gbPurchasehistory";
            this.gbPurchasehistory.Size = new System.Drawing.Size(776, 426);
            this.gbPurchasehistory.TabIndex = 1;
            this.gbPurchasehistory.TabStop = false;
            this.gbPurchasehistory.Text = "Purchase history";
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(675, 397);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 1;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // dtgOrderHistory
            // 
            this.dtgOrderHistory.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgOrderHistory.Location = new System.Drawing.Point(6, 39);
            this.dtgOrderHistory.Name = "dtgOrderHistory";
            this.dtgOrderHistory.RowHeadersWidth = 51;
            this.dtgOrderHistory.RowTemplate.Height = 24;
            this.dtgOrderHistory.Size = new System.Drawing.Size(764, 341);
            this.dtgOrderHistory.TabIndex = 0;
            // 
            // OrderHistory
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbPurchasehistory);
            this.Name = "OrderHistory";
            this.Text = "OrderHistory";
            this.gbPurchasehistory.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dtgOrderHistory)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbPurchasehistory;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.DataGridView dtgOrderHistory;
    }
}