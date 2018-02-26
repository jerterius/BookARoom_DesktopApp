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
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bookingDataGridView = new System.Windows.Forms.DataGridView();
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.Remove = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.lblPasswordAsterix = new System.Windows.Forms.Label();
            this.lblRePasswordAsterix = new System.Windows.Forms.Label();
            this.lblEmailAsterix = new System.Windows.Forms.Label();
            this.bookingNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.customerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).BeginInit();
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
            this.cbTitle.Items.AddRange(new object[] {
            "Mr.",
            "Mrs.",
            "Ms.",
            "Dr."});
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
            this.btnAbort.Text = "Cancel";
            this.btnAbort.UseVisualStyleBackColor = true;
            this.btnAbort.Visible = false;
            this.btnAbort.Click += new System.EventHandler(this.btnAbort_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(626, 283);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(131, 33);
            this.btnSave.TabIndex = 4;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Visible = false;
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
            this.tbxRePassword.Visible = false;
            // 
            // lblRePassword
            // 
            this.lblRePassword.AutoSize = true;
            this.lblRePassword.Location = new System.Drawing.Point(513, 125);
            this.lblRePassword.Name = "lblRePassword";
            this.lblRePassword.Size = new System.Drawing.Size(139, 20);
            this.lblRePassword.TabIndex = 0;
            this.lblRePassword.Text = "Repeat Password:";
            this.lblRePassword.Visible = false;
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
            // Column1
            // 
            this.Column1.DataPropertyName = "BookingNumber";
            this.Column1.HeaderText = "Column1";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // bookingDataGridView
            // 
            this.bookingDataGridView.AllowUserToAddRows = false;
            this.bookingDataGridView.AllowUserToDeleteRows = false;
            this.bookingDataGridView.AutoGenerateColumns = true;
            this.bookingDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.bookingDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.bookingNumberDataGridViewTextBoxColumn,
            this.dateDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.roomNumberDataGridViewTextBoxColumn,
            this.Remove});
            this.bookingDataGridView.DataSource = this.bookingsBindingSource;
            this.bookingDataGridView.Location = new System.Drawing.Point(73, 434);
            this.bookingDataGridView.MultiSelect = false;
            this.bookingDataGridView.Name = "bookingDataGridView";
            this.bookingDataGridView.RowTemplate.Height = 28;
            this.bookingDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.bookingDataGridView.Size = new System.Drawing.Size(879, 220);
            this.bookingDataGridView.TabIndex = 18;
            // 
            // bookingsBindingSource
            // 
            this.bookingsBindingSource.DataMember = "Bookings";
            this.bookingsBindingSource.DataSource = this.customerBindingSource;
            // 
            // Remove
            // 
            this.Remove.HeaderText = "Remove";
            this.Remove.Name = "Remove";
            // 
            // lblPasswordAsterix
            // 
            this.lblPasswordAsterix.AutoSize = true;
            this.lblPasswordAsterix.ForeColor = System.Drawing.Color.Red;
            this.lblPasswordAsterix.Location = new System.Drawing.Point(900, 79);
            this.lblPasswordAsterix.Name = "lblPasswordAsterix";
            this.lblPasswordAsterix.Size = new System.Drawing.Size(15, 20);
            this.lblPasswordAsterix.TabIndex = 0;
            this.lblPasswordAsterix.Text = "*";
            this.lblPasswordAsterix.Visible = false;
            // 
            // lblRePasswordAsterix
            // 
            this.lblRePasswordAsterix.AutoSize = true;
            this.lblRePasswordAsterix.ForeColor = System.Drawing.Color.Red;
            this.lblRePasswordAsterix.Location = new System.Drawing.Point(900, 125);
            this.lblRePasswordAsterix.Name = "lblRePasswordAsterix";
            this.lblRePasswordAsterix.Size = new System.Drawing.Size(15, 20);
            this.lblRePasswordAsterix.TabIndex = 0;
            this.lblRePasswordAsterix.Text = "*";
            this.lblRePasswordAsterix.Visible = false;
            // 
            // lblEmailAsterix
            // 
            this.lblEmailAsterix.AutoSize = true;
            this.lblEmailAsterix.ForeColor = System.Drawing.Color.Red;
            this.lblEmailAsterix.Location = new System.Drawing.Point(464, 289);
            this.lblEmailAsterix.Name = "lblEmailAsterix";
            this.lblEmailAsterix.Size = new System.Drawing.Size(15, 20);
            this.lblEmailAsterix.TabIndex = 0;
            this.lblEmailAsterix.Text = "*";
            this.lblEmailAsterix.Visible = false;
            // 
            // bookingNumberDataGridViewTextBoxColumn
            // 
            this.bookingNumberDataGridViewTextBoxColumn.DataPropertyName = "BookingNumber";
            this.bookingNumberDataGridViewTextBoxColumn.HeaderText = "BookingNumber";
            this.bookingNumberDataGridViewTextBoxColumn.Name = "bookingNumberDataGridViewTextBoxColumn";
            this.bookingNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // dateDataGridViewTextBoxColumn
            // 
            this.dateDataGridViewTextBoxColumn.DataPropertyName = "Date";
            this.dateDataGridViewTextBoxColumn.HeaderText = "Date";
            this.dateDataGridViewTextBoxColumn.Name = "dateDataGridViewTextBoxColumn";
            this.dateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // customerBindingSource
            // 
            this.customerBindingSource.DataSource = typeof(BookARoom.Models.Customer);
            // 
            // UCAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.bookingDataGridView);
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
            this.Controls.Add(this.lblEmailAsterix);
            this.Controls.Add(this.lblRePasswordAsterix);
            this.Controls.Add(this.lblPasswordAsterix);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblTitle);
            this.Name = "UCAccount";
            this.Size = new System.Drawing.Size(1098, 879);
            ((System.ComponentModel.ISupportInitialize)(this.bookingDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.customerBindingSource)).EndInit();
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
        private BindingSource customerBindingSource;
        private DataGridViewTextBoxColumn Column1;
        private DataGridView bookingDataGridView;
        private BindingSource bookingsBindingSource;
        private DataGridViewTextBoxColumn bookingNumberDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn Remove;
        private Label lblPasswordAsterix;
        private Label lblRePasswordAsterix;
        private Label lblEmailAsterix;

        public Button BtnEdit {get; set;}
    }
}
