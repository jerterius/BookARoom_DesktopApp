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


        public DataTable AvailableRooms(City city)
        {
           return dal.FindAvailableRooms(city);
        }


        public void Add(object addToTable, EventArgs e)
        {
                dal.Add(addToTable);
        }


       public void Remove(object removeFromTable, EventArgs e)
        {
            dal.Remove(removeFromTable);
        }

     }

 }


 
