using Microsoft.EntityFrameworkCore;
using Serilog;
using UniversityProject.Domain.Entities;
using UniversityProject.Domain.Enums;
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

    public async Task<bool> IsNameExistExcludeSelf(string name, int id)
    {
        var student = await _repo.GetTableNoTracking().Where(x => x.Name.Equals(name) & !x.StudentID.Equals(id)).FirstOrDefaultAsync();
        if (student == null) return false;
        return true;
    }

    public async Task<string> EditStudentAsync(Student student)
    {
        await _repo.UpdateAsync(student);
        return "Success";
    }

    public async Task<string> DeleteStudentAsync(Student student)
    {
        var trans = _repo.BeginTransaction();
        try
        {
            await _repo.DeleteAsync(student);
            await trans.CommitAsync();
            return "Success";
        }
        catch (Exception ex)
        {
            await trans.RollbackAsync();
            Log.Error(ex.Message);
            return "Falied";
        }
    }

    public IQueryable<Student> FilterStudentPaginatedQuerable(StudentOrderingEnum orderingEnum, string search)
    {
        var querable = _repo.GetTableNoTracking().Include(xx=>xx.Department).AsQueryable();
        if (search != null)
        {
            querable = querable.Where(x => x.Name.Contains(search) || x.Address.Contains(search));
        }
        switch (orderingEnum)
        {
            case StudentOrderingEnum.StudentID:
                querable = querable.OrderBy(x => x.StudentID);
                break;
            case StudentOrderingEnum.Name:
                querable = querable.OrderBy(x => x.Name);
                break;
            case StudentOrderingEnum.Address:
                querable = querable.OrderBy(x => x.Address);
                break;
            case StudentOrderingEnum.DepartmentID:
                querable = querable.OrderBy(x => x.Department.DepartmentID);
                break;
        }

        return querable;
    }
}
