using AutoMapper;
using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handlers;
public class GetStudentHandler : IRequestHandler<GetListStudentQuery, List<ListStudent>>
{
    private readonly IStudentService _studentService;
    private readonly IMapper _mapper;
    public GetStudentHandler(IStudentService studentService , IMapper mapper)
    {
        _studentService = studentService;
        _mapper = mapper;
    }
    public async Task<List<ListStudent>> Handle(GetListStudentQuery request, CancellationToken cancellationToken)
    {
        var students = await _studentService.GetStudentsListAsync();
 
        var res = _mapper.Map<List<ListStudent>>(students);

        return res;
    }

}
