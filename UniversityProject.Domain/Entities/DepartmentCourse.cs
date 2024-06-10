using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Domain.Entities;
public class DepartmentCourse
{
    [Key]
    [Column(Order = 0)]
    [ForeignKey("Department")]
    public int DepartmentID { get; set; }
    [ForeignKey("Course")]
    [Column(Order = 1)]
    [Key]
    public int CourseID { get; set; }
    public virtual Department Department { get; set; }
    public virtual Course Course { get; set; }
}
