namespace BookARoom.Views
{
    partial class UCLogin
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
            this.lblUserName = new System.Windows.Forms.Label();
            this.tbxEmail = new System.Windows.Forms.TextBox();
            this.tbxPassword = new System.Windows.Forms.TextBox();
            this.lblLoginPass = new System.Windows.Forms.Label();
            this.btnLogin = new System.Windows.Forms.Button();
            this.linkLblNewUser = new System.Windows.Forms.LinkLabel();
            this.lblLoginStatus = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Location = new System.Drawing.Point(102, 154);
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(57, 20);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "E-Mail:";
            // 
            // tbxEmail
            // 
            this.tbxEmail.Location = new System.Drawing.Point(165, 151);
            this.tbxEmail.Name = "tbxEmail";
            this.tbxEmail.Size = new System.Drawing.Size(184, 26);
            this.tbxEmail.TabIndex = 2;
            // 
            // tbxPassword
            // 
            this.tbxPassword.Location = new System.Drawing.Point(165, 195);
            this.tbxPassword.Name = "tbxPassword";
            this.tbxPassword.PasswordChar = '*';
            this.tbxPassword.Size = new System.Drawing.Size(184, 26);
            this.tbxPassword.TabIndex = 2;
            // 
            // lblLoginPass
            // 
            this.lblLoginPass.AutoSize = true;
            this.lblLoginPass.Location = new System.Drawing.Point(86, 198);
            this.lblLoginPass.Name = "lblLoginPass";
            this.lblLoginPass.Size = new System.Drawing.Size(82, 20);
            this.lblLoginPass.TabIndex = 1;
            this.lblLoginPass.Text = "Password:";
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(203, 238);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(101, 31);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Login";
            this.btnLogin.UseVisualStyleBackColor = true;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // linkLblNewUser
            // 
            this.linkLblNewUser.AutoSize = true;
            this.linkLblNewUser.Location = new System.Drawing.Point(191, 286);
            this.linkLblNewUser.Name = "linkLblNewUser";
            this.linkLblNewUser.Size = new System.Drawing.Size(120, 20);
            this.linkLblNewUser.TabIndex = 4;
            this.linkLblNewUser.TabStop = true;
            this.linkLblNewUser.Text = "Create Account";
            this.linkLblNewUser.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.linkLblNewUser_LinkClicked);
            // 
            // lblLoginStatus
            // 
            this.lblLoginStatus.AutoSize = true;
            this.lblLoginStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoginStatus.ForeColor = System.Drawing.Color.Red;
            this.lblLoginStatus.Location = new System.Drawing.Point(134, 341);
            this.lblLoginStatus.Name = "lblLoginStatus";
            this.lblLoginStatus.Size = new System.Drawing.Size(247, 20);
            this.lblLoginStatus.TabIndex = 5;
            this.lblLoginStatus.Text = "Login failed: Incorrect details!";
            this.lblLoginStatus.Visible = false;
            // 
            // UCLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.lblLoginStatus);
            this.Controls.Add(this.linkLblNewUser);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.tbxPassword);
            this.Controls.Add(this.tbxEmail);
            this.Controls.Add(this.lblLoginPass);
            this.Controls.Add(this.lblUserName);
            this.Name = "UCLogin";
            this.Size = new System.Drawing.Size(487, 406);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblUserName;
        private System.Windows.Forms.TextBox tbxEmail;
        private System.Windows.Forms.TextBox tbxPassword;
        private System.Windows.Forms.Label lblLoginPass;
        private System.Windows.Forms.Button btnLogin;
        private System.Windows.Forms.LinkLabel linkLblNewUser;
        private System.Windows.Forms.Label lblLoginStatus;
    }
}
