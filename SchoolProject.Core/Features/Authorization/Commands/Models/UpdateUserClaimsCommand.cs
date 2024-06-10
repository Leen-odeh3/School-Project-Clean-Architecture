using MediatR;
using 
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.Requests;

namespace UniversityProject.Core.Features.Authorization.Commands.Models
{
    public class UpdateUserClaimsCommand : UpdateUserClaimsRequest, IRequest<Response<string>>
    {
    }
}
