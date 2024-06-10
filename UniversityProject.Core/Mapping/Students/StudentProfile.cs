using AutoMapper;

namespace UniversityProject.Core.Mapping.Students;
public partial class StudentProfile : Profile
{
    public StudentProfile()
    {
        GetStudentListMapping();
        GetStudentByIdMapping();
        addStudentMapping();
        EditStudentCommandMapping();
        CreateMap<UniversityProject.Domain.Entities.Student, UniversityProject.Core.Feature.Student.Queries.Results.GetStudentPaginatedListResponse>();

    }

}