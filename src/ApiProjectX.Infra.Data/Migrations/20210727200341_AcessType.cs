using System;
using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class AcessType : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.CreateTable(
                name: "AcessType",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    Type = table.Column<string>(type: "nvarchar(max)", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AcessType", x => x.Id);
                });

            migrationBuilder.CreateTable(
                name: "UserEntity",
                columns: table => new
                {
                    Id = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    UserName = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserNick = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserEmail = table.Column<string>(type: "nvarchar(255)", maxLength: 255, nullable: false),
                    UserPassword = table.Column<string>(type: "nvarchar(20)", maxLength: 20, nullable: false),
                    UserBirth = table.Column<string>(type: "nvarchar(8)", maxLength: 8, nullable: false),
                    AcessTypeId = table.Column<Guid>(type: "uniqueidentifier", nullable: false),
                    CreatedAt = table.Column<DateTime>(type: "datetime2", nullable: false),
                    UpdatedAt = table.Column<DateTime>(type: "datetime2", nullable: false)
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_UserEntity", x => x.Id);
                    table.ForeignKey(
                        name: "FK_UserEntity_AcessType_AcessTypeId",
                        column: x => x.AcessTypeId,
                        principalTable: "AcessType",
                        principalColumn: "Id",
                        onDelete: ReferentialAction.Cascade);
                });

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_AcessTypeId",
                table: "UserEntity",
                column: "AcessTypeId");

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_UserEmail",
                table: "UserEntity",
                column: "UserEmail",
                unique: true);

            migrationBuilder.CreateIndex(
                name: "IX_UserEntity_UserNick",
                table: "UserEntity",
                column: "UserNick",
                unique: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "UserEntity");

            migrationBuilder.DropTable(
                name: "AcessType");
        }
    }
}
