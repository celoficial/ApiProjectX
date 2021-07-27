using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class UpdateKey : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeCategory",
                table: "AnimeCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeAuthor",
                table: "AnimeAuthor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeCategory",
                table: "AnimeCategory",
                column: "Id");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeAuthor",
                table: "AnimeAuthor",
                column: "Id");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeCategory_AnimeId",
                table: "AnimeCategory",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_AnimeAuthor_AnimeId",
                table: "AnimeAuthor",
                column: "AnimeId");
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeCategory",
                table: "AnimeCategory");

            migrationBuilder.DropIndex(
                name: "IX_AnimeCategory_AnimeId",
                table: "AnimeCategory");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeAuthor",
                table: "AnimeAuthor");

            migrationBuilder.DropIndex(
                name: "IX_AnimeAuthor_AnimeId",
                table: "AnimeAuthor");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeCategory",
                table: "AnimeCategory",
                columns: new[] { "AnimeId", "CategoryId" });

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeAuthor",
                table: "AnimeAuthor",
                columns: new[] { "AnimeId", "AuthorId" });
        }
    }
}
