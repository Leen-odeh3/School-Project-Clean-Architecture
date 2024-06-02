using UniversityProject.Domain.Entities;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Services.Implementation;
public class StudentService : IStudentService
{
    private IStudentRepository _repo;
    public StudentService(IStudentRepository repo)
    {
        _repo = repo;
    }

    public async Task<Student> AddStudentAsync(Student student)
    {
      var stu = _repo.AddAsync(student);
        return await stu;
    }

    public async Task<Student> GetByIdAsync(int id)
    {
        var student = await _repo.GetByIdAsync(id);

        return student;
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _repo.GetStudentsAsync();
    }
}
