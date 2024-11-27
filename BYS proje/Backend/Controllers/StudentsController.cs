using Microsoft.AspNetCore.Mvc;
using UniversitySystem.Models;
using UniversitySystem.Services;

namespace UniversitySystem.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class StudentsController : ControllerBase
    {
        private readonly StudentService _studentService;

        public StudentsController(StudentService studentService)
        {
            _studentService = studentService;
        }

        [HttpGet]
        public IActionResult GetStudents()
        {
            var students = _studentService.GetAllStudents();
            return Ok(students);
        }

        [HttpPost]
        public IActionResult CreateStudent([FromBody] Student student)
        {
            _studentService.AddStudent(student);
            return CreatedAtAction(nameof(GetStudents), new { id = student.StudentId }, student);
        }
    }
}
