
using MediatR;
using 
    
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.Results;

namespace UniversityProject.Core.Features.Authentication.Commands.Models
{
    public class SignInCommand : IRequest<Response<JwtAuthResult>>
    {
        public string UserName { get; set; }
        public string Password { get; set; }
    }
}
