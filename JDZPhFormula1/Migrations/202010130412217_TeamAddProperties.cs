namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamAddProperties : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "FullTeamName", c => c.String(maxLength: 150));
            AddColumn("dbo.Teams", "Base", c => c.String());
            AddColumn("dbo.Teams", "Profile", c => c.String());
        }
        
        public override void Down()
        {
            DropColumn("dbo.Teams", "Profile");
            DropColumn("dbo.Teams", "Base");
            DropColumn("dbo.Teams", "FullTeamName");
        }
    }
}
