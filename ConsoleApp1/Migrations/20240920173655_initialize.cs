using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

#pragma warning disable CA1814 // Prefer jagged arrays over multidimensional

namespace ConsoleApp1.Migrations
{
    /// <inheritdoc />
    public partial class initialize : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Country",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    CountryName = table.Column<string>(name: "Country Name", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Country", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Genre",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    GanrName = table.Column<string>(name: "Ganr Name", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Genre", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Kategoria",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    KategoriaName = table.Column<string>(name: "Kategoria Name", type: "nvarchar(100)", maxLength: 100, nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Kategoria", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "Artist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    FirstName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    LastName = table.Column<string>(type: "nvarchar(100)", maxLength: 100, nullable: false),
                    CountryId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Artist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Artist_Country_CountryId",
                        column: x => x.CountryId,
                        principalTable: "Country",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Pleylist",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrekName = table.Column<string>(name: "Trek Name", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    KategoriaId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Pleylist", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Pleylist_Kategoria_KategoriaId",
                        column: x => x.KategoriaId,
                        principalTable: "Kategoria",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Albom",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    AlbomName = table.Column<string>(name: "Albom Name", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    Year = table.Column<int>(type: "int", nullable: false),
                    GenreId = table.Column<int>(type: "int", nullable: false),
                    ArtistId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Albom", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Albom_Artist_ArtistId",
                        column: x => x.ArtistId,
                        principalTable: "Artist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_Albom_Genre_GenreId",
                        column: x => x.GenreId,
                        principalTable: "Genre",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "Trek",
                columns: table => new
                {
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1"),
                    TrekName = table.Column<string>(name: "Trek Name", type: "nvarchar(100)", maxLength: 100, nullable: false),
                    AlbomId = table.Column<int>(type: "int", nullable: false),
                    Duration = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Trek", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Trek_Albom_AlbomId",
                        column: x => x.AlbomId,
                        principalTable: "Albom",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateTable(
                name: "PleylistTrek",
                columns: table => new
                {
                    PleylistsId = table.Column<int>(type: "int", nullable: false),
                    TreksId = table.Column<int>(type: "int", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_PleylistTrek", x => new { x.PleylistsId, x.TreksId });
                    table.ForeignKey(
                        name: "FK_PleylistTrek_Pleylist_PleylistsId",
                        column: x => x.PleylistsId,
                        principalTable: "Pleylist",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                    table.ForeignKey(
                        name: "FK_PleylistTrek_Trek_TreksId",
                        column: x => x.TreksId,
                        principalTable: "Trek",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.InsertData(
                table: "Country",
                columns: new[] { "Id", "Country Name" },
                values: new object[,]
                {
                    { 1, "FFFF" },
                    { 2, "CCCC" }
                });

            migrationBuilder.InsertData(
                table: "Genre",
                columns: new[] { "Id", "Ganr Name" },
                values: new object[,]
                {
                    { 1, "WWWWW" },
                    { 2, "EEEEE" }
                });

            migrationBuilder.InsertData(
                table: "Kategoria",
                columns: new[] { "Id", "Kategoria Name" },
                values: new object[,]
                {
                    { 1, "QQQQQ" },
                    { 2, "RRRRR" }
                });

            migrationBuilder.InsertData(
                table: "Artist",
                columns: new[] { "Id", "CountryId", "LastName", "FirstName" },
                values: new object[,]
                {
                    { 1, 1, "BBBBb", "AN 225" },
                    { 2, 2, "BBBBb", "AN 225" }
                });

            migrationBuilder.InsertData(
                table: "Pleylist",
                columns: new[] { "Id", "KategoriaId", "Trek Name" },
                values: new object[,]
                {
                    { 1, 1, "AN 225" },
                    { 2, 2, "AN 225" }
                });

            migrationBuilder.InsertData(
                table: "Albom",
                columns: new[] { "Id", "ArtistId", "GenreId", "Albom Name", "Year" },
                values: new object[,]
                {
                    { 1, 1, 1, "AN 225", 1234 },
                    { 2, 2, 2, "AN 225", 2345 }
                });

            migrationBuilder.InsertData(
                table: "Trek",
                columns: new[] { "Id", "AlbomId", "Duration", "Trek Name" },
                values: new object[,]
                {
                    { 1, 1, 1233, "AN 225" },
                    { 2, 2, 20024, "AN 225" }
                });

            migrationBuilder.CreateIndex(
                name: "IX_Albom_ArtistId",
                table: "Albom",
                column: "ArtistId");

            migrationBuilder.CreateIndex(
                name: "IX_Albom_GenreId",
                table: "Albom",
                column: "GenreId");

            migrationBuilder.CreateIndex(
                name: "IX_Artist_CountryId",
                table: "Artist",
                column: "CountryId");

            migrationBuilder.CreateIndex(
                name: "IX_Pleylist_KategoriaId",
                table: "Pleylist",
                column: "KategoriaId");

            migrationBuilder.CreateIndex(
                name: "IX_PleylistTrek_TreksId",
                table: "PleylistTrek",
                column: "TreksId");

            migrationBuilder.CreateIndex(
                name: "IX_Trek_AlbomId",
                table: "Trek",
                column: "AlbomId");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "PleylistTrek");

            migrationBuilder.DropTable(
                name: "Pleylist");

            migrationBuilder.DropTable(
                name: "Trek");

            migrationBuilder.DropTable(
                name: "Kategoria");

            migrationBuilder.DropTable(
                name: "Albom");

            migrationBuilder.DropTable(
                name: "Artist");

            migrationBuilder.DropTable(
                name: "Genre");

            migrationBuilder.DropTable(
                name: "Country");
        }
    }
}
