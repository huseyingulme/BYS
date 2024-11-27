using Microsoft.AspNetCore.Mvc;
using BackendProject.Services;
using BackendProject.Models;

namespace BackendProject.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class InstructorController : ControllerBase
    {
        private readonly IInstructorService _instructorService;

        public InstructorController(IInstructorService instructorService)
        {
            _instructorService = instructorService;
        }

        [HttpGet]
        public IActionResult GetAllInstructors()
        {
            var instructors = _instructorService.GetAllInstructors();
            return Ok(instructors);
        }

        [HttpGet("{id}")]
        public IActionResult GetInstructorById(int id)
        {
            var instructor = _instructorService.GetInstructorById(id);
            if (instructor == null)
                return NotFound("Instructor not found.");

            return Ok(instructor);
        }

        [HttpPost]
        public IActionResult AddInstructor([FromBody] Instructor instructor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            _instructorService.AddInstructor(instructor);
            return Ok("Instructor added successfully.");
        }

        [HttpPut("{id}")]
        public IActionResult UpdateInstructor(int id, [FromBody] Instructor instructor)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var result = _instructorService.UpdateInstructor(id, instructor);
            if (!result)
                return NotFound("Instructor not found.");

            return Ok("Instructor updated successfully.");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteInstructor(int id)
        {
            var result = _instructorService.DeleteInstructor(id);
            if (!result)
                return NotFound("Instructor not found.");

            return Ok("Instructor deleted successfully.");
        }
    }
}
