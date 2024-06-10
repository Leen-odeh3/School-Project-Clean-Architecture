
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class Course
{
    [Key]
    public int CourseID { get; set; }
    [StringLength(500)]
    public string CourseName { get; set; }
    public DateTime Period { get; set; }
    public virtual ICollection<StudentCourse> StudentsCourses { get; set; }
    public virtual ICollection<DepartmentCourse> DepartmetsSubjects { get; set; }
    public virtual ICollection<InstructorCourse> InstructorCourse { get; set; }
}
