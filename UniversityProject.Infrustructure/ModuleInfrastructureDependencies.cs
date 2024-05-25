using Microsoft.Extensions.DependencyInjection;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Infrustructure.GenericRepository;
namespace UniversityProject.Infrustructure;
public static class ModuleInfrastructureDependencies
{

    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient<IStudentRepository, StudentRepository>();
        return services;
    }

}
