

namespace LoansMonitoring.ClassLib.Models;
public class Product
{
   public int Id { get; set; }
   [DisplayName("Product Name")]
   [MaxLength(20)]
   public string Name { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }

}
