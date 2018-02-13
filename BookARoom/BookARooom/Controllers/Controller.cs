﻿using System;
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

        public List<Hotel> HotelsWithAvailableRooms (string cityName)
        {
            City c = new City() { CityName = cityName };
            return dal.HotelsWithAvailableRooms(c);
        }

        public void GetAllHotels()
        {

        }

        public List<string> Retrieve(string cName)
        {
            return dal.Retrieve(cName);
        }
        

        public List<string> AllCitiesInCountry(string country)
        {
            return dal.AllCitiesInCountry(country);
        }
    }

 }


 
