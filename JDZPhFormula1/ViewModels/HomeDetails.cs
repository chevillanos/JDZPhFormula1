using JDZPhFormula1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.ViewModels
{
    public class HomeDetails
    {
        public RaceDetail Schedule { get; set; }
        public List<Driver> Drivers { get; set; }
        public List<Team> Teams { get; set; }
    }
}