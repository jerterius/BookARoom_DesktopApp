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

        private void linkLblNewUser_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {

            if (Customer == null) {
                if (createUser != null)
                {
                    createUser(this, EventArgs.Empty);
                    lblLoginStatus.Visible = false;
                }
            } else
            {
                lblLoginStatus.Text = "You are already logged in!";
                    lblLoginStatus.Visible = true;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
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

                    if (userLoggedIn != null)
                        userLoggedIn(Customer, EventArgs.Empty);

                }
            }else
            {
                lblLoginStatus.Text = "You are already logged in!";
                lblLoginStatus.Visible = true;
            }
            

        }

        public void LoadUser(object sender, EventArgs e)
        {
            Customer = sender as Customer;
        }
    }
}
