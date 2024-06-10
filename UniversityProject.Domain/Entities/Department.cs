
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class Department
{
    [Key]
    public int DepartmentID { get; set; }

    [StringLength(500)]
    public string DeptName { get; set; }
    public int? ManagerID { get; set; }
    public virtual ICollection<Student> Students { get; set; }
    public virtual ICollection<DepartmentCourse> DepartmentCourses { get; set; }

    public virtual ICollection<Instructor> Instructors { get; set; }
    public virtual Instructor Manager { get; set; }
}