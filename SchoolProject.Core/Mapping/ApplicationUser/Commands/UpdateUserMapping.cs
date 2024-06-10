using 
    
    
    
    
    Project.Core.Features.ApplicationUser.Commands.Models;
using UniversityProject.Data.Entities.Identity;

namespace UniversityProject.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void UpdateUserMapping()
        {
            CreateMap<EditUserCommand, User>();
        }
    }
}
