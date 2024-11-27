using System.ComponentModel.DataAnnotations;

namespace YourNamespace.Models
{
    public class Course
    {
        [Key]
        public int CourseId { get; set; }

        [Required]
        [MaxLength(100)]
        public string CourseName { get; set; }

        [Required]
        public int Credits { get; set; }

        public int InstructorId { get; set; }
    }
}
