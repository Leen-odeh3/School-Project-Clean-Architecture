using MediatR;
using 
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Data.Results;

namespace UniversityProject.Core.Features.Authentication.Commands.Models
{
    public class RefreshTokenCommand : IRequest<Response<JwtAuthResult>>
    {
        public string AccessToken { get; set; }
        public string RefreshToken { get; set; }
    }
}
