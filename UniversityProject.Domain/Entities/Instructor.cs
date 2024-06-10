using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;

public class Instructor
{
    [Key]
    [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
    public int InstructorId { get; set; }
    public string? Name { get; set; }
    public string? Address { get; set; }
    public string? Position { get; set; }
    public int? SupervisorId { get; set; }
    public decimal? Salary { get; set; }
    public string? Image { get; set; }
    public int DepartmentID { get; set; }

    [ForeignKey(nameof(DepartmentID))]
    [InverseProperty("Instructors")]
    public Department? department { get; set; }

    [InverseProperty("Instructor")]
    public Department? departmentManager { get; set; }


    [ForeignKey(nameof(SupervisorId))]
    [InverseProperty("Instructors")]
    public Instructor? Supervisor { get; set; }
    [InverseProperty("Supervisor")]
    public virtual ICollection<Instructor> Instructors { get; set; }

    [InverseProperty("instructor")]
    public virtual ICollection<InstructorCourse> InstructorCourse { get; set; }
}