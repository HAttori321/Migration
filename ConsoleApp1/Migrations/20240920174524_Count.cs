using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class Count : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<int>(
                name: "CountProslych",
                table: "Trek",
                type: "int",
                nullable: false,
                defaultValue: 0);

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 1,
                column: "CountProslych",
                value: 0);

            migrationBuilder.UpdateData(
                table: "Trek",
                keyColumn: "Id",
                keyValue: 2,
                column: "CountProslych",
                value: 0);
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "CountProslych",
                table: "Trek");
        }
    }
}
