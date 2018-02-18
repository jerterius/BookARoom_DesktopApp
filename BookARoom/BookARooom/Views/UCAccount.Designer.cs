using System.Windows.Forms;

namespace BookARoom.Views
{
    partial class UCAccount
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
            this.lblTitle = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.lblAdress = new System.Windows.Forms.Label();
            this.lblTelephone = new System.Windows.Forms.Label();
            this.lblEmail = new System.Windows.Forms.Label();
            this.cbTitle = new System.Windows.Forms.ComboBox();
            this.tbxName = new System.Windows.Forms.TextBox();
            this.tbxAdress = new System.Windows.Forms.TextBox();
            this.tbxTelephone = new System.Windows.Forms.TextBox();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.lblPassword = new System.Windows.Forms.Label();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.btnEdit = new System.Windows.Forms.Button();
            this.btnAbort = new System.Windows.Forms.Button();
            this.btnSave = new System.Windows.Forms.Button();
            this.tbxRePassword = new System.Windows.Forms.TextBox();
            this.lblRePassword = new System.Windows.Forms.Label();
            this.lblStatus = new System.Windows.Forms.Label();
            this.bookingsDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn7 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(27, 79);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(42, 20);
            this.lblTitle.TabIndex = 0;
            this.lblTitle.Text = "Title:";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(27, 128);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(55, 20);
            this.lblName.TabIndex = 0;
            this.lblName.Text = "Name:";
            // 
            // lblAdress
            // 
            this.lblAdress.AutoSize = true;
            this.lblAdress.Location = new System.Drawing.Point(27, 181);
            this.lblAdress.Name = "lblAdress";
            this.lblAdress.Size = new System.Drawing.Size(63, 20);
            this.lblAdress.TabIndex = 0;
            this.lblAdress.Text = "Adress:";
            // 
            // lblTelephone
            // 
            this.lblTelephone.AutoSize = true;
            this.lblTelephone.Location = new System.Drawing.Point(27, 235);
            this.lblTelephone.Name = "lblTelephone";
            this.lblTelephone.Size = new System.Drawing.Size(88, 20);
            this.lblTelephone.TabIndex = 0;
            this.lblTelephone.Text = "Telephone:";
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Location = new System.Drawing.Point(27, 289);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(57, 20);
            this.lblEmail.TabIndex = 0;
            this.lblEmail.Text = "E-Mail:";
            // 
            // cbTitle
            // 
            this.cbTitle.Enabled = false;
            this.cbTitle.FormattingEnabled = true;
            this.cbTitle.Location = new System.Drawing.Point(138, 76);
            this.cbTitle.Name = "cbTitle";
            this.cbTitle.Size = new System.Drawing.Size(121, 28);
            this.cbTitle.TabIndex = 1;
            // 
            // tbxName
            // 
            this.tbxName.Location = new System.Drawing.Point(138, 125);
            this.tbxName.Name = "tbxName";
            this.tbxName.ReadOnly = true;
            this.tbxName.Size = new System.Drawing.Size(320, 26);
            this.tbxName.TabIndex = 2;
            // 
            // tbxAdress
            // 
            this.tbxAdress.Location = new System.Drawing.Point(138, 178);
            this.tbxAdress.Name = "tbxAdress";
            this.tbxAdress.ReadOnly = true;
            this.tbxAdress.Size = new System.Drawing.Size(320, 26);
            this.tbxAdress.TabIndex = 2;
            // 
            // tbxTelephone
            // 
            this.tbxTelephone.Location = new System.Drawing.Point(138, 232);
            this.tbxTelephone.Name = "tbxTelephone";
            this.tbxTelephone.ReadOnly = true;
            this.tbxTelephone.Size = new System.Drawing.Size(320, 26);
            this.tbxTelephone.TabIndex = 2;
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(138, 286);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.ReadOnly = true;
            this.tbxEmail.Size = new System.Drawing.Size(320, 26);
            this.tbxEmail.TabIndex = 2;
            this.tbxEmail.TextChanged += new System.EventHandler(this.tbxEmail_TextChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Location = new System.Drawing.Point(513, 79);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(82, 20);
            this.lblPassword.TabIndex = 0;
            this.lblPassword.Text = "Password:";
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(658, 76);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.ReadOnly = true;
            this.tbxPassword.Size = new System.Drawing.Size(236, 26);
            this.tbxPassword.TabIndex = 2;
            this.tbxPassword.UseSystemPasswordChar = true;
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(763, 17);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(131, 33);
            this.btnEdit.TabIndex = 4;
            this.btnEdit.Text = "Edit";
            this.btnEdit.UseVisualStyleBackColor = true;
            this.btnEdit.Click += new System.EventHandler(this.btnEdit_Click);
            // 
            // btnAbort
            // 
            this.btnAbort.Location = new System.Drawing.Point(763, 283);
            this.btnAbort.Name = "btnAbort";
            this.btnAbort.Size = new System.Drawing.Size(131, 33);
            this.btnAbort.TabIndex = 4;
            this.btnAbort.Text = "Abort";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Click += new System.EventHandler(this.UCAccount_Load);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(626, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // tbxRePassword
            // 
            this.tbxRePassword.Location = new System.Drawing.Point(658, 122);
            this.tbxRePassword.Name = "tbxRePassword";
            this.tbxRePassword.PasswordChar = '*';
            this.tbxRePassword.ReadOnly = true;
            this.tbxRePassword.Size = new System.Drawing.Size(236, 26);
            this.tbxRePassword.TabIndex = 2;
            this.tbxRePassword.UseSystemPasswordChar = true;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(513, 125);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(139, 20);
            this.lblRePassword.TabIndex = 0;
            this.lblRePassword.Text = "Repeat Password:";
            // 
            // lblStatus
            // 
            this.lblStatus.AutoSize = true;
            this.lblStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStatus.ForeColor = System.Drawing.Color.Red;
            this.lblStatus.Location = new System.Drawing.Point(538, 197);
            this.lblStatus.Name = "lblStatus";
            this.lblStatus.Size = new System.Drawing.Size(62, 20);
            this.lblStatus.TabIndex = 0;
            this.lblStatus.Text = "Status";
            this.lblStatus.Visible = false;
            // 
            // bookingsDataGridView
            // 
            this.bookingsDataGridView.AutoGenerateColumns = false;
            this.bookingsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6,
            this.dataGridViewTextBoxColumn7});
            this.bookingsDataGridView.DataSource = this.bookingsBindingSource;
            this.bookingsDataGridView.Location = new System.Drawing.Point(22, 352);
            this.bookingsDataGridView.Name = "bookingsDataGridView";
            this.bookingsDataGridView.RowTemplate.Height = 28;
            this.bookingsDataGridView.Size = new System.Drawing.Size(982, 268);
            this.bookingsDataGridView.TabIndex = 20;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "BookingNumber";
            this.dataGridViewTextBoxColumn1.HeaderText = "BookingNumber";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Date";
            this.dataGridViewTextBoxColumn2.HeaderText = "Date";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "CEmail";
            this.dataGridViewTextBoxColumn3.HeaderText = "CEmail";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn4.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "RoomNumber";
            this.dataGridViewTextBoxColumn5.HeaderText = "RoomNumber";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Customer";
            this.dataGridViewTextBoxColumn6.HeaderText = "Customer";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            // 
            // dataGridViewTextBoxColumn7
            // 
            this.dataGridViewTextBoxColumn7.DataPropertyName = "Room";
            this.dataGridViewTextBoxColumn7.HeaderText = "Room";
            this.dataGridViewTextBoxColumn7.Name = "dataGridViewTextBoxColumn7";
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataSource = typeof(BookARoom.Models.Booking);
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingsDataGridView);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.btnAbort);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.tbxTelephone);
            this.Controls.Add(this.tbxAdress);
            this.Controls.Add(this.tbxRePassword);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxName);
            this.Controls.Add(this.cbTitle);
            this.Controls.Add(this.lblStatus);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.lblTelephone);
            this.Controls.Add(this.lblAdress);
            this.Controls.Add(this.lblRePassword);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(1024, 647);
            this.Load += new System.EventHandler(this.UCAccount_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bookingsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTitle;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.Label lblAdress;
        private System.Windows.Forms.Label lblTelephone;
        private System.Windows.Forms.Label lblEmail;
        private System.Windows.Forms.ComboBox cbTitle;
        private System.Windows.Forms.TextBox tbxName;
        private System.Windows.Forms.TextBox tbxAdress;
        private System.Windows.Forms.TextBox tbxTelephone;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.Label lblPassword;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Button btnEdit;
        private System.Windows.Forms.Button btnAbort;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.TextBox tbxRePassword;
        private System.Windows.Forms.Label lblRePassword;
        private Label lblStatus;
        private BindingSource bookingsBindingSource;
        private DataGridView bookingsDataGridView;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private DataGridViewTextBoxColumn dataGridViewTextBoxColumn7;

        public Button BtnEdit {get; set;}
    }
}
