namespace BikeRental.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class databateUpdated : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Bikes", "Price", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Bikes", "Price");
        }
    }
}
