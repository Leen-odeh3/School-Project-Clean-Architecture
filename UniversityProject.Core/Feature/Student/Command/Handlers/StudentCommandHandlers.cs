using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Command.Handlers;
public class StudentCommandHandlers : ResponseHandler, IRequestHandler<AddStudentCommand, Response<ListStudent>>
{

    private readonly IStudentService _studentService;

    public StudentCommandHandlers(IStudentService studentService)
    {
        _studentService = studentService;
    }
    async Task<Response<ListStudent>> IRequestHandler<AddStudentCommand, Response<ListStudent>>.Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var addedStudent = await _studentService.AddStudentAsync(request.StudentID, request.Name, request.DepartmentName, request.Phone);

        // Create a response with the added student
        var response = new Response<ListStudent>(addedStudent);

        // Return the response
        return response;
    }
}
