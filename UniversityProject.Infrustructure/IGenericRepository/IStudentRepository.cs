
using UniversityProject.Domain.Entities;
using UniversityProject.Infrustructure.IGenericRepository;

namespace UniversityProject.Domain.IGenericRepository;
public interface IStudentRepository : IGenericRepositoryAsync<Student>
{
    Task<Student> GetByIdAsync(int id);
    public Task<List<Student>> GetStudentsAsync();
}
