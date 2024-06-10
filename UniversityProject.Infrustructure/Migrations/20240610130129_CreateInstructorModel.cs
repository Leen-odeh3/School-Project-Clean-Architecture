using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Infrustructure.Migrations
{
    public partial class CreateInstructorModel : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_StudentID",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentCourses_DepartmentID",
                table: "DepartmentCourses");

            migrationBuilder.DropColumn(
                name: "StudCourID",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "DeptCourID",
                table: "DepartmentCourses");

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "ManagerID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .Annotation("Relational:ColumnOrder", 1);

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                columns: new[] { "StudentID", "CourseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                columns: new[] { "DepartmentID", "CourseID" });

            migrationBuilder.CreateTable(
                name: "Instructors",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Address = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Degree = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    Salary = table.Column<decimal>(type: "decimal(18,2)", nullable: false),
                    Image = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    TeachingDepartmentID = table.Column<int>(type: "int", nullable: false),
                    ManagingDepartmentID = table.Column<int>(type: "int", nullable: true),
                    HeadOfDepartmentID = table.Column<int>(type: "int", nullable: true),
                    ManagingDepartmentDepartmentID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Instructors", x => x.InstructorID);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_ManagingDepartmentDepartmentID",
                        column: x => x.ManagingDepartmentDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Instructors_Departments_ManagingDepartmentID",
                        column: x => x.ManagingDepartmentID,
                        principalTable: "Departments",
                        principalColumn: "DepartmentID");
                    table.ForeignKey(
                        name: "FK_Instructors_Instructors_HeadOfDepartmentID",
                        column: x => x.HeadOfDepartmentID,
                        principalTable: "Instructors",
                        principalColumn: "InstructorID");
                });

            migrationBuilder.CreateTable(
                name: "InstructorCourse",
                columns: table => new
                {
                    InstructorID = table.Column<int>(type: "int", nullable: false),
                    CourseID = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_InstructorCourse", x => new { x.InstructorID, x.CourseID });
                    table.ForeignKey(
                        name: "FK_InstructorCourse_Courses_CourseID",
                        column: x => x.CourseID,
                        principalTable: "Courses",
                        principalColumn: "CourseID",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_InstructorCourse_Instructors_InstructorID",
                        column: x => x.InstructorID,
                        principalTable: "Instructors",
                        principalColumn: "InstructorID",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InstructorID",
                table: "Departments",
                column: "InstructorID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments",
                column: "ManagerID",
                unique: true,
                filter: "[ManagerID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_CourseID",
                table: "InstructorCourse",
                column: "CourseID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_HeadOfDepartmentID",
                table: "Instructors",
                column: "HeadOfDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ManagingDepartmentDepartmentID",
                table: "Instructors",
                column: "ManagingDepartmentDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ManagingDepartmentID",
                table: "Instructors",
                column: "ManagingDepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InstructorID",
                table: "Departments",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorID");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments",
                column: "ManagerID",
                principalTable: "Instructors",
                principalColumn: "InstructorID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments");

            migrationBuilder.DropTable(
                name: "InstructorCourse");

            migrationBuilder.DropTable(
                name: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "ManagerID",
                table: "Departments");

            migrationBuilder.AddColumn<int>(
                name: "StudCourID",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "CourseID",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 1);

            migrationBuilder.AlterColumn<int>(
                name: "DepartmentID",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "DeptCourID",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                column: "StudCourID");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                column: "DeptCourID");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentID",
                table: "StudentCourses",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_DepartmentID",
                table: "DepartmentCourses",
                column: "DepartmentID");
        }
    }
}
