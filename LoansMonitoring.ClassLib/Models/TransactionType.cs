namespace LoansMonitoring.ClassLib.Models;
public class TransactionType
{
   public int Id { get; set; }
   public List<Product> ProductModels { get; set; } = null!;
   public Product ProductModel { get; set; } = null!;
   [DisplayName("Transaction Title")]
   [MaxLength(20)]
   public string Title { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }
}
