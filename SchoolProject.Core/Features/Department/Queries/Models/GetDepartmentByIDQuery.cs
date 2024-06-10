using MediatR;
using 
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Department.Queries.Results;

namespace UniversityProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentByIDQuery : IRequest<Response<GetDepartmentByIDResponse>>
    {
        public int Id { get; set; }
        public int StudentPageNumber { get; set; }
        public int StudentPageSize { get; set; }
    }
}
