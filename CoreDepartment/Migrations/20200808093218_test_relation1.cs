using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class test_relation1 : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "departID",
                table: "employees",
                nullable: true);

            migrationBuilder.CreateIndex(
                name: "IX_employees_departID",
                table: "employees",
                column: "departID");

            migrationBuilder.AddForeignKey(
                name: "FK_employees_departments_departID",
                table: "employees",
                column: "departID",
                principalTable: "departments",
                principalColumn: "ID",
                onDelete: ReferentialAction.Restrict);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_employees_departments_departID",
                table: "employees");

            migrationBuilder.DropIndex(
                name: "IX_employees_departID",
                table: "employees");

            migrationBuilder.DropColumn(
                name: "departID",
                table: "employees");
        }
    }
}
