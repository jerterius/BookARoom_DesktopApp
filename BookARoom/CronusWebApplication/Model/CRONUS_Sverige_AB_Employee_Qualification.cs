namespace CronusWebApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee Qualification")]
    public partial class CRONUS_Sverige_AB_Employee_Qualification
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

        [Column("Qualification Code")]
        [Required]
        [StringLength(10)]
        public string Qualification_Code { get; set; }

        [Column("From Date")]
        public DateTime From_Date { get; set; }

        [Column("To Date")]
        public DateTime To_Date { get; set; }

        public int Type { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        [Required]
        [StringLength(30)]
        public string Institution_Company { get; set; }

        public decimal Cost { get; set; }

        [Column("Course Grade")]
        [Required]
        [StringLength(30)]
        public string Course_Grade { get; set; }

        [Column("Employee Status")]
        public int Employee_Status { get; set; }

        [Column("Expiration Date")]
        public DateTime Expiration_Date { get; set; }
    }
}
