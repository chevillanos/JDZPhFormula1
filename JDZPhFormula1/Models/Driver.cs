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
        public char DriverStatus { get; set; }
        [Required]
        public DateTime JoiningDate { get; set; }
        public DateTime? LeaveDate { get; set; }
        [Required]
        public int TeamId { get; set; }
        [Required]
        public int ClassificationId { get; set; }
    }
}