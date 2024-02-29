namespace Bookish.Models;

public class Loan
{
    public required BookCopy BookCopy  {get; set; }
    public required Member Member  {get; set; }
    public required DateOnly ExpectedReturnDate {get; set;}
    public DateOnly? ActualReturnDate {get; set; } = null;
    public required DateOnly DateBorrowed {get; set;}
}