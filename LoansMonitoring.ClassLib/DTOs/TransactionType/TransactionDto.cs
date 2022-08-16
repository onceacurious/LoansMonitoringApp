namespace LoansMonitoring.ClassLib.DTOs.TransactionType;
public class TransactionDto
{
   public int Id { get; set; }

   [MaxLength(20)]
   [Required]
   public string Title { get; set; } = null!;

   [MaxLength(150)]
   public string Description { get; set; } = string.Empty;
}
