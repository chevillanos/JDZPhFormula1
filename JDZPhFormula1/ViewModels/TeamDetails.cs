using JDZPhFormula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.ViewModels
{
    public class TeamDetails
    {
        public List<DriverStandings> Drivers { get; set; }
        public Team Team { get; set; }
        public int BronzeScore { get; set; }
        public int SilverScore { get; set; }
        public int TotalTeamScore { get; set; }
    }
}