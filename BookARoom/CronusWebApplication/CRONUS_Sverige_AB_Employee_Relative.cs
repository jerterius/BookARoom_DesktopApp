namespace CronusWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee Relative")]
    public partial class CRONUS_Sverige_AB_Employee_Relative
    {
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp { get; set; }

        [Key]
        [Column("Employee No_", Order = 0)]
        [StringLength(20)]
        public string Employee_No_ { get; set; }

        [Key]
        [Column("Line No_", Order = 1)]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Line_No_ { get; set; }

        [Column("Relative Code")]
        [Required]
        [StringLength(10)]
        public string Relative_Code { get; set; }

        [Column("First Name")]
        [Required]
        [StringLength(30)]
        public string First_Name { get; set; }

        [Column("Middle Name")]
        [Required]
        [StringLength(30)]
        public string Middle_Name { get; set; }

        [Column("Last Name")]
        [Required]
        [StringLength(30)]
        public string Last_Name { get; set; }

        [Column("Birth Date")]
        public DateTime Birth_Date { get; set; }

        [Column("Phone No_")]
        [Required]
        [StringLength(30)]
        public string Phone_No_ { get; set; }

        [Column("Relative_s Employee No_")]
        [Required]
        [StringLength(20)]
        public string Relative_s_Employee_No_ { get; set; }
    }
}
