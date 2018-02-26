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
using BookARoom.DAL;

namespace BookARoom.Views
{
    public partial class UCAccount : UserControl
    {
        Controller controller = new Controller();

        public delegate void UpdateUser(object sender, EventArgs e);
        public UpdateUser userUpdated;

        public delegate void UserLogOut(object sender, EventArgs e);
        public UserLogOut userLogOut;

        public Customer Customer { get; set; }

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

            lblRePassword.Visible = true;
            tbxRePassword.Visible = true;

            lblEmailAsterix.Visible = true;
            lblPasswordAsterix.Visible = true;
            lblRePasswordAsterix.Visible = true;
           

            btnSave.Visible = true;
            btnCancel.Visible = true;

            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.DataBindings.Clear();
                }
            }

        }

        public void LoadUser(object sender, EventArgs e)
        {
            Customer = sender as Customer;
            
            customerBindingSource.DataSource = Customer?? new Customer();
 
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
                btnCancel.Visible = false;
                Customer = controller.RetrieveCustomer(email, password);

                if (userUpdated != null)
                    userUpdated(Customer, EventArgs.Empty);
            }
            else
            {
                lblStatus.Text = "Paswords does not match!";
                lblStatus.Visible = true;
            }
        }

        private void tbxEmail_TextChanged(object sender, EventArgs e)
        {
            if (userUpdated != null)
                userUpdated(tbxEmail, e);
        }

        private void btnAbort_Click(object sender, EventArgs e)
        {
            cbTitle.Enabled = false;
            tbxName.ReadOnly = true;
            tbxAdress.ReadOnly = true;
            tbxTelephone.ReadOnly = true;
            tbxEmail.ReadOnly = true;
            tbxPassword.ReadOnly = true;

            tbxRePassword.ReadOnly = true;

            lblPasswordAsterix.Visible = false;
            lblEmailAsterix.Visible = false;
            lblRePassword.Visible = false;
            tbxRePassword.Visible = false;
            lblRePasswordAsterix.Visible = false;
            btnSave.Visible = false;
            btnCancel.Visible = false;

            LoadUser(Customer, e);
            tbxAdress.Text = Customer.CName;

            cbTitle.DataBindings.Add("Text", customerBindingSource, "Title");

            tbxName.DataBindings.Add("Text", customerBindingSource, "CName");

            tbxAdress.DataBindings.Add("Text", customerBindingSource, "CAdress");

            tbxTelephone.DataBindings.Add("Text", customerBindingSource, "CPhoneNumber");

            tbxEmail.DataBindings.Add("Text", customerBindingSource, "CEmail");

            tbxPassword.DataBindings.Add("Text", customerBindingSource, "Password");

        }
        public void SetCreateUser(object sender, EventArgs e)
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

            lblRePassword.Visible = true;
            tbxRePassword.Visible = true;

            lblEmailAsterix.Visible = true;
            lblPasswordAsterix.Visible = true;
            lblRePasswordAsterix.Visible = true;


            btnSave.Visible = true;
            btnCancel.Visible = true;
        }

        private void btnLogOut_Click(object sender, EventArgs e)
        {
            Customer = null;
            LoadUser(Customer, e);
            
            if (userUpdated != null)
                userUpdated(Customer, EventArgs.Empty);

            if (userLogOut != null)
                userLogOut(Customer, EventArgs.Empty);

            
        }

        private void btnDeleteBooking_Click(object sender, EventArgs e)
        {
            foreach(DataGridViewRow row in bookingDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells[4].Value))
                {
                    controller.DeleteBooking(new Guid(row.Cells[0].Value.ToString()));
                }
            }
        }
    }
}
