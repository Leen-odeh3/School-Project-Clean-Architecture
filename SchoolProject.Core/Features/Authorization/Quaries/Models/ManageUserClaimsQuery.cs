using MediatR;
using 
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.Results;

namespace UniversityProject.Core.Features.Authorization.Quaries.Models
{
    public class ManageUserClaimsQuery : IRequest<Response<ManageUserClaimsResult>>
    {
        public int UserId { get; set; }
    }
}
