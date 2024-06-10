﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using UniversityProject.Infrustructure.Data;

#nullable disable

namespace UniversityProject.Infrustructure.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20240610151827_test")]
    partial class test
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.30")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("UniversityProject.Domain.Entities.Course", b =>
                {
                    b.Property<int>("CourseID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CourseID"), 1L, 1);

                    b.Property<string>("CourseName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<DateTime>("Period")
                        .HasColumnType("datetime2");

                    b.HasKey("CourseID");

                    b.ToTable("Courses");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Department", b =>
                {
                    b.Property<int>("DepartmentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("DepartmentID"), 1L, 1);

                    b.Property<string>("DeptName")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int?>("InsManager")
                        .HasColumnType("int");

                    b.HasKey("DepartmentID");

                    b.ToTable("Departments");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.DepartmentCourse", b =>
                {
                    b.Property<int>("DepartmentID")
                        .HasColumnType("int")
                        .HasColumnOrder(0);

                    b.Property<int>("CourseID")
                        .HasColumnType("int")
                        .HasColumnOrder(1);

                    b.HasKey("DepartmentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.ToTable("DepartmentCourses");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Instructor", b =>
                {
                    b.Property<int>("InstructorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("InstructorId"), 1L, 1);

                    b.Property<string>("Address")
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Image")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Position")
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal?>("Salary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("SupervisorId")
                        .HasColumnType("int");

                    b.Property<int?>("departmentManagerDepartmentID")
                        .HasColumnType("int");

                    b.HasKey("InstructorId");

                    b.HasIndex("DepartmentID");

                    b.HasIndex("SupervisorId");

                    b.HasIndex("departmentManagerDepartmentID")
                        .IsUnique()
                        .HasFilter("[departmentManagerDepartmentID] IS NOT NULL");

                    b.ToTable("Instructors");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.InstructorCourse", b =>
                {
                    b.Property<int>("InstructorID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("CourseID1")
                        .HasColumnType("int");

                    b.Property<int?>("InstructorId")
                        .HasColumnType("int");

                    b.HasKey("InstructorID", "CourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("CourseID1");

                    b.HasIndex("InstructorId");

                    b.ToTable("InstructorCourse");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Student", b =>
                {
                    b.Property<int>("StudentID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("StudentID"), 1L, 1);

                    b.Property<string>("Address")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.Property<int>("DepartmentID")
                        .HasColumnType("int");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(200)
                        .HasColumnType("nvarchar(200)");

                    b.Property<string>("Phone")
                        .IsRequired()
                        .HasMaxLength(500)
                        .HasColumnType("nvarchar(500)");

                    b.HasKey("StudentID");

                    b.HasIndex("DepartmentID");

                    b.ToTable("Students");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.StudentCourse", b =>
                {
                    b.Property<int>("StudentID")
                        .HasColumnType("int");

                    b.Property<int>("CourseID")
                        .HasColumnType("int");

                    b.Property<int?>("CourseID1")
                        .HasColumnType("int");

                    b.HasKey("StudentID", "CourseID");

                    b.HasIndex("CourseID");

                    b.HasIndex("CourseID1");

                    b.ToTable("StudentCourses");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.DepartmentCourse", b =>
                {
                    b.HasOne("UniversityProject.Domain.Entities.Course", "Course")
                        .WithMany("DepartmetsSubjects")
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityProject.Domain.Entities.Department", "Department")
                        .WithMany("DepartmentCourses")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Instructor", b =>
                {
                    b.HasOne("UniversityProject.Domain.Entities.Department", "department")
                        .WithMany("Instructors")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityProject.Domain.Entities.Instructor", "Supervisor")
                        .WithMany("Instructors")
                        .HasForeignKey("SupervisorId");

                    b.HasOne("UniversityProject.Domain.Entities.Department", "departmentManager")
                        .WithOne("Instructor")
                        .HasForeignKey("UniversityProject.Domain.Entities.Instructor", "departmentManagerDepartmentID");

                    b.Navigation("Supervisor");

                    b.Navigation("department");

                    b.Navigation("departmentManager");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.InstructorCourse", b =>
                {
                    b.HasOne("UniversityProject.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityProject.Domain.Entities.Course", null)
                        .WithMany("InstructorCourse")
                        .HasForeignKey("CourseID1");

                    b.HasOne("UniversityProject.Domain.Entities.Instructor", "Instructor")
                        .WithMany()
                        .HasForeignKey("InstructorID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityProject.Domain.Entities.Instructor", null)
                        .WithMany("InstructorCourse")
                        .HasForeignKey("InstructorId");

                    b.Navigation("Course");

                    b.Navigation("Instructor");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Student", b =>
                {
                    b.HasOne("UniversityProject.Domain.Entities.Department", "Department")
                        .WithMany("Students")
                        .HasForeignKey("DepartmentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Department");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.StudentCourse", b =>
                {
                    b.HasOne("UniversityProject.Domain.Entities.Course", "Course")
                        .WithMany()
                        .HasForeignKey("CourseID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("UniversityProject.Domain.Entities.Course", null)
                        .WithMany("StudentsCourses")
                        .HasForeignKey("CourseID1");

                    b.HasOne("UniversityProject.Domain.Entities.Student", "Student")
                        .WithMany()
                        .HasForeignKey("StudentID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Course");

                    b.Navigation("Student");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Course", b =>
                {
                    b.Navigation("DepartmetsSubjects");

                    b.Navigation("InstructorCourse");

                    b.Navigation("StudentsCourses");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Department", b =>
                {
                    b.Navigation("DepartmentCourses");

                    b.Navigation("Instructor")
                        .IsRequired();

                    b.Navigation("Instructors");

                    b.Navigation("Students");
                });

            modelBuilder.Entity("UniversityProject.Domain.Entities.Instructor", b =>
                {
                    b.Navigation("InstructorCourse");

                    b.Navigation("Instructors");
                });
#pragma warning restore 612, 618
        }
    }
}
