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





        public void Add(object newObject)
        {

            if (newObject is Booking)
            {

                db.Bookings.Add(newObject as Booking);
                db.SaveChanges();
            }

            else if (newObject is Customer)
                db.Customers.Add(newObject as Customer);
            db.SaveChanges();
        }

        public Customer RetrieveCustomer(string email, string password)
        {
             return db.Customers.Where(c => c.CEmail == email && c.Password == password).First();
         
        }

        public void Update(Customer origin, Customer updated)
        {
            var oldRecord = db.Customers.Where(c => c.CEmail == origin.CEmail).First();
            oldRecord.Title = updated.Title;
            oldRecord.CName = updated.CName;
            oldRecord.CAdress = updated.CAdress;
            oldRecord.CPhoneNumber = updated.CPhoneNumber;
            oldRecord.CEmail = updated.CEmail;
            oldRecord.Password = updated.Password;
            db.SaveChanges();
        }

        public void Remove(object o)
        {

            if (o is Booking)
            {

                db.Bookings.Remove(o as Booking);
                db.SaveChanges();
            }

            else if (o is Customer)
                db.Customers.Remove(o as Customer);
            db.SaveChanges();
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

