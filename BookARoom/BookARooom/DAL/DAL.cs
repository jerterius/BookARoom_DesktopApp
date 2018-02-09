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
       
               
            public BookingContext bContext = new BookingContext();

            SqlConnection myConnection = new SqlConnection();


            public void Add(Object addToList)
            {

                switch (addToList)
                {
                    case Booking b1:
                        bContext.Bookings.Add(b1);
                        bContext.SaveChanges();
                        break;
                    case Room r1:
                        bContext.Rooms.Add(r1);
                        bContext.SaveChanges();
                        break;
                    case Customer c1:
                        bContext.Customers.Add(c1);
                        bContext.SaveChanges();
                        break;
                    case Hotel h1:
                        bContext.Hotels.Add(h1);
                        bContext.SaveChanges();
                        break;
                    case City c1:
                        bContext.Cities.Add(c1);
                        bContext.SaveChanges();
                        break;
                }
            }



            public int TotalPrice(string bookingNumber)
            {
                string query = "select BookingNumber from Bookings inner join on Booking.PhoneNumber = Customer.PhoneNumber where BookingNumber = ?";
            }



            public List<String[]> FindAvailableRooms()
            {
                List<String[]> resultList = new List<String[]>();

                string query = "select * from Rooms where Booking.RoomNumber != Roomnumber";

            from b in db.Blogs
            orderby b.Name
            select b;

            while (rs.next())
                {
                    string roomType = cmd.getString("roomType").toUpperCase();
                    string bed = rs.getString("bed").toUpperCase();
                    string smokeFree = rs.getString("smokeFree").toUpperCase();
                    string guestCapacity = rs.getString("guestCapacity");
                    string price = rs.getString("price");
                    string adress = rs.getString("hotelAdress");

                    Room r = new Room();

                    String[] entry = { roomType, bed, smokeFree, guestCapacity, price, adress };
                    resultList.Add(entry);
                }



            public bool DeleteBooking(string bookingNumber)
            {
                String query = "delete from booking where bookingNumber= ?;";
            }

        }

        }
    }
