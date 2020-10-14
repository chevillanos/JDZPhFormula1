namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaceDetailsIsActive : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.RaceDetails", "IsActive", c => c.Boolean(nullable: false));
        }
        
        public override void Down()
        {
            DropColumn("dbo.RaceDetails", "IsActive");
        }
    }
}
