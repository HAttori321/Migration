using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Tekst : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tekst",
                table: "Trek",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 1,
                column: "Tekst",
                value: "AAAAAAAA");

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 2,
                column: "Tekst",
                value: "bBBBBBBB");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tekst",
                table: "Trek");
        }
    }
}
