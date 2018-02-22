using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
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
        public List<Booking> GetAllBookings(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<Booking>().ToList();
        }
        [WebMethod]
        public List<Room> GetAllRooms(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<Room>().ToList();
        }
        [WebMethod]
        public List<City> GetAllCities(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<City>().ToList();
        }
        [WebMethod]
        public List<Hotel> GetAllHotels(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<Hotel>().ToList();
        }
        [WebMethod]
        public List<Customer> GetAllCustomers(string selectedTable)
        {
            return controller.GetEntities(selectedTable).Cast<Customer>().ToList();
        }
    }
}
