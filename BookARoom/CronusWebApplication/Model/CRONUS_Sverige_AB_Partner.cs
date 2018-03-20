namespace CronusWebApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Partner")]
    public partial class CRONUS_Sverige_AB_Partner
    {
        [Key]
        [Required]
        [StringLength(32)]
        public string Company { get; set; }

        [StringLength(32)]
        public string Adress { get; set; }

        [StringLength(32)]
        public string PhoneNumber { get; set; }

        [StringLength(32)]
        public string Email { get; set; }
    }
}
