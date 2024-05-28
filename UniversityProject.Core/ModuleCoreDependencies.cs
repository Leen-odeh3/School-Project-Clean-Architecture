using Microsoft.Extensions.DependencyInjection;
using System.Reflection;
using MediatR;

namespace UniversityProject.Core;

public static class ModuleCoreDependencies
{
    public static IServiceCollection AddCoreDependencies(this IServiceCollection services)
    {
        services.AddMediatR(Assembly.GetExecutingAssembly());

        return services;
    }

}