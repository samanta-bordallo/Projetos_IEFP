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
            migrationBuilder.AddColumn<string>(
                name: "Link",
                table: "Projects",
                type: "nvarchar(max)",
                nullable: false,
                defaultValue: "");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.DropColumn(
                name: "Link",
                table: "Projects");
        }
    }
}
