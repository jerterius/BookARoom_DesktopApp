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

namespace BookARoom.Views
{
    public partial class UCLogin : UserControl
    {
        public delegate void UserLoggedIn(object sender, EventArgs e);
        public UserLoggedIn userLoggedIn;

        public delegate void ChangeTab(object sender, EventArgs e);
        public ChangeTab changeTab;

        public string Email { get; set; }
        public string Password { get; set; }
        private Controller controller = new Controller();

        //Kanske inte ska vara en IQueryable<object>
        public object Customer { get; set; }


        
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
            Email = tbxEmail.Text;
            Password = tbxPassword.Text;

            if(controller.RetrieveCustomer(Email, Password) == null) {
                lblLoginStatus.Visible = true;
            }
            else
            {
                lblLoginStatus.Visible = false;
                Customer = controller.RetrieveCustomer(Email, Password);

                if (userLoggedIn != null)
                    userLoggedIn(Customer, EventArgs.Empty);

            }
            

        }
    }
}
