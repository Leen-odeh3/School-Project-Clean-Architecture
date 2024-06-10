using MediatR;
using 
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Authentication.Queries.Models
{
    public class AuthorizeUserQuery : IRequest<Response<string>>
    {
        public string AccessToken { get; set; }
    }
}
