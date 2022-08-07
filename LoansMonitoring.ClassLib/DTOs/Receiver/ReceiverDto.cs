namespace LoansMonitoring.ClassLib.DTOs.Receiver;
public class ReceiverDto
{
   public Guid ObjectId { get; set; }
   public string FirstName { get; set; } = null!;
   [MaxLength(20)]
   public string LastName { get; set; } = null!;
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;
   [MaxLength(20)]
   public string? Position { get; set; }
   [MaxLength(20)]
   public string DisplayName { get; set; } = null!;

}
