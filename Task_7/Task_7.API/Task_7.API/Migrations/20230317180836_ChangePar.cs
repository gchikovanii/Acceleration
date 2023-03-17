using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace Task_7.API.Migrations
{
    public partial class ChangePar : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Class",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Pupils");

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Teachers",
                type: "nvarchar(max)",
                nullable: true);

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Pupils",
                type: "int",
                nullable: false,
                defaultValue: 0);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Subject",
                table: "Teachers");

            migrationBuilder.DropColumn(
                name: "Class",
                table: "Pupils");

            migrationBuilder.AddColumn<int>(
                name: "Class",
                table: "Teachers",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<string>(
                name: "Subject",
                table: "Pupils",
                type: "nvarchar(max)",
                nullable: true);
        }
    }
}
