using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TypoFix : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2,
                column: "SectionHTML",
                value: "<h2>What are HTML Elements?</h2>\r\n        <p>\r\n            HTML elements are the building blocks of a web page. An HTML element defines a piece of content on the page and how it should be displayed by the browser. \r\n            Each element is made up of tags, which tell the browser how to structure and display the content.\r\n        </p>\r\n");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                columns: new[] { "SectionDisplay", "SectionName" },
                values: new object[] { "HTML Divs", "HTMLDivs" });
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2,
                column: "SectionHTML",
                value: "<h2>What are HTML Elements?</h2>\\r\\n        <p>\\r\\n            HTML elements are the building blocks of a web page. An HTML element defines a piece of content on the page and how it should be displayed by the browser. \\r\\n            Each element is made up of tags, which tell the browser how to structure and display the content.\\r\\n        </p>\";\r\n");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                columns: new[] { "SectionDisplay", "SectionName" },
                values: new object[] { "HTML", "HTML" });
        }
    }
}
