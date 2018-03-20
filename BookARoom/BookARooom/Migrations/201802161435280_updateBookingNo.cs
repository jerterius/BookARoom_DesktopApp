namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class updateBookingNo : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
    }
}
