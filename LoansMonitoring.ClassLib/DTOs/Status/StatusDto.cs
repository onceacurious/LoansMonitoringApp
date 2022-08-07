namespace LoansMonitoring.ClassLib.DTOs.Status;
public class StatusDto
{
   public int Id { get; set; }
   [MaxLength(20)]
   [DisplayName("Status Title")]
   public string Title { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }
}
