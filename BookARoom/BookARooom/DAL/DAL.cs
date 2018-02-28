using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.Models;
using System.Data.SqlClient;
using System.Data;
using System.Data.Entity;

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

        public List<Hotel> HotelFilter(string search, string countryName, string cityName, List<DateTime> dates, string standard, int guests, bool smokeFree)
        {
            try
            {
                var hotelList = this.db.Hotels.Where(hotel =>
                        hotel.Name.Contains(search) &&
                        hotel.Countryname == countryName &&
                        hotel.CityName == cityName &&
                        hotel.Standard == standard)
                            .Include(hotel => hotel.Rooms.Select(r => r.Bookings)).ToList();

                List<Room> rooms = hotelList.SelectMany(h => h.Rooms).ToList().Where(r => r.GuestCapacity >= guests).ToList();

                List<Booking> allBookings = rooms.SelectMany(r => r.Bookings).ToList();


                foreach (DateTime d in dates)
                {

                    rooms.Remove(rooms.Where(r => r.Bookings.Any(b => b.Date == d)).FirstOrDefault());

                }

                return rooms.Select(r => r.Hotel).Distinct().ToList();

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
            } catch (Exception e)
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
            } catch (Exception e)
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

