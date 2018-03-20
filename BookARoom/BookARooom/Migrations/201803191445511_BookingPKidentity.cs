namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class BookingPKidentity : DbMigration
    {
        public override void Up()
        {
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.Long(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
        
        public override void Down()
        {
            DropPrimaryKey("dbo.Bookings");
            AlterColumn("dbo.Bookings", "BookingNumber", c => c.Int(nullable: false, identity: true));
            AddPrimaryKey("dbo.Bookings", "BookingNumber");
        }
    }
}
