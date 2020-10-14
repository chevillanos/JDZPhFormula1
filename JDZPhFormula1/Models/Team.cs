using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class Team
    {
        public int Id { get; set; }
        [Required]
        [StringLength(50)]
        public string Name { get; set; }
        public string AvatarURL { get; set; }
        [StringLength(150)]
        public string FullTeamName { get; set; }
        public string Base { get; set; }
        public string Profile { get; set; }
        public string LogoURL { get; set; }
    }
}