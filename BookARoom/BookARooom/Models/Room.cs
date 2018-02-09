using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Collections.ObjectModel;

namespace BookARoom.Models
{
    public class Room
    {
        [Key, Column(Order = 2)]
        public string RoomNumber { get; set; }
        public string Bed { get; set; }
        public bool SmokeFree { get; set; }
        public int Price { get; set; }
        public int GuestCapacity { get; set; }
        [Key, Column(Order = 1)]
        [ForeignKey("Hotel")]
        public string Adress { get; set; }

        public virtual Hotel Hotel { get; set; }
        public virtual ObservableCollection<Booking> Bookings { get; set; }


        public Room(string roomNumber, bool smokeFree, int price, int guestCapacity, string bed, string adress)
        {
            RoomNumber = roomNumber;
            Bed = bed;
            SmokeFree = smokeFree;
            Price = price;
            GuestCapacity = guestCapacity;
            Adress = adress;
        }






    }
}
