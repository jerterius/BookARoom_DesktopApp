using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;
using Z.EntityFramework.Plus;
using System.Collections.ObjectModel;

namespace BookARoom.DAL
{
    public class Dal
    {
        BookingContext db = new BookingContext();



        //Create
        public void Add(object newObject)
        {
            try
            {

                if (newObject is Booking)
                {

                    db.Bookings.Add(newObject as Booking);
                    db.SaveChanges();
                }

                else if (newObject is Customer)
                    db.Customers.Add(newObject as Customer);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Retreive
        public Customer RetrieveCustomer(string email, string password)
        {
            try
            {
                return db.Customers.Where(c => c.CEmail == email && c.Password == password).FirstOrDefault();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> AllCountries()
        {
            try
            {
                return db.Cities.Select(c => c.CountryName).Distinct().ToList();
            }
            catch (Exception e)
            {
                throw e;
            }

        }


        public List<string> AllCitiesInCountry(string country)
        {
            try
            {
                return db.Cities.Where(c => c.CountryName == country).Select(c => c.CityName).ToList();
            }
            catch (Exception e)
            {
                throw e;
            }


        }

        public List<Hotel> HotelFilter(string search, string countryName, string cityName, DateTime fromDate, DateTime toDate, string standard, int guests, bool smokeFree)
        {
            try
            {

                var roomsList = db.Hotels.Where(h =>
                 h.Name.Contains(search) &&
                       h.Countryname == countryName &&
                       h.CityName == cityName &&
                       h.Standard == standard)

                .Select(hotel => new
                {
                    hotel,
                    rooms = hotel.Rooms.Where(r =>
                        r.GuestCapacity >= guests &&
                        !r.Bookings.Any(b => b.Date >= fromDate && b.Date <= toDate))

                })
                .AsEnumerable()
                .SelectMany(a =>
                {
                    a.hotel.Rooms = new ObservableCollection<Room>(a.rooms);
                    return a.rooms;
                })

                .Select(r => r.Hotel).ToList();



                return roomsList.Distinct().ToList();

            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Update
        public void UpdateCustomer(Customer origin, Customer updated)
        {
            try
            {
                var oldRecord = db.Customers.Where(c => c.CEmail == origin.CEmail).First();
                oldRecord.Title = updated.Title;
                oldRecord.CName = updated.CName;
                oldRecord.CAdress = updated.CAdress;
                oldRecord.CPhoneNumber = updated.CPhoneNumber;
                oldRecord.CEmail = updated.CEmail;
                oldRecord.Password = updated.Password;
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Delete
        public void Remove(object o)
        {
            try
            {

                if (o is Booking)
                {
                    Booking tempBooking = o as Booking;
                    var booking = db.Bookings.Where(b => b.BookingNumber == tempBooking.BookingNumber).First();
                    db.Bookings.Remove(booking);
                    db.SaveChanges();
                }

                else if (o is Customer)
                    db.Customers.Remove(o as Customer);
                db.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        /*
        public int TotalPrice(Guid bookingNumber)
        {
            int totalPrice = 0;

            var query = from b in db.Bookings
                        where b.BookingNumber == bookingNumber
                        select b;

            foreach (var item in query)
            {
                totalPrice += item.Room.Price;
            }

            return totalPrice;
        }*/


    }
}

