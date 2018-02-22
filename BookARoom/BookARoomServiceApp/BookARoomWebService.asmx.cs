using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Xml.Serialization;
using BookARoomServiceApp.Models;




namespace BookARoomServiceApp
{
    /// <summary>
    /// Summary description for BookARoomWebService
    /// </summary>
    [WebService(Namespace = "http://tempuri.org/")]
    [WebServiceBinding(ConformsTo = WsiProfiles.BasicProfile1_1)]
    [System.ComponentModel.ToolboxItem(false)]
    // To allow this Web Service to be called from script, using ASP.NET AJAX, uncomment the following line. 
    // [System.Web.Script.Services.ScriptService]
    public class BookARoomWebService : System.Web.Services.WebService
    {
        ControllerBookARoomClient controller = new ControllerBookARoomClient();

        [WebMethod]
        public List<Booking> GetAllBookings()
        {
            return controller.GetEntities("All Bookings").Cast<Booking>().ToList();
        }
        [WebMethod]
        public List<Room> GetAllRooms()
        {
            return controller.GetEntities("All Rooms").Cast<Room>().ToList();
        }
        [WebMethod]
        public List<City> GetAllCities()
        {
            return controller.GetEntities("All Cities").Cast<City>().ToList();
        }
        [WebMethod]
        public List<Hotel> GetAllHotels()
        {
            return controller.GetEntities("All Hotels").Cast<Hotel>().ToList();
        }
        [WebMethod]
        public List<Customer> GetAllCustomers()
        {
            return controller.GetEntities("All Customers").Cast<Customer>().ToList();
        }
    }
}
