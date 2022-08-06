﻿namespace LoansMonitoring.ClassLib.DTOs.Category;
public class ProductCategoryAddDto
{
   public int ProductId { get; set; }
   [MaxLength(20, ErrorMessage = "Name too long")]
   public string Name { get; set; } = null!;
   [MaxLength(150, ErrorMessage = "Description too long")]
   public string? Description { get; set; }
}