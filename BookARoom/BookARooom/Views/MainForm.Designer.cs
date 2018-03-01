﻿using System.Windows.Forms;

namespace BookARoom.Views
{
    partial class MainForm
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
            this.tabControlPK = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.ucLogin1 = new BookARoom.Views.UCLogin();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.ucNavigator1 = new BookARoom.Views.UCNavigator();
            this.tabPagePKWS = new System.Windows.Forms.TabPage();
            this.ucBookARoomClient1 = new BookARoom.Views.UCBookARoomClient();
            this.tabPageERPWS = new System.Windows.Forms.TabPage();
            this.ucEmployee1 = new BookARoom.Views.UCEmployee();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.ucAccount1 = new BookARoom.Views.UCAccount();
            this.tabPageWS = new System.Windows.Forms.TabPage();
            this.ucUppgift2_11 = new BookARoom.Views.UCUppgift2_1();
            this.tabControlMain.SuspendLayout();
            this.tabPagePK.SuspendLayout();
            this.tabControlPK.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPagePKWS.SuspendLayout();
            this.tabPageERPWS.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
            this.tabPageWS.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControlMain
            // 
            this.tabControlMain.Controls.Add(this.tabPagePK);
            this.tabControlMain.Controls.Add(this.tabPagePKWS);
            this.tabControlMain.Controls.Add(this.tabPageERPWS);
            this.tabControlMain.Controls.Add(this.tabPageWS);
            this.tabControlMain.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlMain.Location = new System.Drawing.Point(0, 0);
            this.tabControlMain.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlMain.Name = "tabControlMain";
            this.tabControlMain.SelectedIndex = 0;
            this.tabControlMain.Size = new System.Drawing.Size(1403, 888);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagePK
            // 
            this.tabPagePK.Controls.Add(this.tabControlPK);
            this.tabPagePK.Location = new System.Drawing.Point(4, 25);
            this.tabPagePK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePK.Name = "tabPagePK";
            this.tabPagePK.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePK.Size = new System.Drawing.Size(1395, 859);
            this.tabPagePK.TabIndex = 0;
            this.tabPagePK.Text = "Programkonstruktion";
            this.tabPagePK.UseVisualStyleBackColor = true;
            // 
            // tabControlPK
            // 
            this.tabControlPK.Controls.Add(this.tabPageLogin);
            this.tabControlPK.Controls.Add(this.tabPageSearch);
            this.tabControlPK.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlPK.Location = new System.Drawing.Point(3, 2);
            this.tabControlPK.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabControlPK.Name = "tabControlPK";
            this.tabControlPK.SelectedIndex = 0;
            this.tabControlPK.Size = new System.Drawing.Size(1389, 862);
            this.tabControlPK.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.ucLogin1);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 25);
            this.tabPageLogin.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageLogin.Size = new System.Drawing.Size(1381, 833);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // ucLogin1
            // 
            this.ucLogin1.Customer = null;
            this.ucLogin1.Location = new System.Drawing.Point(5, 5);
            this.ucLogin1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucLogin1.Name = "ucLogin1";
            this.ucLogin1.Size = new System.Drawing.Size(433, 325);
            this.ucLogin1.TabIndex = 4;
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.ucNavigator1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 25);
            this.tabPageSearch.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageSearch.Size = new System.Drawing.Size(1382, 833);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // ucNavigator1
            // 
            this.ucNavigator1.AutoSize = true;
            this.ucNavigator1.Customer = null;
            this.ucNavigator1.Location = new System.Drawing.Point(5, 5);
            this.ucNavigator1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucNavigator1.Name = "ucNavigator1";
            this.ucNavigator1.Size = new System.Drawing.Size(1273, 476);
            this.ucNavigator1.TabIndex = 0;
            // 
            // tabPagePKWS
            // 
            this.tabPagePKWS.Controls.Add(this.ucBookARoomClient1);
            this.tabPagePKWS.Location = new System.Drawing.Point(4, 25);
            this.tabPagePKWS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePKWS.Name = "tabPagePKWS";
            this.tabPagePKWS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPagePKWS.Size = new System.Drawing.Size(1395, 859);
            this.tabPagePKWS.TabIndex = 1;
            this.tabPagePKWS.Text = "Programkonstruktion & Webservice";
            this.tabPagePKWS.UseVisualStyleBackColor = true;
            // 
            // ucBookARoomClient1
            // 
            this.ucBookARoomClient1.Location = new System.Drawing.Point(7, 5);
            this.ucBookARoomClient1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucBookARoomClient1.Name = "ucBookARoomClient1";
            this.ucBookARoomClient1.Size = new System.Drawing.Size(1381, 751);
            this.ucBookARoomClient1.TabIndex = 0;
            // 
            // tabPageERPWS
            // 
            this.tabPageERPWS.Controls.Add(this.ucEmployee1);
            this.tabPageERPWS.Location = new System.Drawing.Point(4, 25);
            this.tabPageERPWS.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageERPWS.Name = "tabPageERPWS";
            this.tabPageERPWS.Padding = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.tabPageERPWS.Size = new System.Drawing.Size(1395, 859);
            this.tabPageERPWS.TabIndex = 2;
            this.tabPageERPWS.Text = "ERP & Webservice";
            this.tabPageERPWS.UseVisualStyleBackColor = true;
            // 
            // ucEmployee1
            // 
            this.ucEmployee1.CreateEmployeeEnabled = false;
            this.ucEmployee1.EmployeeNo = null;
            this.ucEmployee1.Location = new System.Drawing.Point(5, 12);
            this.ucEmployee1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucEmployee1.Name = "ucEmployee1";
            this.ucEmployee1.Size = new System.Drawing.Size(1383, 845);
            this.ucEmployee1.TabIndex = 0;
            // 
            // tabPageAccount
            // 
            this.tabPageAccount.Controls.Add(this.ucAccount1);
            this.tabPageAccount.Location = new System.Drawing.Point(4, 29);
            this.tabPageAccount.Name = "tabPageAccount";
            this.tabPageAccount.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageAccount.Size = new System.Drawing.Size(1556, 1045);
            this.tabPageAccount.TabIndex = 2;
            this.tabPageAccount.Text = "Account";
            this.tabPageAccount.UseVisualStyleBackColor = true;
            // 
            // ucAccount1
            // 
            this.ucAccount1.BtnEdit = null;
            this.ucAccount1.CreateCustomerEnabled = false;
            this.ucAccount1.Customer = null;
            this.ucAccount1.Location = new System.Drawing.Point(6, 6);
            this.ucAccount1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.ReadOnly = true;
            this.ucAccount1.Size = new System.Drawing.Size(952, 621);
            this.ucAccount1.TabIndex = 0;
            // 
            // tabPageWS
            // 
            this.tabPageWS.Controls.Add(this.ucUppgift2_11);
            this.tabPageWS.Location = new System.Drawing.Point(4, 25);
            this.tabPageWS.Name = "tabPageWS";
            this.tabPageWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageWS.Size = new System.Drawing.Size(1395, 859);
            this.tabPageWS.TabIndex = 3;
            this.tabPageWS.Text = "WSÖppnaFil";
            this.tabPageWS.UseVisualStyleBackColor = true;
            // 
            // ucUppgift2_11
            // 
            this.ucUppgift2_11.Location = new System.Drawing.Point(0, 0);
            this.ucUppgift2_11.Name = "ucUppgift2_11";
            this.ucUppgift2_11.Size = new System.Drawing.Size(819, 528);
            this.ucUppgift2_11.TabIndex = 0;
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1403, 844);
            this.Controls.Add(this.tabControlMain);
            this.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Main Form";
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePK.ResumeLayout(false);
            this.tabControlPK.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPagePKWS.ResumeLayout(false);
            this.tabPageERPWS.ResumeLayout(false);
            this.tabPageAccount.ResumeLayout(false);
            this.tabPageWS.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private TabControl tabControlMain;
        private TabPage tabPagePK;
        private TabPage tabPagePKWS;
        private TabPage tabPageERPWS;
        private TabControl tabControlPK;
        private TabPage tabPageLogin;
        private TabPage tabPageSearch;
        private UCNavigator ucNavigator1;
        private TabPage tabPageAccount;
        private UCAccount ucAccount1;
        private UCLogin ucLogin1;
        private UCEmployee ucEmployee1;
        private UCBookARoomClient ucBookARoomClient1;
        private TabPage tabPageWS;
        private UCUppgift2_1 ucUppgift2_11;
    }
}

