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
            this.tbSearch = new System.Windows.Forms.TextBox();
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
            this.cityBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.tbGuests)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandard)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // btnClear
            // 
            this.btnClear.Location = new System.Drawing.Point(152, 551);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(143, 41);
            this.btnClear.TabIndex = 0;
            this.btnClear.Text = "Clear";
            this.btnClear.UseVisualStyleBackColor = true;
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(3, 551);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(143, 41);
            this.btnSubmit.TabIndex = 0;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.UseVisualStyleBackColor = true;
            this.btnSubmit.Click += new System.EventHandler(this.button2_Click);
            // 
            // tbSearch
            // 
            this.tbSearch.Location = new System.Drawing.Point(4, 57);
            this.tbSearch.Name = "tbSearch";
            this.tbSearch.Size = new System.Drawing.Size(291, 26);
            this.tbSearch.TabIndex = 1;
            // 
            // cbCountry
            // 
            this.cbCountry.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource, "CountryName", true));
            this.cbCountry.DataSource = this.cityBindingSource;
            this.cbCountry.DisplayMember = "CountryName";
            this.cbCountry.FormattingEnabled = true;
            this.cbCountry.Location = new System.Drawing.Point(4, 124);
            this.cbCountry.Name = "cbCountry";
            this.cbCountry.Size = new System.Drawing.Size(142, 28);
            this.cbCountry.TabIndex = 2;
            this.cbCountry.ValueMember = "CountryName";
            // 
            // cbCity
            // 
            this.cbCity.DataBindings.Add(new System.Windows.Forms.Binding("SelectedValue", this.cityBindingSource, "CityName", true));
            this.cbCity.DataSource = this.cityBindingSource;
            this.cbCity.DisplayMember = "CityName";
            this.cbCity.FormattingEnabled = true;
            this.cbCity.Location = new System.Drawing.Point(153, 124);
            this.cbCity.Name = "cbCity";
            this.cbCity.Size = new System.Drawing.Size(142, 28);
            this.cbCity.TabIndex = 2;
            this.cbCity.ValueMember = "CityName";
            // 
            // tbGuests
            // 
            this.tbGuests.Location = new System.Drawing.Point(97, 379);
            this.tbGuests.Name = "tbGuests";
            this.tbGuests.Size = new System.Drawing.Size(198, 69);
            this.tbGuests.TabIndex = 3;
            this.tbGuests.Scroll += new System.EventHandler(this.tbGuests_Scroll);
            // 
            // dtpFromDate
            // 
            this.dtpFromDate.Location = new System.Drawing.Point(69, 281);
            this.dtpFromDate.Name = "dtpFromDate";
            this.dtpFromDate.Size = new System.Drawing.Size(226, 26);
            this.dtpFromDate.TabIndex = 4;
            // 
            // dtpToDate
            // 
            this.dtpToDate.Location = new System.Drawing.Point(68, 332);
            this.dtpToDate.Name = "dtpToDate";
            this.dtpToDate.Size = new System.Drawing.Size(227, 26);
            this.dtpToDate.TabIndex = 5;
            // 
            // lblFromDate
            // 
            this.lblFromDate.AutoSize = true;
            this.lblFromDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblFromDate.Location = new System.Drawing.Point(8, 283);
            this.lblFromDate.Name = "lblFromDate";
            this.lblFromDate.Size = new System.Drawing.Size(55, 20);
            this.lblFromDate.TabIndex = 6;
            this.lblFromDate.Text = "From:";
            // 
            // lblToDate
            // 
            this.lblToDate.AutoSize = true;
            this.lblToDate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblToDate.Location = new System.Drawing.Point(28, 334);
            this.lblToDate.Name = "lblToDate";
            this.lblToDate.Size = new System.Drawing.Size(34, 20);
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
            this.clbRoomStandard.Location = new System.Drawing.Point(4, 456);
            this.clbRoomStandard.Name = "clbRoomStandard";
            this.clbRoomStandard.Size = new System.Drawing.Size(292, 88);
            this.clbRoomStandard.TabIndex = 7;
            // 
            // lblGuests
            // 
            this.lblGuests.AutoSize = true;
            this.lblGuests.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblGuests.Location = new System.Drawing.Point(3, 379);
            this.lblGuests.Name = "lblGuests";
            this.lblGuests.Size = new System.Drawing.Size(72, 20);
            this.lblGuests.TabIndex = 6;
            this.lblGuests.Text = "Guests:";
            // 
            // tbStandard
            // 
            this.tbStandard.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.tbStandard.LargeChange = 1;
            this.tbStandard.Location = new System.Drawing.Point(99, 174);
            this.tbStandard.Maximum = 5;
            this.tbStandard.Name = "tbStandard";
            this.tbStandard.Size = new System.Drawing.Size(196, 69);
            this.tbStandard.TabIndex = 3;
            this.tbStandard.Scroll += new System.EventHandler(this.tbStandard_Scroll);
            // 
            // lblStandard
            // 
            this.lblStandard.AutoSize = true;
            this.lblStandard.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblStandard.Location = new System.Drawing.Point(3, 174);
            this.lblStandard.Name = "lblStandard";
            this.lblStandard.Size = new System.Drawing.Size(67, 20);
            this.lblStandard.TabIndex = 6;
            this.lblStandard.Text = "Rating:";
            // 
            // cityBindingSource
            // 
            this.cityBindingSource.DataSource = typeof(BookARoom.Models.City);
            // 
            // UCNavigator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
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
            this.Controls.Add(this.tbSearch);
            this.Controls.Add(this.btnSubmit);
            this.Controls.Add(this.btnClear);
            this.Name = "UCNavigator";
            this.Size = new System.Drawing.Size(329, 612);
            ((System.ComponentModel.ISupportInitialize)(this.tbGuests)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tbStandard)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cityBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.Button btnSubmit;
        private System.Windows.Forms.TextBox tbSearch;
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
        private System.Windows.Forms.BindingSource cityBindingSource;
    }
}
