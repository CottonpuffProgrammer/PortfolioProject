using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TypoFix3 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                column: "SectionDisplay",
                value: "HTML Divs");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                column: "SectionDisplay",
                value: "HTML");
        }
    }
}
