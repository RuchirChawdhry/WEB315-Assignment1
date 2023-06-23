using System;
using System.ComponentModel.DataAnnotations;

namespace RazorPagesLibrary.Models
{
    public class Library
    {
    public int ID { get; set; }
    public string BookName { get; set; }
    public string BookCategory { get; set; }
    public string BookDescription { get; set; }
    public string BookAuthor { get; set; }

    [DataType(DataType.Date)]
    public DateTime PublishDate { get; set; }

    public bool OnLoan { get; set; }
    public int LoanedTimes { get; set; }
    public string LoanedByName { get; set; }
    
    // New Properties
    public int TotalPages { get; set; } // Integer type property
    public string Publisher { get; set; } // String type property
    public string ISBN { get; set; } // String type property

    }
}