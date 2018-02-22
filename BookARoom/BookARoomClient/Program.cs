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
                Console.WriteLine(c.CName);
            }
            Console.ReadLine();
          
        }
    }
}
