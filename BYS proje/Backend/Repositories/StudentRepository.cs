using BackendProject.Models;
using BackendProject.Data;
using System.Collections.Generic;
using System.Linq;

namespace BackendProject.Repositories
{
    public class StudentRepository
{
    private readonly StudentManagementContext _context;

    public StudentRepository(StudentManagementContext context)
    {
        _context = context;
    }

    public async Task<List<Student>> GetAllStudentsAsync()
    {
        return await _context.Students.ToListAsync();
    }

    public async Task<Student> GetStudentByIdAsync(int studentId)
    {
        return await _context.Students.FindAsync(studentId);
    }

    public async Task AddStudentAsync(Student student)
    {
        _context.Students.Add(student);
        await _context.SaveChangesAsync();
    }

    public async Task UpdateStudentAsync(Student student)
    {
        _context.Students.Update(student);
        await _context.SaveChangesAsync();
    }

    public async Task DeleteStudentAsync(int studentId)
    {
        var student = await _context.Students.FindAsync(studentId);
        if (student != null)
        {
            _context.Students.Remove(student);
            await _context.SaveChangesAsync();
        }
    }
}

}
