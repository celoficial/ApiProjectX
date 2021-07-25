using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class AnimeAuthor : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "Author",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AuthorName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Author", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "AnimeAuthor",
                columns: table => new
                {
                    AuthorId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AnimeAuthor", x => new { x.AnimeId, x.AuthorId });
                    table.ForeignKey(
                        name: "FK_AnimeAuthor_Anime_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_AnimeAuthor_Author_AuthorId",
                        column: x => x.AuthorId,
                        principalTable: "Author",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_AnimeAuthor_AuthorId",
                table: "AnimeAuthor",
                column: "AuthorId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AnimeAuthor");

            migrationBuilder.DropTable(
                name: "Author");
        }
    }
}
