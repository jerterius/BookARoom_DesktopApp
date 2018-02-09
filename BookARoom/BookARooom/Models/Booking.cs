using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookARooom.Models
{
    public class Booking
    {

        [Key, Column(Order = 1)]
        [ForeignKey("Customer")]
        public string PhoneNumber { get; set; }

        [Key, Column(Order = 2)]
        [ForeignKey("Room")]
        public string RoomNumber { get; set; }

        public string BookingNumber { get; set; }
        public DateTime Date { get; set; }
        public string Responsible { get; set; }
        public string CreditCardNumber { get; set; }

        public virtual Customer Customers { get; set; }
        public virtual Room Room { get; set; }



        public Booking(string bookingNumber, DateTime date, string responsible, string creditCardNumber, string phoneNumber)
        {
            BookingNumber = bookingNumber;
            Date = date;
            Responsible = responsible;
            CreditCardNumber = creditCardNumber;
            PhoneNumber = phoneNumber;

        }


    }
}
