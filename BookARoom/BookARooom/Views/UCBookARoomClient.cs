using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.ServiceReferenceBookARoom;
using BookARoom.Utilities;


namespace BookARoom.Views
{
    public partial class UCBookARoomClient : UserControl
    {
        //For making a simple comit
        public UCBookARoomClient()
        {
            try
            {
                InitializeComponent();
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
            }

        }
        private void CbSelectEntityTable_SelectedIndexChanged(object sender, EventArgs e)
        {
            try { 
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
                        entitiesDataGridView.DataSource = service.GetAllRooms();
                        break;

                    case "All Cities":
                        entitiesDataGridView.DataSource = service.GetAllCities();
                        break;
                }
            }
            }
            catch (Exception ex)
            {
                lblResponse.Text = ExceptionHandler.ConvertExceptionToMessage(ex);
                lblResponse.Visible = true;
                lblResponse.Text = ex.GetType().ToString();
            }


        }

        private void UCBookARoomClient_Load(object sender, EventArgs e)
        {

        }
    }
}
