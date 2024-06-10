using MediatR;
using 
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authentication.Commands.Models
{
    public class SendResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
    }
}
