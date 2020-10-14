namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class AddTeamAndClassification : DbMigration
    {
        public override void Up()
        {
            CreateTable(
                "dbo.Classifications",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateTable(
                "dbo.Teams",
                c => new
                    {
                        Id = c.Int(nullable: false, identity: true),
                        Name = c.String(),
                    })
                .PrimaryKey(t => t.Id);
            
            CreateIndex("dbo.Drivers", "TeamId");
            CreateIndex("dbo.Drivers", "ClassificationId");
            AddForeignKey("dbo.Drivers", "ClassificationId", "dbo.Classifications", "Id", cascadeDelete: true);
            AddForeignKey("dbo.Drivers", "TeamId", "dbo.Teams", "Id", cascadeDelete: true);
        }
        
        public override void Down()
        {
            DropForeignKey("dbo.Drivers", "TeamId", "dbo.Teams");
            DropForeignKey("dbo.Drivers", "ClassificationId", "dbo.Classifications");
            DropIndex("dbo.Drivers", new[] { "ClassificationId" });
            DropIndex("dbo.Drivers", new[] { "TeamId" });
            DropTable("dbo.Teams");
            DropTable("dbo.Classifications");
        }
    }
}
