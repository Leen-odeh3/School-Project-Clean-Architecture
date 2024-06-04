using MediatR;
using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;
using UniversityProject.Core.Bases;
using UniversityProject.Core.Feature.Student.Queries.Results;

namespace UniversityProject.Core.Feature.Student.Command.Models;
public class AddStudentCommand: IRequest<Response<ListStudent>>
{
    public string? Name { get; set; }
    public string Address { get; set; }
    [StringLength(500)]
    public string Phone { get; set; }
    [ForeignKey("Department")]
    public int DepartmentID { get; set; }


    public AddStudentCommand(string? name, int departmentId, string? phone, string address)
    {
        Name = name;
        DepartmentID = departmentId;
        Phone = phone;
        Address = address;
    }
}
