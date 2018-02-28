using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CronusWebApplication.Model
{
    [Table("EMPLOYEES_TOP5_ABSENCE")]
    public class CRONUS_Employee_Top5_Absence
    {
        [Key]
        [StringLength(128)]
        [Column("First Name")]
        public string First_Name { get; set; }

    }
}