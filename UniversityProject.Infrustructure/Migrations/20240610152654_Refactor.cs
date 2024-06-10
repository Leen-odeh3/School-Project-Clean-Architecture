using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Infrustructure.Migrations
{
    public partial class Refactor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
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
                name: "FK_StudentCourses_Courses_CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropIndex(
                name: "IX_InstructorCourse_CourseID1",
                table: "InstructorCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "CourseID1",
                table: "InstructorCourse");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructors",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "InstructorCourse",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "InstructorCourse",
                newName: "Id");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorCourse_InstructorId",
                table: "InstructorCourse",
                newName: "IX_InstructorCourse_InstructorID");

            migrationBuilder.AddColumn<int>(
                name: "Id",
                table: "StudentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "InstructorCourse",
                type: "int",
                nullable: false,
                defaultValue: 0,
                oldClrType: typeof(int),
                oldType: "int",
                oldNullable: true);

            migrationBuilder.AlterColumn<int>(
                name: "Id",
                table: "InstructorCourse",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
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
                name: "Id",
                table: "DepartmentCourses",
                type: "int",
                nullable: false,
                defaultValue: 0)
                .Annotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_StudentID",
                table: "StudentCourses",
                column: "StudentID");

            migrationBuilder.CreateIndex(
                name: "IX_DepartmentCourses_DepartmentID",
                table: "DepartmentCourses",
                column: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse",
                column: "InstructorID",
                principalTable: "Instructors",
                principalColumn: "InstructorID",
                onDelete: ReferentialAction.Cascade);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_InstructorCourse_Instructors_InstructorID",
                table: "InstructorCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudentCourses",
                table: "StudentCourses");

            migrationBuilder.DropIndex(
                name: "IX_StudentCourses_StudentID",
                table: "StudentCourses");

            migrationBuilder.DropPrimaryKey(
                name: "PK_InstructorCourse",
                table: "InstructorCourse");

            migrationBuilder.DropPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses");

            migrationBuilder.DropIndex(
                name: "IX_DepartmentCourses_DepartmentID",
                table: "DepartmentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "StudentCourses");

            migrationBuilder.DropColumn(
                name: "Id",
                table: "DepartmentCourses");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "Instructors",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "InstructorCourse",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "Id",
                table: "InstructorCourse",
                newName: "InstructorID");

            migrationBuilder.RenameIndex(
                name: "IX_InstructorCourse_InstructorID",
                table: "InstructorCourse",
                newName: "IX_InstructorCourse_InstructorId");

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
                oldType: "int");

            migrationBuilder.AlterColumn<int>(
                name: "InstructorID",
                table: "InstructorCourse",
                type: "int",
                nullable: false,
                oldClrType: typeof(int),
                oldType: "int")
                .OldAnnotation("SqlServer:Identity", "1, 1");

            migrationBuilder.AddColumn<int>(
                name: "CourseID1",
                table: "InstructorCourse",
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
                name: "PK_InstructorCourse",
                table: "InstructorCourse",
                columns: new[] { "InstructorID", "CourseID" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_DepartmentCourses",
                table: "DepartmentCourses",
                columns: new[] { "DepartmentID", "CourseID" });

            migrationBuilder.CreateIndex(
                name: "IX_StudentCourses_CourseID1",
                table: "StudentCourses",
                column: "CourseID1");

            migrationBuilder.CreateIndex(
                name: "IX_InstructorCourse_CourseID1",
                table: "InstructorCourse",
                column: "CourseID1");

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
                name: "FK_StudentCourses_Courses_CourseID1",
                table: "StudentCourses",
                column: "CourseID1",
                principalTable: "Courses",
                principalColumn: "CourseID");
        }
    }
}
