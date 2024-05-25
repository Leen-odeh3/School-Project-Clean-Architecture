using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Domain.Entities;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handler;
public class StudentHandler : IRequestHandler<GetAllStudentQuery, List<Student>>
{
    private readonly IStudentService _studentService;
    public StudentHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }
    public Task<List<Student>> Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
    {
        return await _studentService.GetStudentsListAsync();
    }
}
