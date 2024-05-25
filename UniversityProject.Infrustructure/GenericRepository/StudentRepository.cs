using Microsoft.EntityFrameworkCore;
using UniversityProject.Domain.Entities;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Infrustructure.Data;

namespace UniversityProject.Infrustructure.GenericRepository;
public class StudentRepository:IStudentRepository
{
    private readonly AppDbContext _context;
    public StudentRepository(AppDbContext context)
    {
       _context= context;
    }
    public async Task<List<Student>> GetStudentsAsync()
    {
       return await _context.Students.ToListAsync();

    }
}
