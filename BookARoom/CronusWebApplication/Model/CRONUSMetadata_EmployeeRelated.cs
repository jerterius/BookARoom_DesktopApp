using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;


namespace CronusWebApplication.Model
{
    [Table("CONTENT_METADATA_RELATEDTABLES")]
    public class CRONUSMetadata_EmployeeRelated
    {
        [Key]
        [StringLength(128)]
        public string Tabellnamn { get; set; }

        [Column("First Name")]
        public string First_Name { get; set; }

         public int Status { get; set; }

        [Column("Job Title")]
        public string Job_Title { get; set; }

        public string Address { get; set; }


    }
}