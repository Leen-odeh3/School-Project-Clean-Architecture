
using UniversityProject.Domain.Entities;

namespace UniversityProject.Domain.IGenericRepository;
public interface IStudentRepository
{
    public Task<List<Student>> GetStudentsAsync();
}
