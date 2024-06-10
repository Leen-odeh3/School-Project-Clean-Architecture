using MediatR;
using 
    
    
    
    Project.Core.Bases;
using UniversityProject.Core.Features.Department.Queries.Results;

namespace UniversityProject.Core.Features.Department.Queries.Models
{
    public class GetDepartmentStudentListCountQuery : IRequest<Response<List<GetDepartmentStudentListCountResults>>>
    {

    }
}
