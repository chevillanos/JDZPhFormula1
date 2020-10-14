namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class RaceSessionsUpdateRaceResult : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.RaceResults",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        RaceDetailId = c.Int(),
                        DriverId = c.Int(),
                        RaceSessionId = c.Int(),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Drivers", t => t.DriverId)
                .ForeignKey("dbo.RaceDetails", t => t.RaceDetailId)
                .ForeignKey("dbo.RaceSessions", t => t.RaceSessionId)
                .Index(t => t.RaceDetailId)
                .Index(t => t.DriverId)
                .Index(t => t.RaceSessionId);
            
            AddColumn("dbo.RaceSessions", "IsFastestLap", c => c.Byte(nullable: false));
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RaceResults", "RaceSessionId", "dbo.RaceSessions");
            DropForeignKey("dbo.RaceResults", "RaceDetailId", "dbo.RaceDetails");
            DropForeignKey("dbo.RaceResults", "DriverId", "dbo.Drivers");
            DropIndex("dbo.RaceResults", new[] { "RaceSessionId" });
            DropIndex("dbo.RaceResults", new[] { "DriverId" });
            DropIndex("dbo.RaceResults", new[] { "RaceDetailId" });
            DropColumn("dbo.RaceSessions", "IsFastestLap");
            DropTable("dbo.RaceResults");
        }
    }
}
