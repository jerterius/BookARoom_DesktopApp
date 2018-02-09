using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace BookARooom.Models
{
    public class City
    {
        [Key]
        [Column(Order = 1)]
        public string CityName { get; set; }
        [Key]
        [Column(Order = 2)]
        public string Country { get; set; }

    }
}
