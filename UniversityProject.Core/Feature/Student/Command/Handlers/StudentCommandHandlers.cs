using AutoMapper;
using UniversityProject.Domain.Entities;
using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Command.Handlers;
public class StudentCommandHandlers : ResponseHandler, 
                                      IRequestHandler<AddStudentCommand, Response<String>>,
                                      IRequestHandler<EditStudentCommand,Response<String>>,
                                      IRequestHandler<DeleteStudentCommand,Response<String>>
{

    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public StudentCommandHandlers(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }

    public async Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {
        var newStudentEntity = _mapper.Map<UniversityProject.Domain.Entities.Student>(request);

        var result = await _studentService.AddStudentAsync(newStudentEntity);

        var response = result != null ? Success("Student added successfully.") : BadRequest<string>("Failed to add student.");

        return response;
    }

    public async Task<Response<string>> Handle(EditStudentCommand request, CancellationToken cancellationToken)
    {
        var student = await _studentService.GetByIdAsync(request.StudentID);

        if (student is null) return NotFound<string>();

        var studentmapper = _mapper.Map(request, student);

        var result = await _studentService.EditStudentAsync(studentmapper);
 
        if (result is "Success") return Success("edit student success");
        else return BadRequest<string>();
    }

    public async Task<Response<string>> Handle(DeleteStudentCommand request, CancellationToken cancellationToken)
    {
        var student = await _studentService.GetByIdAsync(request.Id);
        if (student is null) return NotFound<string>();

        var result = await _studentService.DeleteStudentAsync(student);
        if (result == "Success") return Deleted<string>();
        else return BadRequest<string>();
    }
}
