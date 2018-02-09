using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookARoom.Models
{
    public class City
    {
        [Key]
        [Column(Order = 1)]
        public string CityName { get; set; }
        [Key]
        [Column(Order = 2)]
        public string CountryName { get; set; }

        public City(string cityName, string countryName)
        {
            CityName = cityName;
            CountryName = countryName;
        }
    }
}
