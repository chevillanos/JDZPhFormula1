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
    public class DriverRepository : IDriverService
    {
        ApplicationDbContext _context;

        public DriverRepository()
        {
            _context = new ApplicationDbContext();
        }

        public List<DriverStandings> ByClassification(string classificationName)
        {
            //var drivers = new List<Driver>();

            //if (classificationName == Classification.Bronze.ToString())
            //{
            //    drivers = _context.Drivers
            //   .Where(d => d.ClassificationId == (int)Classification.Bronze)
            //   .Include(t => t.Team)
            //   .Include(c => c.Classification)
            //   .ToList();
            //}
            //else
            //{
            //    drivers = _context.Drivers
            //    .Where(d => d.ClassificationId == (int)Classification.Silver)
            //    .Include(t => t.Team)
            //    .Include(c => c.Classification)                
            //    .ToList();
            //}

            //return drivers;

            var classification = new SqlParameter
            {
                ParameterName = "Classification",
                Value = classificationName == Classification.Bronze.ToString() ? 1 : 2
            };

            var driverStats = _context.Database.SqlQuery<DriverStandings>("GetDriverStandings @Classification", classification)
                .ToList();

            return driverStats;
        }

        public Driver Details(int? id)
        {
            var driver = _context.Drivers.Include(d => d.Team)
                .SingleOrDefault(d => d.Id == id);

            return driver;
        }
    }

    enum Classification
    {
        Bronze = 1,
        Silver = 2,
        Gold = 3
    }
}