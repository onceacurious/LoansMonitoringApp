namespace LoansMonitoring.ClassLib.DTOs.Status;
public class StatusDto
{
   public int Id { get; set; }

   [Required]
   [MaxLength(20)]
   public string Title { get; set; } = null!;

   [MaxLength(150)]
   public string Description { get; set; } = string.Empty;
}
