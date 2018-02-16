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

        

        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public string BookingNumber { get; set; }

        [Index("IX_DateRoom", 1, IsUnique = true)]
        public DateTime Date { get; set; }

        [ForeignKey("Customer")]
        public string CPhoneNumber { get; set; }

        [Index("IX_DateRoom", 2, IsUnique = true)]
        [ForeignKey("Room"), Column(Order = 1)]
        public string Adress { get; set; }

        [Index("IX_DateRoom", 3, IsUnique = true)]
        [ForeignKey("Room"), Column(Order = 2)]
        public string RoomNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }


        public Booking(string adress, string bookingNo, string cPhoneNo, DateTime date, string roomNo)
        {
            Adress = adress;
            BookingNumber = bookingNo;
            CPhoneNumber = cPhoneNo;
            Date = date;
            RoomNumber = roomNo;

        }


    }
}
