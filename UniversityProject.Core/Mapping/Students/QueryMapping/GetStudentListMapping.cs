using UniversityProject.Core.Feature.Student.Queries.Results;
using UniversityProject.Domain.Entities;
namespace UniversityProject.Core.Mapping.Students;

public partial class StudentProfile
{
    public void GetStudentListMapping()
    {
        CreateMap<Student, ListStudent>()
            .ForMember(x => x.DepartmentName, opt => opt.MapFrom(xx => xx.Department.DeptName));

    }
}
