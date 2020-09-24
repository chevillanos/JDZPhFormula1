using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class RaceResult
    {
        public int Id { get; set; }
        public int RaceDetailId { get; set; }
        public int DriverId { get; set; }
        public int RaceSessionId { get; set; }
        public bool IsFastestLap { get; set; }
        public bool HasPenalty { get; set; }

        public virtual RaceDetail RaceDetail { get; set; }
        public virtual Driver Driver { get; set; }        
        public virtual RaceSession RaceSession { get; set; }
    }
}