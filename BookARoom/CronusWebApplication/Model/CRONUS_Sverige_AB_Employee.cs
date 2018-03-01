namespace CronusWebApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.Collections.ObjectModel;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee")]
    public partial class CRONUS_Sverige_AB_Employee
    {
        [Key]
        [StringLength(20)]
        public string No_ { get; set; }

        [Column("First Name")]
        [Required]
        [StringLength(30)]
        public string First_Name { get; set; }

        [Column("Last Name")]
        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        [Column("Job Title")]
        [Required]
        [StringLength(30)]
        public string Job_Title { get; set; }

        [Required]
        [StringLength(50)]
        public string Address { get; set; }

        [Column("Address 2")]
        [Required]
        [StringLength(50)]
        public string Address_2 { get; set; }

        [Required]
        [StringLength(30)]
        public string City { get; set; }

        [Column("Post Code")]
        [Required]
        [StringLength(20)]
        public string Post_Code { get; set; }

        [Required]
        [StringLength(30)]
        public string County { get; set; }

        [Column("Phone No_")]
        [Required]
        [StringLength(30)]
        public string Phone_No_ { get; set; }

        [Column("Mobile Phone No_")]
        [Required]
        [StringLength(30)]
        public string Mobile_Phone_No_ { get; set; }

        [Column("E-Mail")]
        [Required]
        [StringLength(80)]
        public string E_Mail { get; set; }
   
    }
}
