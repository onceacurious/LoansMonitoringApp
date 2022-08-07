namespace LoansMonitoring.ClassLib.DTOs.Status;
public class StatusUpdateDto
{
   public int Id { get; set; }
   public string Title { get; set; } = null!;
   public string? Description { get; set; }
}
