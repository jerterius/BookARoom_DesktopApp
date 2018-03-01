using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReferenceCronus2;
using BookARoom.Utilities;

namespace BookARoom.Views
{
    public partial class UCEmployee : UserControl
    {
        //ServiceSoapClient service = new ServiceSoapClient();
        public UCEmployee()
        {
            InitializeComponent();
        }
        public string EmployeeNo { get; set; }

        private void BtnSave_UpdateClick(object sender, EventArgs e)
        {
            try {


            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }
        private void BtnSave_InsertClick(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
        }
        private void BtnSave_RemoveClick(object sender, EventArgs e)
        {
            try
            {


            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }


        }


        private void BtnNew_Click(object sender, EventArgs e)
        {

            try
            {
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).ReadOnly = false;
                        (c as TextBox).Text = null;
                    }

                    if (c is Button)
                    {
                        (c as Button).Visible = true;
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
                foreach (Control c in this.Controls)
                {
                    if (c is TextBox)
                    {
                        (c as TextBox).ReadOnly = true;
                    }

                    this.btnCancel.Visible = false;
                    this.btnSave.Visible = false;

                }

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
                        case "All Employees":

                            tablesDataGridView.DataSource = service.GetAllEmployees();
                            
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
                if (cbSelectedTable.Text.Equals("All Employees"))
                {
                    tbxTitle.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Job_Title"].Value.ToString();
                    tbxFirstName.Text = tablesDataGridView.Rows[e.RowIndex].Cells["First_Name"].Value.ToString();
                    tbxLastName.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Last_Name"].Value.ToString();
                    tbxAdress.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();

                    EmployeeNo = tablesDataGridView.Rows[e.RowIndex].Cells["No_"].Value.ToString();
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
                CRONUS_Sverige_AB_Employee newEmployee = new CRONUS_Sverige_AB_Employee();

            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }
           

        }
    }
}
