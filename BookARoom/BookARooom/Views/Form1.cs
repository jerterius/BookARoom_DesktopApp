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
using BookARoom.Controllers;


namespace BookARoom.Views
{
    public partial class Form1 : Form
    {
        public Controller Controller {get; set;}

        public Form1()
        {
            Controller = new Controller();
            InitializeComponent();
            //Säger till ucNavigator att när dess clickevent körs så skall ucAccount tbxTelephone hämtas

          //  ucNavigator1.getBookingData += new UCNavigator.GetBookingData(ucAccount1.);

            ucAccount1.passBookingData += new UCAccount.PassBookingData(ucNavigator1.GetCustomerData);
            ucLogin1.changeTab += new UCLogin.ChangeTab(this.SelectAccountTab);
            ucLogin1.changeTab += new UCLogin.ChangeTab(ucAccount1.btnEdit_Click);
            ucLogin1.userLoggedIn += new UCLogin.UserLoggedIn(ucAccount1.UCAccount_LoadUser);
            ucLogin1.userLoggedIn += new UCLogin.UserLoggedIn(this.SelectAccountTab);
         

        }

        private void ucNavigator1_Load(object sender, EventArgs e)
        {
            this.Dock = DockStyle.Fill;
        }

        private void SelectAccountTab(object sender, EventArgs e)
        {
            if (!tabControlPK.TabPages.ContainsKey("tabPageAccount")){
                this.tabControlPK.TabPages.Add(tabPageAccount);
            }
            
            this.tabControlPK.SelectedTab = tabPageAccount;
        }
    }
}
