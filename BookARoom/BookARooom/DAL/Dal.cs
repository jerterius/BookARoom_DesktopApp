using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

namespace BookARoom.DAL
{
    public class Dal
    {
        BookingContext db = new BookingContext();

        SqlDataAdapter da = new SqlDataAdapter();

        public static SqlConnection OpenConnect()
        {
            SqlConnection con = new SqlConnection("Data Source = (localdb)\\MSSQLLocalDB; Initial Catalog = BookingDB; Integrated Security = True; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = True; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");

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





        public void Add(object addToTable)
        {


            if (addToTable is Booking)
            {

                db.Bookings.Add(addToTable as Booking);
                db.SaveChanges();
            }

            else if (addToTable is Customer)
                db.Customers.Add(addToTable as Customer);
            db.SaveChanges();
        }

        public IQueryable<object> Retrieve(object o)
        {
            if (o is Customer)
            {
                Customer customer = o as Customer;
                var query = from c in db.Customers
                            where c.Password == customer.Password && customer.CEmail == c.CEmail
                            select c;

                

                return query as IQueryable<Customer>;
                
            }

            return null;
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


        public int TotalPrice(Guid bookingNumber)
        {
            int totalPrice = 0;

            var query = from b in db.Bookings
                        where b.BookingNumber == bookingNumber
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


        public List<Hotel> HotelsInCity(City city)
        {
            var hotelList = db.Hotels.Where(h => h.CityName == city.CityName).ToList();

            return hotelList;
        }



        public List<Hotel> HotelsWithAvailableRooms(string search, string countryName, string cityName, List<DateTime> dates, string standard, int guests, bool smokeFree)
        {

            var hotelList = this.db.Hotels.Where(hotel =>
                    hotel.Countryname == countryName &&
                    hotel.CityName == cityName &&
                    hotel.Standard == standard)
                        .Include(hotel => hotel.Rooms.Select(r => r.Bookings)).ToList();

            List<Room> rooms = hotelList.SelectMany(h => h.Rooms).ToList();

            List<Booking> allBookings = rooms.Where(r => r.GuestCapacity >= guests).SelectMany(r => r.Bookings).ToList();

            allBookings = allBookings.Where(b => dates.Contains(b.Date) == false).ToList();

            List<Hotel> returnHotels = allBookings.Select(b => b.Room.Hotel).Distinct().ToList();


            return returnHotels;
        }

            /**
            var bookingsWithNoMatchingDates = hotelList
                .Select(hotel => hotel.Rooms.Select(r => r.Bookings
                    .Where(booking => dates.Contains(booking.Date) == false)
                ));

            var availableRooms = bookingsWithNoMatchingDates.Select(b => b.Room).ToList();
                //.Where(room => room.Bookings.Where(booking => dates.Contains(booking.Date)).ToList();
            /*
            var hotelList = (from h in db.Hotels
                              join b in db.Bookings on h.Adress equals b.Adress
                             
                              select h).Distinct().ToList();*/

           // hotelList.Find(h => h.Countryname.Contains(countryName));
/*
            var hotelList = (from h in db.Hotels
                             join b in db.Bookings on h.Adress equals b.Adress
                             select h).Distinct().ToList();

            hotelList = hotelList.FindAll(hotel => )



            return hotelList;
        }
        */

        public List<string> GetAllCountries()
        {

            var query = db.Cities.Select(c => c.CountryName);

            return query.Distinct().ToList();

        }


        public List<string> AllCitiesInCountry(string country)
        {
            var cities = from c in db.Cities
                         where c.CountryName == country
                         select c.CityName;

            return cities.ToList();
        }


        public DataSet TestGetData()
        {

            OpenConnect();

            DataSet data = new DataSet();
            data.Locale = System.Globalization.CultureInfo.InvariantCulture;

            QueryStatement("select * from Hotels");
            da.Fill(data, "Hotels");

            QueryStatement("select * from Rooms");
            da.Fill(data, "Rooms");

            DataRelation relation = new DataRelation("HotelsRooms",
                data.Tables["Hotels"].Columns["Adress"],
                data.Tables["Rooms"].Columns["Adress"]);
            data.Relations.Add(relation);

            CloseConnect(OpenConnect());
            return data;
        }
    }
}

