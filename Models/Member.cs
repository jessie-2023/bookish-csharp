namespace Bookish.Models;

public class Member 
{
    public required string Name {get; set;}
    public List<Loan> LoanHistory {get; } = [];

    public List<Loan> ActiveLoans => LoanHistory.Where(loan =>loan.ActualReturnDate == null).ToList();
}