﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.Controllers;

namespace BookARoom.Views
{
    public partial class UCAccount : UserControl
    {
        Controller controller = new Controller();

        public delegate void PassBookingData(object sender, EventArgs e);
        public PassBookingData passBookingData;

        public UCAccount()
        {
            InitializeComponent();
        }
        public string getTelephoneNo(object sender, EventArgs e)
        {
            return tbxTelephone.Text;
        }

        public void btnEdit_Click(object sender, EventArgs e)
        {
            cbTitle.Enabled = true;
            tbxName.ReadOnly = false;
            tbxAdress.ReadOnly = false;
            tbxTelephone.ReadOnly = false;
            tbxEmail.ReadOnly = false;
            tbxPassword.ReadOnly = false;
            tbxPassword.Text = null;
            tbxRePassword.ReadOnly = false;
            tbxRePassword.Text = null;

            btnSave.Visible = true;
            btnAbort.Visible = true;


        }

        private void UCAccount_Load(object sender, EventArgs e)
        {
            cbTitle.Enabled = false;
            tbxName.ReadOnly = true;
            tbxAdress.ReadOnly = true;
            tbxTelephone.ReadOnly = true;
            tbxEmail.ReadOnly = true;
            tbxPassword.ReadOnly = true;
            tbxRePassword.ReadOnly = true;

            btnSave.Visible = false;
            btnAbort.Visible = false;
        }

        private void UCAccount_LoadUser(object sender, EventArgs e)
        {
            sender = sender as UCLogin;
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            if (tbxPassword.Text.Equals(tbxRePassword.Text))
            {
                string title = cbTitle.Text;
                string name = tbxName.Text;
                string adress = tbxAdress.Text;
                string telephone = tbxTelephone.Text;
                string email = tbxEmail.Text;
                string password = tbxPassword.Text;

                controller.AddCustomer(title, name, adress, telephone, email, password);

                lblStatus.Text = "Customer was added!";
                lblStatus.ForeColor = System.Drawing.Color.Green;
                lblStatus.Visible = true;

                cbTitle.Enabled = false;
                tbxName.ReadOnly = true;
                tbxAdress.ReadOnly = true;
                tbxTelephone.ReadOnly = true;
                tbxEmail.ReadOnly = true;
                tbxPassword.ReadOnly = true;
                tbxRePassword.ReadOnly = true;

                btnSave.Visible = false;
                btnAbort.Visible = false;
            }
            else {
                lblStatus.Text = "Paswords does not match!";
                lblStatus.Visible = true;
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (passBookingData != null)
                passBookingData(tbxEmail, e);
        }
    }
}
