namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedTeamAndClassification : DbMigration
    {
        public override void Up()
        {
            // Classifications TABLE
            Sql("INSERT INTO Classifications (Name) VALUES ('Bronze')");
            Sql("INSERT INTO Classifications (Name) VALUES ('Silver')");
            Sql("INSERT INTO Classifications (Name) VALUES ('Gold')");

            // Teams TABLE
            Sql("INSERT INTO Teams (Name) VALUES ('Mercedes')");
            Sql("INSERT INTO Teams (Name) VALUES ('Ferrari')");
            Sql("INSERT INTO Teams (Name) VALUES ('Red Bull')");
            Sql("INSERT INTO Teams (Name) VALUES ('Williams')");
            Sql("INSERT INTO Teams (Name) VALUES ('Renault')");
            Sql("INSERT INTO Teams (Name) VALUES ('McLaren')");
            Sql("INSERT INTO Teams (Name) VALUES ('Alfa Romeo')");
            Sql("INSERT INTO Teams (Name) VALUES ('Alpha Tauri')");
            Sql("INSERT INTO Teams (Name) VALUES ('Racing Point')");
            Sql("INSERT INTO Teams (Name) VALUES ('Haas')");
        }

        public override void Down()
        {
        }
    }
}
