using Microsoft.Extensions.DependencyInjection;
using UniversityProject.Domain.IGenericRepository;
using UniversityProject.Infrustructure.GenericRepository;
using UniversityProject.Infrustructure.IGenericRepository;
namespace UniversityProject.Infrustructure;
public static class ModuleInfrastructureDependencies
{

    public static IServiceCollection AddInfrastructureDependencies(this IServiceCollection services)
    {
        services.AddTransient<IStudentRepository, StudentRepository>();
        services.AddTransient(typeof(IGenericRepositoryAsync<>), typeof(GenericRepositoryAsync<>));

        return services;
    }

}
