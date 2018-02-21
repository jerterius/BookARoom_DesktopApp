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
        var allBookings = from b in db.Bookings
                          select b;

        return allBookings;
    }

    public List<City> GetAllCities()
    {
        var allCities = from c in db.Cities
                          select c;

        return allCities;
    }

    public List<Customer> GetAllCustomers()
    {
        var allCustomers = from c in db.Customers
                          select c;

        return allCustomers;
    }

    public List<Hotel> GetAllHotels()
    {
        var allHotels = from h in db.Hotels
                          select h;

        return allHotels;
    }

    public List<Room> GetAllRooms()
    {
        var allRooms = from r in db.Rooms
                          select r;

        return allRooms;
    }

    


     }
     
}