using AutoMapper;
using UniversityProject.Domain.Entities;
using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Command.Handlers;
public class StudentCommandHandlers : ResponseHandler, 
                                      IRequestHandler<AddStudentCommand, Response<String>>
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


}
