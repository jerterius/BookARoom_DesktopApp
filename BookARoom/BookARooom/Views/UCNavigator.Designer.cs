namespace BookARoom.Views
{
    partial class UCNavigator
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
            this.btnClear = new System.Windows.Forms.Button();
            this.btnSubmit = new System.Windows.Forms.Button();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.cbCountry = new System.Windows.Forms.ComboBox();
            this.cbCity = new System.Windows.Forms.ComboBox();
            this.tbGuests = new System.Windows.Forms.TrackBar();
            this.dtpFromDate = new System.Windows.Forms.DateTimePicker();
            this.dtpToDate = new System.Windows.Forms.DateTimePicker();
            this.lblFromDate = new System.Windows.Forms.Label();
            this.lblToDate = new System.Windows.Forms.Label();
            this.clbRoomStandard = new System.Windows.Forms.CheckedListBox();
            this.lblGuests = new System.Windows.Forms.Label();
            this.tbStandard = new System.Windows.Forms.TrackBar();
            this.lblStandard = new System.Windows.Forms.Label();
            this.hotelDataGridView = new System.Windows.Forms.DataGridView();
            this.dataGridViewTextBoxColumn1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dataGridViewTextBoxColumn6 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.hotelBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.roomsDataGridView = new System.Windows.Forms.DataGridView();
            this.roomNumberDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.bedDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.smokeFreeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.priceDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.guestCapacityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.adressDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Booking = new System.Windows.Forms.DataGridViewButtonColumn();
            this.roomsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bookingsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(135, 441);
            this.btnClear.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(127, 33);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 441);
            this.btnSubmit.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(127, 33);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Search";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(4, 46);
            this.tbxSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(259, 22);
            this.tbxSearch.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.DisplayMember = "CountryName";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(4, 99);
            this.cbCountry.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(127, 24);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.ValueMember = "CountryName";
            this.cbCountry.SelectedIndexChanged += new System.EventHandler(this.cbCountry_SelectedIndexChanged);
            // 
            // cbCity
            // 
            this.cbCity.DisplayMember = "CityName";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(136, 99);
            this.cbCity.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(127, 24);
            this.cbCity.TabIndex = 2;
            this.cbCity.ValueMember = "CityName";
            // 
            // tbGuests
            // 
            this.tbGuests.Location = new System.Drawing.Point(86, 303);
            this.tbGuests.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbGuests.Name = "tbGuests";
            this.tbGuests.Size = new System.Drawing.Size(176, 56);
            this.tbGuests.TabIndex = 3;
            this.tbGuests.Scroll += new System.EventHandler(this.tbGuests_Scroll);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(61, 225);
            this.dtpFromDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(201, 22);
            this.dtpFromDate.TabIndex = 4;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(60, 266);
            this.dtpToDate.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(202, 22);
            this.dtpToDate.TabIndex = 5;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(7, 226);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(49, 17);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "From:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(25, 267);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(32, 17);
            this.lblToDate.TabIndex = 6;
            this.lblToDate.Text = "To:";
            // 
            // clbRoomStandard
            // 
            this.clbRoomStandard.FormattingEnabled = true;
            this.clbRoomStandard.Items.AddRange(new object[] {
            "Smoke Free",
            "Extrabed",
            "Children"});
            this.clbRoomStandard.Location = new System.Drawing.Point(4, 365);
            this.clbRoomStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.clbRoomStandard.Name = "clbRoomStandard";
            this.clbRoomStandard.Size = new System.Drawing.Size(260, 55);
            this.clbRoomStandard.TabIndex = 7;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(3, 303);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(64, 17);
            this.lblGuests.TabIndex = 6;
            this.lblGuests.Text = "Guests:";
            // 
            // tbStandard
            // 
            this.tbStandard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbStandard.LargeChange = 1;
            this.tbStandard.Location = new System.Drawing.Point(88, 139);
            this.tbStandard.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tbStandard.Maximum = 5;
            this.tbStandard.Name = "tbStandard";
            this.tbStandard.Size = new System.Drawing.Size(174, 56);
            this.tbStandard.TabIndex = 3;
            this.tbStandard.Scroll += new System.EventHandler(this.tbStandard_Scroll);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(3, 139);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(60, 17);
            this.lblStandard.TabIndex = 6;
            this.lblStandard.Text = "Rating:";
            // 
            // hotelDataGridView
            // 
            this.hotelDataGridView.AllowUserToAddRows = false;
            this.hotelDataGridView.AllowUserToDeleteRows = false;
            this.hotelDataGridView.AutoGenerateColumns = false;
            this.hotelDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.hotelDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.dataGridViewTextBoxColumn1,
            this.dataGridViewTextBoxColumn2,
            this.dataGridViewTextBoxColumn3,
            this.dataGridViewTextBoxColumn4,
            this.dataGridViewTextBoxColumn5,
            this.dataGridViewTextBoxColumn6});
            this.hotelDataGridView.DataSource = this.hotelBindingSource;
            this.hotelDataGridView.Location = new System.Drawing.Point(289, 46);
            this.hotelDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.hotelDataGridView.Name = "hotelDataGridView";
            this.hotelDataGridView.ReadOnly = true;
            this.hotelDataGridView.RowTemplate.Height = 28;
            this.hotelDataGridView.Size = new System.Drawing.Size(981, 209);
            this.hotelDataGridView.TabIndex = 15;
            this.hotelDataGridView.RowHeadersVisible = false;
            // 
            // dataGridViewTextBoxColumn1
            // 
            this.dataGridViewTextBoxColumn1.DataPropertyName = "Adress";
            this.dataGridViewTextBoxColumn1.HeaderText = "Adress";
            this.dataGridViewTextBoxColumn1.Name = "dataGridViewTextBoxColumn1";
            this.dataGridViewTextBoxColumn1.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn2
            // 
            this.dataGridViewTextBoxColumn2.DataPropertyName = "Name";
            this.dataGridViewTextBoxColumn2.HeaderText = "Name";
            this.dataGridViewTextBoxColumn2.Name = "dataGridViewTextBoxColumn2";
            this.dataGridViewTextBoxColumn2.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn3
            // 
            this.dataGridViewTextBoxColumn3.DataPropertyName = "Standard";
            this.dataGridViewTextBoxColumn3.HeaderText = "Standard";
            this.dataGridViewTextBoxColumn3.Name = "dataGridViewTextBoxColumn3";
            this.dataGridViewTextBoxColumn3.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn4
            // 
            this.dataGridViewTextBoxColumn4.DataPropertyName = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.HeaderText = "PhoneNumber";
            this.dataGridViewTextBoxColumn4.Name = "dataGridViewTextBoxColumn4";
            this.dataGridViewTextBoxColumn4.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn5
            // 
            this.dataGridViewTextBoxColumn5.DataPropertyName = "CityName";
            this.dataGridViewTextBoxColumn5.HeaderText = "CityName";
            this.dataGridViewTextBoxColumn5.Name = "dataGridViewTextBoxColumn5";
            this.dataGridViewTextBoxColumn5.ReadOnly = true;
            // 
            // dataGridViewTextBoxColumn6
            // 
            this.dataGridViewTextBoxColumn6.DataPropertyName = "Countryname";
            this.dataGridViewTextBoxColumn6.HeaderText = "Countryname";
            this.dataGridViewTextBoxColumn6.Name = "dataGridViewTextBoxColumn6";
            this.dataGridViewTextBoxColumn6.ReadOnly = true;
            // 
            // hotelBindingSource
            // 
            this.hotelBindingSource.DataSource = typeof(BookARoom.Models.Hotel);
            // 
            // roomsDataGridView
            // 
            this.roomsDataGridView.AllowUserToAddRows = false;
            this.roomsDataGridView.AllowUserToDeleteRows = false;
            this.roomsDataGridView.AutoGenerateColumns = false;
            this.roomsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.ColumnHeader;
            this.roomsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.roomsDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.roomNumberDataGridViewTextBoxColumn,
            this.bedDataGridViewTextBoxColumn,
            this.smokeFreeDataGridViewCheckBoxColumn,
            this.priceDataGridViewTextBoxColumn,
            this.guestCapacityDataGridViewTextBoxColumn,
            this.adressDataGridViewTextBoxColumn,
            this.Booking});
            this.roomsDataGridView.RowHeadersVisible = false;
            this.roomsDataGridView.DataSource = this.roomsBindingSource;
            this.roomsDataGridView.Location = new System.Drawing.Point(289, 297);
            this.roomsDataGridView.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.roomsDataGridView.Name = "roomsDataGridView";
            this.roomsDataGridView.ReadOnly = true;
            this.roomsDataGridView.RowTemplate.Height = 28;
            this.roomsDataGridView.Size = new System.Drawing.Size(981, 176);
            this.roomsDataGridView.TabIndex = 16;
            this.roomsDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.roomsDataGridView_CellClick);
            // 
            // roomNumberDataGridViewTextBoxColumn
            // 
            this.roomNumberDataGridViewTextBoxColumn.DataPropertyName = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.HeaderText = "RoomNumber";
            this.roomNumberDataGridViewTextBoxColumn.Name = "roomNumberDataGridViewTextBoxColumn";
            this.roomNumberDataGridViewTextBoxColumn.ReadOnly = true;
            this.roomNumberDataGridViewTextBoxColumn.Width = 124;
            // 
            // bedDataGridViewTextBoxColumn
            // 
            this.bedDataGridViewTextBoxColumn.DataPropertyName = "Bed";
            this.bedDataGridViewTextBoxColumn.HeaderText = "Bed";
            this.bedDataGridViewTextBoxColumn.Name = "bedDataGridViewTextBoxColumn";
            this.bedDataGridViewTextBoxColumn.ReadOnly = true;
            this.bedDataGridViewTextBoxColumn.Width = 62;
            // 
            // smokeFreeDataGridViewCheckBoxColumn
            // 
            this.smokeFreeDataGridViewCheckBoxColumn.DataPropertyName = "SmokeFree";
            this.smokeFreeDataGridViewCheckBoxColumn.HeaderText = "SmokeFree";
            this.smokeFreeDataGridViewCheckBoxColumn.Name = "smokeFreeDataGridViewCheckBoxColumn";
            this.smokeFreeDataGridViewCheckBoxColumn.ReadOnly = true;
            this.smokeFreeDataGridViewCheckBoxColumn.Width = 86;
            // 
            // priceDataGridViewTextBoxColumn
            // 
            this.priceDataGridViewTextBoxColumn.DataPropertyName = "Price";
            this.priceDataGridViewTextBoxColumn.HeaderText = "Price";
            this.priceDataGridViewTextBoxColumn.Name = "priceDataGridViewTextBoxColumn";
            this.priceDataGridViewTextBoxColumn.ReadOnly = true;
            this.priceDataGridViewTextBoxColumn.Width = 69;
            // 
            // guestCapacityDataGridViewTextBoxColumn
            // 
            this.guestCapacityDataGridViewTextBoxColumn.DataPropertyName = "GuestCapacity";
            this.guestCapacityDataGridViewTextBoxColumn.HeaderText = "GuestCapacity";
            this.guestCapacityDataGridViewTextBoxColumn.Name = "guestCapacityDataGridViewTextBoxColumn";
            this.guestCapacityDataGridViewTextBoxColumn.ReadOnly = true;
            this.guestCapacityDataGridViewTextBoxColumn.Width = 129;
            // 
            // adressDataGridViewTextBoxColumn
            // 
            this.adressDataGridViewTextBoxColumn.DataPropertyName = "Adress";
            this.adressDataGridViewTextBoxColumn.HeaderText = "Adress";
            this.adressDataGridViewTextBoxColumn.Name = "adressDataGridViewTextBoxColumn";
            this.adressDataGridViewTextBoxColumn.ReadOnly = true;
            this.adressDataGridViewTextBoxColumn.Width = 81;
            // 
            // Booking
            // 
            this.Booking.HeaderText = "Booking";
            this.Booking.Name = "Booking";
            this.Booking.ReadOnly = true;
            this.Booking.Text = "SELECT";
            this.Booking.UseColumnTextForButtonValue = true;
            this.Booking.Width = 65;
            // 
            // roomsBindingSource
            // 
            this.roomsBindingSource.DataMember = "Rooms";
            this.roomsBindingSource.DataSource = this.hotelBindingSource;
            // 
            // UCNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.roomsDataGridView);
            this.Controls.Add(this.hotelDataGridView);
            this.Controls.Add(this.clbRoomStandard);
            this.Controls.Add(this.lblToDate);
            this.Controls.Add(this.lblStandard);
            this.Controls.Add(this.lblGuests);
            this.Controls.Add(this.lblFromDate);
            this.Controls.Add(this.dtpToDate);
            this.Controls.Add(this.dtpFromDate);
            this.Controls.Add(this.tbStandard);
            this.Controls.Add(this.tbGuests);
            this.Controls.Add(this.cbCity);
            this.Controls.Add(this.cbCountry);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "UCNavigator";
            this.Size = new System.Drawing.Size(1281, 510);
            this.Load += new System.EventHandler(this.UCNavigator_Load);
            ((System.ComponentModel.ISupportInitialize)(this.tbGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.hotelBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.roomsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bookingsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ComboBox cbCountry;
        private System.Windows.Forms.ComboBox cbCity;
        private System.Windows.Forms.TrackBar tbGuests;
        private System.Windows.Forms.DateTimePicker dtpFromDate;
        private System.Windows.Forms.DateTimePicker dtpToDate;
        private System.Windows.Forms.Label lblFromDate;
        private System.Windows.Forms.Label lblToDate;
        private System.Windows.Forms.CheckedListBox clbRoomStandard;
        private System.Windows.Forms.Label lblGuests;
        private System.Windows.Forms.TrackBar tbStandard;
        private System.Windows.Forms.Label lblStandard;
        private System.Windows.Forms.BindingSource hotelBindingSource;
        private System.Windows.Forms.DataGridView hotelDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn1;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn2;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn3;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn4;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn5;
        private System.Windows.Forms.DataGridViewTextBoxColumn dataGridViewTextBoxColumn6;
        private System.Windows.Forms.BindingSource bookingsBindingSource;
        private System.Windows.Forms.BindingSource roomsBindingSource;
        private System.Windows.Forms.DataGridView roomsDataGridView;
        private System.Windows.Forms.DataGridViewTextBoxColumn roomNumberDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn bedDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewCheckBoxColumn smokeFreeDataGridViewCheckBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn priceDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn guestCapacityDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn adressDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewButtonColumn Booking;
    }
}
