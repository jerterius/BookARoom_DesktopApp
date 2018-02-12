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

            public void Add(Object addToList)
            {
            using (var db = new BookingContext())
            {

                switch (addToList)
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


        /*
            public int TotalPrice(string bookingNumber)
            {
                string query = "select BookingNumber from Bookings inner join on Booking.PhoneNumber = Customer.PhoneNumber where BookingNumber = ?";
            }



            public List<Room> FindAvailableRooms()
            {
                

                string query = "select * from Rooms where Booking.RoomNumber != Roomnumber";

            from b in db.Blogs
            orderby b.Name
            select b;

            



            public bool DeleteBooking(string bookingNumber)
            {
                String query = "delete from booking where bookingNumber= ?;";
            }

        }

       */ }
    }
