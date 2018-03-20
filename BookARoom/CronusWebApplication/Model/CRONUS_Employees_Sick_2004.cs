using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CronusWebApplication.Model
{
    [Table("EMPLOYEES_SICK_2004")]
    public class CRONUS_Employees_Sick_2004
    {
        [Key]
        [Column("First Name")]
        public string First_Name {get; set;}

        [Column("Job Title")]
        public string Job_Title { get; set; }

        [Column("From Date")]
        public DateTime From_Date { get; set; }

        [NotMapped]
        public string From_DateString
        {
            get { return From_Date.ToString(); }
            set { From_Date = Convert.ToDateTime(value); }
        }

        [Column("To Date")]
        public DateTime To_Date { get; set; }

        [NotMapped]
        public string To_DateString
        {
            get { return To_Date.ToString(); }
            set { To_Date = Convert.ToDateTime(value); }
        }

        [Column("Cause of Absence Code")]
        public string Cause_of_Absence_Code { get; set; }
    }

}
