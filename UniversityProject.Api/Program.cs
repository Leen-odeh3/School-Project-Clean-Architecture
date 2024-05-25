using Microsoft.EntityFrameworkCore;
using UniversityProject.Infrustructure;
using UniversityProject.Infrustructure.Data;
using UniversityProject.Services;

namespace UniversityProject.Api;
public class Program
{
    public static void Main(string[] args)
    {
        var builder = WebApplication.CreateBuilder(args);


        builder.Services.AddControllers();

        builder.Services.AddEndpointsApiExplorer();
        builder.Services.AddSwaggerGen();

        builder.Services.AddDbContext<AppDbContext>(option =>
        option.UseSqlServer( builder.Configuration.GetConnectionString("Default")));

        builder.Services.AddInfrastructureDependencies()
            .AddModuleServiceDependencies();

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();


        app.MapControllers();

        app.Run();
    }
}
