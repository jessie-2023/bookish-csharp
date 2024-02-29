namespace Bookish.Models;

public class Catalogue
{
    private readonly HashSet<Book> _books = [];
    private readonly HashSet<BookCopy> _copies = [];
    private readonly Dictionary<string, Book> _titleRegister = []; // title - Book - multiple copies
    private readonly Dictionary<string, List<Book>> _authorRegister = []; // author - list of Book - multiple copies for each
    
    public void BrowseAll()
    {
        foreach(var book in _books )
        {
            Console.WriteLine($"{book.Title} by {book.Author}");
            Console.WriteLine($"Total copies: {book.Copies.Count}. Available copies: {book.Copies.Count(copy => !copy.HasActiveLoan)}");
        }
        
    }

    public Book SearchByTitle(string title)
    {
        
        //match input string to Book.Title

        return _titleRegister[title]; // the matched Book 
    }

    public List<Book> SearchByAuthor(string author)
    {

        //[]
        //foreach book in _books
        //if input string == book.Author, add it to the list

        return _authorRegister[author]; // the list of authored books
    }


}