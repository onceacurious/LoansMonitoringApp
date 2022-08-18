
namespace LoansMonitoring.ClassLib.DTOs.User;
public class UserCreateDto
{
   [MaxLength(20)]
   [Required]
   public string FirstName { get; set; } = string.Empty;

   [MaxLength(20)]
   [Required]
   public string LastName { get; set; } = string.Empty;

   [MaxLength(20)]
   [Required]
   public string MiddleName { get; set; } = string.Empty;

   [MaxLength(15)]
   [Required]
   public string Password { get; set; } = string.Empty;

}
