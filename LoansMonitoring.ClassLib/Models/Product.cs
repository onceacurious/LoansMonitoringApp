using System.Text.Json.Serialization;

namespace LoansMonitoring.ClassLib.Models;
public class Product
{
   public int Id { get; set; }

   [Required]
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;

   [MaxLength(150, ErrorMessage = "Description too long")]
   public string Descirption { get; set; } = string.Empty;

   [Required]
   [JsonIgnore]
   public Loan Loan { get; set; } = null!;
}
