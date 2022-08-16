namespace LoansMonitoring.ClassLib.DTOs.UserAuth;
public class UserAuthDto
{
   public int Id { get; set; }

   public string Username { get; set; } = string.Empty;

   public string Password { get; set; } = string.Empty;

   public int UserId { get; set; }
}
