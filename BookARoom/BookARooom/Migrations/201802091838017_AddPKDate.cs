namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddPKDate : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "Adress", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bookings", new[] { "CPhoneNumber", "Adress", "RoomNumber", "Date" });
            CreateIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" }, cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms");
            DropIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "Adress", c => c.String(maxLength: 128));
            AddPrimaryKey("dbo.Bookings", new[] { "CPhoneNumber", "RoomNumber" });
            CreateIndex("dbo.Bookings", new[] { "Adress", "RoomNumber" });
            AddForeignKey("dbo.Bookings", new[] { "Adress", "RoomNumber" }, "dbo.Rooms", new[] { "Adress", "RoomNumber" });
        }
    }
}
