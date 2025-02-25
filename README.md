# Website Overview

--------------------------------------------------

## The End Goal:

The goal of my project is to create a website where people can create an account and bookmark possibly helpful coding resources. For now, this can be chalked up to basic explanations of certains concepts of a couple of coding languages, but I do hope to add some examples and images or other media to help people understand the concepts more. I am working on this alone so it might not be nearly as helpful as other established coding websites, but the goal is to make a website similar to those.

## The Current Goal:

Reduce redundancy of current website code by further utilizing objects and the database.

--------------------------------------------------

# Website Progress

--------------------------------------------------

## Week 2 (1st Sprint):

### 1/21/2025 - 2 hours:

- Connected required services and began work on the 
shared layout between pages.

### 1/22/2025 - 2 hours:

- Finished shared layout between pages, created 
basic introduction pages for each section.

### 1/23/2025 - 1 hour:

- Added a SectionsController and some navigation 
buttons to move between sections.

--------------------------------------------------

## Week 3 (2nd Sprint):

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

--------------------------------------------------

## Week 4 (3rd Sprint):

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

--------------------------------------------------

## Week 5 (4th Sprint):

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

--------------------------------------------------

## Week 6 (5th Sprint):

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

--------------------------------------------------

## Week 7 (6th Sprint):

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
