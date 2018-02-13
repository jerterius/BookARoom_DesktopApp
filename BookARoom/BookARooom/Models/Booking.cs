using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;


namespace BookARoom.Models
{
    public class Booking
    {

        [Key, Column(Order = 0)]
        [ForeignKey("Customer")]
        public string CPhoneNumber { get; set; }

        [Key]
        [ForeignKey("Room"), Column(Order = 1)]
        public string Adress { get; set; }

        [Key]
        [ForeignKey("Room"), Column(Order = 2)]
        public string RoomNumber { get; set; }

        public string BookingNumber { get; set; }
        [Key, Column(Order = 3)]
        public DateTime Date { get; set; }
        public string Responsible { get; set; }
        public string CreditCardNumber { get; set; }

        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }

       

        public Booking (string bookingNumber)
        {
            BookingNumber = bookingNumber;
        }

        public Booking(string bookingNumber, DateTime date, string responsible, string creditCardNumber, string phoneNumber)
        {
            BookingNumber = bookingNumber;
            Date = date;
            Responsible = responsible;
            CreditCardNumber = creditCardNumber;
            CPhoneNumber = phoneNumber;

        }


    }
}
