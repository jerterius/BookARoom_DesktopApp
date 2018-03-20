using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class DalHotel : IDal<Hotel>
    {
        BookingContext db = new BookingContext();

        public List<Hotel> GetEntities()
        {
            var allHotels = db.Hotels;

            return allHotels.ToList();
        }
    }
}