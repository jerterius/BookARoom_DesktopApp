using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.Controllers;
using BookARoom.Models;
using BookARoom.Utilities;

namespace BookARoom.Views
{
    public partial class UCLogin : UserControl
    {
        public delegate void UserLoggedIn(Customer c, EventArgs e);
        public UserLoggedIn userLoggedIn;

        public delegate void ChangeTab(object sender, EventArgs e);
        public ChangeTab createUser;

 
        private Controller controller = new Controller();

        //Kanske inte ska vara en IQueryable<object>
        public Customer Customer { get; set; }


        
        public UCLogin()
        {
            
            InitializeComponent();
        }

        private void LinkLblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            try
            {
                if (Customer == null)
                {
                    createUser?.Invoke(this, EventArgs.Empty);
                    lblLoginStatus.Visible = false;
                    
                }
                else
                {
                    lblLoginStatus.Text = "You are already logged in!";
                    lblLoginStatus.Visible = true;
                }

            }
            catch (Exception ex)
            {
                lblLoginStatus.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblLoginStatus.Visible = true;
            }

        }

        private void BtnLogin_Click(object sender, EventArgs e)
        {

            try
            {
                string email = tbxEmail.Text;
                string password = tbxPassword.Text;

                if (Customer == null)
                {

                    if (controller.RetrieveCustomer(email, password) == null)
                    {
                        lblLoginStatus.Visible = true;
                    }
                    else
                    {
                        lblLoginStatus.Visible = false;
                        Customer = controller.RetrieveCustomer(email, password);

                        userLoggedIn?.Invoke(Customer, EventArgs.Empty);

                    }
                }
                else
                {
                    lblLoginStatus.Text = "You are already logged in!";
                    lblLoginStatus.Visible = true;
                }

            }
            catch (Exception ex)
            {
                lblLoginStatus.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblLoginStatus.Visible = true;
            }
            

        }

        public void LoadUser(object sender, EventArgs e)
        {

            try
            {
                Customer = sender as Customer;

            }
            catch (Exception ex)
            {
                lblLoginStatus.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblLoginStatus.Visible = true;
            }
            
        }
    }
}
