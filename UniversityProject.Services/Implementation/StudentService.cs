using UniversityProject.Domain.Entities;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Infrustructure.GenericRepository;
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
        var existingStudent = _repo.GetTableNoTracking().Where(x => x.Name.Equals(student.Name)).FirstOrDefault();

        if (existingStudent != null)
            return "Student Exist";

        await _repo.AddAsync(student);

        return "Success";
    }

    public async Task<bool> IsNameExist(string name)
    {
        var student = _repo.GetTableNoTracking().Where(x => x.Name.Equals(name)).FirstOrDefault();
        if (student is null) return false;
        return true;
    }

}
