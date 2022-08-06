

namespace LoansMonitoring.ClassLib.Models;
public class ProductCategory
{
   public int Id { get; set; }
   public Product Product { get; set; } = null!;
   [DisplayName("Category Name")]
   [MaxLength(20)]
   public string Name { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }
}
