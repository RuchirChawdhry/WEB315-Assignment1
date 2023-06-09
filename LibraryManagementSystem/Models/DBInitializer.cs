using RazorPagesLibrary.Models;
using System;
using System.Linq;
namespace LibraryManagementSystem{
    public static class DbInitializer{
        public static void Initialize(RazorPagesLibraryContext context){
            if(context.Library.Any()){
                return;
            }
            var libraries = new Library[]{
                new Library
                {
                    ID = 1,
                    BookName = "To Kill a Mockingbird",
                    BookCategory = "Fiction",
                    BookDescription = "A classic novel by Harper Lee",
                    BookAuthor = "Harper Lee",
                    PublishDate = new DateTime(1960, 7, 11),
                    OnLoan = false,
                    LoanedTimes = 1,
                    LoanedByName = null
                },
                new Library
                {
                    ID = 2,
                    BookName = "The Great Gatsby",
                    BookCategory = "Fiction",
                    BookDescription = "A novel by F. Scott Fitzgerald set in the Jazz Age",
                    BookAuthor = "F. Scott Fitzgerald",
                    PublishDate = new DateTime(1925, 4, 10),
                    OnLoan = false,
                    LoanedTimes = 2,
                    LoanedByName = null
                },
                new Library
                {
                    ID = 3,
                    BookName = "1984",
                    BookCategory = "Fiction",
                    BookDescription = "A dystopian novel by George Orwell",
                    BookAuthor = "George Orwell",
                    PublishDate = new DateTime(1949, 6, 8),
                    OnLoan = false,
                    LoanedTimes = 10,
                    LoanedByName = null
                },
                new Library
                {
                    ID = 4,
                    BookName = "Pride and Prejudice",
                    BookCategory = "Fiction",
                    BookDescription = "A novel by Jane Austen about love and social class",
                    BookAuthor = "Jane Austen",
                    PublishDate = new DateTime(1813, 1, 28),
                    OnLoan = true,
                    LoanedTimes = 5,
                    LoanedByName = "G. Austen"
                },
                new Library
                {
                    ID = 5,
                    BookName = "The Lord of the Rings",
                    BookCategory = "Fantasy",
                    BookDescription = "An epic high-fantasy novel by J.R.R. Tolkien",
                    BookAuthor = "J.R.R. Tolkien",
                    PublishDate = new DateTime(1954, 7, 29),
                    OnLoan = false,
                    LoanedTimes = 0,
                    LoanedByName = null
                },
                new Library
                {
                    ID = 6,
                    BookName = "Harry Potter and the Philosopher's Stone",
                    BookCategory = "Fantasy",
                    BookDescription = "The first book in the Harry Potter series by J.K. Rowling",
                    BookAuthor = "J.K. Rowling",
                    PublishDate = new DateTime(1997, 6, 26),
                    OnLoan = true,
                    LoanedTimes = 100,
                    LoanedByName = "Ruchir Chawdhry"
                }
            };
            context.Library.AddRange(libraries);
            context.SaveChanges();
        }
    }
}