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
        SqlDataAdapter da = new SqlDataAdapter();

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

        public void Add(object addToTable)
        {
            OpenConnect();
            var db = new BookingContext();

                switch (addToTable)
                {
                    case Booking b1:
                        db.Bookings.Add(b1);
                        db.SaveChanges();
                        break;
                    case Room r1:
                        db.Rooms.Add(r1);
                        db.SaveChanges();
                        break;
                    case Customer c1:
                        db.Customers.Add(c1);
                        db.SaveChanges();
                        break;
                    case Hotel h1:
                        db.Hotels.Add(h1);
                        db.SaveChanges();
                        break;
                    case City c1:
                        db.Cities.Add(c1);
                        db.SaveChanges();
                        break;
                }
            CloseConnect(OpenConnect());
        }


        public int TotalPrice(string bookingNumber)
        {
            int totalPrice = 0;
            using (var db = new BookingContext())
            {
                var query = from b in db.Bookings
                            where b.BookingNumber.Equals(bookingNumber)
                            select b;

                foreach (var item in query)
                {
                    totalPrice += item.Room.Price;
                }

            CloseConnect(OpenConnect());
            return totalPrice;
            }
        }

        public DataTable FindAvailableRooms(City city)
        {
            DataTable dt = new DataTable();

            OpenConnect();
            QueryStatement("select * from Rooms " +
                "inner join Hotels on Hotel.Adress = Room.Adress " +
                "inner join City where City.CityName = Hotel.CityName" +
                "and where Booking.RoomNumber != Roomnumber");
            
            da.Fill(dt);

            CloseConnect(OpenConnect());
            return dt;
        }
            
        public bool DeleteBooking(string bookingNumber)
        {
            OpenConnect();
            SqlCommand cmd = QueryStatement("delete from booking where bookingNumber=?");
            CloseConnect(OpenConnect());

            return (0 != cmd.ExecuteNonQuery());
        }

     }
 }
    
