namespace BikeRental.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class afasaadd : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Rents", "IsDone", c => c.Int(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Rents", "IsDone");
        }
    }
}
