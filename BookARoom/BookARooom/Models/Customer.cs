using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.Collections.ObjectModel;

namespace BookARoom.Models
{
    public class Customer
    {
        [Key]
        public string CPhoneNumber { get; set; }
        public string CName { get; set; }
        public string Title { get; set; }
        public string CAdress { get; set; }
        public string CEmail { get; set; }
        [Required]
        public string Password { get; set; }

        public virtual ObservableCollection<Booking> Bookings { get; set; } //Rätt

        public Customer()
        {
            this.Bookings = new ObservableCollection<Booking>();
        }

        public Customer(string name, string title, string adress, string phonenumber, string email)
        {
            CName = name;
            Title = title;
            CAdress = adress;
            CPhoneNumber = phonenumber;
            CEmail = email;
        }

    }
}

