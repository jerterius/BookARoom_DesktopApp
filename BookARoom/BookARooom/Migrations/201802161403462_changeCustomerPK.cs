namespace BookARoom.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class changeCustomerPK : DbMigration
    {
        public override void Up()
        {
            DropForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers");
            RenameColumn(table: "dbo.Bookings", name: "CPhoneNumber", newName: "CEmail");
            RenameIndex(table: "dbo.Bookings", name: "IX_CPhoneNumber", newName: "IX_CEmail");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CPhoneNumber", c => c.String());
            AlterColumn("dbo.Customers", "CEmail", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CEmail");
            AddForeignKey("dbo.Bookings", "CEmail", "dbo.Customers", "CEmail", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Bookings", "CEmail", "dbo.Customers");
            DropPrimaryKey("dbo.Customers");
            AlterColumn("dbo.Customers", "CEmail", c => c.String());
            AlterColumn("dbo.Customers", "CPhoneNumber", c => c.String(nullable: false, maxLength: 128));
            AddPrimaryKey("dbo.Customers", "CPhoneNumber");
            RenameIndex(table: "dbo.Bookings", name: "IX_CEmail", newName: "IX_CPhoneNumber");
            RenameColumn(table: "dbo.Bookings", name: "CEmail", newName: "CPhoneNumber");
            AddForeignKey("dbo.Bookings", "CPhoneNumber", "dbo.Customers", "CPhoneNumber", cascadeDelete: true);
        }
    }
}
