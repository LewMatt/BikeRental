namespace BikeRental.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class migr : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "IsAvailable", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "IsAvailable");
        }
    }
}
