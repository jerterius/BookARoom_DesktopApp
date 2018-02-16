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
            this.tabControlPK = new System.Windows.Forms.TabControl();
            this.tabPageLogin = new System.Windows.Forms.TabPage();
            this.lLblNewUser = new System.Windows.Forms.LinkLabel();
            this.ucAccount1 = new BookARoom.Views.UCAccount();
            this.btnLogin = new System.Windows.Forms.Button();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.lblUserName = new System.Windows.Forms.Label();
            this.tabPageSearch = new System.Windows.Forms.TabPage();
            this.ucNavigator1 = new BookARoom.Views.UCNavigator();
            this.tabPageAccount = new System.Windows.Forms.TabPage();
            this.tabPagePKWS = new System.Windows.Forms.TabPage();
            this.tabPageERPWS = new System.Windows.Forms.TabPage();
            this.tabControlMain.SuspendLayout();
            this.tabPagePK.SuspendLayout();
            this.tabControlPK.SuspendLayout();
            this.tabPageLogin.SuspendLayout();
            this.tabPageSearch.SuspendLayout();
            this.tabPageAccount.SuspendLayout();
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
            this.tabControlMain.Size = new System.Drawing.Size(1578, 1110);
            this.tabControlMain.SizeMode = System.Windows.Forms.TabSizeMode.FillToRight;
            this.tabControlMain.TabIndex = 0;
            // 
            // tabPagePK
            // 
            this.tabPagePK.Controls.Add(this.tabControlPK);
            this.tabPagePK.Location = new System.Drawing.Point(4, 29);
            this.tabPagePK.Name = "tabPagePK";
            this.tabPagePK.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePK.Size = new System.Drawing.Size(1570, 1077);
            this.tabPagePK.TabIndex = 0;
            this.tabPagePK.Text = "Programkonstruktion";
            this.tabPagePK.UseVisualStyleBackColor = true;
            // 
            // tabControlPK
            // 
            this.tabControlPK.Controls.Add(this.tabPageLogin);
            this.tabControlPK.Controls.Add(this.tabPageSearch);
            this.tabControlPK.Controls.Add(this.tabPageAccount);
            this.tabControlPK.Dock = System.Windows.Forms.DockStyle.Top;
            this.tabControlPK.Location = new System.Drawing.Point(3, 3);
            this.tabControlPK.Name = "tabControlPK";
            this.tabControlPK.SelectedIndex = 0;
            this.tabControlPK.Size = new System.Drawing.Size(1564, 1078);
            this.tabControlPK.TabIndex = 0;
            // 
            // tabPageLogin
            // 
            this.tabPageLogin.Controls.Add(this.lLblNewUser);
            this.tabPageLogin.Controls.Add(this.btnLogin);
            this.tabPageLogin.Controls.Add(this.textBox2);
            this.tabPageLogin.Controls.Add(this.textBox1);
            this.tabPageLogin.Controls.Add(this.lblLoginPass);
            this.tabPageLogin.Controls.Add(this.lblUserName);
            this.tabPageLogin.Location = new System.Drawing.Point(4, 29);
            this.tabPageLogin.Name = "tabPageLogin";
            this.tabPageLogin.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageLogin.Size = new System.Drawing.Size(1556, 1045);
            this.tabPageLogin.TabIndex = 0;
            this.tabPageLogin.Text = "Login";
            this.tabPageLogin.UseVisualStyleBackColor = true;
            // 
            // lLblNewUser
            // 
            this.lLblNewUser.AutoSize = true;
            this.lLblNewUser.Location = new System.Drawing.Point(162, 275);
            this.lLblNewUser.Name = "lLblNewUser";
            this.lLblNewUser.Size = new System.Drawing.Size(130, 20);
            this.lLblNewUser.TabIndex = 3;
            this.lLblNewUser.TabStop = true;
            this.lLblNewUser.Text = "Create New User";
            this.lLblNewUser.Click += new System.EventHandler(this.lLblNewUser_Click);
            // 
            // ucAccount1
            // 
            this.ucAccount1.BtnEdit = null;
            this.ucAccount1.Location = new System.Drawing.Point(6, 6);
            this.ucAccount1.Name = "ucAccount1";
            this.ucAccount1.Size = new System.Drawing.Size(952, 621);
            this.ucAccount1.TabIndex = 0;
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(191, 164);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(75, 31);
            this.btnLogin.TabIndex = 2;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(151, 113);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(169, 26);
            this.textBox2.TabIndex = 1;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(151, 70);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(169, 26);
            this.textBox1.TabIndex = 1;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Location = new System.Drawing.Point(52, 116);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(82, 20);
            this.lblLoginPass.TabIndex = 0;
            this.lblLoginPass.Text = "Password:";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(77, 73);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "E-mail:";
            // 
            // tabPageSearch
            // 
            this.tabPageSearch.Controls.Add(this.ucNavigator1);
            this.tabPageSearch.Location = new System.Drawing.Point(4, 29);
            this.tabPageSearch.Name = "tabPageSearch";
            this.tabPageSearch.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageSearch.Size = new System.Drawing.Size(1556, 1045);
            this.tabPageSearch.TabIndex = 1;
            this.tabPageSearch.Text = "Search";
            this.tabPageSearch.UseVisualStyleBackColor = true;
            // 
            // ucNavigator1
            // 
            this.ucNavigator1.AutoSize = true;
            this.ucNavigator1.Location = new System.Drawing.Point(6, 6);
            this.ucNavigator1.Name = "ucNavigator1";
            this.ucNavigator1.Size = new System.Drawing.Size(1432, 595);
            this.ucNavigator1.TabIndex = 0;
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
            // tabPagePKWS
            // 
            this.tabPagePKWS.Location = new System.Drawing.Point(4, 29);
            this.tabPagePKWS.Name = "tabPagePKWS";
            this.tabPagePKWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPagePKWS.Size = new System.Drawing.Size(1570, 1077);
            this.tabPagePKWS.TabIndex = 1;
            this.tabPagePKWS.Text = "Programkonstruktion & Webservice";
            this.tabPagePKWS.UseVisualStyleBackColor = true;
            // 
            // tabPageERPWS
            // 
            this.tabPageERPWS.Location = new System.Drawing.Point(4, 29);
            this.tabPageERPWS.Name = "tabPageERPWS";
            this.tabPageERPWS.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageERPWS.Size = new System.Drawing.Size(1570, 1077);
            this.tabPageERPWS.TabIndex = 2;
            this.tabPageERPWS.Text = "ERP & Webservice";
            this.tabPageERPWS.UseVisualStyleBackColor = true;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1578, 1144);
            this.Controls.Add(this.tabControlMain);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.tabControlMain.ResumeLayout(false);
            this.tabPagePK.ResumeLayout(false);
            this.tabControlPK.ResumeLayout(false);
            this.tabPageLogin.ResumeLayout(false);
            this.tabPageLogin.PerformLayout();
            this.tabPageSearch.ResumeLayout(false);
            this.tabPageSearch.PerformLayout();
            this.tabPageAccount.ResumeLayout(false);
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
        private LinkLabel lLblNewUser;
        private Button btnLogin;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label lblLoginPass;
        private Label lblUserName;
    }
}

