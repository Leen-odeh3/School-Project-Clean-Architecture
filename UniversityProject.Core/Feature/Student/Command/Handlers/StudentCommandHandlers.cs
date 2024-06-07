using AutoMapper;
using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Domain.Entities;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Command.Handlers;
public class StudentCommandHandlers : ResponseHandler, IRequestHandler<AddStudentCommand, Response<String>>
{

    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;

    public StudentCommandHandlers(IStudentService studentService, IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }

    public Task<Response<string>> Handle(AddStudentCommand request, CancellationToken cancellationToken)
    {

        var map = _mapper.Map(Student)<request> ;
        var result = _studentService.AddStudentAsync(map);

        if (result.Succeeded)
        {
            return result;

        }
    }

}
