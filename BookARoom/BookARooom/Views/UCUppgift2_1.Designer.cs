namespace BookARoom.Views
{
    partial class UCUppgift2_1
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
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbSelectFile = new System.Windows.Forms.ComboBox();
            this.textBoxShowFile = new System.Windows.Forms.TextBox();
            this.lblSelectFile = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(588, 165);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(122, 28);
            this.btnOpenFile.TabIndex = 0;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbSelectFile
            // 
            this.cbSelectFile.FormattingEnabled = true;
            this.cbSelectFile.Location = new System.Drawing.Point(175, 168);
            this.cbSelectFile.Name = "cbSelectFile";
            this.cbSelectFile.Size = new System.Drawing.Size(355, 24);
            this.cbSelectFile.TabIndex = 1;
            this.cbSelectFile.SelectedIndexChanged += new System.EventHandler(this.cbSelectFile_SelectedIndexChanged);
            // 
            // textBoxShowFile
            // 
            this.textBoxShowFile.Location = new System.Drawing.Point(70, 233);
            this.textBoxShowFile.Multiline = true;
            this.textBoxShowFile.Name = "textBoxShowFile";
            this.textBoxShowFile.Size = new System.Drawing.Size(660, 221);
            this.textBoxShowFile.TabIndex = 3;
            // 
            // lblSelectFile
            // 
            this.lblSelectFile.AutoSize = true;
            this.lblSelectFile.Location = new System.Drawing.Point(67, 171);
            this.lblSelectFile.Name = "lblSelectFile";
            this.lblSelectFile.Size = new System.Drawing.Size(73, 17);
            this.lblSelectFile.TabIndex = 4;
            this.lblSelectFile.Text = "Select file:";
            // 
            // UCUppgift2_1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblSelectFile);
            this.Controls.Add(this.textBoxShowFile);
            this.Controls.Add(this.cbSelectFile);
            this.Controls.Add(this.btnOpenFile);
            this.Name = "UCUppgift2_1";
            this.Size = new System.Drawing.Size(819, 528);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbSelectFile;
        private System.Windows.Forms.TextBox textBoxShowFile;
        private System.Windows.Forms.Label lblSelectFile;
    }
}
