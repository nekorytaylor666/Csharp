namespace TwoMigrationsHW.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class addedType : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Cars", "Type", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Cars", "Type");
        }
    }
}
