namespace LoansMonitoring.ClassLib.DTOs.TransactionType;
public class TransactionUpdateDto
{
   public int Id { get; set; }
   [MaxLength(20)]
   public string Title { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }
}
