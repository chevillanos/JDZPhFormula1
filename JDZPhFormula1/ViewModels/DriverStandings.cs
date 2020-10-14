using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.ViewModels
{
    public class DriverStandings
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string AvatarURL { get; set; }
        public string Team { get; set; }
        public int Score { get; set; }
        public int ClassificationId { get; set; }
    }
}