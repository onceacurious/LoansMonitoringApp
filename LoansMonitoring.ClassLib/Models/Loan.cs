namespace LoansMonitoring.ClassLib.Models;
public class Loan
{
   public int Id { get; set; }

   [Required]
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;

   [MaxLength(150, ErrorMessage = "Description too long")]
   public string Description { get; set; } = string.Empty;

   [Required]
   public ICollection<Product> Prodcucts { get; set; } = null!;
}
