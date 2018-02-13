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
        Booking booking;

        public int TotalPrice(string bookingNumber)
            {
                return dal.TotalPrice(bookingNumber);
             
            }


        public void Add(object addToTable, EventArgs e)
        {
                dal.Add(addToTable);
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

        public List<Hotel> HotelsWithAvailableRooms (City city)
        {
            return dal.HotelsWithAvailableRooms(city);
        }

        public List<string> Retrieve()
        {
            return dal.Retrieve();
        }
        
        public List<string> AllCountries()
        {
            return dal.AllCountries();
        }
    }

 }


 
