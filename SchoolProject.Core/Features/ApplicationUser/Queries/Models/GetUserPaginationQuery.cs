using MediatR;
using 
    
    Project.Core.Features.ApplicationUser.Queries.Results;
using UniversityProject.Core.Wrappers;

namespace UniversityProject.Core.Features.ApplicationUser.Queries.Models
{
    public class GetUserPaginationQuery : IRequest<PaginatedResult<GetUserPaginationReponse>>
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }
    }
}
