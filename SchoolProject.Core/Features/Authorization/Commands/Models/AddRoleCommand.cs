using MediatR;
using 
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authorization.Commands.Models
{
    public class AddRoleCommand : IRequest<Response<string>>
    {
        public string RoleName { get; set; }
    }
}
