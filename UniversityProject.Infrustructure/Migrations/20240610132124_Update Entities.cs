using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace UniversityProject.Infrustructure.Migrations
{
    public partial class UpdateEntities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InstructorID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_ManagerID",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_ManagingDepartmentDepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_ManagingDepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Instructors_HeadOfDepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_ManagingDepartmentDepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InstructorID",
                table: "Departments");

            migrationBuilder.DropIndex(
                name: "IX_Departments_ManagerID",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Degree",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "FirstName",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "LastName",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "ManagingDepartmentDepartmentID",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "InstructorID",
                table: "Departments");

            migrationBuilder.RenameColumn(
                name: "InstructorID",
                table: "Instructors",
                newName: "InstructorId");

            migrationBuilder.RenameColumn(
                name: "TeachingDepartmentID",
                table: "Instructors",
                newName: "DepartmentID");

            migrationBuilder.RenameColumn(
                name: "ManagingDepartmentID",
                table: "Instructors",
                newName: "departmentManagerDepartmentID");

            migrationBuilder.RenameColumn(
                name: "HeadOfDepartmentID",
                table: "Instructors",
                newName: "SupervisorId");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_ManagingDepartmentID",
                table: "Instructors",
                newName: "IX_Instructors_departmentManagerDepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_HeadOfDepartmentID",
                table: "Instructors",
                newName: "IX_Instructors_SupervisorId");

            migrationBuilder.RenameColumn(
                name: "ManagerID",
                table: "Departments",
                newName: "InsManager");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: true,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)");

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true,
                oldClrType: typeof(string),
                oldType: "nvarchar(max)");

            migrationBuilder.AddColumn<string>(
                name: "Name",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Position",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_DepartmentID",
                table: "Instructors",
                column: "DepartmentID");

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
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors",
                column: "DepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_departmentManagerDepartmentID",
                table: "Instructors",
                column: "departmentManagerDepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Instructors_SupervisorId",
                table: "Instructors",
                column: "SupervisorId",
                principalTable: "Instructors",
                principalColumn: "InstructorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_Departments_Instructors_InsManager",
                table: "Departments");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Departments_departmentManagerDepartmentID",
                table: "Instructors");

            migrationBuilder.DropForeignKey(
                name: "FK_Instructors_Instructors_SupervisorId",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Instructors_DepartmentID",
                table: "Instructors");

            migrationBuilder.DropIndex(
                name: "IX_Departments_InsManager",
                table: "Departments");

            migrationBuilder.DropColumn(
                name: "Name",
                table: "Instructors");

            migrationBuilder.DropColumn(
                name: "Position",
                table: "Instructors");

            migrationBuilder.RenameColumn(
                name: "InstructorId",
                table: "Instructors",
                newName: "InstructorID");

            migrationBuilder.RenameColumn(
                name: "departmentManagerDepartmentID",
                table: "Instructors",
                newName: "ManagingDepartmentID");

            migrationBuilder.RenameColumn(
                name: "SupervisorId",
                table: "Instructors",
                newName: "HeadOfDepartmentID");

            migrationBuilder.RenameColumn(
                name: "DepartmentID",
                table: "Instructors",
                newName: "TeachingDepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_SupervisorId",
                table: "Instructors",
                newName: "IX_Instructors_HeadOfDepartmentID");

            migrationBuilder.RenameIndex(
                name: "IX_Instructors_departmentManagerDepartmentID",
                table: "Instructors",
                newName: "IX_Instructors_ManagingDepartmentID");

            migrationBuilder.RenameColumn(
                name: "InsManager",
                table: "Departments",
                newName: "ManagerID");

            migrationBuilder.AlterColumn<decimal>(
                name: "Salary",
                table: "Instructors",
                type: "decimal(18,2)",
                nullable: false,
                defaultValue: 0m,
                oldClrType: typeof(decimal),
                oldType: "decimal(18,2)",
                oldNullable: true);

            migrationBuilder.AlterColumn<string>(
                name: "Address",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "",
                oldClrType: typeof(string),
                oldType: "nvarchar(max)",
                oldNullable: true);

            migrationBuilder.AddColumn<string>(
                name: "Degree",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "FirstName",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<string>(
                name: "LastName",
                table: "Instructors",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.AddColumn<int>(
                name: "ManagingDepartmentDepartmentID",
                table: "Instructors",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "InstructorID",
                table: "Departments",
                type: "int",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_Instructors_ManagingDepartmentDepartmentID",
                table: "Instructors",
                column: "ManagingDepartmentDepartmentID");

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

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_ManagingDepartmentDepartmentID",
                table: "Instructors",
                column: "ManagingDepartmentDepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID",
                onDelete: ReferentialAction.Cascade);

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Departments_ManagingDepartmentID",
                table: "Instructors",
                column: "ManagingDepartmentID",
                principalTable: "Departments",
                principalColumn: "DepartmentID");

            migrationBuilder.AddForeignKey(
                name: "FK_Instructors_Instructors_HeadOfDepartmentID",
                table: "Instructors",
                column: "HeadOfDepartmentID",
                principalTable: "Instructors",
                principalColumn: "InstructorID");
        }
    }
}
