using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Core.Mapping.Students;

public partial class StudentProfile
{
    public void addStudentMapping()
    {
        CreateMap<AddStudentCommand, Student>()
            .ForMember(x => x.DepartmentID, opt => opt.MapFrom(xx => xx.DepartmentID));

    }
}
