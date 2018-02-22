using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoomClient.Models;
using BookARoomClient.ServiceReference1;

namespace BookARoomClient.View
{
    public partial class UCBookARoomClient : UserControl
    {
       // BookARoomWebServiceSoapClient service = new BookARoomWebServiceSoapClient();
        public UCBookARoomClient()
        {
            InitializeComponent();
            
        }

        private void cbSelectEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbSelectEntityTable.Text;
           // List<ServiceReference1.Booking> entityList = service.GetEntities(selectedTable).Cast<ServiceReference1.Booking>().ToList();
            


            //List<Booking> entityList = bookARoomWebService1.GetEntities(selectedTable).Cast<Booking>().ToList();

            //entitiesDataGridView.DataSource = entityList;
        }
    }
}
