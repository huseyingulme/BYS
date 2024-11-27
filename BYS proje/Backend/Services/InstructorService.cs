using BackendProject.Models;
using BackendProject.Repositories;
using System.Collections.Generic;

namespace BackendProject.Services
{
    public class InstructorService : IInstructorService
    {
        private readonly IInstructorRepository _instructorRepository;

        public InstructorService(IInstructorRepository instructorRepository)
        {
            _instructorRepository = instructorRepository;
        }

        public IEnumerable<Instructor> GetAllInstructors()
        {
            return _instructorRepository.GetAllInstructors();
        }

        public Instructor GetInstructorById(int id)
        {
            return _instructorRepository.GetInstructorById(id);
        }

        public void AddInstructor(Instructor instructor)
        {
            _instructorRepository.AddInstructor(instructor);
        }

        public bool UpdateInstructor(int id, Instructor instructor)
        {
            return _instructorRepository.UpdateInstructor(id, instructor);
        }

        public bool DeleteInstructor(int id)
        {
            return _instructorRepository.DeleteInstructor(id);
        }
    }
}
