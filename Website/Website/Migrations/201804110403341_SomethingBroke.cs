namespace Website.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SomethingBroke : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(nullable: false, maxLength: 255));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "PhoneNumber", c => c.String(maxLength: 255));
        }
    }
}