using System.Text.RegularExpressions;

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
   public string DisplayName
   {
      get
      {
         var name = FirstName + "_" + LastName;
         return _sWhiteSpace.Replace(name, "") + "_" + Id;
      }
   }
}
