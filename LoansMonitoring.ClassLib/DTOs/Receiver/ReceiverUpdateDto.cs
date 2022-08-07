namespace LoansMonitoring.ClassLib.DTOs.Receiver;
public class ReceiverUpdateDto
{
   public int Id { get; set; }
   [MaxLength(20)]
   public string FirstName { get; set; } = null!;
   [MaxLength(20)]
   public string LastName { get; set; } = null!;
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;
   [MaxLength(20)]
   public string? Position { get; set; }
}
