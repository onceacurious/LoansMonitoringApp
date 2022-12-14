namespace LoansMonitoring.ClassLib.Models;
public class User
{
   public int Id { get; set; }

   public Guid ObjectId { get; set; } = Guid.NewGuid();

   [MaxLength(20)]
   [Required]
   public string FirstName { get; set; } = string.Empty;

   [MaxLength(20)]
   [Required]
   public string LastName { get; set; } = string.Empty;

   [MaxLength(20)]
   [Required]
   public string MiddleName { get; set; } = string.Empty;

   [MaxLength(20)]
   public string Username
   {
      get
      {
         var firstName = UsernameCoversion.Username(FirstName);
         var name = firstName + "." + LastName.Trim().ToLower();
         return name + "_" + Id;
      }
   }

   public byte[]? PasswordHash { get; set; }
   public byte[]? PasswordSalt { get; set; }

   public string Password { get; set; } = string.Empty;

   public UserBio? UserBio { get; set; }

}
