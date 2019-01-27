namespace TwoMigrationsHW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class init : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Cars",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Model = c.String(),
                        Color = c.String(),
                        Price = c.Int(nullable: false),
                        CarShop_Id = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.CarShops", t => t.CarShop_Id)
                .Index(t => t.CarShop_Id);
            
            CreateTable(
                "dbo.CarShops",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Address = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Cars", "CarShop_Id", "dbo.CarShops");
            DropIndex("dbo.Cars", new[] { "CarShop_Id" });
            DropTable("dbo.CarShops");
            DropTable("dbo.Cars");
        }
    }
}
