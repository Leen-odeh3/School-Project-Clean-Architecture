using UniversityProject.Domain.Entities;

namespace UniversityProject.Core.Feature.Student.Queries.Results;
public class ListStudents
{
    public int StudentID { get; set; }
    public string Name { get; set; }
    public string Address { get; set; }
    public string Phone { get; set; }
    public int DepartmentID { get; set; }
    public virtual Department Department { get; set; }
}
