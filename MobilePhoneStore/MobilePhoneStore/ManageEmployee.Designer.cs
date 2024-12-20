namespace MobilePhoneStore
{
    partial class ManageEmployee
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
            this.gbManageEmployee = new System.Windows.Forms.GroupBox();
            this.btBack = new System.Windows.Forms.Button();
            this.tbSearch = new System.Windows.Forms.TextBox();
            this.lbEmployeelist = new System.Windows.Forms.Label();
            this.dtgEmployee = new System.Windows.Forms.DataGridView();
            this.gbEmployeeInformation = new System.Windows.Forms.GroupBox();
            this.tbEmployeeCode = new System.Windows.Forms.TextBox();
            this.lbEmployeeCode = new System.Windows.Forms.Label();
            this.btUpdate = new System.Windows.Forms.Button();
            this.btAdd = new System.Windows.Forms.Button();
            this.btClear = new System.Windows.Forms.Button();
            this.btDelete = new System.Windows.Forms.Button();
            this.cbbAuthorityLeve1 = new System.Windows.Forms.ComboBox();
            this.tbPassword = new System.Windows.Forms.TextBox();
            this.tbUsername = new System.Windows.Forms.TextBox();
            this.tbEmployeePosition = new System.Windows.Forms.TextBox();
            this.tbEmployeeName = new System.Windows.Forms.TextBox();
            this.lbPassword = new System.Windows.Forms.Label();
            this.lbUsername = new System.Windows.Forms.Label();
            this.lbAuthorityLeve1 = new System.Windows.Forms.Label();
            this.lbPosition = new System.Windows.Forms.Label();
            this.lbFullName = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gbManageEmployee.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).BeginInit();
            this.gbEmployeeInformation.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbManageEmployee
            // 
            this.gbManageEmployee.Controls.Add(this.btBack);
            this.gbManageEmployee.Controls.Add(this.tbSearch);
            this.gbManageEmployee.Controls.Add(this.lbEmployeelist);
            this.gbManageEmployee.Controls.Add(this.dtgEmployee);
            this.gbManageEmployee.Controls.Add(this.gbEmployeeInformation);
            this.gbManageEmployee.Location = new System.Drawing.Point(12, 12);
            this.gbManageEmployee.Name = "gbManageEmployee";
            this.gbManageEmployee.Size = new System.Drawing.Size(776, 426);
            this.gbManageEmployee.TabIndex = 0;
            this.gbManageEmployee.TabStop = false;
            this.gbManageEmployee.Text = "ManageEmployee";
            this.gbManageEmployee.Enter += new System.EventHandler(this.gbManageEmployee_Enter);
            // 
            // btBack
            // 
            this.btBack.Location = new System.Drawing.Point(30, 386);
            this.btBack.Name = "btBack";
            this.btBack.Size = new System.Drawing.Size(82, 34);
            this.btBack.TabIndex = 17;
            this.btBack.Text = "Back";
            this.btBack.UseVisualStyleBackColor = true;
            this.btBack.Click += new System.EventHandler(this.btBack_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(547, 21);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(142, 22);
            this.tbSearch.TabIndex = 10;
            this.tbSearch.TextChanged += new System.EventHandler(this.tbSearch_TextChanged);
            this.tbSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tbSearch_KeyUp_1);
            // 
            // lbEmployeelist
            // 
            this.lbEmployeelist.AutoSize = true;
            this.lbEmployeelist.Location = new System.Drawing.Point(436, 24);
            this.lbEmployeelist.Name = "lbEmployeelist";
            this.lbEmployeelist.Size = new System.Drawing.Size(92, 16);
            this.lbEmployeelist.TabIndex = 10;
            this.lbEmployeelist.Text = "Employee List";
            // 
            // dtgEmployee
            // 
            this.dtgEmployee.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtgEmployee.Location = new System.Drawing.Point(420, 59);
            this.dtgEmployee.Name = "dtgEmployee";
            this.dtgEmployee.RowHeadersWidth = 51;
            this.dtgEmployee.RowTemplate.Height = 24;
            this.dtgEmployee.Size = new System.Drawing.Size(330, 315);
            this.dtgEmployee.TabIndex = 2;
            this.dtgEmployee.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtgEmployee_CellClick);
            // 
            // gbEmployeeInformation
            // 
            this.gbEmployeeInformation.Controls.Add(this.tbEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.lbEmployeeCode);
            this.gbEmployeeInformation.Controls.Add(this.btUpdate);
            this.gbEmployeeInformation.Controls.Add(this.btAdd);
            this.gbEmployeeInformation.Controls.Add(this.btClear);
            this.gbEmployeeInformation.Controls.Add(this.btDelete);
            this.gbEmployeeInformation.Controls.Add(this.cbbAuthorityLeve1);
            this.gbEmployeeInformation.Controls.Add(this.tbPassword);
            this.gbEmployeeInformation.Controls.Add(this.tbUsername);
            this.gbEmployeeInformation.Controls.Add(this.tbEmployeePosition);
            this.gbEmployeeInformation.Controls.Add(this.tbEmployeeName);
            this.gbEmployeeInformation.Controls.Add(this.lbPassword);
            this.gbEmployeeInformation.Controls.Add(this.lbUsername);
            this.gbEmployeeInformation.Controls.Add(this.lbAuthorityLeve1);
            this.gbEmployeeInformation.Controls.Add(this.lbPosition);
            this.gbEmployeeInformation.Controls.Add(this.lbFullName);
            this.gbEmployeeInformation.Location = new System.Drawing.Point(19, 31);
            this.gbEmployeeInformation.Name = "gbEmployeeInformation";
            this.gbEmployeeInformation.Size = new System.Drawing.Size(352, 349);
            this.gbEmployeeInformation.TabIndex = 0;
            this.gbEmployeeInformation.TabStop = false;
            this.gbEmployeeInformation.Text = "Employee Information";
            // 
            // tbEmployeeCode
            // 
            this.tbEmployeeCode.Location = new System.Drawing.Point(149, 28);
            this.tbEmployeeCode.Name = "tbEmployeeCode";
            this.tbEmployeeCode.Size = new System.Drawing.Size(121, 22);
            this.tbEmployeeCode.TabIndex = 16;
            // 
            // lbEmployeeCode
            // 
            this.lbEmployeeCode.AutoSize = true;
            this.lbEmployeeCode.Location = new System.Drawing.Point(40, 31);
            this.lbEmployeeCode.Name = "lbEmployeeCode";
            this.lbEmployeeCode.Size = new System.Drawing.Size(40, 16);
            this.lbEmployeeCode.TabIndex = 15;
            this.lbEmployeeCode.Text = "Code";
            // 
            // btUpdate
            // 
            this.btUpdate.Location = new System.Drawing.Point(233, 259);
            this.btUpdate.Name = "btUpdate";
            this.btUpdate.Size = new System.Drawing.Size(82, 34);
            this.btUpdate.TabIndex = 14;
            this.btUpdate.Text = "Update";
            this.btUpdate.UseVisualStyleBackColor = true;
            this.btUpdate.Click += new System.EventHandler(this.btUpdate_Click);
            // 
            // btAdd
            // 
            this.btAdd.Location = new System.Drawing.Point(51, 259);
            this.btAdd.Name = "btAdd";
            this.btAdd.Size = new System.Drawing.Size(82, 34);
            this.btAdd.TabIndex = 13;
            this.btAdd.Text = "Add";
            this.btAdd.UseVisualStyleBackColor = true;
            this.btAdd.Click += new System.EventHandler(this.btAdd_Click);
            // 
            // btClear
            // 
            this.btClear.Location = new System.Drawing.Point(233, 309);
            this.btClear.Name = "btClear";
            this.btClear.Size = new System.Drawing.Size(82, 34);
            this.btClear.TabIndex = 12;
            this.btClear.Text = "Clear";
            this.btClear.UseVisualStyleBackColor = true;
            this.btClear.Click += new System.EventHandler(this.btClear_Click);
            // 
            // btDelete
            // 
            this.btDelete.Location = new System.Drawing.Point(51, 309);
            this.btDelete.Name = "btDelete";
            this.btDelete.Size = new System.Drawing.Size(82, 34);
            this.btDelete.TabIndex = 11;
            this.btDelete.Text = "Delete";
            this.btDelete.UseVisualStyleBackColor = true;
            this.btDelete.Click += new System.EventHandler(this.btDelete_Click);
            // 
            // cbbAuthorityLeve1
            // 
            this.cbbAuthorityLeve1.FormattingEnabled = true;
            this.cbbAuthorityLeve1.Location = new System.Drawing.Point(149, 140);
            this.cbbAuthorityLeve1.Name = "cbbAuthorityLeve1";
            this.cbbAuthorityLeve1.Size = new System.Drawing.Size(121, 24);
            this.cbbAuthorityLeve1.TabIndex = 9;
            this.cbbAuthorityLeve1.SelectedIndexChanged += new System.EventHandler(this.cbbAuthorityLeve1_SelectedIndexChanged);
            // 
            // tbPassword
            // 
            this.tbPassword.Location = new System.Drawing.Point(149, 216);
            this.tbPassword.Name = "tbPassword";
            this.tbPassword.Size = new System.Drawing.Size(121, 22);
            this.tbPassword.TabIndex = 8;
            // 
            // tbUsername
            // 
            this.tbUsername.Location = new System.Drawing.Point(149, 178);
            this.tbUsername.Name = "tbUsername";
            this.tbUsername.Size = new System.Drawing.Size(121, 22);
            this.tbUsername.TabIndex = 7;
            // 
            // tbEmployeePosition
            // 
            this.tbEmployeePosition.Location = new System.Drawing.Point(149, 101);
            this.tbEmployeePosition.Name = "tbEmployeePosition";
            this.tbEmployeePosition.Size = new System.Drawing.Size(121, 22);
            this.tbEmployeePosition.TabIndex = 6;
            this.tbEmployeePosition.TextChanged += new System.EventHandler(this.tbPosition_TextChanged);
            // 
            // tbEmployeeName
            // 
            this.tbEmployeeName.Location = new System.Drawing.Point(149, 67);
            this.tbEmployeeName.Name = "tbEmployeeName";
            this.tbEmployeeName.Size = new System.Drawing.Size(121, 22);
            this.tbEmployeeName.TabIndex = 5;
            // 
            // lbPassword
            // 
            this.lbPassword.AutoSize = true;
            this.lbPassword.Location = new System.Drawing.Point(38, 216);
            this.lbPassword.Name = "lbPassword";
            this.lbPassword.Size = new System.Drawing.Size(67, 16);
            this.lbPassword.TabIndex = 4;
            this.lbPassword.Text = "Password";
            // 
            // lbUsername
            // 
            this.lbUsername.AutoSize = true;
            this.lbUsername.Location = new System.Drawing.Point(38, 181);
            this.lbUsername.Name = "lbUsername";
            this.lbUsername.Size = new System.Drawing.Size(70, 16);
            this.lbUsername.TabIndex = 3;
            this.lbUsername.Text = "Username";
            // 
            // lbAuthorityLeve1
            // 
            this.lbAuthorityLeve1.AutoSize = true;
            this.lbAuthorityLeve1.Location = new System.Drawing.Point(40, 143);
            this.lbAuthorityLeve1.Name = "lbAuthorityLeve1";
            this.lbAuthorityLeve1.Size = new System.Drawing.Size(36, 16);
            this.lbAuthorityLeve1.TabIndex = 2;
            this.lbAuthorityLeve1.Text = "Role";
            // 
            // lbPosition
            // 
            this.lbPosition.AutoSize = true;
            this.lbPosition.Location = new System.Drawing.Point(38, 107);
            this.lbPosition.Name = "lbPosition";
            this.lbPosition.Size = new System.Drawing.Size(55, 16);
            this.lbPosition.TabIndex = 1;
            this.lbPosition.Text = "Position";
            // 
            // lbFullName
            // 
            this.lbFullName.AutoSize = true;
            this.lbFullName.Location = new System.Drawing.Point(40, 67);
            this.lbFullName.Name = "lbFullName";
            this.lbFullName.Size = new System.Drawing.Size(65, 16);
            this.lbFullName.TabIndex = 0;
            this.lbFullName.Text = "FullName";
            // 
            // ManageEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbManageEmployee);
            this.Name = "ManageEmployee";
            this.Text = "ManageEmployee";
            this.Load += new System.EventHandler(this.ManageEmployee_Load);
            this.gbManageEmployee.ResumeLayout(false);
            this.gbManageEmployee.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dtgEmployee)).EndInit();
            this.gbEmployeeInformation.ResumeLayout(false);
            this.gbEmployeeInformation.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gbManageEmployee;
        private System.Windows.Forms.GroupBox gbEmployeeInformation;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Label lbEmployeelist;
        private System.Windows.Forms.DataGridView dtgEmployee;
        private System.Windows.Forms.ComboBox cbbAuthorityLeve1;
        private System.Windows.Forms.TextBox tbPassword;
        private System.Windows.Forms.TextBox tbUsername;
        private System.Windows.Forms.TextBox tbEmployeePosition;
        private System.Windows.Forms.TextBox tbEmployeeName;
        private System.Windows.Forms.Label lbPassword;
        private System.Windows.Forms.Label lbUsername;
        private System.Windows.Forms.Label lbAuthorityLeve1;
        private System.Windows.Forms.Label lbPosition;
        private System.Windows.Forms.Label lbFullName;
        private System.Windows.Forms.Button btUpdate;
        private System.Windows.Forms.Button btAdd;
        private System.Windows.Forms.Button btClear;
        private System.Windows.Forms.Button btDelete;
        private System.Windows.Forms.TextBox tbEmployeeCode;
        private System.Windows.Forms.Label lbEmployeeCode;
        private System.Windows.Forms.Button btBack;
        private System.Windows.Forms.TextBox tbSearch;
    }
}