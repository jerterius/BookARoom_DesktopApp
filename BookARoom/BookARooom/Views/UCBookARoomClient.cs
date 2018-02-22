using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReference1;

namespace BookARoom.View
{
    public partial class UCBookARoomClient : UserControl
    {
       BookARoomWebServiceSoapClient service = new BookARoomWebServiceSoapClient();
        public UCBookARoomClient()
        {
            InitializeComponent();
            
        }

        private void cbSelectEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedTable = cbSelectEntityTable.Text;
            List<ServiceReference1.Booking> entityList = service.GetAllBookings();
            


            //List<Booking> entityList = bookARoomWebService1.GetEntities(selectedTable).Cast<Booking>().ToList();

            entitiesDataGridView.DataSource = entityList;
        }
    }
}
