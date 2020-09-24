using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class RaceSession
    {
        public int Id { get; set; }
        public string Description { get; set; } // Qualifying or Race
        public byte Position { get; set; }
        public int Score { get; set; }
    }
}