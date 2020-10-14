namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddLogoURLTeam : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "LogoURL", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "LogoURL");
        }
    }
}
