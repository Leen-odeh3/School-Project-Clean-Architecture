using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Authorization.Quaries.Results;

namespace UniversityProject.Core.Features.Authorization.Quaries.Models
{
    public class GetRolesListQuery : IRequest<Response<List<GetRolesListResult>>>
    {
    }
}
