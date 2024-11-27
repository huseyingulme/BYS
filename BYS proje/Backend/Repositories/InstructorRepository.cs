using BackendProject.Models;
using BackendProject.Data;
using System.Collections.Generic;
using System.Linq;

namespace BackendProject.Repositories
{
    public class InstructorRepository : IInstructorRepository
    {
        private readonly AppDbContext _context;

        public InstructorRepository(AppDbContext context)
        {
            _context = context;
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return _context.Instructors.ToList();
        }

        public Instructor GetInstructorById(int id)
        {
            return _context.Instructors.FirstOrDefault(i => i.InstructorID == id);
        }

        public void AddInstructor(Instructor instructor)
        {
            _context.Instructors.Add(instructor);
            _context.SaveChanges();
        }

        public bool UpdateInstructor(int id, Instructor updatedInstructor)
        {
            var instructor = _context.Instructors.FirstOrDefault(i => i.InstructorID == id);
            if (instructor == null) return false;

            instructor.FirstName = updatedInstructor.FirstName;
            instructor.LastName = updatedInstructor.LastName;
            instructor.Email = updatedInstructor.Email;
            instructor.Department = updatedInstructor.Department;

            _context.SaveChanges();
            return true;
        }

        public bool DeleteInstructor(int id)
        {
            var instructor = _context.Instructors.FirstOrDefault(i => i.InstructorID == id);
            if (instructor == null) return false;

            _context.Instructors.Remove(instructor);
            _context.SaveChanges();
            return true;
        }
    }
}
