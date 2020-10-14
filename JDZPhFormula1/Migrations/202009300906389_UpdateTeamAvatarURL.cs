namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class UpdateTeamAvatarURL : DbMigration
    {
        public override void Up()
        {
            AddColumn("dbo.Teams", "AvatarURL", c => c.String());
            AlterColumn("dbo.Teams", "Name", c => c.String(nullable: false, maxLength: 50));
        }
        
        public override void Down()
        {
            AlterColumn("dbo.Teams", "Name", c => c.String());
            DropColumn("dbo.Teams", "AvatarURL");
        }
    }
}
