using MediatR;
using 
    
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Students.Queries.Results;

namespace UniversityProject.Core.Features.Students.Queries.Models
{
    public class GetStudentByIDQuery : IRequest<Response<GetSingleStudentResponse>>
    {
        public int Id { get; set; }
        public GetStudentByIDQuery(int id)
        {
            Id=id;
        }
    }
}
