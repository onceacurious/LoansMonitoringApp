using System.Text.RegularExpressions;

namespace LoansMonitoring.ClassLib.Models;
public class Receiver
{
   private static readonly Regex sWhiteSpace = new Regex(@"\s+");
   public int Id { get; set; }
   public Guid ObjectId { get; set; } = new Guid();
   [MaxLength(20)]
   public string FirstName { get; set; } = null!;
   [MaxLength(20)]
   public string LastName { get; set; } = null!;
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;
   [MaxLength(20)]
   public string? Position { get; set; }
   [MaxLength(20)]
   public string DisplayName
   {
      get
      {
         var name = FirstName + "_" + LastName;
         return sWhiteSpace.Replace(name, "") + Id;
      }
   }
}
