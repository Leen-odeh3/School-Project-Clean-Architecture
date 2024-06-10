using 
    
    
    Project.Core.Features.ApplicationUser.Queries.Results;
using UniversityProject.Data.Entities.Identity;

namespace UniversityProject.Core.Mapping.ApplicationUser
{
    public partial class ApplicationUserProfile
    {
        public void GetUserPaginationMapping()
        {
            CreateMap<User, GetUserPaginationReponse>();

        }
    }
}