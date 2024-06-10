using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class StudentCourse
{
    [Key]
    public int Id { get; set; }
    [ForeignKey("Student")]
    public int StudentID { get; set; }

    [ForeignKey("Course")]
    public int CourseID { get; set; }
    public virtual Student Student { get; set; }
    public virtual Course Course { get; set; }
}
