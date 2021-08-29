using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class AnimeStudio : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Anime_AnimeId",
                table: "StudioAnimeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Studio_StudioId",
                table: "StudioAnimeEntity");

            migrationBuilder.AddForeignKey(
                name: "FK_StudioAnimeEntity_Anime_AnimeId",
                table: "StudioAnimeEntity",
                column: "AnimeId",
                principalTable: "Anime",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_StudioAnimeEntity_Studio_StudioId",
                table: "StudioAnimeEntity",
                column: "StudioId",
                principalTable: "Studio",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Anime_AnimeId",
                table: "StudioAnimeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Studio_StudioId",
                table: "StudioAnimeEntity");

            migrationBuilder.AddForeignKey(
                name: "FK_StudioAnimeEntity_Anime_AnimeId",
                table: "StudioAnimeEntity",
                column: "AnimeId",
                principalTable: "Anime",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);

            migrationBuilder.AddForeignKey(
                name: "FK_StudioAnimeEntity_Studio_StudioId",
                table: "StudioAnimeEntity",
                column: "StudioId",
                principalTable: "Studio",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
