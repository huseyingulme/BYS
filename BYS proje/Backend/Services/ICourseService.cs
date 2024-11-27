using System.Collections.Generic;
using YourNamespace.Models;

namespace YourNamespace.Services
{
    public interface ICourseService
    {
        IEnumerable<Course> GetAllCourses();
        Course GetCourseById(int id);
        void AddCourse(Course course);
        Course UpdateCourse(int id, Course course);
        bool DeleteCourse(int id);
    }
}
