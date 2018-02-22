using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections.ObjectModel;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookARoomClient.Models
{
    public class Hotel
    {
        [Key]
        public string Adress { get; set; }
        public string Name { get; set; }
        public string Standard { get; set; }
        public string PhoneNumber { get; set; }
        [ForeignKey("City"), Column(Order =1)]
        public string CityName { get; set; }
        [ForeignKey("City"), Column(Order = 2)]
        public string Countryname { get; set; }

        public virtual City City { get; set; }
        public virtual ObservableCollection<Room> Rooms { get; set; }

        //Default konstruktor enligt Entity Framework
        public Hotel()
        {
            this.Rooms = new ObservableCollection<Room>();
        }
        public Hotel(string name, string standard, string adress, string phoneNumber)
        {
            Name = name;
            Standard = standard;
            Adress = adress;
            PhoneNumber = phoneNumber;

        }



        //Ej tillämpbar med Entity Framwork. lösningen enligt nästa rad.
        //public List<Room> Rooms { get => rooms; set => rooms = value; }


    }
}
