using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.Models;
using System.Data.SqlClient;
using System.Data;

namespace BookARoom.DAL
{
    public class Dal
    {
        BookingContext db = new BookingContext();

       /* SqlDataAdapter da = new SqlDataAdapter();

        public static SqlConnection OpenConnect()
         { 
            string dbAdress = "Data Source = MSSQLLocalDB;Initial Catalog=BookingDB;Integrated Security=SSPI";
            
            SqlConnection con = new SqlConnection(dbAdress);
            con.Open();
            return con;
         } 

        public static void CloseConnect(SqlConnection con)
        {
            if (con.State == ConnectionState.Open)
                con.Close();
            con.Dispose();
        }

        public SqlCommand QueryStatement(string query)
        {
            SqlCommand cmd = new SqlCommand(query, OpenConnect());
            cmd.CommandType = CommandType.Text;
            da.SelectCommand = cmd;

            return cmd;
        } 
        public DataTable AllCountries()
        {
            DataTable dt = new DataTable();

            OpenConnect();
            QueryStatement("select CountryName from Cities");
            da.Fill(dt);

            CloseConnect(OpenConnect());
            return dt;
        }

        public DataTable AllCities()
        {
            DataTable dt = new DataTable();

            OpenConnect();
            QueryStatement("select CityName from Cities");
            da.Fill(dt);

            CloseConnect(OpenConnect());
            return dt;
        } */

        public void Add(object addToTable)
        {
            switch (addToTable)
            {
                case Booking b1:
                    db.Bookings.Add(b1);
                    db.SaveChanges();
                    break;
                case Customer c1:
                    db.Customers.Add(c1);
                    db.SaveChanges();
                    break;
            }
        }

        public void Remove(object removeFromTable)
        {
            switch (removeFromTable)
            {
                case Booking b1:
                    db.Bookings.Remove(b1);
                    db.SaveChanges();
                    break;
                case Customer c1:
                    db.Customers.Remove(c1);
                    db.SaveChanges();
                    break;
            }
        }

        public int TotalPrice(string bookingNumber)
        {
            int totalPrice = 0;
           
            var query = from b in db.Bookings
                        where b.BookingNumber.Equals(bookingNumber)
                        select b;

            foreach (var item in query)
            {
                totalPrice += item.Room.Price;
            }

            return totalPrice;
        }

        public List<Room> FindAvailableRooms(Hotel hotel)
        {
            var availableRooms = from r in db.Rooms
                                 join h in db.Hotels on r.Adress equals hotel.Adress
                                 join c in db.Cities on hotel.CityName equals c.CityName
                                 where !db.Bookings.Any(b => b.RoomNumber == r.RoomNumber)
                                 select r;

            return availableRooms.ToList();
        }

        //Alla städer som finns i ett visst land

        public List<Hotel> HotelsInCity(City city)
        {
            var hotelList = db.Hotels.Where(h => h.CityName == city.CityName).ToList();

            return hotelList;                    
        }


        public List<Hotel> HotelsWithAvailableRooms(City city)
        {
            var hotelList = from h in db.Hotels
                           join c in db.Cities on h.CityName equals city.CityName
                           join r in db.Rooms on h.Adress equals r.Adress
                           where !db.Bookings.Any(b => b.RoomNumber == r.RoomNumber)
                           select h;

            return hotelList.ToList();
        }

        public List<string[]> Retrieve ()
        {
            var cities = from c in db.Cities
                         select c.CityName;

            return cities.ToList();
        }
    }
 }
    
