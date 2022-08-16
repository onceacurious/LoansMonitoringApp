namespace LoansMonitoring.ClassLib.Models;
public class UserAuth
{
   public int Id { get; set; }

   public byte[] PasswordHash { get; set; } = null!;

   public byte[] PasswordSalt { get; set; } = null!;

   [JsonIgnore]
   public User User { get; set; } = null!;

   public int UserId { get; set; }

}
