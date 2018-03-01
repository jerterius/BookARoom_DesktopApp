namespace BookARoom.Views
{
    partial class UserControlUppgift2
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
            this.lbSelectFile = new System.Windows.Forms.Label();
            this.btnOpenFile = new System.Windows.Forms.Button();
            this.cbSelectFile = new System.Windows.Forms.ComboBox();
            this.rtbShowFile = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // lbSelectFile
            // 
            this.lbSelectFile.AutoSize = true;
            this.lbSelectFile.Location = new System.Drawing.Point(35, 150);
            this.lbSelectFile.Name = "lbSelectFile";
            this.lbSelectFile.Size = new System.Drawing.Size(73, 17);
            this.lbSelectFile.TabIndex = 2;
            this.lbSelectFile.Text = "Select file:";
            this.lbSelectFile.Click += new System.EventHandler(this.lbSelectFile_Click);
            // 
            // btnOpenFile
            // 
            this.btnOpenFile.Location = new System.Drawing.Point(646, 146);
            this.btnOpenFile.Name = "btnOpenFile";
            this.btnOpenFile.Size = new System.Drawing.Size(138, 30);
            this.btnOpenFile.TabIndex = 3;
            this.btnOpenFile.Text = "Open file";
            this.btnOpenFile.UseVisualStyleBackColor = true;
            this.btnOpenFile.Click += new System.EventHandler(this.btnOpenFile_Click);
            // 
            // cbSelectFile
            // 
            this.cbSelectFile.FormattingEnabled = true;
            this.cbSelectFile.Items.AddRange(new object[] {
            "Notepad"});
            this.cbSelectFile.Location = new System.Drawing.Point(146, 150);
            this.cbSelectFile.Name = "cbSelectFile";
            this.cbSelectFile.Size = new System.Drawing.Size(411, 24);
            this.cbSelectFile.TabIndex = 4;
            this.cbSelectFile.SelectedIndexChanged += new System.EventHandler(this.cbSelectFile_SelectedIndexChanged);
            // 
            // rtbShowFile
            // 
            this.rtbShowFile.Location = new System.Drawing.Point(38, 233);
            this.rtbShowFile.Name = "rtbShowFile";
            this.rtbShowFile.Size = new System.Drawing.Size(1003, 354);
            this.rtbShowFile.TabIndex = 0;
            this.rtbShowFile.Text = "";
            // 
            // UserControlUppgift2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.cbSelectFile);
            this.Controls.Add(this.btnOpenFile);
            this.Controls.Add(this.lbSelectFile);
            this.Controls.Add(this.rtbShowFile);
            this.Name = "UserControlUppgift2";
            this.Size = new System.Drawing.Size(1078, 609);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbSelectFile;
        private System.Windows.Forms.Button btnOpenFile;
        private System.Windows.Forms.ComboBox cbSelectFile;
        private System.Windows.Forms.RichTextBox rtbShowFile;
    }
}
