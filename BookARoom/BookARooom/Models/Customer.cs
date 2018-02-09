using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace BookARooom.Models
{
    public class Customer
    {
        [Key]
        public string PhoneNumber { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Adress { get; set; }
        public string Email { get; set; }

        public virtual ObservableCollection<Booking> Bookings { get; set; } //Rätt

        public Customer()
        {
            this.Bookings = new ObservableCollection<Booking>();
        }

        public Customer(string name, string title, string adress, string phonenumber, string email)
        {
            Name = name;
            Title = title;
            Adress = adress;
            PhoneNumber = phonenumber;
            Email = email;
        }

    }
}

