using UniversityProject.Domain.Entities;
using UniversityProject.Domain.Enums;

namespace UniversityProject.Services.Abstracts;
public interface IStudentService
{
    public Task<List<Student>> GetStudentsListAsync();
    public Task<Student> GetByIdAsync(int id);

    public Task<String> AddStudentAsync(Student student);
    public Task<Boolean> IsNameExist(string name);
    public Task<bool> IsNameExistExcludeSelf(string name, int id);

    public Task<string> EditStudentAsync(Student student);
    public Task<string> DeleteStudentAsync(Student student);
    public IQueryable<Student> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search);

}
