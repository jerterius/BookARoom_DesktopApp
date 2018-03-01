using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Services;
using System.Web.Services.Protocols;
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
            try
            {
                return controller.GetAllBookings();
            } catch (Exception e)
            {
                throw new SoapException("Oväntat fel", SoapException.ServerFaultCode, "Oväntat fel", e);
            }
        }
        [WebMethod]
        public List<Room> GetAllRooms()
        {
            try
            {
                return controller.GetAllRooms();
            } catch (Exception e)
            {
                throw new SoapException("Oväntat fel", SoapException.ServerFaultCode, "Oväntat fel", e);
            }
        }
        [WebMethod]
        public List<City> GetAllCities()
        {
            try
            {
                return controller.GetAllCities();
            } catch (Exception e)
            {
                throw new SoapException("Oväntat fel", SoapException.ServerFaultCode, "Oväntat fel", e);
            }
        }
        [WebMethod]
        public List<Hotel> GetAllHotels()
        {
            try
            {
                return controller.GetAllHotels();
            } catch (Exception e)
            {
                throw new SoapException("Oväntat fel", SoapException.ServerFaultCode, "Oväntat fel", e);
            }
        }
        [WebMethod]
        public List<Customer> GetAllCustomers()
        {
            try
            {
                return controller.GetAllCustomers();
            } catch (Exception e)
            {
                throw new SoapException("Oväntat fel", SoapException.ServerFaultCode, "Oväntat fel", e);
            }
        }
    }
}
