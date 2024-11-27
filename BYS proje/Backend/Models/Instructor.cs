using System.ComponentModel.DataAnnotations;

namespace BackendProject.Models
{
    public class Instructor
    {
        [Key]
        public int InstructorID { get; set; }

        [Required]
        [MaxLength(50)]
        public string FirstName { get; set; }

        [Required]
        [MaxLength(50)]
        public string LastName { get; set; }

        [Required]
        [MaxLength(100)]
        public string Email { get; set; }

        [Required]
        [MaxLength(50)]
        public string Department { get; set; }
    }
}
