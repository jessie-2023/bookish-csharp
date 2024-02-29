namespace Bookish.Models;

public class Librarian
{
    public required string Name {get; set;}
    private readonly HashSet<Member> _members = [];
    
    
}