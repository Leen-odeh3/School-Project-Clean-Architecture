using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace UniversityProject.Domain.Entities;
public class Student
{
    [Key]
    public int StudentID { get; set; }
    [StringLength(200)]
    public string Name { get; set; }
    [StringLength(500)]
    public string Address { get; set; }
    [StringLength(500)]
    public string Phone { get; set; }
    [ForeignKey("Department")]
    public int DepartmentID { get; set; }
    public virtual Department Department { get; set; }
}
