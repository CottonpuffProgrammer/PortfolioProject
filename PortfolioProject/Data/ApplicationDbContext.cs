﻿using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using PortfolioProject.Models;
using System.Reflection.Emit;

namespace PortfolioProject.Data;

public class ApplicationDbContext : IdentityDbContext<IdentityUser>
{
    public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
        : base(options)
    {
    }

    protected override void OnModelCreating(ModelBuilder builder)
    {
        base.OnModelCreating(builder);

        // Seeds data for the local database, rather than having to add it manually via a method
        builder.Entity<Section>().HasData(

            // All Seeded HTML Sections
            new Section
            {
                SectionId = 1,
                SectionType = "HTML",
                SectionName = "HTML",
                SectionDisplay = "HTML Introduction",
                SectionHTML = "<h2>What is HTML?</h2>\r\n        <p>HTML, or HyperText Markup Language, is the standard language used to create and organize content on the web. \r\n            It provides the basic structure for all web pages, allowing browsers to display text, images, links, and other elements in a readable format.</p>\r\n        <p>HTML works by using tags (also called elements) to define different types of content. \r\n            These tags tell the browser how to display and organize the information on the page. \r\n            For example, \"h1\" is used for main headings, \"p\" for paragraphs, and \"a\" for hyperlinks.</p>\r\n\r\n        <p> (Add Examples later!)</p>\r\n\r\n        <p>In short, HTML is important because it is the language that web browsers understand to display the content of a webpage. \r\n            It forms the backbone of every website, ensuring that content is accessible, organized, and interactive for users.</p>"
            },

            new Section
            {
                SectionId = 2,
                SectionType = "HTML",
                SectionName = "HTMLElements",
                SectionDisplay = "HTML Elements",
                SectionHTML = "<h2>What are HTML Elements?</h2>\r\n        <p>\r\n            HTML elements are the building blocks of a web page. An HTML element defines a piece of content on the page and how it should be displayed by the browser. \r\n            Each element is made up of tags, which tell the browser how to structure and display the content.\r\n        </p>\r\n        <p>\r\n            An HTML element typically consists of three parts:\r\n        </p>\r\n        <ul>\r\n            <li>Opening Tag: The start of the element, usually containing the element’s name. It tells the browser that the element begins here.</li>\r\n\r\n            <li>Content: The actual data or content inside the element. This can be text, images, links, or other elements.</li>\r\n\r\n            <li>Closing Tag: The end of the element, indicating where the element finishes. It’s similar to the opening tag, but with a slash (/) before the element name.</li>\r\n        </ul>\r\n\r\n        <p>There are many types of HTML elements, to name a few:</p>\r\n        <ul>\r\n            <li>Structural Elements: These elements help structure the layout of a webpage.</li>\r\n\r\n            <li>Text Elements: These elements define and format text on the page.</li>\r\n\r\n            <li>Link and Navigation Elements: These elements create clickable links to navigate between pages or websites.</li>\r\n\r\n            <li>Image and Media Elements: These elements are used to embed images, videos, audio, etc.</li>\r\n\r\n            <li>List Elements: These elements are used to display lists of items.</li>\r\n\r\n            <li>And many more! (Soon to be added!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Understanding HTML elements is key to building and structuring any webpage, as they dictate how content is displayed in the browser.\r\n        </p>"
            },

            new Section
            {
                SectionId = 3,
                SectionType = "HTML",
                SectionName = "HTMLAttributes",
                SectionDisplay = "HTML Attributes",
                SectionHTML = "<h2>What are HTML Attributes?</h2>\r\n        <p>\r\n            HTML attributes provide additional information about an HTML element. \r\n            They are used to configure the behavior or appearance of elements and are always placed within the opening tag of an element. \r\n            Attributes define properties like a link’s destination, an image's source, or a form element's placeholder text.\r\n        </p>\r\n        <p>Common HTML Attributes include:</p>\r\n        <ul>\r\n            <li>href (for links)</li>\r\n\r\n            <li>src (for images)</li>\r\n\r\n            <li>alt (for images)</li>\r\n\r\n            <li>class (for styling and JavaScript)</li>\r\n\r\n            <li>id (for unique identification)</li>\r\n\r\n            <li>style (for inline styling)</li>\r\n\r\n            <li>And more! (Will be added soon!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Understanding how to use HTML attributes effectively is key to controlling how elements look and behave on your webpage.\r\n        </p>"
            },

            new Section
            {
                SectionId = 4,
                SectionType = "HTML",
                SectionName = "HTMLComments",
                SectionDisplay = "HTML Comments",
                SectionHTML = "<h2>What are HTML Comments?</h2>\r\n        <p>\r\n            HTML comments are used to add notes or explanations within your HTML code. \r\n            They are not displayed on the webpage itself, but they can help developers understand the code, leave reminders, \r\n            or temporarily disable sections of the code during development.\r\n        </p>\r\n        <p>Purposes of HTML Comments:</p>\r\n        <ul>\r\n            Documentation:\r\n            <li>HTML comments allow developers to add explanations or instructions within the code. \r\n                This is useful for clarifying complex sections of the code or leaving notes for other developers working on the same project.</li>\r\n\r\n            Temporarily Disable Code:\r\n            <li>You can use comments to temporarily disable part of the HTML code without deleting it. \r\n                This is helpful when testing or troubleshooting.</li>\r\n\r\n            Organizing Code:\r\n            <li>Comments can help break the code into sections, making it easier to read and navigate. This is especially useful in larger projects with lots of code.</li>\r\n\r\n            Notes for Future Development:\r\n            <li>You can add reminders or TODOs in your comments for future work or improvements.</li>\r\n        </ul>\r\n\r\n        <p>\r\n            As stated above, HTML comments are used to leave notes or explanations in the code that won't be displayed on the webpage. \r\n            They are helpful for documentation, organizing code, temporarily disabling elements, and leaving reminders. \r\n            While they are invisible to users, they make it easier for developers to collaborate and maintain the code.\r\n        </p>"
            },

            new Section
            {
                SectionId = 5,
                SectionType = "HTML",
                SectionName = "HTMLStyles",
                SectionDisplay = "HTML Styles",
                SectionHTML = "<h2>What are HTML Styles?</h2>\r\n        <p>\r\n            HTML styles refer to the way web pages are visually presented. \r\n            They control the appearance of elements such as text, images, and layout. HTML itself is used to structure content, but CSS (Cascading Style Sheets) is primarily responsible for styling the content.\r\n            However, styles can be added directly within HTML elements as well, through the use of the style attribute or by linking to external CSS files.\r\n        </p>\r\n        <p>Common CSS Properties for Styling HTML include:</p>\r\n        <ul>\r\n            Colors and background:\r\n            <li>color: Sets the color of text.</li>\r\n\r\n            <li>background-color: Sets the background color of an element.</li>\r\n\r\n            Text Styling:\r\n            <li>font-size: Specifies the size of the font.</li>\r\n\r\n            <li>font-family: Specifies the font type.</li>\r\n\r\n            <li>font-weight: Controls the thickness of text (e.g., bold).</li>\r\n\r\n            <li>text-align: Aligns text (e.g., left, center, right).</li>\r\n\r\n            Layout and Positioning:\r\n            <li>margin: Adds space around an element.</li>\r\n\r\n            <li>padding: Adds space inside an element (between the content and border).</li>\r\n\r\n            <li>width and height: Define the size of an element.</li>\r\n\r\n            <li>display: Defines how an element is displayed (e.g., block, inline).</li>\r\n\r\n            <li>More detailed Examples for all sorts of styles and more will be added in time! (Soon!)</li>\r\n        </ul>\r\n\r\n        <p>\r\n            HTML styles are used to control how elements look on a webpage. \r\n            While HTML defines the structure of the content, styles are typically added using CSS. \r\n            You can apply styles inline within an element, within a \"style\" block in the \"head\", or by linking to an external CSS file. \r\n            Styles are important for making your website visually attractive, ensuring consistency, and improving usability and accessibility.\r\n        </p>"
            },

            new Section
            {
                SectionId = 6,
                SectionType = "HTML",
                SectionName = "HTMLLists",
                SectionDisplay = "HTML Lists",
                SectionHTML = "<h2>What are HTML Lists?</h2>\r\n        <p>\r\n            HTML lists are used to group and organize content in an ordered or unordered format. \r\n            Lists help structure information in a way that's easy to read and follow. \r\n            HTML supports three main types of lists: ordered lists, unordered lists, and definition lists.\r\n        </p>\r\n        <p>Types of Lists in HTML:</p>\r\n        <ul>\r\n            Unordered List:\r\n            <li>\r\n                These are defined by bullet points and are created using the \"ul\" tag (this sentence is contained in an unordered list!).\r\n            </li>\r\n\r\n            Ordered List:\r\n            <li>\r\n                A list that uses numbers instead of dots, a good example would be steps to a recipe in a cookbook.\r\n            </li>\r\n\r\n            Nested Lists:\r\n            <li>You can also nest lists inside other lists. This can be useful when you need to represent a hierarchy of items.</li>\r\n            (Add Examples later!)\r\n        </ul>\r\n\r\n        <p>\r\n            Lists are a great way to display items in order on a website, and can even be customized with HTML Styles and CSS!\r\n        </p>"
            },

            new Section
            {
                SectionId = 7,
                SectionType = "HTML",
                SectionName = "HTMLLinks",
                SectionDisplay = "HTML Links",
                SectionHTML = "<h2>What are HTML Links?</h2>\r\n        <p>\r\n            HTML links (also called hyperlinks) are used to connect one webpage to another, or to link to external resources like images, files, or other websites. \r\n            They are created using the \"a\" (anchor) tag, which allows users to click and navigate to a different page or location.\r\n        </p>\r\n        <p>Types of Links in HTML:</p>\r\n        <ul>\r\n            Links to Other Web Pages:\r\n            <li>\r\n                You can link to other pages on the same website or to external websites.\r\n            </li>\r\n\r\n            Link to Specific Sections of a Page:\r\n            <li>\r\n                Links can also be used to navigate to specific sections of the same webpage, which is called an anchor link. \r\n                This is done using the id attribute on the target section and linking to it.\r\n            </li>\r\n\r\n            Links to Files:\r\n            <li>You can also create links to downloadable files like PDFs, images, or videos.</li>\r\n        </ul>\r\n\r\n        <p>\r\n            Summarily, HTML links are created using the \"a\" tag, and they allow users to navigate to other pages, sections within the same page, or external resources. \r\n            Links can be customized with various attributes like \"href\", \"target, \"title, and \"rel to control their behavior. \r\n            Links are a fundamental part of the web, providing navigation between different resources, whether it's within the same website or to external websites and files.\r\n        </p>"
            },

            new Section
            {
                SectionId = 8,
                SectionType = "HTML",
                SectionName = "HTMLDivs",
                SectionDisplay = "HTML Divs",
                SectionHTML = "<h2>What are HTML Divs?</h2>\r\n        <p>\r\n            In HTML, a \"div\" (short for \"division\") is a block-level element used to group together other HTML elements. \r\n            It doesn't have any inherent meaning or style by itself, but it's a useful container for structuring your web page. \r\n            The \"div\" tag is commonly used for layout purposes and to apply CSS styling or JavaScript functionality to a section of your page.\r\n        </p>\r\n        <p>Uses for a \"div\" in HTML:</p>\r\n        <ul>\r\n            Grouping Content:\r\n            <li>\r\n                The \"div\" can be used to wrap other HTML elements like text, images, forms, etc., into one container. This helps keep your code organized.\r\n            </li>\r\n\r\n            Styling:\r\n            <li>\r\n                You can use CSS to style a \"div\". For example, you could set the width, height, background color, margin, padding, and more.\r\n            </li>\r\n\r\n            Layout:\r\n            <li>The \"div\" is often used in combination with CSS for layouts, such as creating columns, grids, or other structured sections on a page.</li>\r\n        </ul>\r\n\r\n        <p>\r\n            HTML Divs have a variety of uses, but are most often used to group certain contnet together to be styled differently from that around it, it's\r\n            not the only use of a div, but is most certainly the most prominent use!\r\n        </p>"
            },

            // All Seeded CSS Sections
            new Section
            {
                SectionId = 9,
                SectionType = "CSS",
                SectionName = "CSS",
                SectionDisplay = "CSS Introduction",
                SectionHTML = "<h2>What is CSS?</h2>\r\n        <p>\r\n            CSS (Cascading Style Sheets) is a styling language used to define the look and feel of a website or web application. \r\n            It works alongside HTML (which structures the content) to create visually engaging layouts by specifying how HTML elements should appear on the screen.\r\n        </p>\r\n        <p>\r\n            With CSS, you can control various visual aspects, such as:\r\n        </p>\r\n\r\n        <ol>\r\n            <li>\r\n                Colors: Set the color of text, backgrounds, and other elements.\r\n            </li>\r\n            <li>\r\n                Fonts: Choose the type, size, and style of text.\r\n            </li>\r\n            <li>\r\n                Spacing: Control margins, padding, and the distance between elements.\r\n            </li>\r\n            <li>\r\n                Layout: Position elements in a grid, flexbox, or other layout models.\r\n            </li>\r\n            <li>\r\n                Borders: Customize the thickness, style, and color of borders.\r\n            </li>\r\n            <li>\r\n                Animations and Transitions: Add movement or changes in elements when users interact with them.\r\n            </li>\r\n        </ol>\r\n\r\n        <p> (Add Examples later!)</p>"
            },

            new Section
            {
                SectionId = 10,
                SectionType = "CSS",
                SectionName = "CSSSelectors",
                SectionDisplay = "CSS Selectors",
                SectionHTML = "<h2>What are CSS Selectors?</h2>\r\n\r\n        <p>\r\n            CSS selectors are patterns used to select and style HTML elements. They tell the browser which elements to apply styles to. \r\n            Selectors can target elements in various ways, based on their type, attributes, class, ID, and more.\r\n            Here’s a breakdown of the most common CSS selectors:\r\n        </p>\r\n\r\n        <ul>\r\n            Universal Selector:\r\n            <li>\r\n                The universal selector targets all elements on a page.\r\n            </li>\r\n            Type Selector (Element Selector):\r\n            <li>\r\n                The type (or element) selector targets all elements of a specific type.\r\n            </li>\r\n            Class Selector:\r\n            <li>\r\n                The class selector targets elements with a specific class. It’s prefixed with a period.\r\n            </li>\r\n            ID Selector:\r\n            <li>\r\n                The ID selector targets an element with a specific ID. It’s prefixed with a #. An ID is unique to a single element on a page.\r\n            </li>\r\n            <li>\r\n                And many more! (More might be added soon!)\r\n            </li>\r\n        </ul>"
            },

            new Section
            {
                SectionId = 11,
                SectionType = "CSS",
                SectionName = "CSSSyntax",
                SectionDisplay = "CSS Syntax",
                SectionHTML = "<h2>What is CSS Syntax?</h2>\r\n\r\n        <p>CSS syntax is how you write and structure your CSS rules. It consists of selectors, properties, and values. Here's the breakdown of the basic syntax:</p>\r\n\r\n        <ul>\r\n            <li>\r\n            Selector: This targets the HTML element(s) you want to style. It could be an element, class, ID, or even more complex selectors like pseudo-classes.\r\n            </li>\r\n            <li>\r\n            Property: This defines what aspect of the element you want to style (like color, font-size, or margin).\r\n            </li>\r\n            <li>\r\n            Value: This specifies what value to apply to the property (like blue for color, 16px for font-size, or 20px for margin).\r\n            </li>\r\n        </ul>\r\n\r\n        <p>(Add Examples later on!)</p>\r\n\r\n        <p>This is the basic structure of CSS syntax, and it allows you to define how elements on a webpage are styled and presented.</p>"
            },

            new Section
            {
                SectionId = 12,
                SectionType = "CSS",
                SectionName = "CSSComments",
                SectionDisplay = "CSS Comments",
                SectionHTML = "<h2>What are CSS Comments?</h2>\r\n\r\n        <p>CSS comments are used to add notes, explanations, or reminders within your CSS code. \r\n            Comments help make your code more readable for yourself or others who may be working on the same code. \r\n            They are ignored by the browser, meaning they do not affect the rendering of the webpage.</p>\r\n\r\n        <p>Key Point About CSS Comments:</p>\r\n\r\n        <ul>\r\n            Multiline Comments:\r\n            <li>\r\n                Comments can span multiple lines if needed.\r\n            </li>\r\n            Inline Comments:\r\n            <li>\r\n                You can also add comments at the end of a line, after a style rule.\r\n            </li>\r\n            Commenting Out Code:\r\n            <li>\r\n                Comments can be used to temporarily \"comment out\" parts of your code. This is helpful for testing or debugging.\r\n            </li>\r\n            No Nesting:\r\n            <li>\r\n                CSS does not support nested comments. If you try to nest a comment inside another comment, it will cause an error.\r\n            </li>\r\n        </ul>"
            },

            new Section
            {
                SectionId = 13,
                SectionType = "CSS",
                SectionName = "CSSBackgrounds",
                SectionDisplay = "CSS Backgrounds",
                SectionHTML = "<h2>What are CSS Backgrounds?</h2>\r\n\r\n        <p>\r\n            In CSS, backgrounds are used to enhance the appearance of elements by adding color, images, gradients, or other visual effects behind the content.\r\n            You can apply backgrounds to any HTML element, such as div, body, or even individual text elements, to create a more dynamic and visually appealing design.\r\n        </p>\r\n\r\n        <p>Properties for CSS Backgrounds:</p>\r\n        <ul>\r\n            background-color:\r\n            <li>\r\n                Sets the background color of an element.\r\n            </li>\r\n            background-image:\r\n            <li>\r\n                Sets an image as the background for an element. You can use the URL of the image as the value.\r\n            </li>\r\n            background-repeat:\r\n            <li>\r\n                Defines whether the background image should repeat (tile) or not.\r\n            </li>\r\n            background-position:\r\n            <li>\r\n                Specifies the position of the background image within the element. You can set it using keywords (like top, center, bottom) or using specific values (e.g., 10px 20px).\r\n            </li>\r\n            background-attachment:\r\n            <li>\r\n                Controls whether the background image scrolls with the page or stays fixed.\r\n            </li>\r\n        </ul>\r\n\r\n        <p>\r\n            CSS backgrounds allow you to add rich visual elements to your web design.\r\n            You can use colors, images, gradients, and control how they are displayed within elements using various properties.\r\n            With the ability to customize the size, position, repeat behavior, and scrolling behavior of backgrounds, you can create engaging and dynamic web layouts.\r\n        </p>"
            },

            new Section
            {
                SectionId = 14,
                SectionType = "CSS",
                SectionName = "CSSBorders",
                SectionDisplay = "CSS Borders",
                SectionHTML = "<h2>What are CSS Borders?</h2>\r\n\r\n        <p>\r\n            CSS borders are used to create a visible line around an element, helping to define its boundaries and enhance its visual appearance.\r\n            Borders can be applied to almost any HTML element, such as divs, paragraphs, and images, and they are customizable in terms of width, style, and color.\r\n        </p>\r\n\r\n        <p>Border Properties:</p>\r\n\r\n        <ul>\r\n            border-width:\r\n            <li>\r\n                Specifies the thickness of the border.\r\n            </li>\r\n            border-style:\r\n            <li>\r\n                Defines the style of the border. There are several possible values:\r\n\r\n                (Add Examples after creating more pages!)\r\n            </li>\r\n            border-color:\r\n            <li>\r\n                Sets the color of the border. You can use color names, hex codes, RGB values, HSL, or other color formats.\r\n            </li>\r\n            border:\r\n            <li>\r\n                The border property is a shorthand for combining border-width, border-style, and border-color into a single line.\r\n            </li>\r\n        </ul>\r\n\r\n        <p>You can also put a border on only specific sides of something using border-right, border-left, border-top, and border-bottom!</p>"
            },

            new Section
            {
                SectionId = 15,
                SectionType = "CSS",
                SectionName = "CSSHeightWidth",
                SectionDisplay = "CSS Height and Width",
                SectionHTML = "<h2>What is CSS Height and Width?</h2>\r\n\r\n        <p>\r\n            In CSS, the height and width properties are used to define the size of an element.\r\n            These properties are fundamental for controlling the layout and positioning of elements within a web page,\r\n            allowing you to set fixed dimensions or flexible ones depending on the design requirements.\r\n        </p>\r\n\r\n        <p>\r\n            The width property in CSS defines the horizontal size (the width) of an element.\r\n            It determines how wide the element will be within its container.\r\n        </p>\r\n\r\n        <p>\r\n            The height property in CSS defines the vertical size (the height) of an element.\r\n            It determines how tall the element will be within its container.\r\n        </p>\r\n\r\n        <p>Both width and height can be set using different units such as:</p>\r\n\r\n        <ul>\r\n            <li>\r\n                px (pixels): Fixed size.\r\n            </li>\r\n\r\n            <li>\r\n                % (percent): Relative size based on the parent element’s width.\r\n            </li>\r\n\r\n            <li>\r\n                em or rem (relative to font size): Useful for flexible designs.\r\n            </li>\r\n\r\n            <li>\r\n                vw (viewport width) and vh (viewport height): Relative to the width of the viewport.\r\n            </li>\r\n        </ul>"
            },

            new Section
            {
                SectionId = 16,
                SectionType = "CSS",
                SectionName = "CSSMargins",
                SectionDisplay = "CSS Margins",
                SectionHTML = "<h2>What are CSS Margins?</h2>\r\n\r\n        <p>\r\n            In CSS, margins are used to create space outside of an element, separating it from other elements on the page. \r\n            Margins provide a way to control the spacing between an element and its neighbors, allowing for more flexible layouts. \r\n            They don't affect the size of the element itself but influence the space around it.\r\n        </p>\r\n\r\n        <p>Key Points About Margins:</p>\r\n\r\n        <ul>\r\n            <li>\r\n                Margins create external space, whereas padding creates internal space between the element's content and its border.\r\n            </li>\r\n            <li>\r\n                Margins are transparent, meaning the background color or image of the element does not extend into the margin area.\r\n            </li>\r\n            <li>\r\n                Margins can be used to control the distance between elements, making layouts more visually appealing and organized.\r\n            </li>\r\n        </ul>\r\n\r\n        <p>CSS margins are a good tool for controlling the spacing around elements and creating layouts. \r\n            By adjusting the margins, you can manage the positioning of elements relative to one another.</p>"
            },

            // All Seeded Javascript Sections
            new Section
            {
                SectionId = 17,
                SectionType = "Javascript",
                SectionName = "Javascript",
                SectionDisplay = "Javascript Introduction",
                SectionHTML = "<h2>What is Javascript?</h2>\r\n\r\n        <p>\r\n            JavaScript is a high-level, dynamic, interpreted programming language that is primarily used for creating interactive effects within web browsers.\r\n            It's one of the core technologies of web development, alongside HTML and CSS, and is commonly used to build websites that are dynamic, interactive,\r\n            and responsive to user actions.\r\n        </p>\r\n\r\n        <p>Key Features of Javascript:</p>\r\n\r\n        <ul>\r\n            <li>\r\n                Client-Side Scripting: JavaScript is most commonly used as a client-side scripting language.\r\n                This means it runs on the user's web browser rather than on a web server.\r\n                It enables the web page to interact with the user, update dynamically without needing to reload the page,\r\n                and respond to events like clicks, form submissions, or keyboard inputs.\r\n            </li>\r\n            <li>\r\n                Interactivity: JavaScript enables interaction between the user and the webpage, such as:\r\n\r\n                <ul>\r\n                    <li>\r\n                        Form validation: Checking if a form is filled out correctly before submission.\r\n                    </li>\r\n                    <li>\r\n                        Animations and effects: Making elements move, fade, or change over time.\r\n                    </li>\r\n                    <li>\r\n                        Handling user events: Responding to clicks, hover effects, and other actions.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                Versatility: JavaScript is not limited to the browser.\r\n                With platforms like Node.js, JavaScript can also be run on a server, enabling the development of full-stack applications.\r\n            </li>\r\n            <li>\r\n                Event-Driven: JavaScript is an event-driven language, meaning that most actions in a web page,\r\n                like clicks, mouse movements, key presses, or even data loading, are treated as events that can trigger JavaScript functions (event handlers).\r\n            </li>\r\n            <li>\r\n                Dynamic Typing: JavaScript does not require you to declare the type of a variable explicitly.\r\n                It is dynamically typed, meaning the type of a variable is determined at runtime, and can change during the execution of the program.\r\n            </li>\r\n            <li>\r\n                Asynchronous: JavaScript can perform asynchronous operations, meaning it can execute code without waiting for other tasks to complete.\r\n                This is especially useful for tasks like fetching data from a server or waiting for user input without freezing the page.\r\n            </li>\r\n            <li>\r\n                Object-Oriented: JavaScript supports object-oriented programming (OOP) principles, such as creating objects, classes, and using inheritance.\r\n                However, it also supports functional programming and procedural programming styles.\r\n            </li>\r\n        </ul>"
            },

            new Section
            {
                SectionId = 18,
                SectionType = "Javascript",
                SectionName = "JavascriptPlacement",
                SectionDisplay = "Javascript Placement",
                SectionHTML = "<h2>Where do you put Javascript?</h2>\r\n\r\n        <p>In web development, JavaScript can be placed in several locations within an HTML document, \r\n            depending on how and when you want the JavaScript code to be executed. \r\n            The placement of JavaScript affects both the page's loading performance and how smoothly the user experience is.</p>\r\n\r\n            <p>Usually, you will want to place Javascript in the following places:</p>\r\n\r\n            <ul>\r\n                <li>\r\n                JavaScript can be placed inside the head section of your HTML document. This means the script will load before the HTML content is fully rendered.\r\n                (This is useful for scripts that must load early, such as those required for functionality that needs to be available as soon as the page starts rendering, like analytics or page-specific settings.)\r\n                </li>\r\n                <li>\r\n                Placing JavaScript just before the closing body tag is considered best practice for most cases. This ensures that the HTML content is fully loaded and rendered before the script runs.\r\n                (It's ideal for general JavaScript code that interacts with elements on the page, as it ensures that the HTML elements the script interacts with are already available.)\r\n                </li>\r\n                <li>\r\n                If you place a script in the head section but don't want it to block page rendering, you can use the async attribute. This tells the browser to download the script in the background while continuing to render the page.\r\n                (Good for when you have independent scripts that don’t rely on other scripts or the page structure, such as external libraries or analytics tracking.)\r\n                </li>\r\n            <li>\r\n                The defer attribute also prevents the script from blocking page rendering, but it ensures that the script is executed after the HTML is fully parsed.\r\n                (This is useful when you want to place the script in the head section but need it to execute after the page content has been parsed. It's commonly used for scripts that manipulate the DOM or need access to page elements.)\r\n            </li>\r\n            </ul>"
            },

            new Section
            {
                SectionId = 19,
                SectionType = "Javascript",
                SectionName = "JavascriptStatements",
                SectionDisplay = "Javascript Statements",
                SectionHTML = "<h2>What are Javascript Statements?</h2>\r\n\r\n        <p>\r\n            In JavaScript, a statement is a single unit of code that performs an action.\r\n            It is the basic building block of JavaScript programs. A statement typically ends with a semicolon (;),\r\n            though it is optional in many cases due to JavaScript's automatic semicolon insertion (ASI).\r\n        </p>\r\n\r\n        <p>Types of Javascript Statements include:</p>\r\n\r\n        <ul>\r\n            <li>\r\n                Declaration Statements These are used to declare variables or functions. They define the resources that your program will use.\r\n            </li>\r\n            <li>\r\n                Expression Statements An expression is a combination of values, variables, operators, and functions that can be evaluated to produce a value.\r\n                An expression statement is an expression followed by a semicolon.\r\n            </li>\r\n            <li>\r\n                Control Flow Statements These statements control the flow of execution in your program by making decisions or repeating actions.\r\n            </li>\r\n            <li>\r\n                Exception Handling Statements These statements are used to handle errors or exceptional conditions in the program.\r\n            </li>\r\n        </ul>\r\n\r\n        <p>This is just some of, not all of, what Javascript statements can do!</p>"
            },

            new Section
            {
                SectionId = 20,
                SectionType = "Javascript",
                SectionName = "JavascriptSyntax",
                SectionDisplay = "Javascript Syntax",
                SectionHTML = "<h2>What is Javascript Syntax?</h2>\r\n\r\n        <p>\r\n            JavaScript syntax refers to the rules that define a correctly structured JavaScript program.\r\n            It specifies how the code should be written so that the JavaScript engine can interpret and execute it.\r\n            In simple terms, JavaScript syntax is like the grammar of the language, defining how we write statements, variables, operators, functions, etc.\r\n        </p>\r\n\r\n        <p>There are many kinds of syntax for different operations in Javascript, such as:</p>\r\n\r\n        <ul>\r\n            <li>\r\n                Statements: A statement is a single line of code that performs an action. Most JavaScript statements end with a semicolon (;), but this is optional in some cases due to automatic semicolon insertion (ASI).\r\n            </li>\r\n            <li>\r\n                Case Sensitive: JavaScript is case-sensitive, which means Variable, variable, and VARIABLE are considered three different identifiers.\r\n            </li>\r\n            <li>\r\n                Variables: In JavaScript, variables are declared using let, const, or var. The most common modern approach is to use let and const.\r\n            </li>\r\n            <li>\r\n                Data Types: JavaScript has primitive types (like numbers, strings, and booleans) and objects (like arrays and functions).\r\n            </li>\r\n            <li>\r\n                Operators: JavaScript uses operators (such as +, -, *, /, %, ++, --) to perform operations on variables and values.\r\n            </li>\r\n        </ul>\r\n\r\n        <p>This is just scratching the surface of syntax in Javascript, there is plenty more to learn!</p>"
            },

            new Section
            {
                SectionId = 21,
                SectionType = "Javascript",
                SectionName = "JavascriptVariables",
                SectionDisplay = "Javascript Variables",
                SectionHTML = "<h2>What are Javascript Variables?</h2>\r\n\r\n        <p>\r\n            In JavaScript, a variable is a container that holds a value, such as a number, string, object, or function.\r\n            Variables are essential for storing data that can be used and manipulated throughout your program.\r\n\r\n            JavaScript variables can hold a variety of values and are fundamental to how the language operates.\r\n        </p>\r\n\r\n        <p>Important aspects of Variables to know include:</p>\r\n\r\n        <ol>\r\n            <li>\r\n                Declaring Variables:\r\n                JavaScript provides three main ways to declare variables:\r\n                <ul>\r\n                    <li>\r\n                        var: This is the older way of declaring variables.\r\n                        It is function-scoped, which means the variable is accessible anywhere within the function it is declared in, and it is not block-scoped.\r\n                        The use of var is generally discouraged in modern JavaScript.\r\n                    </li>\r\n                    <li>\r\n                        let: This is the preferred modern way to declare variables.\r\n                        It is block-scoped, meaning the variable is accessible only within the block (e.g., inside a loop or an if statement) where it is declared.\r\n                        let allows reassignment.\r\n                    </li>\r\n                    <li>\r\n                        const: This is used to declare variables that should not be reassigned after their initial value is set.\r\n                        It is also block-scoped. const is useful for declaring constants or values that should remain unchanged throughout the program.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                Variable Scope:\r\n                <ul>\r\n                    <li>\r\n                        Global Scope: A variable declared outside of any function or block is accessible everywhere in your JavaScript code.\r\n                    </li>\r\n                    <li>\r\n                        Function Scope: A variable declared inside a function using var is function-scoped, meaning it’s only accessible within that function.\r\n                    </li>\r\n                    <li>\r\n                        Block Scope: Variables declared with let and const are block-scoped, meaning they are only accessible within the block where they are declared\r\n                        (such as inside a loop or an if statement).\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                Data Types:\r\n                <ul>\r\n                    <li>\r\n                        String: A sequence of characters enclosed in single or double quotes.\r\n                    </li>\r\n                    <li>\r\n                        Number: Represents both integers and floating-point numbers.\r\n                    </li>\r\n                    <li>\r\n                        Boolean: Represents either true or false.\r\n                    </li>\r\n                    <li>\r\n                        Undefined: A variable that is declared but not assigned a value has the value undefined.\r\n                    </li>\r\n                    <li>\r\n                        Null: A variable that explicitly has no value is assigned null.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n        </ol>"
            },

            new Section
            {
                SectionId = 22,
                SectionType = "Javascript",
                SectionName = "JavascriptLet",
                SectionDisplay = "Javascript Let",
                SectionHTML = "<h2>What is \"Let\" in Javascript?</h2>\r\n\r\n        <p>\r\n            The let keyword in JavaScript is used to declare block-scoped variables,\r\n            meaning the variable is only accessible within the block, statement, or expression where it is defined.\r\n            Let is a modern way to declare variables in JavaScript, with better scoping rules compared to the older var keyword.\r\n        </p>\r\n\r\n        <p>Key Features of Let:</p>\r\n\r\n        <ol>\r\n            <li>\r\n                Block Scope: Unlike var, which is function-scoped, a variable declared with let is block-scoped,\r\n                meaning it is only available within the block (delimited by curly braces {}) where it is declared.\r\n            </li>\r\n            <li>\r\n                Reassignable: Variables declared with let can be reassigned new values.\r\n            </li>\r\n            <li>\r\n                No Redeclaration in the Same Scope: You cannot declare the same variable more than once within the same scope using let.\r\n                This helps avoid accidental redeclaration errors.\r\n            </li>\r\n            <li>\r\n                Hoisting Behavior: Variables declared with let are hoisted to the top of their scope, but unlike var, they are not initialized.\r\n                If you try to access a let variable before its declaration, it will result in a ReferenceError due to the \"temporal dead zone.\"\r\n            </li>\r\n            <li>\r\n                Reassigning after Declaration: Unlike const, which requires the variable to be assigned only once, let allows for reassignment after the initial declaration.\r\n            </li>\r\n        </ol>"
            },

            new Section
            {
                SectionId = 23,
                SectionType = "Javascript",
                SectionName = "JavascriptOperators",
                SectionDisplay = "Javascript Operators",
                SectionHTML = "<h2>What are Javascript Operators?</h2>\r\n\r\n        <p>\r\n            JavaScript operators are symbols used to perform operations on variables and values.\r\n            They allow you to manipulate data, perform calculations, or compare values.\r\n            There are various types of operators in JavaScript, and each one serves a different purpose.\r\n        </p>\r\n\r\n        <p>Examples of Operators in Javascript include:</p>\r\n\r\n        <ol>\r\n            <li>\r\n                Arithmetic operators are used to perform mathematical calculations, such as addition, subtraction, multiplication, etc.\r\n                <ul>\r\n                    <li>\r\n                        + (Addition): Adds two values.\r\n                    </li>\r\n                    <li>\r\n                        - (Subtraction): Subtracts one value from another.\r\n                    </li>\r\n                    <li>\r\n                        * (Multiplication): Multiplies two values.\r\n                    </li>\r\n                    <li>\r\n                        / (Division): Divides one value by another.\r\n                    </li>\r\n                    <li>\r\n                        % (Modulus): Returns the remainder of a division operation.\r\n                    </li>\r\n                    <li>\r\n                        ++ (Increment): Increases the value of a variable by 1.\r\n                    </li>\r\n                    <li>\r\n                        -- (Decrement): Decreases the value of a variable by 1.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                Assignment operators are used to assign values to variables.\r\n                The most common one is the simple =, but there are shorthand versions for performing calculations and assignments simultaneously.\r\n                <ul>\r\n                    <li>\r\n                        = (Assignment): Assigns a value to a variable.\r\n                    </li>\r\n                    <li>\r\n                        += (Add and assign): Adds a value to a variable and assigns the result back to the variable.\r\n                    </li>\r\n                    <li>\r\n                        -= (Subtract and assign): Subtracts a value from a variable and assigns the result back to the variable.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n            <li>\r\n                Comparison operators are used to compare two values. They return a boolean value (true or false) depending on the result of the comparison.\r\n                <ul>\r\n                    <li>\r\n                        == (Equal to): Checks if two values are equal, without considering data type.\r\n                    </li>\r\n                    <li>\r\n                        === (Strict equal to): Checks if two values are equal and of the same data type.\r\n                    </li>\r\n                    <li>\r\n                        != (Not equal to): Checks if two values are not equal, without considering data type.\r\n                    </li>\r\n                    <li>\r\n                        !== (Strict not equal to): Checks if two values are not equal or not of the same data type.\r\n                    </li>\r\n                </ul>\r\n            </li>\r\n        </ol>\r\n\r\n        <p>These are just some examples, but there are plenty more operators to use!</p>"
            },

            new Section
            {
                SectionId = 24,
                SectionType = "Javascript",
                SectionName = "JavascriptFunctions",
                SectionDisplay = "Javascript Functions",
                SectionHTML = "<h2>What are Javascript Functions?</h2>\r\n\r\n        <p>\r\n            In JavaScript, a function is a block of code that performs a specific task and can be executed when it is called.\r\n            Functions help in making your code modular, reusable, and more organized.\r\n            They allow you to write code once and call it multiple times, potentially with different inputs (called parameters), which makes your program more flexible.\r\n        </p>\r\n\r\n        <p>Function in Javascript have 3 main components:</p>\r\n\r\n        <ol>\r\n            <li>\r\n                Function Declaration: This defines the function and its name.\r\n            </li>\r\n            <li>\r\n                Parameters: These are the placeholders for the values that you pass to the function when calling it (inputs).\r\n            </li>\r\n            <li>\r\n                Return Statement: Functions can return a value to the calling code. This is optional — not all functions return values.\r\n            </li>\r\n        </ol>\r\n\r\n        <p>There is plenty more to learn about functions, but would be helped with examples (coming soon)!</p>"
            }
            );


    }

    public DbSet<Section> Sections { get; set; }

    public DbSet<Bookmark> Bookmarks { get; set; }
}