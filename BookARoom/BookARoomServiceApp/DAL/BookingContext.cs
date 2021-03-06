﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.Entity;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class BookingContext : DbContext
    {
        public BookingContext() : base("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=BookingDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False")
        {
            this.Configuration.LazyLoadingEnabled = false;
            this.Configuration.ProxyCreationEnabled = false;
        }
        public DbSet<Customer> Customers { get; set; }

        public DbSet<Booking> Bookings { get; set; }

        public DbSet<Room> Rooms { get; set; }

        public DbSet<Hotel> Hotels { get; set; }

        public DbSet<City> Cities { get; set; }

    }
}