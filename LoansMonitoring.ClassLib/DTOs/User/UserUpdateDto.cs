namespace LoansMonitoring.ClassLib.DTOs.User;
public class UserUpdateDto
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

   [MaxLength(20)]
   public string Position { get; set; } = "staff";


}
