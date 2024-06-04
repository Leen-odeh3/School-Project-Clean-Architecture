

using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Core.Mapping.Students;

public partial class StudentProfile
{
    public void addStudentMapping()
    {
        CreateMap<Student, AddStudentCommand>()
            .ForMember(x => x.DepartmentID, opt => opt.MapFrom(xx => xx.Department.DeptName));

    }
}
