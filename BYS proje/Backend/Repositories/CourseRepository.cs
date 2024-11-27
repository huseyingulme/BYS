using System.Collections.Generic;
using System.Linq;
using YourNamespace.Data;
using YourNamespace.Models;

namespace YourNamespace.Repositories
{
    public class CourseRepository : ICourseRepository
    {
        private readonly AppDbContext _context;

        public CourseRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Course> GetAll()
        {
            return _context.Courses.ToList();
        }

        public Course GetById(int id)
        {
            return _context.Courses.FirstOrDefault(c => c.CourseId == id);
        }

        public void Add(Course course)
        {
            _context.Courses.Add(course);
            _context.SaveChanges();
        }

        public Course Update(int id, Course course)
        {
            var existingCourse = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (existingCourse == null) return null;

            existingCourse.CourseName = course.CourseName;
            existingCourse.Credits = course.Credits;
            existingCourse.InstructorId = course.InstructorId;

            _context.SaveChanges();
            return existingCourse;
        }

        public bool Delete(int id)
        {
            var course = _context.Courses.FirstOrDefault(c => c.CourseId == id);
            if (course == null) return false;

            _context.Courses.Remove(course);
            _context.SaveChanges();
            return true;
        }
    }
}
