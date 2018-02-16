using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace BookARoom.Views
{
    public partial class UCLogin : UserControl
    {

        public delegate void ChangeTab(object sender, EventArgs e);
        public ChangeTab changeTab;

        
        public UCLogin()
        {
            InitializeComponent();
        }

        private void linkLblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            if (changeTab != null)
                changeTab(this, EventArgs.Empty);
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;


        }
    }
}
