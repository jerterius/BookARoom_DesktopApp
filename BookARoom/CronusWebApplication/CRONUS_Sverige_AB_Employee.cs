namespace CronusWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee")]
    public partial class CRONUS_Sverige_AB_Employee
    {
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp { get; set; }

        [Key]
        [StringLength(20)]
        public string No_ { get; set; }

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

        [Required]
        [StringLength(30)]
        public string Initials { get; set; }

        [Column("Job Title")]
        [Required]
        [StringLength(30)]
        public string Job_Title { get; set; }

        [Column("Search Name")]
        [Required]
        [StringLength(30)]
        public string Search_Name { get; set; }

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

        [Column("Alt_ Address Code")]
        [Required]
        [StringLength(10)]
        public string Alt__Address_Code { get; set; }

        [Column("Alt_ Address Start Date")]
        public DateTime Alt__Address_Start_Date { get; set; }

        [Column("Alt_ Address End Date")]
        public DateTime Alt__Address_End_Date { get; set; }

        [Column(TypeName = "image")]
        public byte[] Picture { get; set; }

        [Column("Birth Date")]
        public DateTime Birth_Date { get; set; }

        [Column("Social Security No_")]
        [Required]
        [StringLength(30)]
        public string Social_Security_No_ { get; set; }

        [Column("Union Code")]
        [Required]
        [StringLength(10)]
        public string Union_Code { get; set; }

        [Column("Union Membership No_")]
        [Required]
        [StringLength(30)]
        public string Union_Membership_No_ { get; set; }

        public int Sex { get; set; }

        [Column("Country_Region Code")]
        [Required]
        [StringLength(10)]
        public string Country_Region_Code { get; set; }

        [Column("Manager No_")]
        [Required]
        [StringLength(20)]
        public string Manager_No_ { get; set; }

        [Column("Emplymt_ Contract Code")]
        [Required]
        [StringLength(10)]
        public string Emplymt__Contract_Code { get; set; }

        [Column("Statistics Group Code")]
        [Required]
        [StringLength(10)]
        public string Statistics_Group_Code { get; set; }

        [Column("Employment Date")]
        public DateTime Employment_Date { get; set; }

        public int Status { get; set; }

        [Column("Inactive Date")]
        public DateTime Inactive_Date { get; set; }

        [Column("Cause of Inactivity Code")]
        [Required]
        [StringLength(10)]
        public string Cause_of_Inactivity_Code { get; set; }

        [Column("Termination Date")]
        public DateTime Termination_Date { get; set; }

        [Column("Grounds for Term_ Code")]
        [Required]
        [StringLength(10)]
        public string Grounds_for_Term__Code { get; set; }

        [Column("Global Dimension 1 Code")]
        [Required]
        [StringLength(20)]
        public string Global_Dimension_1_Code { get; set; }

        [Column("Global Dimension 2 Code")]
        [Required]
        [StringLength(20)]
        public string Global_Dimension_2_Code { get; set; }

        [Column("Resource No_")]
        [Required]
        [StringLength(20)]
        public string Resource_No_ { get; set; }

        [Column("Last Date Modified")]
        public DateTime Last_Date_Modified { get; set; }

        [Required]
        [StringLength(30)]
        public string Extension { get; set; }

        [Required]
        [StringLength(30)]
        public string Pager { get; set; }

        [Column("Fax No_")]
        [Required]
        [StringLength(30)]
        public string Fax_No_ { get; set; }

        [Column("Company E-Mail")]
        [Required]
        [StringLength(80)]
        public string Company_E_Mail { get; set; }

        [Required]
        [StringLength(30)]
        public string Title { get; set; }

        [Column("Salespers__Purch_ Code")]
        [Required]
        [StringLength(10)]
        public string Salespers__Purch__Code { get; set; }

        [Column("No_ Series")]
        [Required]
        [StringLength(10)]
        public string No__Series { get; set; }
    }
}
