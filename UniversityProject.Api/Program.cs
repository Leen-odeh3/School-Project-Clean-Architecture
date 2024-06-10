using Microsoft.AspNetCore.Localization;
using Microsoft.EntityFrameworkCore;
using System.Globalization;
using UniversityProject.Core;
using UniversityProject.Core.MiddleWare;
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
            .AddModuleServiceDependencies().AddCoreDependencies();

        #region AllowCORS
        var CORS = "_cors";
        builder.Services.AddCors(options =>
        {
            options.AddPolicy(name: CORS,
                              policy =>
                              {
                                  policy.AllowAnyHeader();
                                  policy.AllowAnyMethod();
                                  policy.AllowAnyOrigin();
                              });
        });

        #endregion

        var app = builder.Build();

        if (app.Environment.IsDevelopment())
        {
            app.UseSwagger();
            app.UseSwaggerUI();
        }

        app.UseHttpsRedirection();

        app.UseAuthorization();
        app.MapControllers();

        app.UseMiddleware<ErrorHandlerMiddleware>();

        app.Run();
    }
}
