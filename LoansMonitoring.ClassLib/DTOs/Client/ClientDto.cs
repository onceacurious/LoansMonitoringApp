namespace LoansMonitoring.ClassLib.DTOs.Client;
public class ClientDto
{
   public int Id { get; set; }
   public string FullName { get; set; } = null!;
   [MaxLength(20)]
   public string FirstName { get; set; } = null!;
   [MaxLength(20)]
   public string LastName { get; set; } = null!;
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;

}
