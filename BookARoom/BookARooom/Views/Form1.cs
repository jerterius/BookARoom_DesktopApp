using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.DAL;
using BookARoom.Models;
using System.Data.Entity;

namespace BookARoom.Views
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //Säger till ucNavigator att när dess clickevent körs så skall ucAccount tbxTelephone hämtas

          //  ucNavigator1.getBookingData += new UCNavigator.GetBookingData(ucAccount1.);

            ucAccount1.passBookingData += new UCAccount.PassBookingData(ucNavigator1.GetCustomer);
            ucLogin1.changeTab += new UCLogin.ChangeTab(this.SelectAccountTab);
         

        }

        private void ucNavigator1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }



        private void lLblNewUser_Click(object sender, EventArgs e)
        {
            tabControlPK.SelectedTab = tabPageAccount;
          
        }

        private void SelectAccountTab(object sender, EventArgs e)
        {
            this.tabControlPK.SelectedTab = tabPageAccount;
        }
    }
}
