using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using BookARoomClient.localhost;




namespace BookARoomClient
{
    public class Program
    {
        static void Main(string[] args)
        {

            BookARoomWebService service = new BookARoomWebService();

            service.GetEntities("All Bookings");

          
        }
    }
}
