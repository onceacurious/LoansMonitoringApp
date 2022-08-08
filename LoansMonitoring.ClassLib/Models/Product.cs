namespace LoansMonitoring.ClassLib.Models;
public class Product
{
   public int Id { get; set; }
   public string Name { get; set; } = null!;
   public string Descirption { get; set; } = string.Empty;
   public Loan Loan { get; set; } = null!;
   public int LoanId { get; set; }
}
