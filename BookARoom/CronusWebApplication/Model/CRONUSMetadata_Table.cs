using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CronusWebApplication.Model
{
    [Table("sys.tables")]
    public class CRONUSMetadata_Table
    {
        [Key]
        [StringLength(128)]
        public string Name { get; set; }
    }
}