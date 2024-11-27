using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace UniversitySystem.Models
{
    public class Student
    {
        [Key]
        public int StudentId { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [EmailAddress]
        public string Email { get; set; }

        [Required]
        public string Password { get; set; }

        public string Major { get; set; }

        public ICollection<Course> Courses { get; set; }
    }
}
