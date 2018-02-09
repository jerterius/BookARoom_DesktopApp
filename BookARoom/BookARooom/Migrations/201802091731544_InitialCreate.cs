namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class InitialCreate : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bookings",
                c => new
                    {
                        CPhoneNumber = c.String(nullable: false, maxLength: 128),
                        Adress = c.String(maxLength: 128),
                        RoomNumber = c.String(nullable: false, maxLength: 128),
                        BookingNumber = c.String(),
                        Date = c.DateTime(nullable: false),
                        Responsible = c.String(),
                        CreditCardNumber = c.String(),
                    })
                .PrimaryKey(t => new { t.CPhoneNumber, t.RoomNumber })
                .ForeignKey("dbo.Customers", t => t.CPhoneNumber, cascadeDelete: true)
                .ForeignKey("dbo.Rooms", t => new { t.Adress, t.RoomNumber })
                .Index(t => t.CPhoneNumber)
                .Index(t => new { t.Adress, t.RoomNumber });
            
            CreateTable(
                "dbo.Customers",
                c => new
                    {
                        CPhoneNumber = c.String(nullable: false, maxLength: 128),
                        CName = c.String(),
                        Title = c.String(),
                        CAdress = c.String(),
                        CEmail = c.String(),
                    })
                .PrimaryKey(t => t.CPhoneNumber);
            
            CreateTable(
                "dbo.Rooms",
                c => new
                    {
                        Adress = c.String(nullable: false, maxLength: 128),
                        RoomNumber = c.String(nullable: false, maxLength: 128),
                        Bed = c.String(),
                        SmokeFree = c.Boolean(nullable: false),
                        Price = c.Int(nullable: false),
                        GuestCapacity = c.Int(nullable: false),
                    })
                .PrimaryKey(t => new { t.Adress, t.RoomNumber })
                .ForeignKey("dbo.Hotels", t => t.Adress, cascadeDelete: true)
                .Index(t => t.Adress);
            
            CreateTable(
                "dbo.Hotels",
                c => new
                    {
                        CityName = c.String(maxLength: 128),
                        Countryname = c.String(maxLength: 128),
                        Adress = c.String(nullable: false, maxLength: 128),
                        Name = c.String(),
                        Standard = c.String(),
                        PhoneNumber = c.String(),
                    })
                .PrimaryKey(t => t.Adress)
                .ForeignKey("dbo.Cities", t => new { t.CityName, t.Countryname })
                .Index(t => new { t.CityName, t.Countryname });
            
            CreateTable(
                "dbo.Cities",
                c => new
                    {
                        CityName = c.String(nullable: false, maxLength: 128),
                        CountryName = c.String(nullable: false, maxLength: 128),
                    })
                .PrimaryKey(t => new { t.CityName, t.CountryName });
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropForeignKey("dbo.Rooms", "Adress", "dbo.Hotels");
            DropForeignKey("dbo.Hotels", new[] { "CityName", "Countryname" }, "dbo.Cities");
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            DropIndex("dbo.Hotels", new[] { "CityName", "Countryname" });
            DropIndex("dbo.Rooms", new[] { "Adress" });
            DropIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            DropIndex("dbo.Bookings", new[] { "CPhoneNumber" });
            DropTable("dbo.Cities");
            DropTable("dbo.Hotels");
            DropTable("dbo.Rooms");
            DropTable("dbo.Customers");
            DropTable("dbo.Bookings");
        }
    }
}
