using 
    
    
    
    
    
    
    
    Project.Core.Features.Authorization.Quaries.Results;
using UniversityProject.Data.Entities.Identity;

namespace UniversityProject.Core.Mapping.Roles
{
    public partial class RoleProfile
    {
        public void GetRolesListMapping()
        {
            CreateMap<Role, GetRolesListResult>();
        }
    }
}
