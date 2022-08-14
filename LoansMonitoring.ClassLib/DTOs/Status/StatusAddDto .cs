namespace LoansMonitoring.ClassLib.DTOs.Status;
public class StatusAddDto
{
   [Required]
   [MaxLength(20)]
   public string Title { get; set; } = null!;

   [MaxLength(150)]
   public string Description { get; set; } = string.Empty;
}
