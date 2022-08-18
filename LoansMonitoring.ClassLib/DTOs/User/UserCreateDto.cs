
namespace LoansMonitoring.ClassLib.DTOs.User;
public class UserCreateDto
{
   [MaxLength(20)]
   [Required]
   public string FirstName { get; set; } = null!;

   [MaxLength(20)]
   [Required]
   public string LastName { get; set; } = null!;

   [MaxLength(20)]
   [Required]
   public string MiddleName { get; set; } = null!;

   [MaxLength(15)]
   [Required]
   public string Password { get; set; } = null!;

}
