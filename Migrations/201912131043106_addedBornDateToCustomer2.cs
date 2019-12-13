namespace Vidly.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedBornDateToCustomer2 : DbMigration
    {
        public override void Up()
        {
            AlterColumn("dbo.Customers", "BornDate", c => c.String());
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Customers", "BornDate", c => c.DateTime());
        }
    }
}
