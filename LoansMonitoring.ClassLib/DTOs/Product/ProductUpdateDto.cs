namespace LoansMonitoring.ClassLib.DTOs.Product;
public class ProductUpdateDto
{
   public int Id { get; set; }
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;
   [MaxLength(150, ErrorMessage = "Description too long")]
   public string? Description { get; set; }
}
