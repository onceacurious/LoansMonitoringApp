using LoansMonitoring.ClassLib.DTOs.Loan;

namespace LoansMonitoring.API.Repositories.Contracts;

public interface ILoanRepository
{
   Task<IEnumerable<Loan>> GetLoans();
   Task<Loan> GetLoan(int id);
   Task<Loan> CreateLoan(Loan loan);
   Task<Loan> UpdateLoan(int id, LoanUpdateDeleteDto dto);
   Task<Loan> DeleteLoan(int id);
}
