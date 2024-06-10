using AutoMapper;

namespace 
    
    
    
    
    
    
    
    Project.Core.Mapping.Departments
{
    public partial class DepartmentProfile : Profile
    {
        public DepartmentProfile()
        {
            GetDepartmentByIdMapping();
            GetDepartmentStudentCountMapping();
            GetDepartmentStudentCountByIdMapping();
        }
    }
}
