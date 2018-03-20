namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class bookingNoGUID : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bookings");
            DropColumn("dbo.Bookings", "BookingNumber");
            AddColumn("dbo.Bookings", "BookingNumber", c => c.Guid(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bookings");
            DropColumn("dbo.Bookings", "BookingNumber");
            AddColumn("dbo.Bookings", "BookingNumber", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
    }
}
