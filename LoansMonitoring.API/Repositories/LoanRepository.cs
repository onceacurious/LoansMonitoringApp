using LoansMonitoring.API.Repositories.Contracts;
using LoansMonitoring.ClassLib.DTOs.Loan;

namespace LoansMonitoring.API.Repositories;

public class LoanRepository : ILoanRepository
{
   private readonly DbConnection _db;

   public LoanRepository(DbConnection db)
   {
      _db = db;
   }

   public async Task<Loan> CreateLoan(Loan loan)
   {
      var result = await _db.AddAsync(loan);
      await _db.SaveChangesAsync();
      return result.Entity;
   }

   public async Task<Loan> DeleteLoan(int id)
   {
      var loan = await _db.Loans.FindAsync(id);
      if (loan != null)
      {
         _db.Loans.Remove(loan);
         await _db.SaveChangesAsync();
         return loan;
      }
      return null;
   }

   public async Task<Loan> GetLoan(int id)
   {
      var loan = await _db.Loans.Include(l => l.Prodcucts).SingleOrDefaultAsync(l => l.Id == id);
      return loan;
   }

   public async Task<IEnumerable<Loan>> GetLoans()
   {
      var loans = await _db.Loans.ToListAsync();
      return loans;
   }

   public async Task<Loan> UpdateLoan(int id, LoanUpdateDto dto)
   {
      var loan = await _db.Loans.FindAsync(id);
      if (loan != null)
      {
         loan.Name = dto.Name;
         loan.Description = dto.Description;
         await _db.SaveChangesAsync();
         return loan;
      }
      return null;
   }
}
