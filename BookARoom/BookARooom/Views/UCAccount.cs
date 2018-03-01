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
using BookARoom.DAL;

namespace BookARoom.Views
{
    public partial class UCAccount : UserControl
    {
        Controller controller = new Controller();

        public delegate void UpdateUser(Customer c, EventArgs e);
        public UpdateUser userUpdated;

        public delegate void UserLogOut(Customer c, EventArgs e);
        public UserLogOut userLogOut;

        public Customer Customer { get; set; }

        public bool CreateCustomerEnabled { get; set; } = false;
        public bool ReadOnly { get; set; } = true;

        public UCAccount()
        {
            try { 


            InitializeComponent();
             } catch (Exception ex)
                {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
                }
        }

        private  void ToggleReadOnly(bool setting)
        {
            try { 
                foreach (Control c in Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).ReadOnly = setting;
                    }
                    else if (c is ComboBox)
                    {
                        (c as ComboBox).Enabled = !setting;
                    }

                    lblRePassword.Visible = !setting;
                    tbxRePassword.Visible = !setting;

                    lblEmailAsterix.Visible = !setting;
                    lblPasswordAsterix.Visible = !setting;
                    lblRePasswordAsterix.Visible = !setting;

                    btnSave.Visible = !setting;
                    btnCancel.Visible = !setting;
                }

            btnSave.Visible = !setting;
            btnCancel.Visible = !setting;

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }

        public void BtnEdit_Click(object sender, EventArgs e)
        {
            try { 
            ToggleReadOnly(false);

            foreach (Control c in Controls)
            {
                if (c is TextBox || c is ComboBox)
                {
                    c.DataBindings.Clear();
                }
            }
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        public void LoadCustomer(Customer c, EventArgs e)
        {
            try
            {
                Customer = c;
                customerBindingSource.DataSource = Customer ?? new Customer();
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        public void UpdateCustomer(object sender, EventArgs e)
        {
            try { 
            Customer = controller.RetrieveCustomer(Customer.CEmail, Customer.Password);
                customerBindingSource.DataSource = Customer;
            
             } catch (Exception ex)
                {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
                }
}


        private void BtnSave_Click(object sender, EventArgs e)
        {
            try { 
            string title = cbTitle.Text;
            string name = tbxName.Text;
            string adress = tbxAdress.Text;
            string telephone = tbxTelephone.Text;
            string email = tbxEmail.Text;
            string password = tbxPassword.Text;

            Customer newCustomer = new Customer()
            {
                Title = title,
                CName = name,
                CAdress = adress,
                CPhoneNumber = telephone,
                CEmail = email,
                Password = password

            };

            if (CreateCustomerEnabled) //Skapa ny kund
            {
                if (tbxPassword.Text.Equals(tbxRePassword.Text))
                {

                    controller.AddCustomer(newCustomer);

                    lblStatus.Text = "Customer was added!";
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                    lblStatus.Visible = true;

                    ToggleReadOnly(true);

                    Customer = controller.RetrieveCustomer(email, password);

                        userUpdated?.Invoke(Customer, EventArgs.Empty);

                        CreateCustomerEnabled = false;
                }
                else
                {
                    lblStatus.Text = "Paswords does not match!";
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                    lblStatus.Visible = true;
                }
            }
            else //Uppdatera kund
            {
                if (tbxPassword.Text.Equals(tbxRePassword.Text))
                {
              
                    controller.Update(Customer, newCustomer);

                    lblStatus.Text = "Customer was updated!";
                    lblStatus.ForeColor = System.Drawing.Color.Black;
                    lblStatus.Visible = true;

                    ToggleReadOnly(false);

                    Customer = controller.RetrieveCustomer(email, password);
                    /*
                    if (userUpdated != null)
                        userUpdated(Customer, EventArgs.Empty);*/

                    CreateCustomerEnabled = false;
                }
                else
                {
                    lblStatus.Text = "Paswords does not match!";
                    lblStatus.Visible = true;
                }   

            }
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }


        private void BtnCancel_Click(object sender, EventArgs e)
        {
            try { 

            ToggleReadOnly(true);

            LoadCustomer(Customer, e);

            cbTitle.DataBindings.Add("Text", customerBindingSource, "Title");

            tbxName.DataBindings.Add("Text", customerBindingSource, "CName");

            tbxAdress.DataBindings.Add("Text", customerBindingSource, "CAdress");

            tbxTelephone.DataBindings.Add("Text", customerBindingSource, "CPhoneNumber");

            tbxEmail.DataBindings.Add("Text", customerBindingSource, "CEmail");

            tbxPassword.DataBindings.Add("Text", customerBindingSource, "Password");
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }
        public void SetCreateUser(object sender, EventArgs e)
        {
            try { 
            ToggleReadOnly(false);

            CreateCustomerEnabled = true;
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }

        private void BtnLogOut_Click(object sender, EventArgs e)
        {
            try { 
            Customer = null;
            LoadCustomer(Customer, e);

                userUpdated?.Invoke(Customer, EventArgs.Empty);

                userLogOut?.Invoke(Customer, EventArgs.Empty);

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }

        private void BtnDeleteBooking_Click(object sender, EventArgs e)
        {
           // try { 
            foreach (DataGridViewRow row in bookingDataGridView.Rows)
            {
                if (Convert.ToBoolean(row.Cells["removeDataGridViewTextBoxColumn"].Value))
                {
                    controller.DeleteBooking(new Guid(row.Cells["bookingNumberDataGridViewTextBoxColumn"].Value.ToString()));
                }
            }
            Customer = controller.RetrieveCustomer(tbxEmail.Text, tbxPassword.Text);
            LoadCustomer(Customer, null);
            /*}
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }*/
        }
    }
}
