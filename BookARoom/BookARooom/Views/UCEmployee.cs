using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReferenceCronus;
using BookARoom.Utilities;
using System.Data.Entity.Validation;
using System.Web.Services.Protocols;

namespace BookARoom.Views
{
    public partial class UCEmployee : UserControl
    {
        public UCEmployee()
        {
            InitializeComponent();
        }
        public string EmployeeNo { get; set; }

        public bool CreateEmployeeEnabled { get; set; }

        private CRONUS_Sverige_AB_Partner partner;

        private void ToggleReadOnly(bool setting)
        {
            foreach (Control c in this.Controls)
            {
                if (c is TextBox)
                {
                    (c as TextBox).ReadOnly = setting;
                }

                
                btnSave.Visible = !setting;
                btnCancel.Visible = !setting;
                
            }
        }
        private void BtnSave_Click(object sender, EventArgs e)
        {
            try {
                using (CronusWebServiceSoapClient service = new CronusWebServiceSoapClient())
                {



                    if (CreateEmployeeEnabled) //Skapa ny kund
                    {
                        partner = new CRONUS_Sverige_AB_Partner()
                        {
                            Company = tbxCompanyName.Text,
                            Adress = tbxAddress.Text,
                            PhoneNumber = tbxPhoneNo.Text,
                            Email = tbxEmail.Text
                           

                        };
                        
                        service.AddPartner(partner);
                        
                            lblResponse.Text = "Partner was added.";
                            lblResponse.Visible = true;

                        ToggleReadOnly(true);

                    }
                    else //Uppdatera befintlig kund
                    {

                        CRONUS_Sverige_AB_Partner updatePartner = new CRONUS_Sverige_AB_Partner()
                        {
                            Company = tbxCompanyName.Text,
                            Adress = tbxAddress.Text,
                            PhoneNumber = tbxPhoneNo.Text,
                            Email = tbxEmail.Text
                        };

                        service.UpdatePartner(partner, updatePartner);


                        lblResponse.Text = "Partner was updated.";
                        lblResponse.Visible = true;
                    }
                } 

            }
            catch (SoapException ex)
            {
                lblResponse.Text = "Partner could not be added. Check required fields.";
            }
        }



        private void BtnNew_Click(object sender, EventArgs e)
        {

            try
            {
                CreateEmployeeEnabled = true;

                ToggleReadOnly(false);

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        
                        (c as TextBox).Text = null;
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
            try
            {
                ToggleReadOnly(true);

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        private void CbSelectedTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                string selectedTable = this.cbSelectedTable.Text;

                using (CronusWebServiceSoapClient service = new CronusWebServiceSoapClient())
                {

                    switch (selectedTable)
                    {
                        case "All Partners":

                            tablesDataGridView.DataSource = service.GetAllPartners();

                            break;

                        case "Content and metadata from Employee and related tables":
                            tablesDataGridView.DataSource = service.GetEmployeeMetaDataAndRelated();

                            break;

                        case "Employees And Relatives":
                            tablesDataGridView.DataSource = service.GetEmployeesAndRelatives();
                            break;

                        case "Employee Absence(2004)":
                            tablesDataGridView.DataSource = service.GetEmployeesSick2004();
                            break;

                        case "Employees With Most Absence":
                            tablesDataGridView.DataSource = service.GetTop5EmployeesAbsent();
                            break;

                        case "All Keys":

                            tablesDataGridView.DataSource = service.GetAllKeys();
                            break;

                        case "All Indexes":

                            tablesDataGridView.DataSource = service.GetAllIndexes();
                            break;

                        case "All Table Constraints":

                            tablesDataGridView.DataSource = service.GetAllConstraints();
                            break;

                        case "All Tables In Database":

                            tablesDataGridView.DataSource = service.GetAllTablesInDB();
                            break;

                        case "All Columns From Employee-Table":
                            tablesDataGridView.DataSource = service.GetAllColumnsInEmployees();
                            break;
                    }


                }

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
            

        }



        private void TablesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                if (cbSelectedTable.Text.Equals("All Partners"))
                {
                    tbxCompanyName.Text = tablesDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
                    tbxAddress.Text = tablesDataGridView.Rows[e.RowIndex].Cells[1].Value.ToString();
                    tbxPhoneNo.Text = tablesDataGridView.Rows[e.RowIndex].Cells[2].Value.ToString();
                    tbxEmail.Text = tablesDataGridView.Rows[e.RowIndex].Cells[3].Value.ToString();

                    partner = new CRONUS_Sverige_AB_Partner()
                    {
                        Company = tbxCompanyName.Text,
                        Adress = tbxAddress.Text,
                        PhoneNumber = tbxPhoneNo.Text,
                        Email = tbxEmail.Text
                    };
                    
                }

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }

        private void BtnEdit_Click(object sender, EventArgs e)
        {

            try
            {
                ToggleReadOnly(false);

                partner = new CRONUS_Sverige_AB_Partner()
                {
                    Company = tbxCompanyName.Text,
                    Adress = tbxAddress.Text,
                    PhoneNumber = tbxPhoneNo.Text,
                    Email = tbxEmail.Text
                };

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
           

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                using (CronusWebServiceSoapClient service = new CronusWebServiceSoapClient())
                {
                    service.RemovePartner(partner);
                }

                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {

                        (c as TextBox).Text = null;
                    }
                }

                lblResponse.Text = "Partner was removed.";
                lblResponse.Visible = true;
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }
    }
}
