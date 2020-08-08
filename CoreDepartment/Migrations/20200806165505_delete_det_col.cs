﻿using Microsoft.EntityFrameworkCore.Migrations;

namespace CoreDepartment.Migrations
{
    public partial class delete_det_col : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Details",
                table: "departments");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Details",
                table: "departments",
                nullable: true);
        }
    }
}
