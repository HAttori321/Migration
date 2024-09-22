using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Reiting : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "Reiting",
                table: "Trek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.AddColumn<int>(
                name: "Reiting",
                table: "Albom",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Albom",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reiting",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Albom",
                keyColumn: "Id",
                keyValue: 2,
                column: "Reiting",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 1,
                column: "Reiting",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 2,
                column: "Reiting",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Reiting",
                table: "Trek");

            migrationBuilder.DropColumn(
                name: "Reiting",
                table: "Albom");
        }
    }
}
