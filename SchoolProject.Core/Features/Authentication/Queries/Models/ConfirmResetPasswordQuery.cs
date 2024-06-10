using MediatR;
using 
    
    
    
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authentication.Queries.Models
{
    public class ConfirmResetPasswordQuery : IRequest<Response<string>>
    {
        public string Code { get; set; }
        public string Email { get; set; }
    }
}
