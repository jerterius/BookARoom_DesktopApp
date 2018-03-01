using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CronusWebApplication.Model
{
    [Table("EMPLOYEES_AND_RELATIVES")]
    public class CRONUS_Employees_And_Relatives
    {
        [Key]
        [Column("First Name")]
        public string First_Name { get; set; }

        [Column("Last Name")]
        public string Last_Name { get; set; }

        [Column("Job Title")]
        public string Job_Title { get; set; }

        [Column("Relative")]
        public string Relative { get; set; }

        [Column("Description")]
        public string Description { get; set; }
    }

}
