﻿using System;
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
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();

            ucLogin1.userLoggedIn += new UCLogin.UserLoggedIn(ucNavigator1.LoadUser);
            ucLogin1.userLoggedIn += new UCLogin.UserLoggedIn(ucAccount1.LoadCustomer);
            ucLogin1.userLoggedIn += new UCLogin.UserLoggedIn(this.SelectAccountTab);

            ucLogin1.createUser += new UCLogin.ChangeTab(this.SelectAccountTab);
            ucLogin1.createUser += new UCLogin.ChangeTab(ucAccount1.SetCreateUser);

            ucAccount1.userUpdated += new UCAccount.UpdateUser(ucNavigator1.LoadUser);
            ucAccount1.userUpdated += new UCAccount.UpdateUser(ucLogin1.LoadUser);

            ucAccount1.userLogOut += new UCAccount.UserLogOut(this.CloseAccountTab);
            ucAccount1.userLogOut += new UCAccount.UserLogOut(ucNavigator1.LoadUser);
            ucAccount1.userLogOut += new UCAccount.UserLogOut(ucAccount1.LoadCustomer);

            ucNavigator1.updateBookings += new UCNavigator.UpdateBookings(ucAccount1.UpdateCustomer);

            

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

        private void CloseAccountTab(object sender, EventArgs e)
        {
            this.tabControlPK.TabPages.Remove(tabPageAccount);
        }
    }
}
