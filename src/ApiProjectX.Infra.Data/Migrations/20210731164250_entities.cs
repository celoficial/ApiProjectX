using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class entities : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_UserEntity_AcessType_AcessTypeId",
                table: "UserEntity");

            migrationBuilder.DropPrimaryKey(
                name: "PK_UserEntity",
                table: "UserEntity");

            migrationBuilder.RenameTable(
                name: "UserEntity",
                newName: "User");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_UserNick",
                table: "User",
                newName: "IX_User_UserNick");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_UserEmail",
                table: "User",
                newName: "IX_User_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_UserEntity_AcessTypeId",
                table: "User",
                newName: "IX_User_AcessTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_User",
                table: "User",
                column: "Id");

            migrationBuilder.CreateTable(
                name: "Season",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Season", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Season_Anime_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Watching",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Watching", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Watching_Anime_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_Watching_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "WatchLater",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    AnimeId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    UserId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_WatchLater", x => x.Id);
                    table.ForeignKey(
                        name: "FK_WatchLater_Anime_AnimeId",
                        column: x => x.AnimeId,
                        principalTable: "Anime",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                    table.ForeignKey(
                        name: "FK_WatchLater_User_UserId",
                        column: x => x.UserId,
                        principalTable: "User",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateTable(
                name: "Episode",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    DescriptionEpisode = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: true),
                    ImgEpisodeUrl = table.Column<string>(type: "nvarchar(max)", nullable: true),
                    SeasonId = table.Column<Guid>(type: "uniqueidentifier", nullable: true),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_Episode", x => x.Id);
                    table.ForeignKey(
                        name: "FK_Episode_Season_SeasonId",
                        column: x => x.SeasonId,
                        principalTable: "Season",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.SetNull);
                });

            migrationBuilder.CreateIndex(
                name: "IX_Episode_SeasonId",
                table: "Episode",
                column: "SeasonId");

            migrationBuilder.CreateIndex(
                name: "IX_Season_AnimeId",
                table: "Season",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Watching_AnimeId",
                table: "Watching",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_Watching_UserId",
                table: "Watching",
                column: "UserId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLater_AnimeId",
                table: "WatchLater",
                column: "AnimeId");

            migrationBuilder.CreateIndex(
                name: "IX_WatchLater_UserId",
                table: "WatchLater",
                column: "UserId");

            migrationBuilder.AddForeignKey(
                name: "FK_User_AcessType_AcessTypeId",
                table: "User",
                column: "AcessTypeId",
                principalTable: "AcessType",
                principalColumn: "Id",
                onDelete: ReferentialAction.SetNull);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropForeignKey(
                name: "FK_User_AcessType_AcessTypeId",
                table: "User");

            migrationBuilder.DropTable(
                name: "Episode");

            migrationBuilder.DropTable(
                name: "Watching");

            migrationBuilder.DropTable(
                name: "WatchLater");

            migrationBuilder.DropTable(
                name: "Season");

            migrationBuilder.DropPrimaryKey(
                name: "PK_User",
                table: "User");

            migrationBuilder.RenameTable(
                name: "User",
                newName: "UserEntity");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserNick",
                table: "UserEntity",
                newName: "IX_UserEntity_UserNick");

            migrationBuilder.RenameIndex(
                name: "IX_User_UserEmail",
                table: "UserEntity",
                newName: "IX_UserEntity_UserEmail");

            migrationBuilder.RenameIndex(
                name: "IX_User_AcessTypeId",
                table: "UserEntity",
                newName: "IX_UserEntity_AcessTypeId");

            migrationBuilder.AddPrimaryKey(
                name: "PK_UserEntity",
                table: "UserEntity",
                column: "Id");

            migrationBuilder.AddForeignKey(
                name: "FK_UserEntity_AcessType_AcessTypeId",
                table: "UserEntity",
                column: "AcessTypeId",
                principalTable: "AcessType",
                principalColumn: "Id",
                onDelete: ReferentialAction.Restrict);
        }
    }
}
