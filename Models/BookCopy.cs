namespace Bookish.Models;

public class BookCopy
{
    public required Book Book {get; set;}
    
    public List<Loan> Loans {get; } =[];

    public bool HasActiveLoan  => Loans.Any(loan => loan.ActualReturnDate == null);
    public Loan? ActiveLoan  => Loans.SingleOrDefault(loan => loan.ActualReturnDate == null);
}   