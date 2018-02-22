using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookARoomClient.ServiceReference1;




namespace BookARoomClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookARoomWebServiceSoapClient client = new BookARoomWebServiceSoapClient();
            List<Booking> bookingList = client.GetAllBookings("All Bookings").Cast<Booking>().ToList();

            foreach(Booking b in bookingList)
            {
                Console.WriteLine("Bookingnumber: {0}, Room number: {1}, Adress: {2}, Customer Email: {3} ", b.BookingNumber, b.RoomNumber, b.Adress, b.CEmail);
            }

          
        }
    }
}
