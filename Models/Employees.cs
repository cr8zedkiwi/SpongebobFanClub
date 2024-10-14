using System;
using System.ComponentModel.DataAnnotations;

namespace SongebobFanClub.Models
{
    public class Employees
    {
        public int ID { get; set; }

        [Required]
        [StringLength(50, ErrorMessage ="Please enter your full name using 50 characters or less.")]
        public string? FirstName { get; set; }

        [Required]
        [StringLength(50, ErrorMessage = "Please enter your full name using 50 characters or less.")]
        public string? LastName { get; set; }

        [Required]
        [StringLength(20, ErrorMessage = "Please enter your position at work using 20 characters or less.")]
        public string? Position { get; set; }

        [Required]
        [StringLength(10, ErrorMessage = "Please enter your salary using 10 characters or less.")]
        public string? Salary { get; set; }
    }
}
