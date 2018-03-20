using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class DalRoom : IDal<Room>
    {
        BookingContext db = new BookingContext();

        public List<Room> GetEntities()
        {

            var allRooms = db.Rooms;

            return allRooms.ToList();
        }
    }
}