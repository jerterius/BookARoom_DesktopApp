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
        public UCLogin()
        {
            InitializeComponent();
        }

        private void linkLblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

        }

        private void linkLblNewUser_LinkClicked_1(object sender, LinkLabelLinkClickedEventArgs e)
        {
            TabControl tabControl = this.Parent.Controls.Find("tabControlPK", true)[0] as TabControl;
            tabControl.SelectedIndex = 2;
        }
    }
}
