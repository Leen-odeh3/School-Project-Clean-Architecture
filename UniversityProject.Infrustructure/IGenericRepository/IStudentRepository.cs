
using UniversityProject.Domain.Entities;
using UniversityProject.Infrustructure.IGenericRepository;

namespace UniversityProject.Domain.IGenericRepository;
public interface IStudentRepository : IGenericRepositoryAsync<Student>
{
    public Task<List<Student>> GetStudentsAsync();
}
