using JDZPhFormula1.Models;
using JDZPhFormula1.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using JDZPhFormula1.ViewModels;
using System.Data.SqlClient;
namespace JDZPhFormula1.Repository
{
    public class HomeRepository : IHomeService
    {
        ApplicationDbContext _context;

        public HomeRepository()
        {
            _context = new ApplicationDbContext();
        }

        public HomeDetails HomeDetails(string classification)
        {
            var drivers = _context.Drivers.Include(d => d.Team).OrderBy(t => t.TeamId).ToList();
            var teams = _context.Teams.OrderBy(t => t.Name).ToList();

            var homedetails = new HomeDetails
            {
                Drivers = drivers,
                Teams = teams,
                Schedule = _context.RaceDetails
                .Where(s => s.ClassificationId == 1)
                .Where(s => s.IsActive == true)
                .SingleOrDefault()
            };

            return homedetails;
        }
    }
}