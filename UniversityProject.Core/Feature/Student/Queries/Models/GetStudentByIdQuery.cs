using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Results;

namespace UniversityProject.Core.Feature.Student.Queries.Models;
public class GetStudentByIdQuery : IRequest<Response<ListStudent>>
{
    public int StudentID { get; set; }
    public GetStudentByIdQuery(int id)
    {
        StudentID = id;
    }
}
