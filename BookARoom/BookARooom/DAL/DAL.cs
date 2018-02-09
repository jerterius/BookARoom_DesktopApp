using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARooom.Models;
using System.Data.SqlClient;
using System.Data;

namespace BookARooom.DAL
{
    public class DAL
    {
               
            public BookingContext bContext = new BookingContext();

            SqlConnection myConnection = new SqlConnection();


            public void Add(Object addToList)
            {

                switch (addToList)
                {
                    case Booking b1:
                        bContext.Bookings.Add(b1);
                        break;
                    case Room r1:
                        bContext.Rooms.Add(r1);
                        break;
                    case Customer c1:
                        bContext.Customers.Add(c1);
                        break;
                    case Hotel h1:
                        bContext.Hotels.Add(h1);
                        break;
                    case City c1:
                        bContext.Cities.Add(c1);
                        break;
                }
            }



            public int TotalPrice(string bookingNumber)
            {
                string query = "select BookingNumber from Bookings inner join on Booking.PhoneNumber = Customer.PhoneNumber where BookingNumber = ?";
                ps = con.prepareStatement(query);
            }



            public List<String[]> AvailableRooms(City city)
            {
                List<String[]> resultList = new List<String[]>();

                string query = "select * from Rooms where Booking.RoomNumber != Roomnumber";

                using (var cmd = new SqlCommand(query, myConnection)) ;
                {
                    SqlDataAdapter adapt = new SqlDataAdapter(cmd);
                    myConnection.Open();

                }

                while (rs.next())
                {
                    "Roomtype", "Bed", "Smokefree", "GuestCapacity", "Price", "HotelAdress"
                    string roomType = rs.getString("ccode").toUpperCase();
                    string bed = rs.getString("cname").toUpperCase();
                    string smokeFree = rs.getString("semester").toUpperCase();
                    string guestCapacity = rs.getString("point");
                    string price = DataRowState.getString("");
                    string adress = DataRowState.getString("");

                    Room r = new Room(rs.getString("ccode"));

                    String[] entry = { roomType, bed, smokefree, guestCapacity, price, adress };
                    resultList.Add(entry);
                }



                public bool DeleteBooking(string bookingNumber) throws SQLException, Exception
            {
                    try
                    {
                        con = getConnection();

                        String query = "delete from booking where bookingNumber= ?;";

                        ps = con.prepareStatement(query);
                        ps.setString(1, bookingNumber);

                        return (0 != ps.executeUpdate());

                    }
                    finally
                    {
                        close();
                        c = null;
                    }
                }
            }

        }
    }
