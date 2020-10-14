namespace JDZPhFormula1.Migrations
{
    using System;
    using System.Data.Entity.Migrations;
    
    public partial class SeedDrivers : DbMigration
    {
        public override void Up()
        {
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Luigi Delmo', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Marco Oasan', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Miguel Mendoza', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Janb Dayrit', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Raymund Bumagat', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Joseph Cairo', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Edward Moreno', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('April Virata', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Vic Nodalo', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Raff Ignacio', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Carl Henry', '2020-03-29', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Maui Lontoc', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('James Viado', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Terence  Remollo', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('James Co', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Renee Lugtu', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Axel Nocom', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('John Go', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Rafael Aclan', '2020-10-01', NULL, 1, 1)");
            Sql("INSERT INTO Drivers (Name, JoiningDate, LeaveDate, TeamId, ClassificationId) VALUES ('Wilann Navarro', '2020-10-01', NULL, 1, 1)");

        }

        public override void Down()
        {
        }
    }
}
