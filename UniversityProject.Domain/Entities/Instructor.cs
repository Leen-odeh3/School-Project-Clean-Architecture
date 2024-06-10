using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;

public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InstructorID { get; set; }
    public string FirstName { get; set; }
    public string LastName { get; set; }
    public string Address { get; set; }
    public string Degree { get; set; }
    public decimal Salary { get; set; }
    public string? Image { get; set; }

    [ForeignKey("TeachingDepartment")]
    public int TeachingDepartmentID { get; set; }

    [ForeignKey("ManagingDepartment")]
    public int? ManagingDepartmentID { get; set; }

    [ForeignKey("HeadOfDepartment")]
    public int? HeadOfDepartmentID { get; set; }

    public virtual Department TeachingDepartment { get; set; }
    public virtual Department ManagingDepartment { get; set; }
    public virtual Instructor HeadOfDepartment { get; set; }

    public virtual ICollection<InstructorCourse> InstructorCourses { get; set; }
    public virtual ICollection<Department> HeadDepartments { get; set; }
}