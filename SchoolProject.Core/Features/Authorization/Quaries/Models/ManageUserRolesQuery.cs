using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.Results;

namespace UniversityProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserRolesQuery : IRequest<Response<ManageUserRolesResult>>
    {
        public int UserId { get; set; }
    }
}
