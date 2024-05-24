using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Domain.Entities;
public class DepartmentCourse
{
    [Key]
    public int DeptCourID { get; set; }  
    [ForeignKey("Department")]
    public int DepartmentID { get; set; }
    [ForeignKey("Course")]
    public int CourseID { get; set; }
    public virtual Department Department { get; set; }
    public virtual Course Course { get; set; }
}
