using AutoMapper;
using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handlers;
public class GetStudentHandler : IRequestHandler<GetListStudentQuery, Response<List<ListStudent>>>
{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;
    public GetStudentHandler(IStudentService studentService , IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }
    public async Task<Response<List<ListStudent>>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
    {
        var studentList = await _studentService.GetStudentsListAsync();
        var studentListMapper = _mapper.Map<List<ListStudent>>(studentList);
        var responseHandler = new ResponseHandler();
        var result = responseHandler.Success(studentListMapper);
        return result;
    }
}
