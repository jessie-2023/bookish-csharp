namespace Bookish.Models;

public class Book
{
    public required string Title {get; set;}
    public required string Author {get; set;}
    public List<BookCopy> Copies {get; set; } = [];
}

