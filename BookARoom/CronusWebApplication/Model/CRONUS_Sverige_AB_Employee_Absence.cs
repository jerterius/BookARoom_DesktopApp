namespace CronusWebApplication.Model
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee Absence")]
    public partial class CRONUS_Sverige_AB_Employee_Absence
    {
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp { get; set; }

        [Key]
        [Column("Entry No_")]
        [DatabaseGenerated(DatabaseGeneratedOption.None)]
        public int Entry_No_ { get; set; }

        [Column("Employee No_")]
        [Required]
        [StringLength(20)]
        public string Employee_No_ { get; set; }

        [Column("From Date")]
        public DateTime From_Date { get; set; }

        [Column("To Date")]
        public DateTime To_Date { get; set; }

        [Column("Cause of Absence Code")]
        [Required]
        [StringLength(10)]
        public string Cause_of_Absence_Code { get; set; }

        [Required]
        [StringLength(30)]
        public string Description { get; set; }

        public decimal Quantity { get; set; }

        [Column("Unit of Measure Code")]
        [Required]
        [StringLength(10)]
        public string Unit_of_Measure_Code { get; set; }

        [Column("Quantity (Base)")]
        public decimal Quantity__Base_ { get; set; }

        [Column("Qty_ per Unit of Measure")]
        public decimal Qty__per_Unit_of_Measure { get; set; }
    }
}
