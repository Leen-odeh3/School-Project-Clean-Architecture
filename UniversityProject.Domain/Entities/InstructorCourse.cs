using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class InstructorCourse
{
    [Key]  
    [ForeignKey("Instructor")]
    [Column(Order = 0)]

    public int InstructorID { get; set; }
    [Key] 
    [ForeignKey("Course")]
    [Column(Order = 1)]

    public int CourseID { get; set; }
    public Instructor? Instructor { get; set; } 
    public Course Course { get; set; }

}
