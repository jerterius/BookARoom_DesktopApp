using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace CronusWebApplication.Model
{
    [Table("sys.indexes")]
    public class CRONUSMetadata_Index
    {
        [Key]
        [StringLength(128)]
        public string Name { get; set; }
    }
}