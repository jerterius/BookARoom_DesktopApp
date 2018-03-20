namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RemoveCreditCardResponsible : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "Password", c => c.String(nullable: false));
            DropColumn("dbo.Bookings", "Responsible");
            DropColumn("dbo.Bookings", "CreditCardNumber");
        }
        
        public override void Down()
        {
            AddColumn("dbo.Bookings", "CreditCardNumber", c => c.String());
            AddColumn("dbo.Bookings", "Responsible", c => c.String());
            AlterColumn("dbo.Customers", "Password", c => c.String());
        }
    }
}
