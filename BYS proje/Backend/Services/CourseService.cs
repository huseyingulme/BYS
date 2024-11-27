using System.Collections.Generic;
using YourNamespace.Models;
using YourNamespace.Repositories;

namespace YourNamespace.Services
{
    public class CourseService : ICourseService
    {
        private readonly ICourseRepository _courseRepository;

        public CourseService(ICourseRepository courseRepository)
        {
            _courseRepository = courseRepository;
        }

        public IEnumerable<Course> GetAllCourses()
        {
            return _courseRepository.GetAll();
        }

        public Course GetCourseById(int id)
        {
            return _courseRepository.GetById(id);
        }

        public void AddCourse(Course course)
        {
            _courseRepository.Add(course);
        }

        public Course UpdateCourse(int id, Course course)
        {
            return _courseRepository.Update(id, course);
        }

        public bool DeleteCourse(int id)
        {
            return _courseRepository.Delete(id);
        }
    }
}
