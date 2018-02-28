using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookARoomServiceApp.Models
{
    public class Booking
    {



        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public Guid BookingNumber { get; set; }

        [Index("IX_DateRoom", 1, IsUnique = true)]
        public DateTime Date { get; set; }

        [System.ComponentModel.DataAnnotations.Schema.NotMapped]
        public string DateString {
            get { return Date.ToString();  }
            set { Date = Convert.ToDateTime(value); }
                } 

        [ForeignKey("Customer")]
        [Required]
        public string CEmail { get; set; }

        [Index("IX_DateRoom", 2, IsUnique = true)]
        [ForeignKey("Room"), Column(Order = 1)]
        [Required]
        public string Adress { get; set; }

        [Index("IX_DateRoom", 3, IsUnique = true)]
        [ForeignKey("Room"), Column(Order = 2)]
        [Required]
        public string RoomNumber { get; set; }
        public virtual Customer Customer { get; set; }
        public virtual Room Room { get; set; }

        public Booking() { }
        public Booking(string cEmail, string adress, string roomNo, DateTime date)
        {
            Adress = adress;
            CEmail = cEmail;
            Date = date;
            RoomNumber = roomNo;

        }


    }
}