# Website Overview

## The End Goal

The goal of my project is to create a website where people can create an account and bookmark possibly helpful coding resources. For now, this can be chalked up to basic explanations of certains concepts of a couple of coding languages, but I do hope to add some examples and images or other media to help people understand the concepts more. I am working on this alone so it might not be nearly as helpful as other established coding websites, but the goal is to make a website similar to those.

## Did I Meet This Goal?

Now that the quarter has come to an end, I can say that while my original idea was a bit too ambitious for just one person such as myself, I have come a very long way. At first my website was a redundant mess of code that looked complex but was incredibly simple and repetitive. Now, I have learned how to reduce that redundancy heavily while also picking up other skills along the way such as how to implement a Web API into a website, how to redirect a user to a specific URL with parameters, improving my ability to use a view model to heavily reduce redundant code and use the same spaces to display different content, how to seed data into a database for testing, and how to use vastly improved and organized comments with XML documentation. The website, while still appearing bland due to my lack of skill with styling in CSS and Bootstrap, has taught me much about how a website should look coding wise. I might never reach the heights of a project such as W3Schools, but I believe this project has taught me many skills more important that simply making a wbesite look pretty. For now at least, this project is done, all of my weekly progress and work time can be found below this statement.

# Website Progress

## Week 2 (1st Sprint) 5 Total Hours

### 1/21/2025 - 2 hours:

- Connected required services and began work on the 
shared layout between pages.

### 1/22/2025 - 2 hours:

- Finished shared layout between pages, created 
basic introduction pages for each section.

### 1/23/2025 - 1 hour:

- Added a SectionsController and some navigation 
buttons to move between sections.

## Week 3 (2nd Sprint) 5 Total Hours

### 1/25/2025 - 2 hours:

- Created Section object and View Model for 
displaying Sections and Bookmarks in a neat manner 
without repetitive HTML.

- Made it so the SectionsController can get the 
UserID of the currently logged in user if there is 
one.

### 1/26/2025 - 3 hours:

- Began work on adding display functionality for 
Sections and Bookmarks.

- Added a lengthy method to help create a View 
Model that contains the proper section/bookmark 
objects depending on the displayed webpage.

- Sections will be displayed as they are created, 
functionality was completed.

- Added Test Button to add test data to the website.

## Week 4 (3rd Sprint) 6 Total Hours

### 1/29/2025 - 3 hours:

- Fixed multiple issues that were unseen in the 
previous week such as section display only working 
if a user was logged in and SectionId being a 
string instead of an integer.

### 1/31/2025 - 3 hours:

Added the following pages:

- HTML Introduction (Page Content only)
- HTML Elements
- HTML Attributes
- HTML Styles
- HTML Comments
- HTML Links
- HTML Lists
- HTML Div

## Week 5 (4th Sprint) 4 Total Hours

### 2/05/2025 - 4 hours:

Added the following pages:

- CSS Introduction
- CSS Syntax
- CSS Selectors
- CSS Comments
- CSS Backgrounds
- CSS Borders
- CSS Margins
- CSS Height

## Week 6 (5th Sprint) 4 Total Hours

### 2/14/2025 - 4 hours:

Added the following pages:

- Javascript Introduction
- Javascript Placement
- Javascript Statements
- Javascript Syntax
- Javascript Variables
- Javascript Let
- Javascript Operators
- Javascript Functions

## Week 7 (6th Sprint) 6 Total Hours

### 2/24/2025 - 6 hours:

- Seeded data into local database rather than 
redundantly adding it.

- Removed the need for a billion ".cshtml" files, 
greatly reducing code redundancy.

- Added new property to Section object to store all 
HTML code as a string.

- Added new property to 
SectionsAndBookmarksViewModel, which can track 
exactly what page needs to be displayed based on 
user input.

- Added onto the CreateViewModel method in the 
SectionsController, is now able to make a view 
model that works without needing an extra ".cshtml" 
file to display code.

- Remove "AddTestData" method as it is no longer 
needed thanks to seeding data.

## Week 8 (7th Sprint) 4 Total Hours

### 3/3/2025 - 4 hours:

- Added Bookmark display functionality.

- Added the ability for users to add and delete 
bookmarks, all on one clickable button.

## Week 9 (8th Sprint) 4 Total Hours

### 3/10/2025 - 4 hours:

- Cleaned up comments across the entire project, 
XML documentation is now used and C# comments now 
only exists for complex chunks of code.

- Provided a valid return URL for when a user adds 
or deletes a bookmark.

- Added color to the Add/Delete button for bookmarks
for clarity.

## Week 10 (9th Sprint) 5 Total Hours

### 3/17/2025 + 3/18/2025 - 5 hours:

- Installed Http and JokeAPI packages to the 
project.

- Created new class to handle Http requests from 
JokeAPI.

- Added new button at the bottom of each page that 
takes you to a page to display programming jokes, 
also added the page for this as well.

- Added all required functionality to the 
SectionsController for mentioned buttons and pages 
to work.

- Fixed a small error in the "site.css" file.
