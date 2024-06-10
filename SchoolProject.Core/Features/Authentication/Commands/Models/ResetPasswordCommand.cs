using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authentication.Commands.Models
{
    public class ResetPasswordCommand : IRequest<Response<string>>
    {
        public string Email { get; set; }
        public string Password { get; set; }
        public string ConfirmPassword { get; set; }
    }
}
