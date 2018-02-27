using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using BookARoomServiceApp.Models;

namespace BookARoomServiceApp.DAL
{
    public class DalCustomer : IDal<Customer>
    {
        BookingContext db = new BookingContext();

        public List<Customer> GetEntities()
        {
            var allCustomers = db.Customers;

            return allCustomers.ToList();
        }
    }
}