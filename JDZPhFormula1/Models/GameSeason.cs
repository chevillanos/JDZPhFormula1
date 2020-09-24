using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class GameSeason
    {
        public int Id { get; set; }
        public int GameYear { get; set; }
        public byte Season { get; set; }
        public bool IsActive { get; set; }
    }
}