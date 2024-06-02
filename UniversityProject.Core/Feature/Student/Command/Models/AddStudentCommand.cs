using MediatR;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Results;

namespace UniversityProject.Core.Feature.Student.Command.Models;
public class AddStudentCommand: IRequest<Response<ListStudent>>
{
    public int StudentID { get; set; }
    public string? Name { get; set; }
    public string? DepartmentName { get; set; }
    public string? Phone { get; set; }

    public AddStudentCommand(int studentID, string? name, string? departmentName, string? phone)
    {
        StudentID = studentID;
        Name = name;
        DepartmentName = departmentName;
        Phone = phone;
    }
}
