namespace BookARoom.Views
{
    partial class UCBookARoomClient
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
            this.cbSelectEntityTable = new System.Windows.Forms.ComboBox();
            this.entitiesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblSelectTable = new System.Windows.Forms.Label();
            this.lblResponse = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.entitiesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // cbSelectEntityTable
            // 
            this.cbSelectEntityTable.FormattingEnabled = true;
            this.cbSelectEntityTable.Items.AddRange(new object[] {
            "All Customers",
            "All Bookings",
            "All Rooms",
            "All Hotels",
            "All Cities"});
            this.cbSelectEntityTable.Location = new System.Drawing.Point(16, 143);
            this.cbSelectEntityTable.Name = "cbSelectEntityTable";
            this.cbSelectEntityTable.Size = new System.Drawing.Size(272, 28);
            this.cbSelectEntityTable.TabIndex = 0;
            this.cbSelectEntityTable.SelectedIndexChanged += new System.EventHandler(this.CbSelectEntityTable_SelectedIndexChanged);
            // 
            // entitiesDataGridView
            // 
            this.entitiesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.entitiesDataGridView.Location = new System.Drawing.Point(16, 208);
            this.entitiesDataGridView.Name = "entitiesDataGridView";
            this.entitiesDataGridView.RowTemplate.Height = 28;
            this.entitiesDataGridView.Size = new System.Drawing.Size(1517, 671);
            this.entitiesDataGridView.TabIndex = 1;
            // 
            // lblSelectTable
            // 
            this.lblSelectTable.AutoSize = true;
            this.lblSelectTable.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblSelectTable.Location = new System.Drawing.Point(12, 101);
            this.lblSelectTable.Name = "lblSelectTable";
            this.lblSelectTable.Size = new System.Drawing.Size(110, 20);
            this.lblSelectTable.TabIndex = 2;
            this.lblSelectTable.Text = "Select table:";
            // 
            // lblResponse
            // 
            this.lblResponse.AutoSize = true;
            this.lblResponse.Location = new System.Drawing.Point(12, 891);
            this.lblResponse.Name = "lblResponse";
            this.lblResponse.Size = new System.Drawing.Size(86, 20);
            this.lblResponse.TabIndex = 3;
            this.lblResponse.Text = "Response:";
            this.lblResponse.Visible = false;
            // 
            // UCBookARoomClient
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblResponse);
            this.Controls.Add(this.lblSelectTable);
            this.Controls.Add(this.entitiesDataGridView);
            this.Controls.Add(this.cbSelectEntityTable);
            this.Name = "UCBookARoomClient";
            this.Size = new System.Drawing.Size(1550, 950);
            this.Load += new System.EventHandler(this.UCBookARoomClient_Load);
            ((System.ComponentModel.ISupportInitialize)(this.entitiesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox cbSelectEntityTable;
        private System.Windows.Forms.DataGridView entitiesDataGridView;
        private System.Windows.Forms.Label lblSelectTable;
        private System.Windows.Forms.Label lblResponse;
    }
}
