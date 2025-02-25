using Microsoft.EntityFrameworkCore.Migrations;

#nullable disable

namespace PortfolioProject.Data.Migrations
{
    /// <inheritdoc />
    public partial class TypoFix2 : Migration
    {
        /// <inheritdoc />
        protected override void Up(MigrationBuilder migrationBuilder)
        {
            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 2,
                column: "SectionHTML",
                value: "<h2>What are HTML Elements?</h2>\r\n        <p>\r\n            HTML elements are the building blocks of a web page. An HTML element defines a piece of content on the page and how it should be displayed by the browser. \r\n            Each element is made up of tags, which tell the browser how to structure and display the content.\r\n        </p>\r\n        <p>\r\n            An HTML element typically consists of three parts:\r\n        </p>\r\n        <ul>\r\n            <li>Opening Tag: The start of the element, usually containing the element’s name. It tells the browser that the element begins here.</li>\r\n\r\n            <li>Content: The actual data or content inside the element. This can be text, images, links, or other elements.</li>\r\n\r\n            <li>Closing Tag: The end of the element, indicating where the element finishes. It’s similar to the opening tag, but with a slash (/) before the element name.</li>\r\n        </ul>\r\n\r\n        <p>There are many types of HTML elements, to name a few:</p>\r\n        <ul>\r\n            <li>Structural Elements: These elements help structure the layout of a webpage.</li>\r\n\r\n            <li>Text Elements: These elements define and format text on the page.</li>\r\n\r\n            <li>Link and Navigation Elements: These elements create clickable links to navigate between pages or websites.</li>\r\n\r\n            <li>Image and Media Elements: These elements are used to embed images, videos, audio, etc.</li>\r\n\r\n            <li>List Elements: These elements are used to display lists of items.</li>\r\n\r\n            <li>And many more! (Soon to be added!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Understanding HTML elements is key to building and structuring any webpage, as they dictate how content is displayed in the browser.\r\n        </p>");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 3,
                column: "SectionHTML",
                value: "<h2>What are HTML Attributes?</h2>\r\n        <p>\r\n            HTML attributes provide additional information about an HTML element. \r\n            They are used to configure the behavior or appearance of elements and are always placed within the opening tag of an element. \r\n            Attributes define properties like a link’s destination, an image's source, or a form element's placeholder text.\r\n        </p>\r\n        <p>Common HTML Attributes include:</p>\r\n        <ul>\r\n            <li>href (for links)</li>\r\n\r\n            <li>src (for images)</li>\r\n\r\n            <li>alt (for images)</li>\r\n\r\n            <li>class (for styling and JavaScript)</li>\r\n\r\n            <li>id (for unique identification)</li>\r\n\r\n            <li>style (for inline styling)</li>\r\n\r\n            <li>And more! (Will be added soon!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Understanding how to use HTML attributes effectively is key to controlling how elements look and behave on your webpage.\r\n        </p>");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                column: "SectionDisplay",
                value: "HTML");
        }

        /// <inheritdoc />
        protected override void Down(MigrationBuilder migrationBuilder)
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
                keyValue: 3,
                column: "SectionHTML",
                value: "<h2>What are HTML Elements?</h2>\r\n        <p>\r\n            HTML elements are the building blocks of a web page. An HTML element defines a piece of content on the page and how it should be displayed by the browser. \r\n            Each element is made up of tags, which tell the browser how to structure and display the content.\r\n        </p>\r\n        <p>\r\n            An HTML element typically consists of three parts:\r\n        </p>\r\n        <ul>\r\n            <li>Opening Tag: The start of the element, usually containing the element’s name. It tells the browser that the element begins here.</li>\r\n\r\n            <li>Content: The actual data or content inside the element. This can be text, images, links, or other elements.</li>\r\n\r\n            <li>Closing Tag: The end of the element, indicating where the element finishes. It’s similar to the opening tag, but with a slash (/) before the element name.</li>\r\n        </ul>\r\n\r\n        <p>There are many types of HTML elements, to name a few:</p>\r\n        <ul>\r\n            <li>Structural Elements: These elements help structure the layout of a webpage.</li>\r\n\r\n            <li>Text Elements: These elements define and format text on the page.</li>\r\n\r\n            <li>Link and Navigation Elements: These elements create clickable links to navigate between pages or websites.</li>\r\n\r\n            <li>Image and Media Elements: These elements are used to embed images, videos, audio, etc.</li>\r\n\r\n            <li>List Elements: These elements are used to display lists of items.</li>\r\n\r\n            <li>And many more! (Soon to be added!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Understanding HTML elements is key to building and structuring any webpage, as they dictate how content is displayed in the browser.\r\n        </p>");

            migrationBuilder.UpdateData(
                table: "Sections",
                keyColumn: "SectionId",
                keyValue: 8,
                column: "SectionDisplay",
                value: "HTML Divs");
        }
    }
}
