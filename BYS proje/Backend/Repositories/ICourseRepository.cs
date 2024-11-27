using System.Collections.Generic;
using YourNamespace.Models;

namespace YourNamespace.Repositories
{
    public interface ICourseRepository
    {
        IEnumerable<Course> GetAll();
        Course GetById(int id);
        void Add(Course course);
        Course Update(int id, Course course);
        bool Delete(int id);
    }
}
