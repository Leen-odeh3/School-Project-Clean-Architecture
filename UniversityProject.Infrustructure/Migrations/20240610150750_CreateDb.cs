using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Infrustructure.Migrations
{
    public partial class CreateDb : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InsManager",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_departmentManagerDepartmentID",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsManager",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "InstructorCourse",
                newName: "InstructorId");

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "StudentCourses",
                type: "int",
                nullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "InstructorId",
                table: "InstructorCourse",
                type: "int",
                nullable: true,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "InstructorCourse",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "InstructorCourse",
                type: "int",
                nullable: true);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                columns: new[] { "InstructorID", "CourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID1",
                table: "StudentCourses",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_departmentManagerDepartmentID",
                table: "Instructors",
                column: "departmentManagerDepartmentID",
                unique: true,
                filter: "[departmentManagerDepartmentID] IS NOT NULL");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_CourseID1",
                table: "InstructorCourse",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_InstructorId",
                table: "InstructorCourse",
                column: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Courses_CourseID1",
                table: "InstructorCourse",
                column: "CourseID1",
                principalTable: "Courses",
                principalColumn: "CourseID");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorId",
                table: "InstructorCourse",
                column: "InstructorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_StudentCourses_Courses_CourseID1",
                table: "StudentCourses",
                column: "CourseID1",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Courses_CourseID1",
                table: "InstructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorId",
                table: "InstructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_StudentCourses_Courses_CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_departmentManagerDepartmentID",
                table: "Instructors");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourse_CourseID1",
                table: "InstructorCourse");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourse_InstructorId",
                table: "InstructorCourse");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "InstructorCourse");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "InstructorCourse");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "InstructorCourse",
                newName: "InstructorID");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "InstructorCourse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true)
                .Annotation("Relational:ColumnOrder", 0);

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                columns: new[] { "InstructorID", "CourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_departmentManagerDepartmentID",
                table: "Instructors",
                column: "departmentManagerDepartmentID");

            migrationBuilder.CreateIndex(
                name: "IX_Departments_InsManager",
                table: "Departments",
                column: "InsManager",
                unique: true,
                filter: "[InsManager] IS NOT NULL");

            migrationBuilder.AddForeignKey(
                name: "FK_Departments_Instructors_InsManager",
                table: "Departments",
                column: "InsManager",
                principalTable: "Instructors",
                principalColumn: "InstructorId");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorId",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");
        }
    }
}
