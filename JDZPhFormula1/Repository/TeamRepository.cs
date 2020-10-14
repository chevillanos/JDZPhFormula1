using JDZPhFormula1.Models;
using JDZPhFormula1.Services;
using JDZPhFormula1.ViewModels;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data.SqlTypes;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Repository
{
    public class TeamRepository : ITeamService
    {
        ApplicationDbContext _context;

        public TeamRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<Team> GetTeams()
        {
            var teams = _context.Teams.ToList();

            return teams;
        }

        public TeamDetails GetTeamByName(string name)
        {
            var team = _context.Teams.Where(t => t.Name == name).SingleOrDefault();

            var driverStats = _context.Database.SqlQuery<DriverStandings>("GetDriverStandings @Classification",
                new SqlParameter("@Classification", SqlInt32.Null))
                .Where(d => d.Team == team.Name)
                .OrderBy(d => d.Id)
                .ToList();

            int bronze = _context.Database.SqlQuery<int>("GetTeamScore @Classification, @Team",
                new SqlParameter("@Classification", Classification.Bronze),
                new SqlParameter("@Team", team.Name)).FirstOrDefault();
            int silver = _context.Database.SqlQuery<int>("GetTeamScore @Classification, @Team",
                new SqlParameter("@Classification", Classification.Silver),
                new SqlParameter("@Team", team.Name)).FirstOrDefault();
            int total = _context.Database.SqlQuery<int>("GetTeamScore @Classification, @Team",
                new SqlParameter("@Classification", SqlInt32.Null),
                new SqlParameter("@Team", team.Name)).FirstOrDefault();

            var teamDetails = new TeamDetails
            {
                Team = team,
                Drivers = driverStats,
                BronzeScore = bronze,
                SilverScore = silver,
                TotalTeamScore = total
            };

            return teamDetails;
        }
    }
}