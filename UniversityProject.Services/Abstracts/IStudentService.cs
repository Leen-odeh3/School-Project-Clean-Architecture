using UniversityProject.Domain.Entities;

namespace UniversityProject.Services.Abstracts;
public interface IStudentService
{
    public Task<List<Student>> GetStudentsListAsync();
}
