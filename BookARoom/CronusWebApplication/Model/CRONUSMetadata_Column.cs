using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Web;

namespace CronusWebApplication.Model
{
    [Table("INFORMATION_SCHEMA.COLUMNS")]
    public class CRONUSMetadata_Column
    {
        public string Table_Name { get; set; }
        [Key]
        [StringLength(128)]
        public string Column_Name { get; set; }

        //public virtual CRONUSMetadata_Table CRONUSMetadata_Table { get; set; }
    }
}