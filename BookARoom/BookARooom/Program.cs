using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using BookARoom.Views;
using BookARoom.Models;
using BookARoom.DAL;

namespace BookARoom
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Hotel hotel = new Hotel("Scandic", "4 stjärnigt", "Lundagatan 10", "1234");
            BookingContext db = new BookingContext();
            db.Hotels.Add(hotel);
            Room room = new Room("1", true, 300, 3, "Queensize", "Lundagatan 10");
            Room room2 = new Room("2", false, 200, 2, "Queensize", "Lundagatan 10");
            db.Rooms.Add(room);
            db.Rooms.Add(room2);
            City city = new City("Stockholm", "Sweden");
            City city2 = new City("London", "England");
            db.Cities.Add(city);
            db.Cities.Add(city2);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
