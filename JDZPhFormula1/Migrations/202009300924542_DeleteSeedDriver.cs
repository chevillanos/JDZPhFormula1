namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class DeleteSeedDriver : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Drivers", "DriverStatus", c => c.String(nullable: false, maxLength: 1));
        }
        
        public override void Down()
        {
            DropColumn("dbo.Drivers", "DriverStatus");
        }
    }
}
