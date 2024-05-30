using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Results;

namespace UniversityProject.Core.Feature.Student.Queries.Models;
public class GetListStudentQuery : IRequest<Response<List<ListStudent>>>
{
}
