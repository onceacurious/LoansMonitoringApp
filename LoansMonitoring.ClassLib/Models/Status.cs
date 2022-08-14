namespace LoansMonitoring.ClassLib.Models;
public class Status
{
   public int Id { get; set; }

   [MaxLength(20)]
   [Required]
   public string Title { get; set; } = null!;

   [MaxLength(150)]
   public string Description { get; set; } = string.Empty;
}
