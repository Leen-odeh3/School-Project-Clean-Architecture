using AutoMapper;

namespace 
    
    
    
    
    
    
    Project.Core.Mapping.Students
{
    public partial class StudentProfile : Profile
    {
        public StudentProfile()
        {
            GetStudentListMapping();
            GetStudentByIDMapping();
            AddStudentCommandMapping();
            EditStudentCommandMapping();
            GetStudentPaginationMapping();
        }
    }
}
