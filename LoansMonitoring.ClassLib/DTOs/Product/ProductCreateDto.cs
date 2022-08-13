namespace LoansMonitoring.ClassLib.DTOs.Product;
public class ProductCreateDto
{
   public string Name { get; set; } = null!;
   public string Description { get; set; } = string.Empty;
   public int LoanId { get; set; }
}
