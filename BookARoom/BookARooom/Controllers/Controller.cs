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


        public void AddCustomer(string title, string name, string adress, string telephone, string email, string password)
        {
            Customer c = new Customer(title, name, adress, telephone, email, password);
                dal.Add(c);
        }

        public void AddBooking(string email, string adress, string roomNo, int bookingNo, DateTime date)
        {
            Booking b = new Booking(email, adress, roomNo, date);
            dal.Add(b);
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

        public List<Hotel> HotelsWithAvailableRooms (string cityName)
        {
            City c = new City() { CityName = cityName };
            return dal.HotelsWithAvailableRooms(c);
        }

        public List<Customer> RetrieveCustomer(string email, string password)
        {
            Customer c = new Customer() { CEmail = email, Password = password };
            
            IQueryable<Customer> result = dal.Retrieve(c) as IQueryable<Customer>;

            if (result.Any<Customer>())
            {
                return result.ToList();
            }
            return null;

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


 
