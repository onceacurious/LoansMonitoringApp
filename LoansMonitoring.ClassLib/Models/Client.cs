namespace LoansMonitoring.ClassLib.Models;
public class Client
{
   public int Id { get; set; }

   public string FullName
   {
      get { return LastName + ", " + FirstName + " " + MiddleName; }
   }

   [Required]
   [MaxLength(20)]
   public string FirstName { get; set; } = null!;

   [Required]
   [MaxLength(20)]
   public string LastName { get; set; } = null!;

   [Required]
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;

   public ICollection<Application> Applications { get; set; } = null!;

}
