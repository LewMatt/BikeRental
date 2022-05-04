namespace BikeRental.Data.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DatabaseCreated : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Bikes",
                c => new
                    {
                        BikeID = c.Int(nullable: false, identity: true),
                        Brand = c.String(nullable: false, maxLength: 200),
                        Model = c.String(nullable: false, maxLength: 200),
                        Type = c.String(maxLength: 200),
                        Color = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.BikeID);
            
            CreateTable(
                "dbo.Rents",
                c => new
                    {
                        RentID = c.Int(nullable: false, identity: true),
                        UserID = c.Int(nullable: false),
                        BikeID = c.Int(nullable: false),
                        Price = c.Int(nullable: false),
                        ExpirationDate = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.RentID)
                .ForeignKey("dbo.Bikes", t => t.BikeID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.UserID)
                .Index(t => t.BikeID);
            
            CreateTable(
                "dbo.Users",
                c => new
                    {
                        UserID = c.Int(nullable: false, identity: true),
                        Login = c.String(nullable: false, maxLength: 200),
                        Password = c.String(nullable: false, maxLength: 200),
                        Name = c.String(nullable: false, maxLength: 200),
                        Surname = c.String(nullable: false, maxLength: 200),
                        Phone = c.String(nullable: false, maxLength: 200),
                        Adress = c.String(maxLength: 200),
                        UserType = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.UserID);
            
            CreateTable(
                "dbo.RepairOrders",
                c => new
                    {
                        RepairOrderID = c.Int(nullable: false, identity: true),
                        BikeID = c.Int(nullable: false),
                        Description = c.String(maxLength: 200),
                    })
                .PrimaryKey(t => t.RepairOrderID)
                .ForeignKey("dbo.Bikes", t => t.BikeID, cascadeDelete: true)
                .Index(t => t.BikeID);
            
            CreateTable(
                "dbo.Repairs",
                c => new
                    {
                        RepairID = c.Int(nullable: false, identity: true),
                        RepairOrderID = c.Int(nullable: false),
                        UserID = c.Int(nullable: false),
                        BikeID = c.Int(nullable: false),
                        Details = c.String(maxLength: 200),
                        State = c.String(maxLength: 200),
                        OverallPrice = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.RepairID)
                .ForeignKey("dbo.Bikes", t => t.BikeID, cascadeDelete: true)
                .ForeignKey("dbo.RepairOrders", t => t.RepairOrderID, cascadeDelete: true)
                .ForeignKey("dbo.Users", t => t.UserID, cascadeDelete: true)
                .Index(t => t.RepairOrderID)
                .Index(t => t.UserID)
                .Index(t => t.BikeID);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Repairs", "UserID", "dbo.Users");
            DropForeignKey("dbo.Repairs", "RepairOrderID", "dbo.RepairOrders");
            DropForeignKey("dbo.Repairs", "BikeID", "dbo.Bikes");
            DropForeignKey("dbo.RepairOrders", "BikeID", "dbo.Bikes");
            DropForeignKey("dbo.Rents", "UserID", "dbo.Users");
            DropForeignKey("dbo.Rents", "BikeID", "dbo.Bikes");
            DropIndex("dbo.Repairs", new[] { "BikeID" });
            DropIndex("dbo.Repairs", new[] { "UserID" });
            DropIndex("dbo.Repairs", new[] { "RepairOrderID" });
            DropIndex("dbo.RepairOrders", new[] { "BikeID" });
            DropIndex("dbo.Rents", new[] { "BikeID" });
            DropIndex("dbo.Rents", new[] { "UserID" });
            DropTable("dbo.Repairs");
            DropTable("dbo.RepairOrders");
            DropTable("dbo.Users");
            DropTable("dbo.Rents");
            DropTable("dbo.Bikes");
        }
    }
}
