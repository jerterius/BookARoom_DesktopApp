using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;
using BookARoomServiceApp.DAL;

/// <summary>
/// Summary description for ControllerBookARoomClient
/// </summary>
public class ControllerBookARoomClient
{
    //DalBookARoomClient dal = new DalBookARoomClient();
    DalBooking dalBooking = new DalBooking();
    DalCity dalCity = new DalCity();
    DalCustomer dalCustomer = new DalCustomer();
    DalHotel dalHotel = new DalHotel();
    DalRoom dalRoom = new DalRoom();
    
    public ControllerBookARoomClient()
    {

    }

    public List<Booking> GetAllBookings()
    {
        return dalBooking.GetEntities();
    }

    public List<City> GetAllCities()
    {
        return dalCity.GetEntities();
    }

    public List<Customer> GetAllCustomers()
    {
        return dalCustomer.GetEntities();
    }

    public List<Hotel> GetAllHotels()
    {
        return dalHotel.GetEntities();
    }

    public List<Room> GetAllRooms()
    {
        return dalRoom.GetEntities();
    }

   /* public List<object> GetEntities(string selectFunction)
    {

        List<object> returnObjects = new List<object>();

        switch (selectFunction)
        {
            case "All Bookings":
                returnObjects = dal.GetAllBookings().Cast<object>().ToList();
                break;
            case "All Cities":
                returnObjects = dal.GetAllCities().Cast<object>().ToList();
                break;
            case "All Customers":
                returnObjects = dal.GetAllCustomers().Cast<object>().ToList();
                break;
            case "All Hotels":
                returnObjects = dal.GetAllHotels().Cast<object>().ToList();
                break;
            case "All Rooms":
                returnObjects = dal.GetAllRooms().Cast<object>().ToList();
                break;
        }

        return returnObjects;
        
    }
    */
    
}