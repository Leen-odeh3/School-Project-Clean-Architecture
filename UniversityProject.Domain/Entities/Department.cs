
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class Department
{
    [Key]
    public int DepartmentID { get; set; }
    [StringLength(500)]
    public string DeptName { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<DepartmentCourse> DepartmentCourses { get; set; }
}
