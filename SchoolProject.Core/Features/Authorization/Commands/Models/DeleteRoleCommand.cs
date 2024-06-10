using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authorization.Commands.Models
{
    public class DeleteRoleCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteRoleCommand(int id)
        {
            Id = id;
        }
    }
}
