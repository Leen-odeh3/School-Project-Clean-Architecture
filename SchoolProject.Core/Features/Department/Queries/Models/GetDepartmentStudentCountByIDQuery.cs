using MediatR;
using 
    
    
    
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Department.Queries.Results;

namespace UniversityProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentStudentCountByIDQuery : IRequest<Response<GetDepartmentStudentCountByIDResult>>
    {
        public int DID { get; set; }
    }
}
