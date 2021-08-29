using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class QUALQUERCOISA : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Anime_AnimeId",
                table: "StudioAnimeEntity");

            migrationBuilder.DropForeignKey(
                name: "FK_StudioAnimeEntity_Studio_StudioId",
                table: "StudioAnimeEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_StudioAnimeEntity",
                table: "StudioAnimeEntity");

            migrationBuilder.RenameTable(
                name: "StudioAnimeEntity",
                newName: "AnimeStudio");

            migrationBuilder.RenameIndex(
                name: "IX_StudioAnimeEntity_StudioId",
                table: "AnimeStudio",
                newName: "IX_AnimeStudio_StudioId");

            migrationBuilder.RenameIndex(
                name: "IX_StudioAnimeEntity_AnimeId",
                table: "AnimeStudio",
                newName: "IX_AnimeStudio_AnimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_AnimeStudio",
                table: "AnimeStudio",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeStudio_Anime_AnimeId",
                table: "AnimeStudio",
                column: "AnimeId",
                principalTable: "Anime",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);

            migrationBuilder.AddForeignKey(
                name: "FK_AnimeStudio_Studio_StudioId",
                table: "AnimeStudio",
                column: "StudioId",
                principalTable: "Studio",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_AnimeStudio_Anime_AnimeId",
                table: "AnimeStudio");

            migrationBuilder.DropForeignKey(
                name: "FK_AnimeStudio_Studio_StudioId",
                table: "AnimeStudio");

            migrationBuilder.DropPrimaryKey(
                name: "PK_AnimeStudio",
                table: "AnimeStudio");

            migrationBuilder.RenameTable(
                name: "AnimeStudio",
                newName: "StudioAnimeEntity");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeStudio_StudioId",
                table: "StudioAnimeEntity",
                newName: "IX_StudioAnimeEntity_StudioId");

            migrationBuilder.RenameIndex(
                name: "IX_AnimeStudio_AnimeId",
                table: "StudioAnimeEntity",
                newName: "IX_StudioAnimeEntity_AnimeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_StudioAnimeEntity",
                table: "StudioAnimeEntity",
                column: "Id");

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
    }
}
