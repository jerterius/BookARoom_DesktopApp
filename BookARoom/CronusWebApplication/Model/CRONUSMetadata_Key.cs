using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CronusWebApplication.Model
{
    [Table("INFORMATION_SCHEMA.KEY_COLUMN_USAGE")]
    public class CRONUSMetadata_Key
    {
        [Key]
        [StringLength(128)]
        public string Constraint_Name { get; set; }
    }
}