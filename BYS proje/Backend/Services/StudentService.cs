using System.Collections.Generic;
using System.Linq;
using UniversitySystem.Data;
using UniversitySystem.Models;

namespace UniversitySystem.Services
{
    public class StudentService
    {
        private readonly ApplicationDbContext _context;

        public StudentService(ApplicationDbContext context)
        {
            _context = context;
        }

        public List<Student> GetAllStudents()
        {
            return _context.Students.ToList();
        }

        public void AddStudent(Student student)
        {
            _context.Students.Add(student);
            _context.SaveChanges();
        }
    }
}
