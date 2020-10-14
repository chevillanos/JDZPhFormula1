using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Web;

namespace JDZPhFormula1.Models
{
    public class Driver
    {
        public int Id { get; set; }
        [Required]
        public string Name { get; set; }
        [Required]
        [StringLength(1)]
        public string DriverStatus { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        [Required]
        public int TeamId { get; set; }
        [Required]
        public int ClassificationId { get; set; }
        public string AvatarURL { get; set; }

        // Navigation property for FK
        public Team Team { get; set; }
        public Classification Classification { get; set; }
    }
}