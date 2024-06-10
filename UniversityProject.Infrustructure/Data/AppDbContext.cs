using Microsoft.EntityFrameworkCore;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Infrustructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> option) :base(option) 
    { 
    }
    protected override void OnModelCreating(ModelBuilder modelBuilder)
    {
        modelBuilder.Entity<DepartmentCourse>().HasKey(dc => new { dc.DepartmentID, dc.CourseID });
        modelBuilder.Entity<InstructorCourse>().HasKey(ic => new { ic.InstructorID, ic.CourseID });
        modelBuilder.Entity<StudentCourse>().HasKey(sc => new { sc.StudentID, sc.CourseID });

        modelBuilder.Entity<Department>()
                    .HasMany(d => d.Instructors)
                    .WithOne(i => i.department)
                    .HasForeignKey(i => i.DepartmentID)
                    .IsRequired(false);

        modelBuilder.Entity<Department>()
                    .HasOne(d => d.Instructor)
                    .WithOne()
                    .HasForeignKey<Department>(d => d.InsManager)
                    .IsRequired(false);

        base.OnModelCreating(modelBuilder);
    }

    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<DepartmentCourse> DepartmentCourses { get; set; }
    public DbSet<Instructor> Instructors { get; set; }
    public DbSet<InstructorCourse> InstructorCourse { get; set; }
}
