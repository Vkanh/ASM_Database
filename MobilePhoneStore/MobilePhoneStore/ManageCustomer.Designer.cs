namespace MobilePhoneStore
{
    partial class ManageCustomer
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
            this.btBack = new System.Windows.Forms.Button();
            this.gbCustomerManager = new System.Windows.Forms.GroupBox();
            this.dtgCustomer = new System.Windows.Forms.DataGridView();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbSearch = new System.Windows.Forms.Label();
            this.lbCustomerList = new System.Windows.Forms.Label();
            this.gbCustomerInformation = new System.Windows.Forms.GroupBox();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.tbCustomerAddress = new System.Windows.Forms.TextBox();
            this.tbPhonenumber = new System.Windows.Forms.TextBox();
            this.tbCustomerName = new System.Windows.Forms.TextBox();
            this.tbCustomerCode = new System.Windows.Forms.TextBox();
            this.lbCustomerAddress = new System.Windows.Forms.Label();
            this.lbPhonenumber = new System.Windows.Forms.Label();
            this.lbCustomerName = new System.Windows.Forms.Label();
            this.lbCustomerCode = new System.Windows.Forms.Label();
            this.gbCustomerManager.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).BeginInit();
            this.gbCustomerInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(18, 415);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(75, 23);
            this.btBack.TabIndex = 14;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click_1);
            // 
            // gbCustomerManager
            // 
            this.gbCustomerManager.Controls.Add(this.dtgCustomer);
            this.gbCustomerManager.Controls.Add(this.tbSearch);
            this.gbCustomerManager.Controls.Add(this.lbSearch);
            this.gbCustomerManager.Controls.Add(this.lbCustomerList);
            this.gbCustomerManager.Controls.Add(this.gbCustomerInformation);
            this.gbCustomerManager.Location = new System.Drawing.Point(12, 12);
            this.gbCustomerManager.Name = "gbCustomerManager";
            this.gbCustomerManager.Size = new System.Drawing.Size(776, 388);
            this.gbCustomerManager.TabIndex = 13;
            this.gbCustomerManager.TabStop = false;
            this.gbCustomerManager.Text = "Customer manager";
            // 
            // dtgCustomer
            // 
            this.dtgCustomer.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgCustomer.Location = new System.Drawing.Point(426, 84);
            this.dtgCustomer.Name = "dtgCustomer";
            this.dtgCustomer.RowHeadersWidth = 51;
            this.dtgCustomer.RowTemplate.Height = 24;
            this.dtgCustomer.Size = new System.Drawing.Size(344, 297);
            this.dtgCustomer.TabIndex = 8;
            this.dtgCustomer.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellClick_1);
            this.dtgCustomer.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgCustomer_CellDoubleClick_1);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(619, 39);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(100, 22);
            this.tbSearch.TabIndex = 7;
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp_1);
            // 
            // lbSearch
            // 
            this.lbSearch.AutoSize = true;
            this.lbSearch.Location = new System.Drawing.Point(527, 39);
            this.lbSearch.Name = "lbSearch";
            this.lbSearch.Size = new System.Drawing.Size(50, 16);
            this.lbSearch.TabIndex = 5;
            this.lbSearch.Text = "Search";
            // 
            // lbCustomerList
            // 
            this.lbCustomerList.AutoSize = true;
            this.lbCustomerList.Location = new System.Drawing.Point(413, 39);
            this.lbCustomerList.Name = "lbCustomerList";
            this.lbCustomerList.Size = new System.Drawing.Size(87, 16);
            this.lbCustomerList.TabIndex = 4;
            this.lbCustomerList.Text = "Customer List";
            // 
            // gbCustomerInformation
            // 
            this.gbCustomerInformation.Controls.Add(this.btClear);
            this.gbCustomerInformation.Controls.Add(this.btDelete);
            this.gbCustomerInformation.Controls.Add(this.btUpdate);
            this.gbCustomerInformation.Controls.Add(this.btAdd);
            this.gbCustomerInformation.Controls.Add(this.tbCustomerAddress);
            this.gbCustomerInformation.Controls.Add(this.tbPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.tbCustomerName);
            this.gbCustomerInformation.Controls.Add(this.tbCustomerCode);
            this.gbCustomerInformation.Controls.Add(this.lbCustomerAddress);
            this.gbCustomerInformation.Controls.Add(this.lbPhonenumber);
            this.gbCustomerInformation.Controls.Add(this.lbCustomerName);
            this.gbCustomerInformation.Controls.Add(this.lbCustomerCode);
            this.gbCustomerInformation.Location = new System.Drawing.Point(6, 21);
            this.gbCustomerInformation.Name = "gbCustomerInformation";
            this.gbCustomerInformation.Size = new System.Drawing.Size(382, 360);
            this.gbCustomerInformation.TabIndex = 0;
            this.gbCustomerInformation.TabStop = false;
            this.gbCustomerInformation.Text = "Custormer information";
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(235, 312);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(75, 23);
            this.btClear.TabIndex = 11;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click_1);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(55, 312);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(75, 23);
            this.btDelete.TabIndex = 10;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click_1);
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(235, 274);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(75, 23);
            this.btUpdate.TabIndex = 9;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click_1);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(55, 274);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(75, 23);
            this.btAdd.TabIndex = 8;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click_1);
            // 
            // tbCustomerAddress
            // 
            this.tbCustomerAddress.Location = new System.Drawing.Point(184, 185);
            this.tbCustomerAddress.Multiline = true;
            this.tbCustomerAddress.Name = "tbCustomerAddress";
            this.tbCustomerAddress.Size = new System.Drawing.Size(173, 83);
            this.tbCustomerAddress.TabIndex = 7;
            // 
            // tbPhonenumber
            // 
            this.tbPhonenumber.Location = new System.Drawing.Point(184, 143);
            this.tbPhonenumber.Name = "tbPhonenumber";
            this.tbPhonenumber.Size = new System.Drawing.Size(100, 22);
            this.tbPhonenumber.TabIndex = 6;
            // 
            // tbCustomerName
            // 
            this.tbCustomerName.Location = new System.Drawing.Point(184, 94);
            this.tbCustomerName.Name = "tbCustomerName";
            this.tbCustomerName.Size = new System.Drawing.Size(100, 22);
            this.tbCustomerName.TabIndex = 5;
            // 
            // tbCustomerCode
            // 
            this.tbCustomerCode.Location = new System.Drawing.Point(184, 52);
            this.tbCustomerCode.Name = "tbCustomerCode";
            this.tbCustomerCode.Size = new System.Drawing.Size(100, 22);
            this.tbCustomerCode.TabIndex = 4;
            // 
            // lbCustomerAddress
            // 
            this.lbCustomerAddress.AutoSize = true;
            this.lbCustomerAddress.Location = new System.Drawing.Point(33, 185);
            this.lbCustomerAddress.Name = "lbCustomerAddress";
            this.lbCustomerAddress.Size = new System.Drawing.Size(118, 16);
            this.lbCustomerAddress.TabIndex = 3;
            this.lbCustomerAddress.Text = "Customer Address";
            // 
            // lbPhonenumber
            // 
            this.lbPhonenumber.AutoSize = true;
            this.lbPhonenumber.Location = new System.Drawing.Point(33, 143);
            this.lbPhonenumber.Name = "lbPhonenumber";
            this.lbPhonenumber.Size = new System.Drawing.Size(94, 16);
            this.lbPhonenumber.TabIndex = 2;
            this.lbPhonenumber.Text = "Phone number";
            // 
            // lbCustomerName
            // 
            this.lbCustomerName.AutoSize = true;
            this.lbCustomerName.Location = new System.Drawing.Point(33, 94);
            this.lbCustomerName.Name = "lbCustomerName";
            this.lbCustomerName.Size = new System.Drawing.Size(104, 16);
            this.lbCustomerName.TabIndex = 1;
            this.lbCustomerName.Text = "Customer Name";
            // 
            // lbCustomerCode
            // 
            this.lbCustomerCode.AutoSize = true;
            this.lbCustomerCode.Location = new System.Drawing.Point(33, 52);
            this.lbCustomerCode.Name = "lbCustomerCode";
            this.lbCustomerCode.Size = new System.Drawing.Size(100, 16);
            this.lbCustomerCode.TabIndex = 0;
            this.lbCustomerCode.Text = "Customer Code";
            // 
            // ManageCustomer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btBack);
            this.Controls.Add(this.gbCustomerManager);
            this.Name = "ManageCustomer";
            this.Text = "ManageCustomer";
            this.gbCustomerManager.ResumeLayout(false);
            this.gbCustomerManager.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgCustomer)).EndInit();
            this.gbCustomerInformation.ResumeLayout(false);
            this.gbCustomerInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.GroupBox gbCustomerManager;
        private System.Windows.Forms.DataGridView dtgCustomer;
        private System.Windows.Forms.TextBox tbSearch;
        private System.Windows.Forms.Label lbSearch;
        private System.Windows.Forms.Label lbCustomerList;
        private System.Windows.Forms.GroupBox gbCustomerInformation;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.TextBox tbCustomerAddress;
        private System.Windows.Forms.TextBox tbPhonenumber;
        private System.Windows.Forms.TextBox tbCustomerName;
        private System.Windows.Forms.TextBox tbCustomerCode;
        private System.Windows.Forms.Label lbCustomerAddress;
        private System.Windows.Forms.Label lbPhonenumber;
        private System.Windows.Forms.Label lbCustomerName;
        private System.Windows.Forms.Label lbCustomerCode;
    }
}