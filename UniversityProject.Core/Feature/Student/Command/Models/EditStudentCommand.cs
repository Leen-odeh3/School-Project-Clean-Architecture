using MediatR;
using UniversityProject.Core.Bases;

namespace UniversityProject.Core.Feature.Student.Command.Models;

public class EditStudentCommand :IRequest<Response<String>>
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int DepartmentID { get; set; }

}
