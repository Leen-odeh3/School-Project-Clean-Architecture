using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handler;
public class StudentHandler : IRequestHandler<GetAllStudentQuery, List<ListStudents>>
{
    private readonly IStudentService _studentService;
    public StudentHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }
    Task<List<ListStudents>> IRequestHandler<GetAllStudentQuery, List<ListStudents>>.Handle(GetAllStudentQuery request, CancellationToken cancellationToken)
    {
       return _studentService.GetStudentsListAsync();
    }
}
