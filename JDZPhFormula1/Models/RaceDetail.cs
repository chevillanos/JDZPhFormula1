using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class RaceDetail
    {
        public int Id { get; set; }
        public string TrackName { get; set; }
        public DateTime Schedule { get; set; }
        public int ClassificationId { get; set; }
        public int GameSeasonId { get; set; }
        public bool IsActive { get; set; }

        public virtual Classification Classification { get; set; }
        public virtual GameSeason GameSeason { get; set; }
    }
}