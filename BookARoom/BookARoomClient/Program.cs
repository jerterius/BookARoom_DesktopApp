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
                Console.WriteLine("Name: {0} \n Title: {1} \n Phone number: {2} \n Adress: {3} \n email: {4} ", c.CName, c.Title, c.CPhoneNumber, c.CAdress, c.CEmail);
            }
            List<Booking> bookingList = client.GetAllBookings();
            foreach(Booking b in bookingList)
            {
                Console.WriteLine("Email: {0} \n Adress: {1} \n Room number: {2} \n Date: {3} \n Booking number: {4}  ", b.CEmail, b.Adress, b.RoomNumber, b.Date, b.BookingNumber);
            }
            List<Room> roomList = client.GetAllRooms();
            foreach(Room r in roomList)
            {
                Console.WriteLine("Room number: {0} \n Bed: {1} \n Smoke free: {2} \n Guest Capacity {3} \n Price: {4} \n Adress: {5} ", r.RoomNumber, r.Bed, r.SmokeFree, r.GuestCapacity, r.Price, r.Adress);
            }
            List<Hotel> hotelList = client.GetAllHotels();
            foreach(Hotel h in hotelList)
            {
                Console.WriteLine("Hotel name: {0} \n Country: {1} \n City: {2} \n Standard: {3} \n Adress: {4} \n Phone number: {5} ", h.Name, h.Countryname, h.CityName, h.Standard, h.Adress, h.PhoneNumber);
            }
            List<City> cityList = client.GetAllCities();
            foreach(City c in cityList)
            {
                Console.WriteLine("City: {0} \n Country: {1} ", c.CityName, c.CountryName);
            }

            Console.ReadLine();
          
        }
    }
}
