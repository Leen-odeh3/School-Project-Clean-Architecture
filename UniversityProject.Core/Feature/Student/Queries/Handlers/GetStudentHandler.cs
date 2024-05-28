using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handlers;
public class GetStudentHandler : IRequestHandler<GetListStudentQuery, List<ListStudent>>
{
    private readonly IStudentService _studentService;

    public GetStudentHandler(IStudentService studentService)
    {
        _studentService = studentService;
    }
    public async Task<List<ListStudent>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
    {
        var students = await _studentService.GetStudentsListAsync();
        var result = students.Select(student => new ListStudent
        {
        }).ToList();

        return result;
    }

}
