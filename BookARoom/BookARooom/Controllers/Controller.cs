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

        //Create
        public void AddCustomer(Customer newCustomer)
        {
            try
            {
                dal.Add(newCustomer);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void AddBooking(string email, string adress, string roomNo, int bookingNo, DateTime date)
        {
            try
            {
                Booking b = new Booking(email, adress, roomNo, date);
                dal.Add(b);
            }
            catch (Exception e)
            {
                throw e;
            }
        }


        //Retrieve
        public List<Hotel> HotelsWithAvailableRooms (string search, string countryName, string cityName, DateTime fromDate, DateTime toDate, string standard, int guests, bool smokeFree)
        {
            try
            {
                List<DateTime> dates = new List<DateTime>();
                for (var date = fromDate; date <= toDate; date = date.AddDays(1))
                {
                    dates.Add(date);
                }

                return dal.HotelFilter(search, countryName, cityName, dates, standard, guests, smokeFree);

            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public Customer RetrieveCustomer(string email, string password)
        {
            try
            {
                return dal.RetrieveCustomer(email, password);

            } catch (Exception e)
            {
                throw e;
            }
        }

        public List<string> GetAllCountries()
        {
            try
            {
                return dal.AllCountries();
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
                return dal.AllCitiesInCountry(country);
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //Update
        public void Update(Customer origin, Customer updated)
        {
            try
            {
                dal.UpdateCustomer(origin, updated);

            } catch (Exception e)
            {
                throw e;
            }
        }

        //Delete
        public void DeleteBooking(Guid bookingNo)
        {
            try
            {
                Booking b = new Booking() { BookingNumber = bookingNo };
                dal.Remove(b);
            } catch (Exception e)
            {
                throw e;
            }
        }
    }

 }


 
