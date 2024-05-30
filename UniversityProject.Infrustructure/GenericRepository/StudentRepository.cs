using Microsoft.EntityFrameworkCore;
using UniversityProject.Domain.Entities;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Infrustructure.Data;

namespace UniversityProject.Infrustructure.GenericRepository;
public class StudentRepository: GenericRepositoryAsync<Student> , IStudentRepository 
{
    private readonly DbSet<Student> _context;
    public StudentRepository(AppDbContext context) :base(context)
    {
       _context= context.Set<Student>();
    }
    public async Task<List<Student>> GetStudentsAsync()
    {
       return await _context.Include(x=>x.Department).ToListAsync();

    }
}
