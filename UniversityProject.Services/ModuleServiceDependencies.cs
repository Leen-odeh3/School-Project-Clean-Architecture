using Microsoft.Extensions.DependencyInjection;
using UniversityProject.Services.Abstracts;
using UniversityProject.Services.Implementation;

namespace UniversityProject.Services;
public static class ModuleServiceDependencies
{
    public static IServiceCollection AddModuleServiceDependencies(this IServiceCollection services)
    {
        services.AddTransient<IStudentService, StudentService>();
        return services;
    }
}
