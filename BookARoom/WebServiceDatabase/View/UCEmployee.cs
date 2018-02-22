using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WebServiceDatabase.View
{
    public partial class UCEmployee : UserControl
    {
        //ServiceSoapClient service = new ServiceSoapClient();
        public UCEmployee()
        {
            InitializeComponent();
        }

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

            //Hej Webbservice din "GetTables" med inparameter "selectedtables"

           employeeBindingSource.DataSource = serviceCronus.GetEmployeeTables(selectedTable);

            tablesDataGridView.DataSource = employeeBindingSource;
            tablesDataGridView.DataMember = "Employees";



        }



        private void tablesDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (cbSelectedTable.Text.Equals("All Employees"))
            {
                tbxTitle.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Job Title"].Value.ToString();
                tbxFirstName.Text = tablesDataGridView.Rows[e.RowIndex].Cells["First Name"].Value.ToString();
                tbxLastName.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Last Name"].Value.ToString();
                tbxAdress.Text = tablesDataGridView.Rows[e.RowIndex].Cells["Address"].Value.ToString();
            }
        }
    }
}
