using JDZPhFormula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.Data.Entity;
using JDZPhFormula1.ViewModels;
using System.Data.SqlClient;

namespace JDZPhFormula1.Controllers
{
    public class RaceResultsController : Controller
    {
        ApplicationDbContext _context;

        public RaceResultsController()
        {
            _context = new ApplicationDbContext();
        }

        // GET: RaceResults
        public ActionResult Index()
        {
            return View();
        }

        // RaceResults/DriverStandings
        public ActionResult DriverStandings()
        {


            //driverStats = from rr in _context.RaceResults
            //              join rs in _context.RaceSessions on rr.RaceSessionId equals rs.Id
            //              join d in _context.Drivers on rr.DriverId equals d.Id
            //              join t in _context.Teams on d.TeamId equals t.Id
            //              group d by d.Name into g
            //              select new
            //              {
            //                  Name = g.Key,
            //                  Sum = g.Sum(rr => rr.
            //              }

            var classification = new SqlParameter
            {
                ParameterName = "Classification",
                Value = 1
            };

            var driverStats = _context.Database.SqlQuery<DriverStandings>("GetDriverStandings @Classification", classification)
                .ToList();
            

            return View(driverStats);
        }
    }
}