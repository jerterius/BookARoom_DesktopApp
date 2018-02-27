using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BookARoom.DAL;
using BookARoom.Models;
using System.Data;

namespace BookARoom.Controllers
{
    public class Controller
    {
        Dal dal = new Dal();

        public int TotalPrice(Guid bookingNumber)
            {
                return dal.TotalPrice(bookingNumber);
             
            }


        public void AddCustomer(Customer newCustomer)
        {
            dal.Add(newCustomer);
        }

        public void AddBooking(string email, string adress, string roomNo, int bookingNo, DateTime date)
        {
            Booking b = new Booking(email, adress, roomNo, date);
            dal.Add(b);
        }
        public void Update(Customer origin, Customer updated)
        {
            dal.Update(origin, updated);
        }

        public void DeleteBooking(Guid bookingNo)
        {
            Booking b = new Booking() {BookingNumber = bookingNo };
            dal.Remove(b);
        }

       public void Remove(object removeFromTable, EventArgs e)
        {
            dal.Remove(removeFromTable);
        }


        public List<Room> FindAvailableRooms(Hotel hotel)
        {
            return dal.FindAvailableRooms(hotel);
        }

        public List<Hotel> HotelsInCity (City city)
        {
            return dal.HotelsInCity(city);
        }

        public List<Hotel> HotelsWithAvailableRooms (string search, string countryName, string cityName, DateTime fromDate, DateTime toDate, string standard, int guests, bool smokeFree)
        {
            List<DateTime> dates = new List<DateTime>();
            for (var date = fromDate; date <= toDate; date = date.AddDays(1))
            {
                dates.Add(date);
            }

                return dal.HotelsWithAvailableRooms( search,  countryName,  cityName, dates,  standard,  guests,  smokeFree);
        }

        public Customer RetrieveCustomer(string email, string password)
        {
            return dal.RetrieveCustomer(email, password);
        }

        public List<string> GetAllCountries()
        {
            return dal.GetAllCountries();
        }
        

        public List<string> AllCitiesInCountry(string country)
        {
            return dal.AllCitiesInCountry(country);
        }

        public DataSet TestGetData()
        {
            return dal.TestGetData();
        }
    }

 }


 
