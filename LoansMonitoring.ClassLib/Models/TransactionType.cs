namespace LoansMonitoring.ClassLib.Models;
public class TransactionType
{
   public int Id { get; set; }

   [Display(Name = "Transaction Title")]
   [MaxLength(20)]
   public string Title { get; set; } = null!;

   [MaxLength(150)]
   public string? Description { get; set; }
}
