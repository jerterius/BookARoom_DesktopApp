using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using BookARoom.Models;

namespace BookARoom.DAL
{
    public class BookingContext : DbContext
    {
        public BookingContext() : base("BookingDB")
        { }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<City> Cities { get; set; }

    }

}

