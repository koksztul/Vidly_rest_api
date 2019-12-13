namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBornDateToCustomer1 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BornDate", c => c.DateTime());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BornDate", c => c.DateTime(nullable: false));
        }
    }
}
