using MediatR;
using UniversityProject.Core.Bases;

namespace UniversityProject.Core.Feature.Student.Command.Models;
public class AddStudentCommand: IRequest<Response<String>>
{
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int DepartmentID { get; set; }
    public AddStudentCommand(string name, int departmentId, string phone, string address)
    {
        Name = name;
        DepartmentID = departmentId;
        Phone = phone;
        Address = address;
    }
}
