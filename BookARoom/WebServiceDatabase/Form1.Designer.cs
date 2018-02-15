namespace WebServiceDatabase
{
    partial class Form1
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
            this.dbTablesDataGridView = new System.Windows.Forms.DataGridView();
            this.lblCronusTitel = new System.Windows.Forms.Label();
            this.comboBoxFunctions = new System.Windows.Forms.ComboBox();
            this.lblTables = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dbTablesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // dbTablesDataGridView
            // 
            this.dbTablesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dbTablesDataGridView.Location = new System.Drawing.Point(12, 155);
            this.dbTablesDataGridView.Name = "dbTablesDataGridView";
            this.dbTablesDataGridView.RowTemplate.Height = 24;
            this.dbTablesDataGridView.Size = new System.Drawing.Size(481, 219);
            this.dbTablesDataGridView.TabIndex = 0;
            this.dbTablesDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dbTablesDataGridView_CellContentClick);
            // 
            // lblCronusTitel
            // 
            this.lblCronusTitel.Font = new System.Drawing.Font("Calibri", 12.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCronusTitel.Location = new System.Drawing.Point(23, 15);
            this.lblCronusTitel.Name = "lblCronusTitel";
            this.lblCronusTitel.Size = new System.Drawing.Size(200, 37);
            this.lblCronusTitel.TabIndex = 1;
            this.lblCronusTitel.Text = "CRONUS Sverige AB";
            this.lblCronusTitel.Click += new System.EventHandler(this.lblCronusTitel_Click);
            // 
            // comboBoxFunctions
            // 
            this.comboBoxFunctions.FormattingEnabled = true;
            this.comboBoxFunctions.Location = new System.Drawing.Point(28, 102);
            this.comboBoxFunctions.Name = "comboBoxFunctions";
            this.comboBoxFunctions.Size = new System.Drawing.Size(210, 24);
            this.comboBoxFunctions.TabIndex = 2;
            this.comboBoxFunctions.SelectedIndexChanged += new System.EventHandler(this.comboBoxFunctions_SelectedIndexChanged);
            // 
            // lblTables
            // 
            this.lblTables.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTables.Location = new System.Drawing.Point(24, 67);
            this.lblTables.Name = "lblTables";
            this.lblTables.Size = new System.Drawing.Size(80, 22);
            this.lblTables.TabIndex = 3;
            this.lblTables.Text = "Tables";
            this.lblTables.Click += new System.EventHandler(this.lblTables_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(503, 386);
            this.Controls.Add(this.lblTables);
            this.Controls.Add(this.comboBoxFunctions);
            this.Controls.Add(this.lblCronusTitel);
            this.Controls.Add(this.dbTablesDataGridView);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.dbTablesDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dbTablesDataGridView;
        private System.Windows.Forms.Label lblCronusTitel;
        private System.Windows.Forms.ComboBox comboBoxFunctions;
        private System.Windows.Forms.Label lblTables;
    }
}

