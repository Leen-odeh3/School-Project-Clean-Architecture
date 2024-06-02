using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Core.Feature.Student.Queries.Results;
public class ListStudent
{
    public int StudentID { get; set; }
    public string? Name { get; set; }
    public string? DepartmentName { get; set; }
    public string? Phone { get; set; }
}
