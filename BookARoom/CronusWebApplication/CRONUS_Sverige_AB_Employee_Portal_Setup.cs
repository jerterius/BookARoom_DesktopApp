namespace CronusWebApplication
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    [Table("CRONUS Sverige AB$Employee Portal Setup")]
    public partial class CRONUS_Sverige_AB_Employee_Portal_Setup
    {
        [Column(TypeName = "timestamp")]
        [MaxLength(8)]
        [Timestamp]
        public byte[] timestamp { get; set; }

        [Key]
        [Column("Primary Key")]
        [StringLength(10)]
        public string Primary_Key { get; set; }

        [Column("Search Limit")]
        public int Search_Limit { get; set; }

        [Column("Temp_ Key Index")]
        public int Temp__Key_Index { get; set; }

        [Column("Temp_ Table No_")]
        public int Temp__Table_No_ { get; set; }

        [Column("Temp_ Key String")]
        [Required]
        [StringLength(250)]
        public string Temp__Key_String { get; set; }

        [Column("Temp_ Option Value")]
        public int Temp__Option_Value { get; set; }

        [Column("Temp_ Option Caption")]
        [Required]
        [StringLength(250)]
        public string Temp__Option_Caption { get; set; }

        [Column("Temp_ SharePoint Site Name")]
        [Required]
        [StringLength(250)]
        public string Temp__SharePoint_Site_Name { get; set; }

        [Column("Back End Public Key", TypeName = "image")]
        public byte[] Back_End_Public_Key { get; set; }

        [Column("Back End Private Key", TypeName = "image")]
        public byte[] Back_End_Private_Key { get; set; }

        [Column("Write Debugging Info_")]
        public byte Write_Debugging_Info_ { get; set; }

        [Column("Config Tool Pane Caption ID")]
        public int Config_Tool_Pane_Caption_ID { get; set; }

        [Column("Config TP WP Request Capt ID")]
        public int Config_TP_WP_Request_Capt_ID { get; set; }

        [Column("Config TP Initial Req_ Capt ID")]
        public int Config_TP_Initial_Req__Capt_ID { get; set; }

        [Column("Config TP Group Capt ID")]
        public int Config_TP_Group_Capt_ID { get; set; }

        [Column("Search Tool Pane Caption ID")]
        public int Search_Tool_Pane_Caption_ID { get; set; }

        [Column("Search Config Table ID")]
        public int Search_Config_Table_ID { get; set; }

        [Column("Search TP All Tables Capt ID")]
        public int Search_TP_All_Tables_Capt_ID { get; set; }

        [Column("Config Tool Pane Caption")]
        [Required]
        [StringLength(80)]
        public string Config_Tool_Pane_Caption { get; set; }

        [Column("Config TP WP Request Caption")]
        [Required]
        [StringLength(80)]
        public string Config_TP_WP_Request_Caption { get; set; }

        [Column("Config TP Initial Req_ Caption")]
        [Required]
        [StringLength(80)]
        public string Config_TP_Initial_Req__Caption { get; set; }

        [Column("Config TP Group Caption")]
        [Required]
        [StringLength(80)]
        public string Config_TP_Group_Caption { get; set; }

        [Column("Search Tool Pane Caption")]
        [Required]
        [StringLength(80)]
        public string Search_Tool_Pane_Caption { get; set; }

        [Column("Search Config Table Caption")]
        [Required]
        [StringLength(80)]
        public string Search_Config_Table_Caption { get; set; }

        [Column("Search TP All Tables Caption")]
        [Required]
        [StringLength(80)]
        public string Search_TP_All_Tables_Caption { get; set; }

        [Column("Debugging Path")]
        [Required]
        [StringLength(250)]
        public string Debugging_Path { get; set; }
    }
}
