using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class Library
    {
    public int ID { get; set; }

    [Required, StringLength(100, MinimumLength = 4)]
    public string BookName { get; set; }

    [Required, StringLength(50, MinimumLength = 4)]
    public string BookCategory { get; set; }

    [Required, StringLength(1000, MinimumLength = 4)]
    public string BookDescription { get; set; }

    [Required, StringLength(100, MinimumLength = 2)]
    public string BookAuthor { get; set; }

    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }

    public bool OnLoan { get; set; }
    public int LoanedTimes { get; set; }

    [Required, StringLength(100, MinimumLength = 2)]
    public string LoanedByName { get; set; }
    
    // New Properties
    [Range(1, 10000)] // Restrict the TotalPages between 1 to 10000
    public int TotalPages { get; set; } // Integer type property
    
    [Required, StringLength(100, MinimumLength = 4)]
    [RegularExpression(@"^[A-Z]+[a-zA-Z\s]*$", ErrorMessage = "Only letters and white spaces are allowed, and the first letter should be uppercase.")]
    public string Publisher { get; set; } // String type property
    
    [Required, StringLength(13, MinimumLength = 10)]
    public string ISBN { get; set; } // String type property

    }
}