using 
    
    
    
    
    
    
    
    Project.Core.Features.Students.Queries.Results;
using UniversityProject.Data.Entities;

namespace UniversityProject.Core.Mapping.Students
{
    public partial class StudentProfile
    {
        public void GetStudentByIDMapping()
        {
            CreateMap<Student, GetSingleStudentResponse>()
               .ForMember(dest => dest.DepartmentName, opt => opt.MapFrom(src => src.Department.Localize(src.Department.DNameAr, src.Department.DNameEn)))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Localize(src.NameAr, src.NameEn)));
        }
    }
}
