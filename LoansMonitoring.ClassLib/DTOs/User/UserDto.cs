namespace LoansMonitoring.ClassLib.DTOs.User;
public class UserDto
{
   private static readonly Regex _sWhiteSpace = new(@"\s+");

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
   public string Position { get; set; } = "staff";

   [MaxLength(20)]
   public string Username
   {
      get
      {
         var name = FirstName + "." + LastName;
         return _sWhiteSpace.Replace(name, "") + "_" + Id;
      }
   }

   [Required]
   public int UserAuthId { get; set; }
}
