namespace LoansMonitoring.ClassLib.Models;
public class Loan
{
   public int Id { get; set; }
   public string Name { get; set; } = null!;
   public string Description { get; set; } = string.Empty;
   public List<Product> Products { get; set; } = null!;
}
