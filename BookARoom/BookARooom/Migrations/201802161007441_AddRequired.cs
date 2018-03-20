namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddRequired : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropIndex("dbo.Bookings", "IX_DateRoom");
            DropIndex("dbo.Bookings", new[] { "CPhoneNumber" });
            AlterColumn("dbo.Bookings", "Adress", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Bookings", "RoomNumber", c => c.String(nullable: false, maxLength: 128));
            AlterColumn("dbo.Bookings", "CPhoneNumber", c => c.String(nullable: false, maxLength: 128));
            CreateIndex("dbo.Bookings", new[] { "Date", "Adress", "RoomNumber" }, unique: true, name: "IX_DateRoom");
            CreateIndex("dbo.Bookings", "CPhoneNumber");
            AddForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers", "CPhoneNumber", cascadeDelete: true);
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            DropIndex("dbo.Bookings", new[] { "CPhoneNumber" });
            DropIndex("dbo.Bookings", "IX_DateRoom");
            AlterColumn("dbo.Bookings", "CPhoneNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bookings", "RoomNumber", c => c.String(maxLength: 128));
            AlterColumn("dbo.Bookings", "Adress", c => c.String(maxLength: 128));
            CreateIndex("dbo.Bookings", "CPhoneNumber");
            CreateIndex("dbo.Bookings", new[] { "Date", "Adress", "RoomNumber" }, unique: true, name: "IX_DateRoom");
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" });
            AddForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers", "CPhoneNumber");
        }
    }
}
