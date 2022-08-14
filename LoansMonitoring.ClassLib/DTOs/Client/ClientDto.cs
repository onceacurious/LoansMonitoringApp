namespace LoansMonitoring.ClassLib.DTOs.Client;
public class ClientDto
{
   public int Id { get; set; }

   [Required]
   [MaxLength(20)]
   public string FirstName { get; set; } = null!;

   [Required]
   [MaxLength(20)]
   public string LastName { get; set; } = null!;

   [Required]
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;

   public ICollection<Application> Applications { get; set; } = null!;

}
