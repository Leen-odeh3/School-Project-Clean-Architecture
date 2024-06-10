using MediatR;
using 
    
    
    
    
    
    Project.Core.Bases;

namespace UniversityProject.Core.Features.Students.Commands.Models
{
    public class DeleteStudentCommand : IRequest<Response<string>>
    {
        public int Id { get; set; }
        public DeleteStudentCommand(int id)
        {
            Id=id;
        }
    }
}
