
using UniversityProject.Domain.Entities;

namespace UniversityProject.Domain.IGenericRepository;
public class IStudentRepository
{
    public Task<List<Student>> GetStudentsAsync;
}
