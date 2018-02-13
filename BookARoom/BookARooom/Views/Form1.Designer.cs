using System.Windows.Forms;

namespace BookARoom.Views
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
            this.tabControlMain = new System.Windows.Forms.TabControl();
            this.tabPagePK = new System.Windows.Forms.TabPage();
            this.tabPagePKWS = new System.Windows.Forms.TabPage();
            this.tabPageERPWS = new System.Windows.Forms.TabPage();
            this.ucNavigator = new BookARoom.Views.UCNavigator();
            this.ucResult1 = new BookARoom.Views.UCResult();
            this.tabControlMain.SuspendLayout();
            this.tabPagePK.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePK);
            this.tabControlMain.Controls.Add(this.tabPagePKWS);
            this.tabControlMain.Controls.Add(this.tabPageERPWS);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1178, 720);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagePK
            // 
            this.tabPagePK.Controls.Add(this.ucResult1);
            this.tabPagePK.Controls.Add(this.ucNavigator);
            this.tabPagePK.Location = new System.Drawing.Point(4, 29);
            this.tabPagePK.Name = "tabPagePK";
            this.tabPagePK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePK.Size = new System.Drawing.Size(1170, 687);
            this.tabPagePK.TabIndex = 0;
            this.tabPagePK.Text = "Programkonstruktion";
            this.tabPagePK.UseVisualStyleBackColor = true;
            // 
            // tabPagePKWS
            // 
            this.tabPagePKWS.Location = new System.Drawing.Point(4, 29);
            this.tabPagePKWS.Name = "tabPagePKWS";
            this.tabPagePKWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePKWS.Size = new System.Drawing.Size(1170, 687);
            this.tabPagePKWS.TabIndex = 1;
            this.tabPagePKWS.Text = "Programkonstruktion & Webservice";
            this.tabPagePKWS.UseVisualStyleBackColor = true;
            // 
            // tabPageERPWS
            // 
            this.tabPageERPWS.Location = new System.Drawing.Point(4, 29);
            this.tabPageERPWS.Name = "tabPageERPWS";
            this.tabPageERPWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageERPWS.Size = new System.Drawing.Size(1170, 687);
            this.tabPageERPWS.TabIndex = 2;
            this.tabPageERPWS.Text = "ERP & Webservice";
            this.tabPageERPWS.UseVisualStyleBackColor = true;
            // 
            // ucNavigator
            // 
            this.ucNavigator.AutoSize = true;
            this.ucNavigator.BackColor = System.Drawing.Color.AliceBlue;
            this.ucNavigator.Dock = System.Windows.Forms.DockStyle.Left;
            this.ucNavigator.Location = new System.Drawing.Point(3, 3);
            this.ucNavigator.Name = "ucNavigator";
            this.ucNavigator.Size = new System.Drawing.Size(299, 681);
            this.ucNavigator.TabIndex = 0;
            this.ucNavigator.Load += new System.EventHandler(this.ucNavigator1_Load);
            // 
            // ucResult1
            // 
            this.ucResult1.Location = new System.Drawing.Point(308, 6);
            this.ucResult1.Name = "ucResult1";
            this.ucResult1.Size = new System.Drawing.Size(860, 664);
            this.ucResult1.TabIndex = 1;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1178, 744);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePK.ResumeLayout(false);
            this.tabPagePK.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPagePK;
        private TabPage tabPagePKWS;
        private TabPage tabPageERPWS;
        private UCNavigator ucNavigator;
        private UCResult ucResult1;
    }
}

