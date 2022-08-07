namespace LoansMonitoring.ClassLib.DTOs.LoanApplication;
public class LoanApplicationAddDto
{
   [Required]
   public int ClientId { get; set; }
   [Required]
   public int ProductId { get; set; }
   [Required]
   public int TransactionTypeId { get; set; }
   [Required]
   public int StatusId { get; set; }
   [Required]
   public DateTime StatusTimestamp { get; set; }
   [MaxLength(150)]
   public string? StatusNotes { get; set; }
   [Required]
   public DateTime DateReceived { get; set; }
   [Required]
   public int ReceiverId { get; set; }
   [Required]
   public DateTime DateForwarded { get; set; }
   [MaxLength(250)]
   public List<string>? Remarks { get; set; }
   [Required]
   public DateTime RemarksTimestamp { get; set; }
}
