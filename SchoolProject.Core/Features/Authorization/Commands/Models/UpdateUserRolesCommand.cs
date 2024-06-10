using MediatR;
using 
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.DTOs;

namespace UniversityProject.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserRolesCommand : UpdateUserRolesRequest, IRequest<Response<string>>
    {
    }
}
