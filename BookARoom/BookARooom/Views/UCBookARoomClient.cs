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


namespace BookARoom.Views
{
    public partial class UCBookARoomClient : UserControl
    {
        //For making a simple comit
        public UCBookARoomClient()
        {
            InitializeComponent();
            
        }
        private void cbSelectEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            using (BookARoomWebServiceSoapClient service = new BookARoomWebServiceSoapClient())
            {

                switch (cbSelectEntityTable.Text)
                {
                    case "All Bookings":
                        entitiesDataGridView.DataSource = service.GetAllBookings();
                        break;

                    case "All Hotels":
                        entitiesDataGridView.DataSource = service.GetAllHotels();
                        break;

                    case "All Customers":
                        entitiesDataGridView.DataSource = service.GetAllCustomers();
                        break;

                    case "All Rooms":
                        entitiesDataGridView.DataSource = service.GetAllCities();
                        break;

                    case "All Cities":
                        entitiesDataGridView.DataSource = service.GetAllBookings();
                        break;
                }
            }

 
        }
    }
}
