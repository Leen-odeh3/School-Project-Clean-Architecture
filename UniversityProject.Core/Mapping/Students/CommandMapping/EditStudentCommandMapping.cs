using UniversityProject.Core.Feature.Student.Command.Models;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Core.Mapping.Students;
public partial class StudentProfile
    {
        public void EditStudentCommandMapping()
        {
            CreateMap<EditStudentCommand, Student>()
               .ForMember(dest => dest.DepartmentID, opt => opt.MapFrom(src => src.DepartmentID))
               .ForMember(dest => dest.Name, opt => opt.MapFrom(src => src.Name))
               .ForMember(dest => dest.Address, opt => opt.MapFrom(src => src.Address))
               .ForMember(dest => dest.StudentID, opt => opt.MapFrom(src => src.StudentID))
               .ForMember(dest => dest.Phone, opt => opt.MapFrom(src => src.Phone));
        }
    }

