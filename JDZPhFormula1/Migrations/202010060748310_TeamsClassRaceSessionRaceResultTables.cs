namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class TeamsClassRaceSessionRaceResultTables : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.GameSeasons",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        GameYear = c.Int(nullable: false),
                        Season = c.Byte(nullable: false),
                        IsActive = c.Boolean(nullable: false),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.RaceDetails",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        TrackName = c.String(),
                        Schedule = c.DateTime(nullable: false),
                        ClassificationId = c.Int(nullable: false),
                        GameSeasonId = c.Int(nullable: false),
                    })
                .PrimaryKey(t => t.Id)
                .ForeignKey("dbo.Classifications", t => t.ClassificationId, cascadeDelete: true)
                .ForeignKey("dbo.GameSeasons", t => t.GameSeasonId, cascadeDelete: true)
                .Index(t => t.ClassificationId)
                .Index(t => t.GameSeasonId);
            
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.RaceDetails", "GameSeasonId", "dbo.GameSeasons");
            DropForeignKey("dbo.RaceDetails", "ClassificationId", "dbo.Classifications");
            DropIndex("dbo.RaceDetails", new[] { "GameSeasonId" });
            DropIndex("dbo.RaceDetails", new[] { "ClassificationId" });
            DropTable("dbo.RaceDetails");
            DropTable("dbo.GameSeasons");
        }
    }
}
