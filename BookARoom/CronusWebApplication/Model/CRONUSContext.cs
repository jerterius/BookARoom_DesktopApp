namespace CronusWebApplication.Model
{
    using System;
    using System.Data.Entity;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Linq;

    public partial class CRONUSContext : DbContext
    {
        public CRONUSContext()
            : base("name=CronusModel1")
        {
        }

        public virtual DbSet<CRONUS_Sverige_AB_Employee> CRONUS_Sverige_AB_Employee { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Absence> CRONUS_Sverige_AB_Employee_Absence { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Portal_Setup> CRONUS_Sverige_AB_Employee_Portal_Setup { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Qualification> CRONUS_Sverige_AB_Employee_Qualification { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Relative> CRONUS_Sverige_AB_Employee_Relative { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Relative> CRONUS_Sverige_AB_Relative { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employee_Statistics_Group> CRONUS_Sverige_AB_Employee_Statistics_Group { get; set; }
        public virtual DbSet<CRONUS_Sverige_AB_Employment_Contract> CRONUS_Sverige_AB_Employment_Contract { get; set; }

        public virtual DbSet<CRONUSMetadata_Index> CRONUSMetadata_Index { get; set; }

        public virtual DbSet<CRONUSMetadata_Constraint> CRONUSMetadata_Constraint { get; set; }
        public virtual DbSet<CRONUSMetadata_Key> CRONUSMetadata_Key { get; set; }
        public virtual DbSet<CRONUSMetadata_Table> CRONUSMetadata_Table { get; set; }
        public virtual DbSet<CRONUSMetadata_Column> CRONUSMetadata_Column { get; set; }

        public virtual DbSet<CRONUSMetadata_EmployeeRelated> CRONUSMetadata_EmployeeRelated { get; set; }
        public virtual DbSet<CRONUS_Employee_Top5_Absence> CRONUS_Employee_Top5_Absence { get; set; }

        public virtual DbSet<CRONUS_Employees_Sick_2004> CRONUS_Employees_Sick_2004 { get; set; }

        public virtual DbSet<CRONUS_Employees_And_Relatives> CRONUS_Employees_And_Relatives { get; set; }



        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            /*
           modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.timestamp)
                .IsFixedLength();
            */

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Middle_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Initials)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Job_Title)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Search_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Address)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Address_2)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.City)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Post_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.County)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Phone_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Mobile_Phone_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.E_Mail)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Alt__Address_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Social_Security_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Union_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Union_Membership_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Country_Region_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Manager_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Emplymt__Contract_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Statistics_Group_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Cause_of_Inactivity_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Grounds_for_Term__Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Global_Dimension_1_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Global_Dimension_2_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Resource_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Extension)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Pager)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Fax_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Company_E_Mail)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Title)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.Salespers__Purch__Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee>()
                .Property(e => e.No__Series)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Employee_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Cause_of_Absence_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Quantity)
                .HasPrecision(38, 20);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Unit_of_Measure_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Quantity__Base_)
                .HasPrecision(38, 20);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Absence>()
                .Property(e => e.Qty__per_Unit_of_Measure)
                .HasPrecision(38, 20);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Primary_Key)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Temp__Key_String)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Temp__Option_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Temp__SharePoint_Site_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Config_Tool_Pane_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Config_TP_WP_Request_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Config_TP_Initial_Req__Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Config_TP_Group_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Search_Tool_Pane_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Search_Config_Table_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Search_TP_All_Tables_Caption)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Portal_Setup>()
                .Property(e => e.Debugging_Path)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Employee_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Qualification_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Institution_Company)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Cost)
                .HasPrecision(38, 20);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Qualification>()
                .Property(e => e.Course_Grade)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Employee_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Relative_Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.First_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Middle_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Last_Name)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Phone_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Relative>()
                .Property(e => e.Relative_s_Employee_No_)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Relative>()
    .Property(e => e.timestamp)
    .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Relative>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Relative>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Statistics_Group>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Statistics_Group>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employee_Statistics_Group>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employment_Contract>()
                .Property(e => e.timestamp)
                .IsFixedLength();

            modelBuilder.Entity<CRONUS_Sverige_AB_Employment_Contract>()
                .Property(e => e.Code)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUS_Sverige_AB_Employment_Contract>()
                .Property(e => e.Description)
                .IsUnicode(false);

            modelBuilder.Entity<CRONUSMetadata_Index>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<CRONUSMetadata_Constraint>()
                .Property(e => e.Constraint_Name)
                .IsFixedLength();

            modelBuilder.Entity<CRONUSMetadata_Key>()
                .Property(e => e.Constraint_Name)
                .IsFixedLength();

            modelBuilder.Entity<CRONUSMetadata_Table>()
                .Property(e => e.Name)
                .IsFixedLength();

            modelBuilder.Entity<CRONUSMetadata_Column>()
                .Property(e => e.Column_Name)
                .IsFixedLength();
        }
    }
}
