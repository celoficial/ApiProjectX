using Microsoft.EntityFrameworkCore.Migrations;

namespace ApiProjectX.Infra.Data.Migrations
{
    public partial class animeEntityChange : Migration
    {
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.AddColumn<string>(
                name: "Tags",
                table: "Anime",
                type: "nvarchar(255)",
                maxLength: 255,
                nullable: true);
        }

        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Tags",
                table: "Anime");
        }
    }
}
