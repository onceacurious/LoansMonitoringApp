using System.Text.Json.Serialization;

namespace LoansMonitoring.ClassLib.Models;

public class Application
{
   public int Id { get; set; }

   [Required]
   [JsonIgnore]
   public Client Client { get; set; } = null!;
   public int ClientId { get; set; }

   [Required]
   public TransactionType TransactionType { get; set; } = null!;

   [Required]
   public Status Status { get; set; } = null!;

   [Required]
   public DateTime StatusTimestamp { get; set; } = DateTime.UtcNow;

   [MaxLength(150)]
   public string StatusNotes { get; set; } = string.Empty;

   [Required]
   public DateTime DateReceived { get; set; }

   [Required]
   public User Receiver { get; set; } = null!;

   [Required]
   public DateTime DateForwarded { get; set; }

   [MaxLength(250)]
   public string Remarks { get; set; } = null!;

   [Required]
   public DateTime RemarksTimestamp { get; set; } = DateTime.UtcNow;

}
