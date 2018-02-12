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
       
            
       /* public void Connect()
        { 
            using (var db = new BookingContext())
            {
            }
        } */

            public void Add(object addToTable)
            {
            using (var db = new BookingContext())
            {

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
            }
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

                    return totalPrice;
                }
            }



        public DataTable FindAvailableRooms(City city)
        {
            DataTable dt = new DataTable();

            SqlConnection con = new SqlConnection("Data Source = MSSQLLocalDB;Initial Catalog=BookingDB;Integrated Security=SSPI");
            SqlCommand cmd = new SqlCommand("select * from Rooms " +
                "inner join Hotels on Hotel.Adress = Room.Adress " +
                "inner join City where City.CityName = Hotel.CityName" +
                "and where Booking.RoomNumber != Roomnumber", con);
            cmd.CommandType = CommandType.Text;
            SqlDataAdapter da = new SqlDataAdapter();
            da.SelectCommand = cmd;
            da.Fill(dt);

            return dt;
        }
            
            public bool DeleteBooking(string bookingNumber)
            {
                SqlConnection con = new SqlConnection("Data Source = MSSQLLocalDB;Initial Catalog=BookingDB;Integrated Security=SSPI");
                SqlCommand cmd = new SqlCommand("delete from booking where bookingNumber=?", con);
                cmd.CommandType = CommandType.Text;
                SqlDataAdapter da = new SqlDataAdapter();
                da.SelectCommand = cmd;

                return (0 != cmd.ExecuteNonQuery());
        }

        }

        }
    }
