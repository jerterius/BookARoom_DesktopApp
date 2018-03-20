namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateBookingPK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropIndex("dbo.Bookings", new[] { "CPhoneNumber" });
            DropIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "CPhoneNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bookings", "Adress", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bookings", "RoomNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
            CreateIndex("dbo.Bookings", new[] { "Date", "Adress", "RoomNumber" }, unique: true, name: "IX_DateRoom");
            CreateIndex("dbo.Bookings", "CPhoneNumber");
            AddForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers", "CPhoneNumber");
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" });
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "CPhoneNumber" });
            DropIndex("dbo.Bookings", "IX_DateRoom");
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.String());
            AlterColumn("dbo.Bookings", "RoomNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Bookings", "Adress", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Bookings", "CPhoneNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bookings", new[] { "CPhoneNumber", "Adress", "RoomNumber", "Date" });
            CreateIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            CreateIndex("dbo.Bookings", "CPhoneNumber");
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" }, cascadeDelete: true);
            AddForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers", "CPhoneNumber", cascadeDelete: true);
        }
    }
}
