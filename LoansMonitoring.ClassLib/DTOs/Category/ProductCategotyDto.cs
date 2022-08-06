namespace LoansMonitoring.ClassLib.DTOs.Category;
public class ProductCategotyDto
{
   public int Id { get; set; }
   [Required]
   public int ProductId { get; set; }
   [Required]
   public string ProductName { get; set; } = null!;
   public string? ProductDescription { get; set; }
   [Required]
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;
   [MaxLength(150, ErrorMessage = "Description too long")]
   public string? Description { get; set; }
}
