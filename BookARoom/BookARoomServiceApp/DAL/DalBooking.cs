using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class DalBooking : IDal<Booking>
    {
        BookingContext db = new BookingContext();

        public List<Booking> GetEntities()
        {
            var allBookings = db.Bookings;

            return allBookings.ToList();
        }
    }
}