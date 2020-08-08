using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class new_dept_col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "departments",
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "departments");
        }
    }
}
