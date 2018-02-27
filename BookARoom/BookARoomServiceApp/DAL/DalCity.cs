using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class DalCity : IDal<City>
    {
        BookingContext db = new BookingContext();

        public List<City> GetEntities()
        {
            var allCities = db.Cities;

            return allCities.ToList();
        }
    }
}