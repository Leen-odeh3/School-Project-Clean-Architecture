
using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Core.Wrappers;
using UniversityProject.Domain.Enums;

namespace UniversityProject.Core.Feature.Student.Queries.Models;
public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
{
    public int PageNumber { get; set; }
    public int PageSize { get; set; }
    public StudentOrderingEnum OrderBy { get; set; }
    public string? Search { get; set; }
}
