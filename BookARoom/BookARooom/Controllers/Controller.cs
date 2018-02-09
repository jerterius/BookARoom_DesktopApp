using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.DAL;
using BookARoom.Models;
using System.Data;

namespace BookARoom.Controllers
{
    public class Controller
    {
 
            public int TotalPrice(string bookingNumber)
            {
                int price = 0;
                List<Booking> bookingNbr = new List<Booking>();
                DAL.BookingContext bContext = new BookingContext();

                foreach (Booking b in bContext.Bookings)
                {
                    if (b.BookingNumber == bookingNumber)
                    {
                        bookingNbr.Add(b);
                    }
                }

                foreach (Booking b in bookingNbr)
                {
                    price += b.Room.Price;
                }

                return price;
            }


            public DataTable AvailableRooms(City city)
            {
                try
                {
                    String[] colID = { "Roomtype", "Bed", "Smokefree", "GuestCapacity", "Price", "HotellAdress" };
                    resultList = Dal.FindAvailableRooms();
                    DataTable model = new DataTable();
             

                    model.setRowCount(0);
                    model.setColumnCount(6);
                    model.setColumnIdentifiers(colID);

                    for (String[] entry : resultList)
                    {
                        model.addRow(entry);
                    }
                    return model;

                }
                finally
                {
                    model = null;

                }
            }
     }

 }


 
