using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookARoomClient.ServiceReference1;






namespace BookARoomClient
{
    public class Program
    {
        static void Main(string[] args)
        {
            BookARoomWebServiceSoapClient client = new BookARoomWebServiceSoapClient();

            List<Customer> customerList = client.GetAllCustomers();
            foreach(Customer c in customerList)
            {
                Console.WriteLine("Name: {0} Title: {1} Phone number: {2} Adress: {3} email: {4} ", c.CName, c.Title, c.CPhoneNumber, c.CAdress, c.CEmail);
            }
            List<Booking> bookingList = client.GetAllBookings();
            foreach(Booking b in bookingList)
            {
                Console.WriteLine("Email: {0} Adress: {1} Room number: {2} Date: {3} Booking number: {4}  ", b.CEmail, b.Adress, b.RoomNumber, b.Date, b.BookingNumber);
            }
            List<Room> roomList = client.GetAllRooms();
            foreach(Room r in roomList)
            {
                Console.WriteLine("Room number: {0} Bed: {1} Smoke free: {2} Guest Capacity {3} Price: {4} Adress: {5} ", r.RoomNumber, r.Bed, r.SmokeFree, r.GuestCapacity, r.Price, r.Adress);
            }
            List<Hotel> hotelList = client.GetAllHotels();
            foreach(Hotel h in hotelList)
            {
                Console.WriteLine("Hotel name: {0} Country: {1} City: {2} Standard: {3} Adress: {4} Phone number: {5} ", h.Name, h.Countryname, h.CityName, h.Standard, h.Adress, h.PhoneNumber);
            }
            List<City> cityList = client.GetAllCities();
            foreach(City c in cityList)
            {
                Console.WriteLine("City: {0} Country: {1} ", c.CityName, c.CountryName);
            }

            Console.ReadLine();
          
        }
    }
}
