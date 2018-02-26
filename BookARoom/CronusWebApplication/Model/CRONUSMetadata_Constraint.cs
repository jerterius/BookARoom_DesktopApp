using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CronusWebApplication.Model
{
    [Table("INFORMATION_SCHEMA.TABLE_CONSTRAINTS")]
    public class CRONUSMetadata_Constraint
    {
        [Key]
        [StringLength(128)]
        public string Constraint_Name { get; set; }

        public string Table_Name { get; set; }

        public string Constraint_Type { get; set; }

    }
}