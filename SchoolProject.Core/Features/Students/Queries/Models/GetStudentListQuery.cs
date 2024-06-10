using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Students.Queries.Results;

namespace UniversityProject.Core.Features.Students.Queries.Models
{
    public class GetStudentListQuery : IRequest<Response<List<GetStudentListResponse>>>
    {
    }
}
