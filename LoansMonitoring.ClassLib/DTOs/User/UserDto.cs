namespace LoansMonitoring.ClassLib.DTOs.User;
public class UserDto
{

   public int Id { get; set; }

   public Guid ObjectId { get; set; } = Guid.NewGuid();

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
   public string Username
   {
      get
      {
         var firstName = UsernameCoversion.Username(FirstName);
         var name = firstName + "." + LastName.Trim();
         return name + "_" + Id;
      }
   }

   public byte[] PasswordHash { get; set; } = null!;

   public byte[] PasswordSalt { get; set; } = null!;

}
