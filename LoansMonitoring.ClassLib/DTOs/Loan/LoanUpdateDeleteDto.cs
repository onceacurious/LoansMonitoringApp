namespace LoansMonitoring.ClassLib.DTOs.Loan;
public class LoanUpdateDeleteDto
{
   public int Id { get; set; }
   [Required]
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;
   [Required]
   [MaxLength(150, ErrorMessage = "Description too long")]
   public string Description { get; set; } = string.Empty;
}
