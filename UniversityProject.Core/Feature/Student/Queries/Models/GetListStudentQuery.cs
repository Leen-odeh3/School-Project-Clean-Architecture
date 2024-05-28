using MediatR;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Core.Feature.Student.Queries.Models;
public class GetListStudentQuery : IRequest<List<ListStudent>>
{
}
