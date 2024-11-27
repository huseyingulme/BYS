using Microsoft.AspNetCore.Mvc;
using YourNamespace.Services;
using YourNamespace.Models;

namespace YourNamespace.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CourseController : ControllerBase
    {
        private readonly ICourseService _courseService;

        public CourseController(ICourseService courseService)
        {
            _courseService = courseService;
        }

        [HttpGet]
        public IActionResult GetAllCourses()
        {
            var courses = _courseService.GetAllCourses();
            return Ok(courses);
        }

        [HttpGet("{id}")]
        public IActionResult GetCourseById(int id)
        {
            var course = _courseService.GetCourseById(id);
            if (course == null)
                return NotFound("Ders bulunamadı.");
            return Ok(course);
        }

        [HttpPost]
        public IActionResult AddCourse([FromBody] Course course)
        {
            _courseService.AddCourse(course);
            return CreatedAtAction(nameof(GetCourseById), new { id = course.CourseId }, course);
        }

        [HttpPut("{id}")]
        public IActionResult UpdateCourse(int id, [FromBody] Course course)
        {
            var updatedCourse = _courseService.UpdateCourse(id, course);
            if (updatedCourse == null)
                return NotFound("Güncellenecek ders bulunamadı.");
            return Ok(updatedCourse);
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteCourse(int id)
        {
            var isDeleted = _courseService.DeleteCourse(id);
            if (!isDeleted)
                return NotFound("Silinecek ders bulunamadı.");
            return NoContent();
        }
    }
}
