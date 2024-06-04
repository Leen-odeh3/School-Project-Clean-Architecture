using UniversityProject.Domain.Entities;

namespace UniversityProject.Services.Abstracts;
public interface IStudentService
{
    public Task<List<Student>> GetStudentsListAsync();
    public Task<Student> GetByIdAsync(int id);

    public Task<Student> AddStudentAsync(Student student);
}
