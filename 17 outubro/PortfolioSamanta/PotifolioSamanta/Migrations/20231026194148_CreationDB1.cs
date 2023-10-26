using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioSamanta.Migrations
{
    /// <inheritdoc />
    public partial class CreationDB1 : Migration
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
                    Id = table.Column<int>(type: "int", nullable: false)
                        .Annotation("SqlServer:Identity", "1, 1")
                },
                constraints: table =>
                {
                    table.PrimaryKey("PK_AboutMe", x => x.Id);
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
