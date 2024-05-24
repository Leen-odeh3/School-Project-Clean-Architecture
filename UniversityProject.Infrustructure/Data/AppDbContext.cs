﻿using Microsoft.EntityFrameworkCore;
using UniversityProject.Domain.Entities;

namespace UniversityProject.Infrustructure.Data;
public class AppDbContext : DbContext
{
    public AppDbContext() { }

    public AppDbContext(DbContextOptions<AppDbContext> option) :base(option) 
    { 
    }
    
    public DbSet<Student> Students { get; set; }
    public DbSet<Department> Departments { get; set; }
    public DbSet<Course> Courses { get; set; }
    public DbSet<StudentCourse> StudentCourses { get; set; }
    public DbSet<DepartmentCourse> DepartmentCourses { get; set; }
}
