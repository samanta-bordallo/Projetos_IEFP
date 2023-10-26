using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioSamanta.Migrations
{
    /// <inheritdoc />
    public partial class CreationDB2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.RenameColumn(
                name: "Link",
                table: "Projects",
                newName: "Topic");

            migrationBuilder.AddColumn<string>(
                name: "Language",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");

            migrationBuilder.CreateTable(
                name: "AboutMe",
                columns: table => new
                {
                },
                constraints: table =>
                {
                });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropTable(
                name: "AboutMe");

            migrationBuilder.DropColumn(
                name: "Language",
                table: "Projects");

            migrationBuilder.RenameColumn(
                name: "Topic",
                table: "Projects",
                newName: "Link");
        }
    }
}
