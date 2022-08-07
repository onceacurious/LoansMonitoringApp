namespace LoansMonitoring.ClassLib.Models;
public class Client
{
   public int Id { get; set; }
   public string FullName
   {
      get { return LastName + ", " + FirstName + " " + MiddleName; }
   }

   [MaxLength(20)]
   public string FirstName { get; set; } = null!;
   [MaxLength(20)]
   public string LastName { get; set; } = null!;
   [MaxLength(20)]
   public string MiddleName { get; set; } = null!;





}
