# WEB315-Assignment1
Assignment 1 - WEB315: Introduction to ASP.NET - St. Clair College

## Description

A Library Management System is a software application designed to efficiently manage the operations and processes of a library. It provides a centralized platform for librarians to handle various tasks such as cataloging, tracking books, managing memberships, and handling loan transactions. Here's how such a system would handle the specific aspects mentioned:

- **BookID**: Each book in the library would have a unique identifier assigned to it. This ID serves as a reference to identify and track the book throughout the system.

- **BookName**: The system would store the name or title of each book. This information helps users and librarians identify and search for specific books within the library's collection.

- **BookCategory**: Books can be categorized into different genres, subjects, or topics. The system would include a category field to classify books into various predefined or custom-defined categories, making it easier to organize and retrieve books based on their subjects.

- **BookDescription**: A brief description of each book can be stored in the system. This description provides users with additional information about the book's content, allowing them to make informed decisions when searching for relevant books.

- **BookAuthor**: The system would record the name of the author(s) associated with each book. This information helps users identify books by their authors and facilitates searches based on specific authors or their works.

- **OnLoan**: This field indicates whether a book is currently on loan or available for borrowing. It can have values such as "Yes" or "No" or utilize more advanced status indicators. This feature allows librarians to track the availability of books and prevents conflicts when multiple users attempt to borrow the same book simultaneously.

- **LoanedTimes**: The system can keep track of the number of times a book has been loaned out. This information helps librarians monitor the popularity of books and make informed decisions regarding book acquisitions, replacements, or retirements based on usage patterns.

- **LoanedByName**: This field stores the name of the person who has borrowed the book. When a book is loaned out, the system records the borrower's information in the LoanedByName field. This feature helps librarians track who has borrowed a particular book and enables efficient management of loaned books. It allows for easy retrieval of borrower information.

By incorporating these features, a Library Management System streamlines book management, facilitates efficient searching and borrowing processes, and provides valuable insights into the library's collection and usage.

## Commands Used
dotnet tool install --global dotnet-ef --version 5
	
dotnet tool install --global dotnet-aspnet-codegenerator --version 5.*
	
dotnet add package Microsoft.EntityFrameworkCore.Design --version 5.*
	
dotnet add package Microsoft.EntityFrameworkCore.SQLite --version 5.*
	
dotnet add package Microsoft.VisualStudio.Web.CodeGeneration.Design --version 5.*
	
dotnet add package Microsoft.EntityFrameworkCore.SqlServer --version 5.*

## Scaffolding
dotnet-aspnet-codegenerator razorpage -m Library -dc RazorPagesLibraryContext -udl -outDir Pages/Books --referenceScriptLibraries -sqlite

## Database Schema/Migrations
dotnet ef migrations add InitialCreate
	
dotnet ef database update




