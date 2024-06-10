using MediatR;
using 
    
    
    
    
    
    Project.Core.Features.Students.Queries.Results;
using UniversityProject.Core.Wrappers;
using UniversityProject.Data.Enums;

namespace UniversityProject.Core.Features.Students.Queries.Models
{
    public class GetStudentPaginatedListQuery : IRequest<PaginatedResult<GetStudentPaginatedListResponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
        public StudentOrderingEnum OrderBy { get; set; }
        public string? Search { get; set; }
    }
}
