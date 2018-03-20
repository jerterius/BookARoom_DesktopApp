namespace BookARoom.Views
{
    partial class UCEmployee
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.tablesDataGridView = new System.Windows.Forms.DataGridView();
            this.employeeBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.cbSelectedTable = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.tbxAddress = new System.Windows.Forms.TextBox();
            this.lblFirstName = new System.Windows.Forms.Label();
            this.lblLastName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.tbxPhoneNo = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblCompanyName = new System.Windows.Forms.Label();
            this.tbxCompanyName = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnNew = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.lblResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // tablesDataGridView
            // 
            this.tablesDataGridView.AutoGenerateColumns = true;
            this.tablesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.tablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.tablesDataGridView.DataSource = this.employeeBindingSource;
            this.tablesDataGridView.Location = new System.Drawing.Point(19, 361);
            this.tablesDataGridView.MultiSelect = false;
            this.tablesDataGridView.Name = "tablesDataGridView";
            this.tablesDataGridView.RowHeadersVisible = false;
            this.tablesDataGridView.RowTemplate.Height = 28;
            this.tablesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.tablesDataGridView.Size = new System.Drawing.Size(1516, 530);
            this.tablesDataGridView.TabIndex = 1;
            this.tablesDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.TablesDataGridView_CellClick);
            // 
            // cbSelectedTable
            // 
            this.cbSelectedTable.FormattingEnabled = true;
            this.cbSelectedTable.Items.AddRange(new object[] {
            "All Partners",
            "",
            "Content and metadata from Employee and related tables",
            "Employees And Relatives",
            "Employee Absence (2004)",
            "Employees With Most Absence",
            "",
            "All Keys",
            "All Indexes",
            "All Table Constraints",
            "All Tables In Database",
            "All Columns From Employee-Table"});
            this.cbSelectedTable.Location = new System.Drawing.Point(19, 314);
            this.cbSelectedTable.Name = "cbSelectedTable";
            this.cbSelectedTable.Size = new System.Drawing.Size(431, 28);
            this.cbSelectedTable.TabIndex = 2;
            this.cbSelectedTable.SelectedIndexChanged += new System.EventHandler(this.CbSelectedTable_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(15, 277);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(67, 20);
            this.label1.TabIndex = 3;
            this.label1.Text = "Tables:";
            // 
            // tbxAddress
            // 
            this.tbxAddress.Location = new System.Drawing.Point(147, 103);
            this.tbxAddress.Name = "tbxAddress";
            this.tbxAddress.ReadOnly = true;
            this.tbxAddress.Size = new System.Drawing.Size(303, 26);
            this.tbxAddress.TabIndex = 4;
            // 
            // lblFirstName
            // 
            this.lblFirstName.AutoSize = true;
            this.lblFirstName.Location = new System.Drawing.Point(15, 106);
            this.lblFirstName.Name = "lblFirstName";
            this.lblFirstName.Size = new System.Drawing.Size(72, 20);
            this.lblFirstName.TabIndex = 3;
            this.lblFirstName.Text = "Address:";
            // 
            // lblLastName
            // 
            this.lblLastName.AutoSize = true;
            this.lblLastName.Location = new System.Drawing.Point(15, 155);
            this.lblLastName.Name = "lblLastName";
            this.lblLastName.Size = new System.Drawing.Size(83, 20);
            this.lblLastName.TabIndex = 3;
            this.lblLastName.Text = "Phone No:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(15, 203);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(52, 20);
            this.lblAdress.TabIndex = 3;
            this.lblAdress.Text = "Email:";
            // 
            // tbxPhoneNo
            // 
            this.tbxPhoneNo.Location = new System.Drawing.Point(147, 152);
            this.tbxPhoneNo.Name = "tbxPhoneNo";
            this.tbxPhoneNo.ReadOnly = true;
            this.tbxPhoneNo.Size = new System.Drawing.Size(303, 26);
            this.tbxPhoneNo.TabIndex = 4;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(147, 200);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(303, 26);
            this.tbxEmail.TabIndex = 4;
            // 
            // lblCompanyName
            // 
            this.lblCompanyName.AutoSize = true;
            this.lblCompanyName.Location = new System.Drawing.Point(15, 59);
            this.lblCompanyName.Name = "lblCompanyName";
            this.lblCompanyName.Size = new System.Drawing.Size(126, 20);
            this.lblCompanyName.TabIndex = 3;
            this.lblCompanyName.Text = "Company Name:";
            // 
            // tbxCompanyName
            // 
            this.tbxCompanyName.Location = new System.Drawing.Point(147, 56);
            this.tbxCompanyName.Name = "tbxCompanyName";
            this.tbxCompanyName.ReadOnly = true;
            this.tbxCompanyName.Size = new System.Drawing.Size(303, 26);
            this.tbxCompanyName.TabIndex = 4;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(567, 98);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(98, 37);
            this.btnEdit.TabIndex = 5;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.BtnEdit_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(567, 147);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(98, 37);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(567, 51);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(98, 37);
            this.btnNew.TabIndex = 5;
            this.btnNew.Text = "New";
            this.btnNew.UseVisualStyleBackColor = true;
            this.btnNew.Click += new System.EventHandler(this.BtnNew_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(248, 246);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(98, 37);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
            this.btnSave.Click += new System.EventHandler(this.BtnSave_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(352, 246);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(98, 37);
            this.btnCancel.TabIndex = 5;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Visible = false;
            this.btnCancel.Click += new System.EventHandler(this.BtnCancel_Click);
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(15, 905);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(86, 20);
            this.lblResponse.TabIndex = 6;
            this.lblResponse.Text = "Response:";
            this.lblResponse.Visible = false;
            // 
            // UCEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.btnCancel);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnNew);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxPhoneNo);
            this.Controls.Add(this.tbxCompanyName);
            this.Controls.Add(this.tbxAddress);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblLastName);
            this.Controls.Add(this.lblCompanyName);
            this.Controls.Add(this.lblFirstName);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.cbSelectedTable);
            this.Controls.Add(this.tablesDataGridView);
            this.Name = "UCEmployee";
            this.Size = new System.Drawing.Size(1550, 950);
            ((System.ComponentModel.ISupportInitialize)(this.tablesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.employeeBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.DataGridView tablesDataGridView;
        private System.Windows.Forms.ComboBox cbSelectedTable;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.BindingSource employeeBindingSource;
        private System.Windows.Forms.TextBox tbxAddress;
        private System.Windows.Forms.Label lblFirstName;
        private System.Windows.Forms.Label lblLastName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.TextBox tbxPhoneNo;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblCompanyName;
        private System.Windows.Forms.TextBox tbxCompanyName;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnNew;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblResponse;
    }
}
