using MediatR;
using UniversityProject.Core.Bases;

namespace UniversityProject.Core.Feature.Student.Command.Models;
public class DeleteStudentCommand : IRequest<Response<string>>
{
    public int Id { get; set; }
    public DeleteStudentCommand(int id)
    {
        Id = id;
    }
}