﻿namespace LoansMonitoring.ClassLib.Models;
public class TransactionType
{
   public int Id { get; set; }
   public ICollection<Product> Products { get; set; } = null!;
   [Display(Name = "Transaction Title")]
   [MaxLength(20)]
   public string Title { get; set; } = null!;
   [MaxLength(150)]
   public string? Description { get; set; }
}
