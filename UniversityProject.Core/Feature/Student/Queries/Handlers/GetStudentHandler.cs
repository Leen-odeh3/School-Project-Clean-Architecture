using AutoMapper;
using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Core.Wrappers;
using UniversityProject.Services.Abstracts;

namespace UniversityProject.Core.Feature.Student.Queries.Handlers;
public class GetStudentHandler : ResponseHandler ,
                                 IRequestHandler<GetListStudentQuery, Response<List<ListStudent>>>,
                                 IRequestHandler<GetStudentByIdQuery , Response<ListStudent>>,
                                 IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>

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
        
        var result = Success(studentListMapper);

        return result;
    }

    public Task<Response<GetStudentPaginatedListQuery>> Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
    {
        throw new NotImplementedException();
    }

    async Task<Response<ListStudent>> IRequestHandler<GetStudentByIdQuery, Response<ListStudent>>.Handle(GetStudentByIdQuery request, CancellationToken cancellationToken)
    {
        var studentList = await _studentService.GetByIdAsync(request.StudentID);

        var studentListMapper = _mapper.Map<ListStudent>(studentList);

        var result = Success(studentListMapper);

        return result;
    }

    async Task<PaginatedResult<GetStudentPaginatedListResponse>> IRequestHandler<GetStudentPaginatedListQuery, PaginatedResult<GetStudentPaginatedListResponse>>.Handle(GetStudentPaginatedListQuery request, CancellationToken cancellationToken)
    {
        var FilterQuery = _studentService.FilterStudentPaginatedQuerable(request.OrderBy, request.Search);
        var PaginatedList = await _mapper.ProjectTo<GetStudentPaginatedListResponse>(FilterQuery).ToPaginatedListAsync(request.PageNumber, request.PageSize);
        PaginatedList.Meta = new { Count = PaginatedList.Data.Count() };

        return PaginatedList;
    }
}
