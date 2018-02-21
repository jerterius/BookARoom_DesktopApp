using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using BookARoom.Models;
using BookARoom.DAL;





/// <summary>
/// Summary description for DalBookARoomClient
/// </summary>
public class DalBookARoomClient
{

    SqlConnection con = new SqlConnection("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");

    BookingContext db = new BookingContext();
    


    public DalBookARoomClient()
    {

    }

    public List<Booking> GetAllBookings()
    {
        var allBookings = db.Bookings;

        return allBookings.ToList();
    }

    public List<City> GetAllCities()
    {
        var allCities = db.Cities;

        return allCities.ToList(); ;
    }

    public List<Customer> GetAllCustomers()
    {
        var allCustomers = db.Customers;

        return allCustomers.ToList();
    }

    public List<Hotel> GetAllHotels()
    {
        var allHotels = db.Hotels;

        return allHotels.ToList();
    }

    public List<Room> GetAllRooms()
    {
        var allRooms = db.Rooms;

        return allRooms.ToList();
    }

    


     
     
}