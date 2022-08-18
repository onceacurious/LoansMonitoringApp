

namespace LoansMonitoring.ClassLib.Models;
public class UserBio
{
   public int Id { get; set; }
   public string Position { get; set; } = "staff";

   [JsonIgnore]
   public User User { get; set; } = null!;

   public int UserId { get; set; }
}
