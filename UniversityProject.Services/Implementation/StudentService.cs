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

    public async Task<Student> GetByIdAsync(int id)
    {
        var student = await _repo.GetByIdAsync(id);

        return student;
    }

    public async Task<List<Student>> GetStudentsListAsync()
    {
        return await _repo.GetStudentsAsync();
    }

    async Task<string> IStudentService.AddStudentAsync(Student student)
    {
       var studentAdded = _repo.GetTableNoTracking().Where(x => x.Name.Equals(student.Name)).FirstOrDefault();

        if(studentAdded != null) return "Student Exist";

       await _repo.AddAsync(studentAdded);

        return "Succsess";
    }
}
