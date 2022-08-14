namespace LoansMonitoring.ClassLib.DTOs.Client;
public class ClientUpdateDto
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

}
