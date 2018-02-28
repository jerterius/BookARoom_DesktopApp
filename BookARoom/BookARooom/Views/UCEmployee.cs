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

        private void btnSave_UpdateClick(object sender, EventArgs e)
        {

        }
        private void btnSave_InsertClick(object sender, EventArgs e)
        {

        }
        private void btnSave_RemoveClick(object sender, EventArgs e)
        {

        }


        private void btnNew_Click(object sender, EventArgs e)
        {
            foreach(Control c in this.Controls)
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

        private void btnCancel_Click(object sender, EventArgs e)
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

        private void cbSelectedTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = this.cbSelectedTable.Text;

            using (CronusWebServiceSoapClient service = new CronusWebServiceSoapClient())
            {
                /*
                //Hej Webbservice din "GetTables" med inparameter "selectedtables"
                string[] nyArray = { "hej", "svej", "grej" };
                List<string[]> nyLista = new List<string[]>();
                nyLista.Add(nyArray);

               //var source = service.GetEmployeeTables(selectedTable);
               var bindingList = new BindingList<string[]>(nyLista);

                var source = new BindingSource(bindingList, null);

                tablesDataGridView.DataSource = nyLista;
               // tablesDataGridView.DataMember = "Employees";*/

                switch (selectedTable)
                {
                    case "All Employees":

                        tablesDataGridView.DataSource = service.GetAllEmployees();
                        
                        break;

                    case "Content and metadata from Employee and related tables":
                        tablesDataGridView.DataSource = service.GetEmployeeMetaDataAndRelated();

                        break;

                    case "Employees And Relatives":

                        break;

                    case "Employee Absence(2004)":

                        break;

                    case "Employees With Most Absence":

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



        private void tablesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
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

        private void btnEdit_Click(object sender, EventArgs e)
        {
            CRONUS_Sverige_AB_Employee newEmployee = new CRONUS_Sverige_AB_Employee();

        }
    }
}
