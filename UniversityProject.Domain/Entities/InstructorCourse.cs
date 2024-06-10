using System.ComponentModel.DataAnnotations.Schema;
using System.ComponentModel.DataAnnotations;

namespace UniversityProject.Domain.Entities;
public class InstructorCourse
{
    [Key]  
    [ForeignKey("Instructor")]
    public int InstructorID { get; set; }
    [Key] 
    [ForeignKey("Course")]
    public int CourseID { get; set; }
    public Instructor? Instructor { get; set; } 
    public Course Course { get; set; }

}
