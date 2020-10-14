namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class removeIsFastestLapRaceSession : DbMigration
    {
        public override void Up()
        {
            DropColumn("dbo.RaceSessions", "IsFastestLap");
        }
        
        public override void Down()
        {
            AddColumn("dbo.RaceSessions", "IsFastestLap", c => c.Byte(nullable: false));
        }
    }
}
